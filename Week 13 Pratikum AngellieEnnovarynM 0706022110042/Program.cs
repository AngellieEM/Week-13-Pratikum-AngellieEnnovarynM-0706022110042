using System;

namespace Pratikum_Week_13_AngellieEnnovarynM_0706022110042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingin menginput berapa data? ");
            int banyakData = Convert.ToInt16(Console.ReadLine());
            string[,] inputData = new string[banyakData, 6];
            /*
            inputData[banyakData,0] itu adalah untuk menyimpan NIM
            inputData[banyakData,1] itu adalah untuk menyimpan NAMA
            inputData[banyakData,2] itu adalah untuk menyimpan JENIS KELAMIN
            inputData[banyakData,3] itu adalah untuk menyimpan TAHUN MASUK
            inputData[banyakData,4] itu adalah untuk menyimpan PROGRAM STUDI 
            inputData[banyakData,5] itu adalah untuk menyimpan KELAS
            */
            for (int i = 0; i < banyakData; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Data ke - " + (i + 1) + " : ");
                Console.Write("NIM : ");
                inputData[i, 0] = Console.ReadLine();
                for (int b = 0; b < i; b++)
                {
                    if (inputData[i, 0] == inputData[b, 0])
                    {
                        Console.WriteLine("MOHON MAAF NIM SUDAH ADA, SILAHKAN MASUKKAN NIM YANG LAIN !! ");
                        Console.Write("NIM : ");
                        inputData[i, 0] = Console.ReadLine();
                    }
                }
                Console.Write("NAMA : ");
                inputData[i, 1] = Console.ReadLine();
                Console.Write("JENIS KELAMIN : ");
                inputData[i, 2] = Console.ReadLine();
                Console.Write("TAHUN MASUK : ");
                inputData[i, 3] = Console.ReadLine();
                Console.Write("PROGRAM STUDI : ");
                inputData[i, 4] = Console.ReadLine();
                Console.Write("KELAS : ");
                inputData[i, 5] = Console.ReadLine();


            }
            Console.Write("Ingin print hasil? (y/n)");
            string cetakData = Console.ReadLine();
            while (cetakData != "y" && cetakData != "n")
            {
                Console.Write("Ingin print hasil? (y/n)");
                cetakData = Console.ReadLine();
                Console.WriteLine(cetakData);
            }

            if (cetakData == "y")
            {
                Console.Clear();
                var sb = new System.Text.StringBuilder();
                sb.Append("\n");
                sb.Append(String.Format("{0, -6} | {1, -4} | {2, -20} | {3, 10} | {4, 5} | {5, 4} | {6, 6}", "Number", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS\n"));
                sb.Append("\n");
                for (int input = 0; input < banyakData; input++)
                {
                    sb.Append(String.Format("{0, -6} | {1, -4} | {2, -20} | {3, 10} | {4, 5} | {5, 4} | {6, 6}", (input + 1), inputData[input, 0], inputData[input, 1], inputData[input, 2], inputData[input, 3], inputData[input, 4], inputData[input, 5] + "\n"));

                }
            }

            Console.Write("Ingin menambah data yang baru? (y/n)");
            string dataBaru = Console.ReadLine();
            while (dataBaru != "y" && dataBaru != "n")
            {
                Console.Write("Ingin print hasil? (y/n)");
                dataBaru = Console.ReadLine();
                Console.WriteLine(cetakData);
            }

            if (dataBaru == "y")
            {
                Console.Write("Ingin menambah berapa banyak data baru? ");
                int banyakDataBaru = Convert.ToInt16(Console.ReadLine());
                string[,] inputDataBaru = new string[banyakDataBaru, 6];

                /*
                 inputData[banyakData,0] itu adalah untuk menyimpan NIM
                 inputData[banyakData,1] itu adalah untuk menyimpan NAMA
                 inputData[banyakData,2] itu adalah untuk menyimpan JENIS KELAMIN
                 inputData[banyakData,3] itu adalah untuk menyimpan TAHUN MASUK
                 inputData[banyakData,4] itu adalah untuk menyimpan PROGRAM STUDI 
                 inputData[banyakData,5] itu adalah untuk menyimpan KELAS
                */
                for (int i = 0; i < banyakDataBaru; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Data ke - " + (i + 1) + " : ");
                    Console.Write("NIM : ");
                    inputDataBaru[i, 0] = Console.ReadLine();
                    for (int b = 0; b < i; b++)
                    {
                        if (inputData[i, 0] == inputData[b, 0])
                        {
                            Console.WriteLine("MOHON MAAF NIM SUDAH ADA, SILAHKAN MASUKKAN NIM YANG LAIN !! ");
                            Console.Write("NIM : ");
                            inputData[i, 0] = Console.ReadLine();
                        }
                    }
                    Console.Write("NAMA : ");
                    inputDataBaru[i, 1] = Console.ReadLine();
                    Console.Write("JENIS KELAMIN : ");
                    inputDataBaru[i, 2] = Console.ReadLine();
                    Console.Write("TAHUN MASUK : ");
                    inputDataBaru[i, 3] = Console.ReadLine();
                    Console.Write("PROGRAM STUDI : ");
                    inputDataBaru[i, 4] = Console.ReadLine();
                    Console.Write("KELAS : ");
                    inputDataBaru[i, 5] = Console.ReadLine();

                }
            }
        }
    }
}