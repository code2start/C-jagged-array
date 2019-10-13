using System;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[][] numbers = new int[3][];
            numbers[0] = new int[3];
            numbers[1] = new int[2];
            numbers[2] = new int[1];
            //initializ 
            numbers[0][1] = 3; */
            int[][] numbers = new int[][]{new int[]{1,2},new int[]{3,4,5},new int[]{6}};
            for(int i = 0; i < numbers.Length;i++){
                for(int j = 0; j < numbers[i].Length;j++){
                    Console.WriteLine(numbers[i][j]);
                }
            }

        }
    }
}
