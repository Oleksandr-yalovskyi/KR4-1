using System;

namespace KR{
    class Program{
    	static void ArrayFill(int[] arr){
    		Random rand = new Random();
    		for ( int i = 0; i < arr.Length; i++ ){
    			arr[i] = rand.Next(0, 50);
    		}
    	}
    	static void ArrayPrint(int[] arr) {
    		Console.Write("Your array: ");
    		for ( int i = 0; i < arr.Length; i++ ) {
    			Console.Write($"{arr[i]} ");
    		}
    		Console.WriteLine();
    	}
    	static int ArrayMin(int[] arr) {
    		int min = arr[0];
    		for ( int i = 0; i < arr.Length; i++ ) {
    			if ( arr[i] < min ) {
    				min = arr[i];
    			}
    		}
    		return min;
    	}
    	static int ArrayMax(int[] arr) {
    		int max = arr[0];
    		for ( int i = 0; i < arr.Length; i++ ) {
    			if ( arr[i] > max ) {
    				max = arr[i];
    			}
    		}
    		return max;
    	}
    	static int ArrayAve(int[] arr) {
    		int i = 0;
    		int sum = 0;
    		while ( i < arr.Length ) {
    			sum += arr[i];
    			i++;
    		}
    		return sum/i;
    	}
    	static int ArraySum(int[] arr) {
    		int sum = 0;
    		for ( int i = 0; i < arr.Length; i++ ) {
    			sum += arr[i];
    		}
    		return sum;
    	}
        static void Main(string[] args){
        	Console.Write("Enter size of array: ");
        	int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            ArrayFill(array);
            ArrayPrint(array);
            Console.WriteLine($"Min value of the array: {ArrayMin(array)}");
            Console.WriteLine($"Max value of the array: {ArrayMax(array)}");
            Console.WriteLine($"Average value of the array: {ArrayAve(array)}");
            Console.WriteLine($"Sum of the value of the array: {ArraySum(array)}");
        }
    }
}
