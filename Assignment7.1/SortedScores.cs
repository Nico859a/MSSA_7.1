using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._1
{
    internal class SortedScores
    {
        static void Main(string[] args)
        {
            int[] Scores = { 88, 76, 65, 94, 80, 95, 77, 68, 96, 84, 84, 55 };
            SelectionSort(Scores);
            Console.Write("The sorted exam scores are: ");
            foreach (int i in Scores)
            {
                Console.Write(i);
                Console.Write(",");
            }
            Console.ReadKey();
        }

        static void SelectionSort(int[] Scores)
        {
            int minposition = 0;
            int temp = 0;
            for (int i = 0; i < Scores.Length - 1; i++)
            {
                minposition = i;
                for (int j = i + 1; j < Scores.Length; j++)
                {
                    if (Scores[j] < Scores[minposition])
                    {
                        minposition = j;
                    }
                }
                if (minposition != i)
                {
                    temp = Scores[i];
                    Scores[i] = Scores[minposition];
                    Scores[minposition] = temp;
                }
            }
        }
    }
}
