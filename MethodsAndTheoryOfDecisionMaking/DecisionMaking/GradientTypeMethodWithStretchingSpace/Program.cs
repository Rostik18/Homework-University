using System;
using System.Numerics;
using System.Text;

namespace GradientTypeMethodWithStretchingSpace
{
    //Методи градієнтного типу з розтягненням простору
    class Program
    {
        static double F(Vector3 vector)
        {
            return vector.X * vector.X + vector.Y + vector.Y + vector.Z * vector.Z;
        }

        static Vector3 G(Vector3 vector)
        {
            return new Vector3(2 * vector.X, 2 * vector.Y, 2 * vector.Z);
        }

        static void RunMethod(Vector3 xVector)
        {
            var B = new Matrix4x4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 0);

            for (int k = 0; k < 500; k++)
            {
                //крок 2
                var almostGradient = G(xVector);

                //крок 3
                if (Math.Round(almostGradient.X, 3) == 0 &&
                    Math.Round(almostGradient.Y, 3) == 0 &&
                    Math.Round(almostGradient.Z, 3) == 0)
                {
                    Console.WriteLine($"x* = ({xVector.X};{xVector.Y};{xVector.Z})");
                    return;
                }

                //крок 4
                var BT = Matrix4x4.Transpose(B);

                //крок 5 Обчислити майже градієнт ~g(yk)
                var almostGradient2 = MultiplyMatrixByVector(BT, almostGradient);

                //крок 6 Обчислити напрямок розтягнення простору
                var xi = Vector3.Divide(almostGradient2, Vector3.Distance(almostGradient2, almostGradient2));

                //крок 7 Обчислити значення крокового множника 
                //звідки брати ro?
                var ro = 0.5;

                //крок 8 Обчислити наступне наближення
                xVector = xVector - Vector3.Multiply((float)p, MultiplyMatrixByVector(B, xi));

                //крок 9  Знайти коефіцієнт розтягнення простору
                // звідки брати альфа?
                var alfa = 1.0;

                //крок 10 Обчислити коефіцієнт “стиснення” простору
                var beta = 1.0 / alfa;

                //крок 11  Обчислити оператор B, обернений до результуючого оператора A
                var matrixG = xVector + Vector3.Multiply((float)((alfa - 1) * Vector3.Distance(xVector, xi)), xi);

                //G має бути матрицею?
                //B = Matrix4x4.Multiply(B, G);

            }
        }

        static Vector3 MultiplyMatrixByVector(Matrix4x4 matrix, Vector3 vector)
        {
            return new Vector3(
                matrix.M11 * vector.X + matrix.M12 * vector.Y + matrix.M13 * vector.Z,
                matrix.M21 * vector.X + matrix.M22 * vector.Y + matrix.M23 * vector.Z,
                matrix.M31 * vector.X + matrix.M32 * vector.Y + matrix.M33 * vector.Z);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** Метод градієнтного типу з розтягненням простору ***");
            Console.WriteLine("***           F = x * x + y * y + z * z             ***");
            Console.WriteLine("***      Підготувала команда ПМа - 41 \"Кицики\"      ***");


        }
    }
}
