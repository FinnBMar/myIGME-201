using System;

namespace ZCalculator
{
    class Program //Finn Marable this program prints all possible values of z depending on what x and y are in their range
    {
        static void Main(string[] args)
        {
            double minXRange = -1.0;
            double maxXRange = 1.0;
            double minYRange = 1.0; //Define the ranges and increments for x and y
            double maxYRange = 4.0;
            double stepIncrement = 0.1;

            int xValuesCount = (int)((maxXRange - minXRange) / stepIncrement) + 1; //Calculate the size of the 3D array
            int yValuesCount = (int)((maxYRange - minYRange) / stepIncrement) + 1;

            double[,,] resultValues = new double[xValuesCount, yValuesCount, 3]; //Create the 3D array to store the results

            for (int xIndex = 0; xIndex < xValuesCount; xIndex++)//Calculate z for each combination of x and y
            {
                for (int yIndex = 0; yIndex < yValuesCount; yIndex++)
                {
                    double currentX = minXRange + xIndex * stepIncrement;
                    double currentY = minYRange + yIndex * stepIncrement;
                    double calculatedZ = 3 * currentY * currentY + 2 * currentX - 1;

                    resultValues[xIndex, yIndex, 0] = currentX;
                    resultValues[xIndex, yIndex, 1] = currentY;
                    resultValues[xIndex, yIndex, 2] = calculatedZ; //Store the values in the 3D array
                }
            }

            for (int xIndex = 0; xIndex < xValuesCount; xIndex++)
            {
                for (int yIndex = 0; yIndex < yValuesCount; yIndex++) //Display the results
                {
                    double currentX = resultValues[xIndex, yIndex, 0];
                    double currentY = resultValues[xIndex, yIndex, 1];
                    double calculatedZ = resultValues[xIndex, yIndex, 2];

                    Console.WriteLine($"X = {currentX}, Y = {currentY}, Z = {calculatedZ}");
                }
            }
        }
    }
}