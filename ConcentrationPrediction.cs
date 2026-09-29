using Microsoft.ML.Data;

public class ConcentrationPrediction
{
    [ColumnName("Score")]
    public float Concentration { get; set; }
}
