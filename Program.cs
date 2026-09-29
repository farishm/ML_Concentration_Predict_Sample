using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ITrainingDataProvider trainingProvider = new TrainingDataProvider();
        IUserInputProvider inputProvider = new ConsoleUserInputProvider();
        IModelTrainer trainer = new ModelTrainer();

        var trainingData = trainingProvider.GetTrainingData();

        Console.WriteLine("Sample Console Application to Predict Concentration of a substance in a Solution");
        Console.WriteLine("for a given Temperature and Pressure.");
        Console.WriteLine();

        Console.WriteLine("Training Data:");
        Console.WriteLine();

        foreach (var m in trainingData)
        {
            Console.WriteLine($"Pressure: {m.Pressure}, Temperature: {m.Temperature}, Concentration: {m.Concentration}");
        }

        Console.WriteLine();
        Console.WriteLine("Training the model, Please wait...");

        var predictor = trainer.Train(trainingData);

        var newMeasurement = new Measurement
        {
            Pressure = inputProvider.GetPressure(),
            Temperature = inputProvider.GetTemperature()
        };

        var prediction = predictor.Predict(newMeasurement);

        Console.WriteLine($"Predicted concentration: {prediction.Concentration:F3}");
        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }
}