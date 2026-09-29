using System.Collections.Generic;

public interface ITrainingDataProvider
{
    List<Measurement> GetTrainingData();
}
