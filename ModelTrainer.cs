using System.Collections.Generic;
using Microsoft.ML;

public class ModelTrainer : IModelTrainer
{
    private readonly MLContext _mlContext;

    public ModelTrainer(int? seed = 1)
    {
        _mlContext = new MLContext(seed: seed);
    }

    public IConcentrationPredictor Train(IEnumerable<Measurement> trainingData)
    {
        var data = _mlContext.Data.LoadFromEnumerable(trainingData);

        var pipeline = _mlContext.Transforms.Concatenate(
                "Features",
                nameof(Measurement.Pressure),
                nameof(Measurement.Temperature))
            .Append(_mlContext.Regression.Trainers.Sdca(
                labelColumnName: nameof(Measurement.Concentration),
                featureColumnName: "Features"));

        var model = pipeline.Fit(data);

        var engine = _mlContext.Model.CreatePredictionEngine<Measurement, ConcentrationPrediction>(model);

        return new ConcentrationPredictor(engine);
    }
}
