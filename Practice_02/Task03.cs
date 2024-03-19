namespace ConsoleApp_01;

public class Task03
{
    public static int findMax(int[] arr)
    {

        if (arr == null)
        {
            return 0;
        } else if (arr.Length == 1)
        {
            return arr[0];
        }
        
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max<arr[i])
            {
                max = arr[i];
            }  
        }

        return max;
    }
}