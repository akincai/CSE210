using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            
            if (num == 0)
                break;

            nums.Add(num);
        }

        int sum = 0;
        int max = nums[0];

        foreach (int num in nums)
        {
            sum += num;

            if (num > max)
                max = num;
        }

        float avg = (float)sum / nums.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

    }
}