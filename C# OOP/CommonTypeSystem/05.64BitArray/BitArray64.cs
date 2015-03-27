
namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            string binaryString = DecimalToBinary(number);
            this.Bits = ToBitArray(binaryString);
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
        private int[] ToBitArray(string numberString)
        {
            int[] result = numberString.ToCharArray().Select(b => int.Parse(b.ToString())).ToArray();
            return result;
        }

        private string DecimalToBinary(ulong number)
        {
            ulong num;
            StringBuilder sb = new StringBuilder();
            string str = String.Empty;
            while (number != 0)
            {
                num = number % 2;
                if (num != 0)
                {
                    sb.Append(1);
                }
                if (num == 0)
                {
                    sb.Append(0);
                }
                number = number / 2;
            }

            string reverse = sb.ToString();
            sb.Clear();
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                sb.Append(reverse[i]);
            }
            return sb.ToString().PadLeft(64, '0');
        }

    }
}
