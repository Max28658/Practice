namespace ConsoleApp_01;

public class Task02
{
    public static double countAvg(int[] arr)
    {
        int sum = 0;
        foreach (var c in arr)
        {
            sum += c;
        }

        return sum / arr.Length;
    }
}