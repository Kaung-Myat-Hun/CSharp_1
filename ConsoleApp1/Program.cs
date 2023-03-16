using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 bit 
            byte b = 100;
            sbyte sb = -120;

            // 16 bit 
            short s = -6000;
            ushort us = 6000;

            // 32 bit
            int i = -10000000;
            uint ui = 1000000;

            //64 bit
            long l = -100000;
            ulong ul = 10000000;

            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(s);
            Console.WriteLine(us);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);

            // type conversation 

            byte x = 100;
            short y = x; //implicit

            x = (byte) y; // explict ကြီးရာကနေပီး ငယ်ရာကိုသွားရင် explicitt ဖြစ်တယ်အာ့ဆိုရင် cast ကို ဖမ်းပေးဖို့လိုတယ် လက်သည်းကွင်းထဲမှာ type ကို ရေးပေးဖို့လိုပါတယ်

            string str = "234";
            int number = Convert.ToInt32 (str);

            string str1 = "1234";
            int num = Convert.ToInt32 (str1);
        }
    }
}
