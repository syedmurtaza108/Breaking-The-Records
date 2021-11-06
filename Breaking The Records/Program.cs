//Finished it in 7 minutes.

using System;

namespace Breaking_The_Records
{
    class Program
    {
        static int[] breakingRecords(int[] score)
        {
            int temp1 = 0, temp2 = 0;
            int[] ans = new int[2];
            int heighest = score[0];
            int lowest = score[0];
            for(int i = 1; i<score.Length; i++)
            {
                if(score[i] > heighest)
                {
                    heighest = score[i];
                    temp1++;
                }
                else if(score[i] < lowest)
                {
                    lowest = score[i];
                    temp2++;
                }
            }
            ans[0] = temp1;
            ans[1] = temp2;
            return ans;   
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
            ;
            int[] result = breakingRecords(score);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
