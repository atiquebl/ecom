public class ScientificCalculator : BasicCalculator, IScientificCalculator
{
    public double SquareRoot(double a)
    {
        if (a < 0)
            throw new ArgumentException("Cannot take square root of a negative number.");
        return Math.Sqrt(a);
    }

    public double Power(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }


}
