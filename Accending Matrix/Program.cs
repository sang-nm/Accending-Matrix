using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accending_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int row1, row2, col1, col2;
            Console.WriteLine("Enter the row of the first matrix:");
            row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column of the first matrix:");
            col1 = int.Parse(Console.ReadLine());
            int[,] FirstMatrix=new int[row1,col1];
            Console.WriteLine("Enter the row of the second matrix:");
            row2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column of the second matrix:");
            col2=int.Parse(Console.ReadLine());
            int[,] SecondMatrix=new int[row2,col2];
            int r1, r2, c1, c2;
            int len=0;
            for(r1=0;r1<row1;r1++)
            {
                for(c1=0;c1<col1;c1++)
                {
                    Console.WriteLine("Enter the value of FisrtMatrix[{0}][{1}]",r1,c1);
                    FirstMatrix[r1,c1]=int.Parse(Console.ReadLine());
                    len = len + 1;
                }
            }
            for(r2=0;r2<row2;r2++)
            {
                for(c2=0;c2<col2;c2++)
                {
                    Console.WriteLine("Enter the value of SecondMatrix[{0}][{1}]",r2,c2);
                    SecondMatrix[r2,c2]=int.Parse(Console.ReadLine());
                    len = len + 1;
                }
            }
            Console.WriteLine("\nThe FisrtMatrix:");
            for (r1 = 0; r1 < row1; r1++)
            {
                for (c1 = 0; c1 < col1; c1++)
                {
                    Console.Write("[{0},{1}]:\t", r1, c1 );
                    Console.Write(FirstMatrix[r1, c1]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThe SecondMatrix:");
            for (r2 = 0; r2 < row2; r2++)
            {
                for (c2 = 0; c2 < col2; c2++)
                {
                    Console.Write("[{0},{1}]:\t", r2, c2 );
                    Console.Write(SecondMatrix[r2, c2]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            int[] Both = new int[len];
            int f = 0, len1;
            len1 = row1 * col1;
            for (r1 = 0; r1 < row1; r1++)
            {
                for (c1 = 0; c1 < col1; c1++)
                {
                    Both[f] = FirstMatrix[r1, c1];
                    f = f + 1;
                }
            }
            f = len1;
            for (r2 = 0; r2 < row2; r2++)
            {
                for (c2 = 0; c2 < col2; c2++)
                {
                    Both[f] = SecondMatrix[r2, c2];
                    f = f + 1;
                }
            }
            Console.Write("\nArray includes two matrixs:\n");
            for (f = 0; f < len;f++ )
            {
                Console.Write("     {0}", Both[f]);
            }
            int i = 0,change;
            Console.Write("\n\nArray includes two matrixs and accending:\n");
            for (f = 0; f < len; f++)
            {
                for (i = f + 1; i < len; i++)
                {
                    if (Both[f] > Both[i])
                    {
                        change = Both[f];
                        Both[f] = Both[i];
                        Both[i] = change;
                    }
                }
                Console.Write("     {0}", Both[f]);
            }
            Console.WriteLine();
            Console.WriteLine("\n\t\t\tKet Qua\n");
            int row3,col3, r3, c3, Multi;
            f = 0;
            if(len%2==1)
            {
                for(row3=0;row3<len/2;row3++)
                {
                    Multi = row3 * row3;
                    if(Multi==len)
                    {
                        col3 = row3;
                        int[,] NewMatrix = new int[row3, col3];
                        Console.WriteLine("The Accending Matrix:");
                        for(r3=0;r3<row3;r3++)
                        {
                            for(c3=0;c3<col3;c3++)
                            {
                                NewMatrix[r3,c3] = Both[f];
                                f++;
                                Console.Write("[{0},{1}]:\t", r3, c3);
                                Console.Write(NewMatrix[r3, c3]);
                                Console.Write("\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            else
            {
                if (len == 2)
                {
                    for (f = 0; f < len; f++)
                    {
                        Console.Write("     {0}", Both[f]);
                    }
                }
                else
                {
                    int x1,x2,Multi2;
                    for (x2 = 0; x2 <= len / 2; x2++)
                    {
                        for (x1 = 0; x1 <= len / 2; x1++)
                        {
                            Multi2 = x1 * x2;
                            if(Multi2==len)
                            {
                                row3 = x1;
                                col3 = x2;
                                f = 0;
                                int[,] NewMatrix = new int[row3, col3];
                                for(x1=0;x1<row3;x1++)
                                {
                                    for(x2=0;x2<col3;x2++)
                                    {
                                        NewMatrix[x1, x2] = Both[f];
                                        f++;
                                        Console.Write("[{0},{1}]:\t", x1, x2);
                                        Console.Write(NewMatrix[x1, x2]);
                                        Console.Write("\t");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
