using System.Security.Principal;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Range of number to find factorial ex: 1-100");

            string? rangeNum = Console.ReadLine();
            int startNum=0, endNum=0;
            if(!string.IsNullOrEmpty(rangeNum) && rangeNum.Contains('-'))
            {
                string[] nums = rangeNum.Split('-');
                startNum = !string.IsNullOrEmpty(nums[0]) ? Convert.ToInt32(nums[0]) : 0;
                endNum = !string.IsNullOrEmpty(nums[1]) ? Convert.ToInt32(nums[1]) : 0;

                for (int i = startNum; i <= endNum; i++)
                {
                    int flag = 0;
                    for (int k = 2; k <= i / 2; k++)
                    {
                        if (i % k == 0)
                        {
                            flag = 1;
                        }

                    }
                    if (flag == 0 && i > 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter Right Value.");
            }

        }
    }
}
