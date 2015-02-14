/*
 Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */
namespace _07.EncodeDecode
{
    using System;
    class EncodeDecode
    {
        
        static void Main()
        {
            Coder coder = new Coder();
            Console.Write("Enter text to encrypt: ");
            string input = Console.ReadLine();
            string encryptText = coder.Encode(input);
            Console.WriteLine("Encrypt text: {0}", encryptText);
            string decryptText = coder.Decode(encryptText);
            Console.WriteLine("Decrypt text: {0}",decryptText);
        }


    }
}
