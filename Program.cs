using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_1_kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Title=("Calculator");
            Console.Write(" Pilih Menu Calculator \n \n");
            Console.Write(" 1. Penjumlahan \n 2. Pengurangan \n 3. Perkalian \n 4. Pembagian");
            Console.Write( "\n \n Input nomor menu [1..4]: " );
            int operasi = int.Parse(Console.ReadLine());

            if(operasi != 1 && operasi !=2 && operasi != 3 && operasi != 4)
            {
                Console.WriteLine("\n \n Maaf, operasi yang anda pilih tidak tersedia");
            }

            switch (operasi)
            {
                case 1:
                    Console.Write("\n Input nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" Input nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n Hasil Penjumlahan: " + a + " + " + b + " = ");
                    Console.WriteLine(a + b);
                    Console.Write("\n Tekan sembarang key untuk keluar");
                    break;
                case 2:
                    Console.Write("\n Input nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" Input nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n Hasil Pengurangan: " + a + " - " + b + " = ");
                    Console.WriteLine(a - b);
                    Console.Write("\n Tekan sembarang key untuk keluar");
                    break;
                case 3:
                    Console.Write("\n Input nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" Input nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n Hasil Perkalian: " + a + " x " + b + " = ");
                    Console.WriteLine(a * b);
                    Console.Write("\n Tekan sembarang key untuk keluar");
                    break;
                case 4:
                    Console.Write("\n Input nilai a: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" Input nilai b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    if(b != 0)
                    {
                        Console.Write("\n Hasil Pembagian: " + a + " / " + b + " = ");
                        Console.WriteLine(a / b);
                    }
                    else
                    {
                        Console.WriteLine("\n Tidak dapat melakukan pembagian dengan bilangan 0");
                    }
                    
                    Console.Write("\n Tekan sembarang key untuk keluar");
                    break;
            }

            Console.ReadLine();
        }
    }
}
