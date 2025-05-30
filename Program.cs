

using System.Drawing;

public class Program
{
    private static void Main(string[] args)
    {
        /*//khoi tao ma tran vuong
        int[,] testArray = {
            { 1, 2 },
            { 5, 6 }
        };

        int diagonalSum = 0;

        for (int row = 0; row < testArray.GetLength(0); row++)
        {
                    diagonalSum += testArray[row, row];
        }
        Console.WriteLine(diagonalSum);*/

        Console.Write("Enter the size of the square matrix: ");
        int sizeSquare = Convert.ToInt32(Console.ReadLine());
        int[,] squareMatrix = new int[sizeSquare, sizeSquare];
        Console.WriteLine("Enter the element: ");

        //nhap phan tu vao mang:
        for (int row = 0; row < squareMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < squareMatrix.GetLength(1); col++)
            {
                Console.Write($"Element [{row}, {col}]: ");
                squareMatrix[row, col] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //in mang ra man hinh
        Console.WriteLine("Array: ");
        for (int row = 0; row < squareMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < squareMatrix.GetLength(1); col++)
            {
                Console.Write(squareMatrix[row, col] + "\t");
            }
            Console.WriteLine();
        }

        //tinh tong duong cheo chinh
        int diagonalSum = 0;
        for (int row = 0; row < squareMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < squareMatrix.GetLength(1); col++)
            {
                if (row == col)
                {
                    diagonalSum += squareMatrix[row, col];
                }
            }
        }
        Console.WriteLine($"The sum of the numbers on the main diagonal of the square matrix is: {diagonalSum}");
    }
}