using System;

namespace Matrix
{
    class Program
    {
        static void Vector()
        {
            Console.WriteLine("Vector:\n");
            Console.WriteLine("Enter size of array:");

            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void BidimensionalMatrix()
        {
            Console.WriteLine("\nBidimensional Matrix:\n");
            Console.WriteLine("\nEnter height and width of matrix");

            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int[,] array = new int[height, width];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void SteppedMatrix()
        {
            Console.WriteLine("\nStepped Matrix:\n");

            int[][] array = new int[4][];
            array[0] = new int[5];
            array[1] = new int[12];
            array[2] = new int[4];
            array[3] = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void ThreedimensionalMatrix()
        {
            Console.WriteLine("\nThree-dimensional Matrix:\n");
            Console.WriteLine("\nEnter length, width, heigth of matrix");

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            
            
            int[,,] array = new int[length, width, height];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Page No:" + (i + 1));
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        static void RandomSteppedMatrix()
        {
            Console.WriteLine("\nRandom Stepped Matrix:\n");

            Random random = new Random();
            int[][][] array = new int[random.Next(3, 6)][][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        array[i][j][k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Page No:" + (i + 1));

                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                    {
                        Console.Write(array[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void ReversMatrix()
        {
            Console.WriteLine("Reversed Vector:\n");
            Console.WriteLine("Enter size of array:");

            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine("Normal array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine("\nReversed array:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + "\t");
            }

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose option:\n" +
                    "1:Vector\n" +
                    "2:Bidimensional Matrix\n" +
                    "3:Stepped Matrix\n" +
                    "4:Threedimensional Matrix\n" +
                    "5:Random Stepped Matrix\n" +
                    "6:Reverse Matrix\n" +
                    "7:Clear screen\n" +
                    "8:Exit");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Vector();
                        break;
                    case 2:
                        BidimensionalMatrix();
                        break;
                    case 3:
                        SteppedMatrix();
                        break;
                    case 4:
                        ThreedimensionalMatrix();
                        break;
                    case 5:
                        RandomSteppedMatrix();
                        break;
                    case 6:
                        ReversMatrix();
                        break;
                    case 7:
                        Console.Clear();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option! Try Again");
                        break;

                }
            }
        }
    }
}
