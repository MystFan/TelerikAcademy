/*Problem 5. 64 Bit array

    Define a class BitArray64 to hold 64 bit values inside an ulong value.
    Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
namespace _05._64BitArray
{
    using System;
    class BitArray
    {
        static void Main()
        {
            BitArray64 bits = new BitArray64(123456789999);
            Console.WriteLine(string.Join(" ",bits));
            Console.WriteLine("Hash Code: {0}", bits.GetHashCode());

            BitArray64 anotherBits = new BitArray64(123456789999);
            Console.WriteLine(string.Join(" ", anotherBits));
            Console.WriteLine("Hash Code: {0}", anotherBits.GetHashCode());

            Console.WriteLine("Equals: {0}", bits.Equals(anotherBits));
            Console.WriteLine(" == {0}", bits == anotherBits);
            Console.WriteLine(" != {0}", bits != anotherBits);

            Console.WriteLine("foreach");
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine("for");
            for (int i = 0; i < bits.Bits.Length; i++)
            {
                Console.Write(bits.Bits[i]);
            }
            Console.WriteLine();
        }
    }
}
