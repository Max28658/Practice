﻿

using ConsoleApp_01;

public class Practice_02
{
    public static void Main(String[] args)
    {
        Console.WriteLine("hello world");
        Console.WriteLine("hello world");
        Console.WriteLine("hello world");



        int[] arr = [1, 3, 44, 5, 4, 5, 3,];
        double avg = Task02.countAvg(arr);
        // Console.WriteLine("avarage of arr: " + Task02.countAvg(arr));
        Console.WriteLine("avarage of arr: " + avg);
        Console.WriteLine("avarage of arr: " + avg);


        Console.WriteLine("max in array " + Task03.findMax(arr));
    }
}