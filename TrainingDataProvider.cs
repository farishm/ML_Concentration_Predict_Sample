using System.Collections.Generic;

public class TrainingDataProvider : ITrainingDataProvider
{
    public List<Measurement> GetTrainingData()
    {
        return new List<Measurement>
        {
            new Measurement { Pressure = 1.0f, Temperature = 15.0f, Concentration = 8.2f },
            new Measurement { Pressure = 1.2f, Temperature = 18.0f, Concentration = 9.6f },
            new Measurement { Pressure = 1.5f, Temperature = 20.0f, Concentration = 11.3f },
            new Measurement { Pressure = 1.8f, Temperature = 22.0f, Concentration = 13.1f },
            new Measurement { Pressure = 2.0f, Temperature = 25.0f, Concentration = 15.0f },

            new Measurement { Pressure = 2.2f, Temperature = 27.0f, Concentration = 16.7f },
            new Measurement { Pressure = 2.5f, Temperature = 30.0f, Concentration = 19.1f },
            new Measurement { Pressure = 2.8f, Temperature = 32.0f, Concentration = 21.0f },
            new Measurement { Pressure = 3.0f, Temperature = 35.0f, Concentration = 23.4f },
            new Measurement { Pressure = 3.2f, Temperature = 38.0f, Concentration = 25.8f },

            new Measurement { Pressure = 1.1f, Temperature = 30.0f, Concentration = 10.8f },
            new Measurement { Pressure = 1.4f, Temperature = 35.0f, Concentration = 12.9f },
            new Measurement { Pressure = 1.7f, Temperature = 40.0f, Concentration = 15.2f },
            new Measurement { Pressure = 2.1f, Temperature = 45.0f, Concentration = 18.1f },
            new Measurement { Pressure = 2.4f, Temperature = 50.0f, Concentration = 20.7f },

            new Measurement { Pressure = 2.7f, Temperature = 55.0f, Concentration = 23.5f },
            new Measurement { Pressure = 3.0f, Temperature = 60.0f, Concentration = 26.4f },
            new Measurement { Pressure = 3.3f, Temperature = 65.0f, Concentration = 29.1f },
            new Measurement { Pressure = 3.6f, Temperature = 70.0f, Concentration = 31.9f },
            new Measurement { Pressure = 4.0f, Temperature = 75.0f, Concentration = 35.0f },

            new Measurement { Pressure = 1.5f, Temperature = 50.0f, Concentration = 14.8f },
            new Measurement { Pressure = 2.0f, Temperature = 60.0f, Concentration = 19.7f },
            new Measurement { Pressure = 2.5f, Temperature = 70.0f, Concentration = 24.8f },
            new Measurement { Pressure = 3.0f, Temperature = 80.0f, Concentration = 29.9f },
            new Measurement { Pressure = 3.5f, Temperature = 90.0f, Concentration = 35.3f }
        };
    }
}
