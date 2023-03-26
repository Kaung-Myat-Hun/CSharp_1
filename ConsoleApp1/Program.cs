using System;
using System.Collections;
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
            // 8 bit ၂ ၈ထပ်ကိန်း တန်ဖိုး 
            byte b = 100;
            sbyte sb = -120;

            // 16 bit ၂ ၁၆ ထပ်ကိန်းတန်ဖိုး
            short s = -6000;
            ushort us = 6000;

            // 32 bit ၂ ၃၂ ထပ်ကိန်းတန်ဖိုး
            int i = -10000000;
            uint ui = 1000000;

            //64 bit ၂ ၆၄ ထပ်ကိန်းတန်ဖိုး
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

            int a=0, g = 0;
            Console.WriteLine(a++); // output 0 ပြတယ် ဒါပေမယ့် တန်ဖိုးက ၁ ဖြစ်သွားတယ် 
            Console.WriteLine(a);

            BT: Console.Write("Please Enter Your myanmar mark : ");
            int mmMark = Convert.ToInt32(Console.ReadLine());

            if (mmMark >= 40)
            {
                Console.WriteLine("Passed with mark " + mmMark);
            }
            else
            {
                Console.WriteLine("Failed");
            }


            //switch (mmMark)
            //{
            //    case 0: case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17: case 18: case 19: case 20: case 21: case 22: case 23: case 24: case 25: case 26: case 27: case 28: case 29: case 30: case 31: case 32:
            //    case 33: case 34: case 35:case 36: case 37: case 38: 
            //    case 39:Console.WriteLine("Fail"); break;
            //    default:Console.WriteLine("Passed");break;
            //}
            //goto BT;

            ArrayList eve = new ArrayList();
            eve.Add(90);
            eve.Add("hello");
            eve.Add(3);
            eve.Add(3.9f);
            eve.Add('p');

            var len = eve.Count;

            //for(int q = 0 ; q<len; q++) {
            //    Console.WriteLine(eve[q]);
            //}
            foreach(var item in eve)
            {
                Console.WriteLine(item);
            }
        }
    }
}
