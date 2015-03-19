
namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Bits = ExtractBits(number);
        }
        public int[] Bits { get; private set; }

        public int this[int index]
        {
            get
            {
                return this.Bits[index];
            }
            set
            {
                if (index < 0 || index > this.Bits.Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.Bits[index] = value;
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Bits.Length; i++)
            {
                yield return this.Bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            return this == (obj as BitArray64);
        }

        public override int GetHashCode()
        {
            return this.Bits.GetHashCode() ^ this.Bits.Length.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            if (first.Bits.Length != second.Bits.Length)
            {
                return false;
            }

            int length = first.Bits.Length;
            for (int i = 0; i < length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            if (first.Bits.Length != second.Bits.Length)
            {
                return true;
            }

            int length = first.Bits.Length;
            for (int i = 0; i < length; i++)
            {
                if (first[i] != second[i])
                {
                    return true;
                }
            }

            return false;
        }
        private int[] ExtractBits(ulong number)
        {
            List<int> extractedBits = new List<int>();
            byte[] byteArray = BitConverter.GetBytes(number);

            for (int i = 0; i < byteArray.Length; i++)
            {
                int[] bits = Convert.ToString(byteArray[i], 2).PadLeft(8, '0')
                   .Select(c => int.Parse(c.ToString()))
                   .ToArray();
                for (int j = 0; j < bits.Length; j++)
                {
                    extractedBits.Add(bits[j]);
                }
            }
            return extractedBits.ToArray();
        }
    }
}
