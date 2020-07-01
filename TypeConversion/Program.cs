using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit
            //int intValue = 127;
            //long longValue = intValue;

            //Console.WriteLine("longValue ={0}", longValue);

            ////explicit
            //longValue = 32767;
            //intValue = (int)longValue;

            //Console.WriteLine("intValue = {0}", intValue);

            //int aint = 0x12345678;
            //Console.WriteLine("{0:X}", aint);

            //aint = ~aint;
            //Console.WriteLine("{0:X}", aint);

            //int aint = 0x12345678;
            //Console.WriteLine("{0:X8}", aint);
            ////aint = ~aint;
            ////Console.WriteLine("{0:X8}", aint);
            //aint = aint >> 4; // 첫번째 자리에 따라 1이면 1로 채우고 0이면 0으로 채운다
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint << 4;
            //Console.WriteLine("{0:X8}", aint);

            //byte abyte1 = 0x3F;
            //byte abyte2 = 0xC1;

            //Console.WriteLine("AND {0:X2}", abyte1 & abyte2);
            //Console.WriteLine("OR {0:X2}", abyte1 | abyte2);

            //Console.WriteLine("XOR {0:X2}", abyte1 ^ abyte2);

            //int iNum = 100;
            //if (iNum < 500)
            //{
            //    Console.WriteLine("iNum은 500보다 작습니다");
            //}
            //else
            //{
            //    Console.WriteLine("iNum은 500보다 큽니다");
            //}
            int point = 0;
            string result="Fail";

            if (point >= 0 && point <= 100)
            {
                if (point > 50)
                    result = "Pass";
                else
                    result = "Fail";
                Console.WriteLine("결과 : " + result);
               
            }
            else {
                Console.WriteLine("에러:범위를 벗어났습니다.");
            }
        }
    }
}
