using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214060
{
    internal class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("kalkulator prisya");
            Console.Write("input nilai satu: ");
            int angka1 = int.Parse(Console.ReadLine());
            Console.Write("input nilai dua: ");
            int angka2 = int.Parse(Console.ReadLine());

            double penambahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penambahan);

            double pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);

            double perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);

            double pembagian = angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);

        }
    }
}
