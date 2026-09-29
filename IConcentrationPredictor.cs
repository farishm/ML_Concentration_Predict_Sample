public interface IConcentrationPredictor
{
    ConcentrationPrediction Predict(Measurement measurement);
}
