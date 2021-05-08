using System;

namespace HomePracticeApp
{
    class Ex13_1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("1차원 배열 Array!");

            int[] score = new int[7];
            score[0] = 0;
            score[1] = 1;
            score[2] = 2;
            score[3] = 3;
            score[4] = 4;
            score[5] = 5;
            score[6] = 6;

            foreach (var item in score)

                Console.WriteLine(item);
            int sum = 0;
            foreach (var item in score)

                sum += item;
            double average = sum / score.Length;
            Console.WriteLine($"합은 {sum}");
            Console.WriteLine($"평균은 {average}");
        }
    }
}
