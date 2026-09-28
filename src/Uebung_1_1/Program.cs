
namespace Uebung_1_1;


class Program
{
    static void Main()
    {
        int[] arr = { 4, 7, 3, 6, 8, 2 };
        int pos = FindMAx(arr);
        Console.WriteLine($"Maxium {arr[pos]} auf Index {pos}\n");
    }
    static int FindMAx(int[] arr)
    {

        int maxPos = 0;
        for (int i = 0; i < 6; i++)
        {
            if (arr[i] > arr[maxPos])
            {
                maxPos = i;
            }
            
        }
        return maxPos;
    }
}

