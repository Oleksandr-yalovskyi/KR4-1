using System;

namespace KR{
    class Program{
    	static void MatrixFill(int[,] mat) { // метод заповенення масиву рандомними значеннями від 50 до 100
    		Random rand = new Random();
    		for ( int i = 0; i < mat.GetLength(0); i++ ) {
    			for ( int j = 0; j < mat.GetLength(1); j++ ) {
    				mat[i,j] = rand.Next(50, 100);
    			}
    		}
    	}
    	static void MatrixPrint(int[,] mat){ // метод виведення масиву у консоль
			for (int i = 0; i < mat.GetLength(0); i++){			
				for (int j = 0; j < mat.GetLength(1); j++)
					Console.Write($"{mat[i, j]} ");
			Console.WriteLine();
			}
		}
		static void MatrixMaxDiagonal(int[,] mat) { // метод знаходження сум діагоналей і знаходження більшої серед них
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

			if ( sum1 > sum2 ) { // перевірка на більшу діагональ
				Console.WriteLine($"The main diagonal is larger than the side: {sum1} > {sum2}");
			} else if ( sum2 > sum1 ) {
				Console.WriteLine($"The side diagonal is larger than the main: {sum2} > {sum1}");
			} else if ( sum1 == sum2 ) { // оскільки значення - рандомні, не виключено що суми будуть рівними
				Console.WriteLine($"The diagonals are equal: {sum2} = {sum1}");
			}
		}
		static void MatrixDiagonalSwap(int[,] mat) { // метод заміни значень головниї та побічної діагоналей
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
    		// виклики методів
    		MatrixFill(matrix);
    		MatrixPrint(matrix);
    		MatrixMaxDiagonal(matrix);
    		MatrixDiagonalSwap(matrix);
    		Console.WriteLine("After swaping");
    		MatrixPrint(matrix);
    	}
    }
}
