using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static int[] grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            do
            {
                for (int cnt = 0; cnt < n; cnt++)
                {
                    BloomGrapes();
                }
                KillGrapesWithPowerLesserThan(n);
            } while (StrongGrapesAreGreaterOrEqualThan(n));
            PrintLiveGrapes();
        }


        static bool StrongGrapesAreGreaterOrEqualThan(int threshold)
        {
            return grapes.Where(e => e > threshold)
                .Count() >= threshold;
        }

        static void BloomGrapes()
        {
            for (int index = 0; index < grapes.Length; index++)
            {
                if (!IsAlive(index))
                {
                    continue;
                }
                if (IsGreaterGrape(index))
                {
                    grapes[index]++;
                    if (IsAlive(index-1))
                    {
                        grapes[index]++;
                        grapes[index - 1]--;
                    }
                    if (IsAlive(index + 1))
                    {
                        grapes[index]++;
                        grapes[index + 1]--;
                    }
                }
                else if (IsLesserGrape(index))
                {
                    //sod
                }
                else
                {
                    grapes[index]++;
                }
            }
        }

        static void KillGrapesWithPowerLesserThan(int threshold)
        {
            for (int cnt = 0; cnt < grapes.Length; cnt++)
            {
                if (grapes[cnt] <= threshold)
                {
                    grapes[cnt] = 0;
                }
            }
        }
        static void PrintLiveGrapes()
        {
            for (int index = 0; index < grapes.Length; index++)
            {
                if (IsAlive(index))
                {
                    Console.Write(grapes[index] + " ");
                }
            }
            Console.WriteLine();
        }
        static bool IsGreaterGrape(int index)
        {
            if (index <= 0 || index >= grapes.Length - 1)
            {
                return false;
            }
            return (grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1]);
        }

        static bool IsLesserGrape(int index)
        {
            return (IsGreaterGrape(index-1) || IsGreaterGrape(index + 1))
           ;
        }

        static bool IsAlive(int index)
        {
            if (index<0 || index>=grapes.Length)
            {
                return false;
            }
            return grapes[index] > 0;
        }
    }
}
