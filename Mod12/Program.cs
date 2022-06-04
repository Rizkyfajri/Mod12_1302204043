// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Nim : 1302204043
//NIM berakhiran 3, 4 atau 5: tipe data input double

namespace Mod12
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Masukan NIM : ");//menyanyakan input
            double A = Convert.ToDouble(Console.ReadLine());//membaca input
            double B = Convert.ToDouble(Console.ReadLine());//variable bersifat double karena nim berakhir dengan angka 3
            double C = Convert.ToDouble(Console.ReadLine());

            //inisiasi class Penjumlahan sebagai jum dan SimpleDataBase sebagai DB
            Penjumlahan jum = new Penjumlahan();
            SimpleDataBase<double> DB = new SimpleDataBase<double>();

            jum.JumlahTigaAngka<double>(A, B, C);//memanggil method JumlahTigaAngka dari Penjumlahan

            //menyimpan nilai A B dan C ke dalam simpledatabase
            DB.AddNewData(A);
            DB.AddNewData(B);
            DB.AddNewData(C);
            //mengoutput timestamp dan isi data yang tersimpan
            DB.PrintAllData();
        }
    }
}