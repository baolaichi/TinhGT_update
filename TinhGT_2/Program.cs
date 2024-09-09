using System;
using TVGiaiThua;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương để tính giai thừa:");

            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = TVGiaiThua.TVGiaiThua.TinhGT_1(number);
                Console.WriteLine($"Giai thừa của {number} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}

