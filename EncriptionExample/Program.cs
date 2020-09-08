using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncriptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string Plaintext = "peter";
            char[] PlainTextArray = Plaintext.ToCharArray();

            string CyperText;
            char[] CyperTextArray;

            char Key = (char)0x0908;

            CyperTextArray = new char[PlainTextArray.Length];
            for (int i = 0; i < PlainTextArray.Length; i++)
                CyperTextArray[i] = (char)(PlainTextArray[i] ^ Key);
            
            CyperText = new string(CyperTextArray);
            Console.WriteLine(Plaintext);
            Console.WriteLine(CyperText);

            string Password = "1234";
            //string SaltText = "ueTYDXVEV6UGPAvD";
            //Plaintext = Password + SaltText;
            Plaintext = Password;

            Console.WriteLine($"PlainText = {Plaintext}");

            byte[] PlainData = Encoding.UTF8.GetBytes(Plaintext);
            byte[] result = (new SHA512Managed()).ComputeHash(PlainData);

            Console.Write("PlainData = ");
            for (int iTemp = 0; iTemp < PlainData.Length; iTemp++)
                Console.Write("{0:X2} ", PlainData[iTemp]);
            Console.WriteLine();

            Console.Write("CyperText = ");
            for (int iTemp = 0; iTemp < result.Length; iTemp++)
                Console.Write("{0:X2} ", result[iTemp]);
            Console.WriteLine();
            
        }
    }
}
