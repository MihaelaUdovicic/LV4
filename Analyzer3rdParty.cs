using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            //implementation missing!
            int redovi = data.Length;
            int stupci = data[0].Length;
            double[] results = new double[stupci];
            for (int i = 0; i < stupci; i++)
            {
                double suma = 0;
                for (int j = 0; j < redovi; j++)
                {
                    suma += data[j][i];
                }
                results [i]= suma / redovi;
            }
            return results;
        }

        public void Matrica(double [][] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                for(int j=0;j< data[i].Length; j++)
                {
                    Console.WriteLine(data[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
