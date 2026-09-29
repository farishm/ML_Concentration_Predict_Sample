using Microsoft.ML;

public class ConcentrationPredictor : IConcentrationPredictor
{
    private readonly PredictionEngine<Measurement, ConcentrationPrediction> _engine;

    public ConcentrationPredictor(PredictionEngine<Measurement, ConcentrationPrediction> engine)
    {
        _engine = engine;
    }

    public ConcentrationPrediction Predict(Measurement measurement)
    {
        return _engine.Predict(measurement);
    }
}
