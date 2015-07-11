namespace VariablesDataExpressionsAndConstants
{
    public class PrintStatistic
    {
        public void PrintStatistics(double[] values, int valuesCount)
        {
            double maxValue = 0;
            for (int i = 0; i < valuesCount; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }

            PrintMax(maxValue);

            double minValue = maxValue;
            for (int i = 0; i < valuesCount; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                }
            }

            PrintMin(minValue);

            double sum = 0;
            for (int i = 0; i < valuesCount; i++)
            {
                sum += values[i];
            }

            PrintAvg(sum / valuesCount);
        }
    }
}
