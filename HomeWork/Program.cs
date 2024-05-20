using System;

class Program
{
    static void Main(string[] args)
    {
        int[] Numbers = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
        string[] Mouth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[][] AArray = new int[3][] { new[] { 2, 3, 4 }, new[] { 4, 9, 16 }, new[] { 8, 27, 64 } };
        const double E = Math.E;
        const double PI = Math.PI;
        double[] Jarray = new double[11] { 1, 2, 3, 4, 5, E, PI, Math.Log(1, 10), Math.Log(10, 10), Math.Log(100, 10), Math.Log(1000, 10) };
        foreach (var a in Numbers)
              Console.WriteLine("Arrays1 : {0}", a);
        foreach (var a in Mouth)
            Console.WriteLine("Arrays2 : {0}", a);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < AArray[i].Length; j++)
            {
                Console.WriteLine("Arrays3 : {0}", AArray[i][j]);
            }
        }
        foreach (var a in Jarray)
            Console.WriteLine("Arrays4 : {0}", a);

        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
        Array.Copy(array, array2, 3);
        foreach (var a in array)
            Console.WriteLine("Arrays5 : {0}", a);
        foreach (var a in array2)
            Console.WriteLine("Arrays5 : {0}", a);

        Array.Resize(ref array, 10);
        foreach (var a in array)
            Console.WriteLine("Arrays6 : {0}", a);







    }
}
