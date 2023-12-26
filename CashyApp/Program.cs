using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CashyApp
{
    internal class Program
    {
        private static double total = 0, harga, bayar, kembalian;
        private static int jumlah, chs;
        static void Main(string[] args)
        {
            
            Console.WriteLine("======================");
            Console.WriteLine("MIMAKE MART");

            do
            {
                Console.WriteLine("======================");
                Console.WriteLine("Menu : ");
                Console.WriteLine("1. Tolak Angin");
                Console.WriteLine("2. Extra Joss");
                Console.WriteLine("3. Bear Brand");
                Console.WriteLine("\n9. Selesaikan Pembayaran");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("======================");
                Console.WriteLine("Masukkan Pilihan :");
                chs = Convert.ToInt32(Console.ReadLine());

                if (chs >= 1 && chs <= 3)
                {
                    Console.Write("Masukkan Jumlah Beli: ");
                    jumlah = Convert.ToInt32(Console.ReadLine());
                    countTotal(jumlah, chs, ref total);
                }

            } while (chs != 9);

            viewTotal();

            Console.Write("Bayar : Rp");
            bayar = Convert.ToDouble(Console.ReadLine());
            hitungKembalian(bayar);
            viewKembalian();
        }

        static void viewTotal()
        {
            Console.WriteLine("==========(PEMBAYARAN)=============");
            Console.WriteLine("Total : Rp" + total);
        }

        static void countTotal(int jml, int chs, ref double total)
        {
            switch (chs)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    harga = 3000;
                    total = total + (harga * jml);
                    break;
                case 2:
                    harga = 2500;
                    total = total + (harga * jml);
                    break;
                case 3:
                    harga = 11000;
                    total = total + (harga * jml);
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("ERROR : INPUT YANG ANDA MASUKKAN SALAH");
                    break;
            }
        }

        static void hitungKembalian(double byr)
        {
            bayar = byr;
            kembalian = bayar - total;
        }

        static void viewKembalian()
        {
            if (bayar <= total)
            {
                Console.WriteLine("Maaf uang Anda tidak cukup");
            }
            else
            {
                Console.WriteLine("Kembalian : Rp" + kembalian);
            }
            Console.WriteLine("==============(TERIMA KASIH)===============");
            Console.ReadLine();
        }
    }
}
