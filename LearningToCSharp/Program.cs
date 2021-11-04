using System;

namespace LearningToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1 , -2 , 3 , -5 , -3 , 2 , 5 , -1 , 2 , -2};
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int AtI = numbers[i];
                    int AtJ = numbers[j];

                    if(AtI + AtJ == 0)
                    {
                        Console.WriteLine($" Pair ({AtI};{AtJ}) and his index ({i};{j})");
                    }
                }
            }
        }
    }
}
