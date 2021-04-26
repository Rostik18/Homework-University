namespace Laba2_FactorioCognitiveModeling.Extensions
{
    static class MatrixExt
    {
        // метод розширення для отримання кількості рядків матриці
        public static int RowsCount(this double[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        // метод розширення для отримання кількості стовпців матриці
        public static int ColumnsCount(this double[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
    }
}
