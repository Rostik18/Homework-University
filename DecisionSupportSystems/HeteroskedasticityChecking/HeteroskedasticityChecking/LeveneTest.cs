using AppliedMathLibrary.Methods;

namespace HeteroskedasticityChecking
{
    // used https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D1%81%D1%82_%D0%9B%D0%B5%D0%B2%D0%B5%D0%BD%D0%B5
    internal static class LeveneTest
    {
        public static double Run(params double[][] samples)
        {
            int k = samples.Length;

            int totalN = 0; // N
            for (int i = 0; i < k; i++)
                totalN += samples[i].Length;

            int[] N = samples.Select(x => x.Length).ToArray(); // Ni

            double[] meanY = new double[k]; // ~Yi
            for (int i = 0; i < k; i++)
                meanY[i] = Statistics.Mean(samples[i]);

            // samples is also Yij
            double[][] Z = new double[k][]; // Zij
            for (int i = 0; i < k; i++)
                Z[i] = samples[i].Select(x => Math.Abs(x - meanY[i])).ToArray();

            double meanZ = Z.SelectMany(x => x).Sum() / totalN; // Z..

            double[] meansZ = Z.Select((x, i) => x.Sum() / N[i]).ToArray(); // Zi.

            double W = (double)(totalN - k) / (k - 1);

            double up = 0;
            double down = 0;

            for (int i = 0; i < k; i++)
                up += N[i] * (meansZ[i] - meanZ) * (meansZ[i] - meanZ);

            for (int i = 0; i < k; i++)
                for (int j = 0; j < N[i]; j++)
                    down += (Z[i][j] - meansZ[i]) * (Z[i][j] - meansZ[i]);

            return W * up / down;
        }
    }
}
