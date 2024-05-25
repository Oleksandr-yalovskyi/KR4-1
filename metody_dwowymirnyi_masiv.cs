using System;

namespace KR{
    class Program{
        static void MatrixFill(int[,] mat) { // method to fill the array with random values from 50 to 100
            Random rand = new Random();
            for ( int i = 0; i < mat.GetLength(0); i++ ) {
                for ( int j = 0; j < mat.GetLength(1); j++ ) {
                    mat[i,j] = rand.Next(50, 100);
                }
            }
        }
        static void MatrixPrint(int[,] mat){ // method to print the array to the console
            for (int i = 0; i < mat.GetLength(0); i++){            
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write($"{mat[i, j]} ");
            Console.WriteLine();
            }
        }
        static void MatrixMaxDiagonal(int[,] mat) { // method to find the sums of the diagonals and determine the larger one
            int sum1 = 0;
            int sum2 = 0;
            for ( int i = 0; i < mat.GetLength(0); i++ ) {
                for ( int j = 0; j < mat.GetLength(1); j++ ) {
                    if ( i == j ) {
                        sum1 += mat[i, j];
                    }
                }
                sum2 += mat[mat.GetLength(0) - 1 - i, i];
            }

            if ( sum1 > sum2 ) { // check which diagonal is larger
                Console.WriteLine($"The main diagonal is larger than the side: {sum1} > {sum2}");
            } else if ( sum2 > sum1 ) {
                Console.WriteLine($"The side diagonal is larger than the main: {sum2} > {sum1}");
            } else if ( sum1 == sum2 ) { // since the values are random, it is possible that the sums will be equal
                Console.WriteLine($"The diagonals are equal: {sum2} = {sum1}");
            }
        }
        static void MatrixDiagonalSwap(int[,] mat) { // method to swap the values of the main and side diagonals
            for ( int i = 0; i < mat.GetLength(0); i++ ) {
                for (int j = 0; j < mat.GetLength(1); j++){
                    if (i == j){
                        int temp = mat[i, mat.GetLength(0) - 1 - i];

                        mat[i, mat.GetLength(0) - 1 - i] = mat[i, j];
                        mat[i, j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args) {
            int size = 8;
            Console.WriteLine($"Size of matrix is {size}x{size}");
            int[,] matrix = new int[size, size];
            // method calls
            MatrixFill(matrix);
            MatrixPrint(matrix);
            MatrixMaxDiagonal(matrix);
            MatrixDiagonalSwap(matrix);
            Console.WriteLine("After swapping");
            MatrixPrint(matrix);
        }
    }
}
