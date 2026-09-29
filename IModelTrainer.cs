using System.Collections.Generic;

public interface IModelTrainer
{
    IConcentrationPredictor Train(IEnumerable<Measurement> trainingData);
}
