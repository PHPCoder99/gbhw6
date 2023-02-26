using System;

namespace gbhw6
{
    class Program
    {
        // 1...
        // static int ReadInt(string prompt){
        //     Console.WriteLine(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // static int[] ReadIntArray(int len){
        //     int[] array = new int[len];
        //     for(int i = 0; i < len; i++){
        //         array[i] = Convert.ToInt32(Console.ReadLine());;
        //     }
        //     return array;
        // }
        
        // static int CountPositive(int[] array){
        //     int count = 0;
        //     for(int i = 0; i < array.Length; i++)
        //         if (array[i] > 0) count++;
        //     return count;
        // }

        // 2...
        // static double[] ReadDoubleArray(){
        //     return Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        // }

        // static double[] CalculateIntersection(double[] array){
        //     // array = {k1, b1, k2, b2}
        //     double x = (array[3]-array[1])/(array[0]-array[2]);
        //     double y = array[0]*x+array[1];
        //     return new[] {x, y};
        // }

        // static void WriteCoords(double[] array){
        //     Console.WriteLine("("+string.Join(", ", array)+")");
        // }
        
        static void Main(string[] args){
            // 1...
            // Console.WriteLine(CountPositive(ReadIntArray(ReadInt("Введите число: "))));

            // 2...
            // Console.WriteLine("Введите k1, b1, k2, b2: ");
            // double[] equations = ReadDoubleArray();
            // WriteCoords(CalculateIntersection(equations));
        }
    }
}
