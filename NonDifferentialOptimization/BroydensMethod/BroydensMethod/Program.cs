using System;
using System.Numerics;
using System.Text;

namespace BroydensMethod
{
    // Метод Бройдена
    class Program
    {
        static readonly Matrix4x4 I = new Matrix4x4 { M11 = 1, M22 = 1 };

        static double F(Vector2 vector) =>
            vector.X * vector.X - vector.X * vector.Y + vector.Y * vector.Y + 9 * vector.X - 6 * vector.Y + 20;

        static Vector2 DerivativeF(Vector2 vector) =>
            new Vector2(
                2 * vector.X - vector.Y + 9,
                -vector.X + 2 * vector.Y - 6
            );

        static void BroydensMethod(Vector2 vector)
        {
            double e = 0.001;

            Matrix4x4 H = I;

            for (int k = 0; k < 1000; k++)
            {
                Console.WriteLine($"{k}: F({vector.X:f3}; {vector.Y:f3}) = {F(vector):f3}");

                var vectorGradient = DerivativeF(vector);

                if (Norm(vectorGradient) <= e)
                    break;

                var p = MatrixVectorMultiply(-H, vectorGradient);

                Func<double, double> compressedFunc = x =>
                    F(new((float)(vector.X + x * p.X), (float)(vector.Y + x * p.Y)));
                (var a, var b) = DCKMethod.FindSegment(compressedFunc);

                var alfa = (float)DichotomyMethod.FindMinimumArgument(compressedFunc, a, b);

                var vectorNext = new Vector2(vector.X + alfa * p.X, vector.Y + alfa * p.Y);

                var vectorGradientNext = DerivativeF(vectorNext);

                var s = vectorNext - vector;
                var y = vectorGradientNext - vectorGradient;

                var ro = 1 / (y.X * s.X + y.Y * s.Y);

                H = (I - (VectorsMultiplyToMatrix(s, y) * ro)) *
                    H * (I - (VectorsMultiplyToMatrix(y, s) * ro)) +
                    (VectorsMultiplyToMatrix(s, s) * ro);

                vector = vectorNext;
                vectorGradient = vectorGradientNext;
            }
        }

        static Vector2 MatrixVectorMultiply(Matrix4x4 matrix, Vector2 vector) =>
            new Vector2(
                matrix.M11 * vector.X + matrix.M12 * vector.Y,
                matrix.M21 * vector.X + matrix.M22 * vector.Y);

        static Matrix4x4 VectorsMultiplyToMatrix(Vector2 v1, Vector2 v2) =>
           new Matrix4x4(
               v1.X * v2.X, v1.X * v2.Y, 0, 0,
               v1.Y * v2.X, v1.Y * v2.Y, 0, 0,
               0, 0, 0, 0,
               0, 0, 0, 0);

        static double Norm(Vector2 v) =>
            Math.Sqrt(v.X * v.X + v.Y * v.Y);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Недиф. Опт.");
            Console.WriteLine("Індивідуальна 2: Метод Бройдена");
            Console.WriteLine("Ростислав Байцар, ПМа - 41");
            Console.WriteLine("F(x, y) = x^2 - xy + y^2 + 9x - 6y + 20");
            Console.WriteLine();

            BroydensMethod(new(1, 1));
        }
    }
}
