using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;
using System.Linq;


namespace morskoy_boi
{
    class Program
    {
        #region firstcode
        /*static void nol()
         {
             int[] a = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
             int h = Convert.ToInt32(Console.ReadLine());

             switch (h)
             {
                 case 1:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 2:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 3:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 4:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 5:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 6:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 7:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 8:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 case 9:
                     for (int i = 0; i < 9; i++)
                     {
                         if (i == h - 1)
                             Console.Write('O');
                         else
                             Console.Write(a[i]);
                         if (i % 3 == 2)
                             Console.WriteLine();
                     }
                     break;
                 default:
                     Console.WriteLine("end");
                     break;
             }

         }
          } */
        #endregion

        static int[] a;
        const int Sz = 3;

        static void Draw()
        {
            for (int i = 0; i < Sz; i++)
            {
                for (int j = 0; j < Sz; j++)
                    switch (a[i * Sz + j])
                    {
                        case -1:
                            Console.Write('X');
                            break;
                        case 0:
                            Console.Write('O');
                            break;
                        default:
                            Console.Write(a[i * Sz + j]);
                            break;
                    }
                Console.WriteLine();
            }
        }

        static void Turn(bool IsX)
        {
            int h;
            do
            {
                if (int.TryParse(Console.ReadLine(), out h) && h > 0 && h <= Sz * Sz && a[h - 1] > 0)
                    a[h - 1] = IsX ? -1 : 0;
                else
                    h = 0;
            }
            while (h == 0);
        }

        static void Main()
        {
            a = new int[Sz * Sz] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int left = Sz * Sz;
            bool IsX = false;
            Draw();
            while (left > 0)
            {
                Turn(IsX);
                Draw();
                IsX = !IsX;
                left--;
            }
            Console.ReadKey();
        }
    }
}
