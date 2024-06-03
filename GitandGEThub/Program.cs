namespace GitandGEThub;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("1chi array uzunligi : ");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("2chi array uzunligi : ");
        //int n1 = int.Parse(Console.ReadLine());

        int[] nums1 = {1,3,4 };
        int[] nums2 = {1,3,4};

        //for (int i = 0; i < nums1.Length; i++)
        //{
        //    nums1[i]= int.Parse(Console.ReadLine());
        //}

        //for (int i = 0;i < nums2.Length; i++)
        //{
        //    nums2[i] = int.Parse(Console.ReadLine());
        //}

        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(NumberOfPairs(nums1, nums2, k));
    }
    public static int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        int count = 0;
        for (int i = 0;i < nums1.Length;i++)
        {
            for (int j = 0;j < nums2.Length;j++)
            {
                if (nums1[i] % nums2[j] * k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
