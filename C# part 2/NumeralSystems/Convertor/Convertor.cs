using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class Convertor
    {
        public string DecimalToBinary(long number)
        {
            long num;
            string str = String.Empty;
            do
            {
                num = number % 2;
                if (num != 0)
                {
                    str = str + (1.ToString());
                }
                if (num == 0)
                {
                    str = str + (0.ToString());
                }
                number = number / 2;
            }
            while (number != 0);
            string reverse = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }

        public string DecimalToSignBinary(short number)
        {
            string result = String.Empty;
            string reverse = String.Empty;
            if (number < 0)
            {
                number *= (-1);
                string binary = DecimalToBinary(number);

                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    reverse += binary[i];
                }
                int sum = (int)Math.Pow(2, binary.Length - 1);

                for (int i = reverse.Length - 2; i >= 0; i--)
                {
                    if (reverse[i] == '1')
                    {
                        sum = sum - (int)Math.Pow(2, i);
                    }
                }

                result = DecimalToBinary(sum).PadLeft(binary.Length, '0').PadLeft(16, '1');
            }
            else
            {
                result = DecimalToBinary(number);
            }
            return result;
        }
        public int BinaryToDecimal(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 49)
                {
                    sum = sum + (int)Math.Pow(2, i);
                }
            }
            return sum;
        }

        public string DecimalToHexadecimal(long number)
        {
            long num;
            string hex = String.Empty;
            do
            {
                num = number % 16;
                if (num > 9)
                {
                    switch (num)
                    {
                        case 10: hex = hex + "A"; break;
                        case 11: hex = hex + "B"; break;
                        case 12: hex = hex + "C"; break;
                        case 13: hex = hex + "D"; break;
                        case 14: hex = hex + "E"; break;
                        case 15: hex = hex + "F"; break;
                        case 16: hex = hex + "G"; break;
                    }
                }
                if (num <= 9)
                {
                    hex = hex + num.ToString();
                }
                number = number / 16;
            }
            while (number != 0);

            string result = ReverseString(hex);
            return result;
        }

        public long HexadecimalToDecimal(string numString)
        {
            long sum = 0;
            long current;
            string revers = ReverseString(numString);

            for (int i = 0; i < revers.Length; i++)
            {
                if (revers[i] > 47 && (revers[i] < 58))
                {
                    current = Convert.ToInt32(revers[i].ToString());
                    sum = sum + (current * (long)Math.Pow(16, i));
                    current = 0;
                }
                else
                {
                    switch (revers[i])
                    {
                        case 'A':
                            sum = sum + 10 * (int)Math.Pow(16, i); break;
                        case 'B':
                            sum = sum + 11 * (int)Math.Pow(16, i); break;
                        case 'C':
                            sum = sum + 12 * (int)Math.Pow(16, i); break;
                        case 'D':
                            sum = sum + 13 * (int)Math.Pow(16, i); break;
                        case 'E':
                            sum = sum + 14 * (int)Math.Pow(16, i); break;
                        case 'F':
                            sum = sum + 15 * (int)Math.Pow(16, i); break;
                        case 'G':
                            sum = sum + 16 * (int)Math.Pow(16, i); break;
                        case 'a':
                            sum = sum + 10 * (int)Math.Pow(16, i); break;
                        case 'b':
                            sum = sum + 11 * (int)Math.Pow(16, i); break;
                        case 'c':
                            sum = sum + 12 * (int)Math.Pow(16, i); break;
                        case 'd':
                            sum = sum + 13 * (int)Math.Pow(16, i); break;
                        case 'e':
                            sum = sum + 14 * (int)Math.Pow(16, i); break;
                        case 'f':
                            sum = sum + 15 * (int)Math.Pow(16, i); break;
                        case 'g':
                            sum = sum + 16 * (int)Math.Pow(16, i); break;
                    }
                }
            }
            return sum;
        }

        public string BinaryToHexadecimal(string str)
        {
            string hex = String.Empty;
            string currentHex = String.Empty;
            string fitZero = String.Empty;
            if (str.Length % 4 != 0)
            {
                int zero = 4 - (str.Length % 4);
                for (int i = 0; i < zero; i++)
                {
                    fitZero = fitZero + "0";
                }
            }
            str = fitZero + str;

            for (int i = 0; i < str.Length; i = i + 4)
            {
                for (int j = i; j < 4 + i; j++)
                {
                    currentHex = currentHex + str[j];
                }
                switch (currentHex)
                {
                    case "0000": currentHex = String.Empty; currentHex += 0; break;
                    case "0001": currentHex = String.Empty; currentHex += 1; break;
                    case "0010": currentHex = String.Empty; currentHex += 2; break;
                    case "0011": currentHex = String.Empty; currentHex += 3; break;
                    case "0100": currentHex = String.Empty; currentHex += 4; break;
                    case "0101": currentHex = String.Empty; currentHex += 5; break;
                    case "0110": currentHex = String.Empty; currentHex += 6; break;
                    case "0111": currentHex = String.Empty; currentHex += 7; break;
                    case "1000": currentHex = String.Empty; currentHex += 8; break;
                    case "1001": currentHex = String.Empty; currentHex += 9; break;
                    case "1010": currentHex = String.Empty; currentHex += 'A'; break;
                    case "1011": currentHex = String.Empty; currentHex += 'B'; break;
                    case "1100": currentHex = String.Empty; currentHex += 'C'; break;
                    case "1101": currentHex = String.Empty; currentHex += 'D'; break;
                    case "1110": currentHex = String.Empty; currentHex += 'E'; break;
                    case "1111": currentHex = String.Empty; currentHex += 'F'; break;
                    default: currentHex += ""; break;
                }
                hex = hex + currentHex;
                currentHex = String.Empty;
            }
            return hex;
        }

        public string HexdecimalToBinary(string str)
        {
            string binary = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '0': binary += " 0000"; break;
                    case '1': binary += " 0001"; break;
                    case '2': binary += " 0010"; break;
                    case '3': binary += " 0011"; break;
                    case '4': binary += " 0100"; break;
                    case '5': binary += " 0101"; break;
                    case '6': binary += " 0110"; break;
                    case '7': binary += " 0111"; break;
                    case '8': binary += " 1000"; break;
                    case '9': binary += " 1001"; break;
                    case 'A': binary += " 1010"; break;
                    case 'B': binary += " 1011"; break;
                    case 'C': binary += " 1100"; break;
                    case 'D': binary += " 1101"; break;
                    case 'E': binary += " 1110"; break;
                    case 'F': binary += " 1111"; break;
                    case 'a': binary += " 1010"; break;
                    case 'b': binary += " 1011"; break;
                    case 'c': binary += " 1100"; break;
                    case 'd': binary += " 1101"; break;
                    case 'e': binary += " 1110"; break;
                    case 'f': binary += " 1111"; break;
                    default: binary += ""; break;
                }
            }
            return binary;
        }

        public string ConvertFromTo(string number, int fromSystem, int toSysem)
        {
            if (toSysem > 16 || toSysem < 2 || fromSystem > 16 || fromSystem < 2)
            {
                throw new ArgumentOutOfRangeException("Numerall systems to convert must be between 2 and 16");
            }
            bool isValidNumber = false;
            switch (fromSystem)
            {
                case 2:  isValidNumber = isBinary(number); break;
                case 3:  isValidNumber = isTernary(number); break;
                case 4:  isValidNumber =  isQuat(number); break;
                case 5:  isValidNumber = isQuinque(number); break;
                case 6:  isValidNumber = isSex(number); break;
                case 7:  isValidNumber = isSeptem(number); break;
                case 8:  isValidNumber =  isOcto(number); break;
                case 9:  isValidNumber = isNovem(number); break;
                case 10: isValidNumber = isDecimal(number); break;
                case 11: isValidNumber =  isUndecim(number); break;
                case 12: isValidNumber = isDuodecim(number); break;
                case 13: isValidNumber = isTredecim(number); break;
                case 14: isValidNumber = isQuatdecim(number); break;
                case 15: isValidNumber = isQuindecim(number); break;
                case 16: isValidNumber = IsHex(number); break;
            }
            if(!isValidNumber)
            {
                throw new ArgumentException("Invalid number to convert");
            }
            string symbols = "0123456789ABCDEFG";
            int to = toSysem;
            long decimalNumber = 0;
            if (fromSystem != 10)
            {
                decimalNumber = ConvertToDecimal(number, fromSystem);
                if (to == 10)
                {
                    return decimalNumber.ToString();
                }
            }
            else
            {
                decimalNumber = long.Parse(number);
            }
            long num;
            string str = String.Empty;
            do
            {
                num = decimalNumber % to;
                if (num != 0)
                {
                    str = str + (num.ToString());
                }
                if (num == 0)
                {
                    str = str + (num.ToString());
                }
                decimalNumber = decimalNumber / to;
            }
            while (decimalNumber != 0);

            string reverse = ReverseString(str);
            return reverse;
        }

        public bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isTernary(IEnumerable<char> chars)
        {
            bool isTernary;
            foreach (var c in chars)
            {
                isTernary = (c >= '0' && c <= '2');
                if (!isTernary)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isQuat(IEnumerable<char> chars)
        {
            bool isQuat;
            foreach (var c in chars)
            {
                isQuat = (c >= '0' && c <= '3');
                if (!isQuat)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isQuinque(IEnumerable<char> chars)
        {
            bool isQuinque;
            foreach (var c in chars)
            {
                isQuinque = (c >= '0' && c <= '4');
                if (!isQuinque)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isSex(IEnumerable<char> chars)
        {
            bool isSex;
            foreach (var c in chars)
            {
                isSex = (c >= '0' && c <= '5');
                if (!isSex)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isSeptem(IEnumerable<char> chars)
        {
            bool isSeptem;
            foreach (var c in chars)
            {
                isSeptem = (c >= '0' && c <= '6');
                if (!isSeptem)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isOcto(IEnumerable<char> chars)
        {
            bool isOcto;
            foreach (var c in chars)
            {
                isOcto = (c >= '0' && c <= '7');
                if (!isOcto)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isNovem(IEnumerable<char> chars)
        {
            bool isNovem;
            foreach (var c in chars)
            {
                isNovem = (c >= '0' && c <= '8');
                if (!isNovem)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isUndecim(IEnumerable<char> chars)
        {
            bool isUndecim;
            foreach (var c in chars)
            {
                isUndecim = (c >= '0' && c <= '9') || (c == 'a') || (c == 'A');
                if (!isUndecim)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isDuodecim(IEnumerable<char> chars)
        {
            bool isDuodecim;
            foreach (var c in chars)
            {
                isDuodecim = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'b') ||
                         (c >= 'A' && c <= 'B');
                if (!isDuodecim)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isTredecim(IEnumerable<char> chars)
        {
            bool isTredecim;
            foreach (var c in chars)
            {
                isTredecim = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'c') ||
                         (c >= 'A' && c <= 'C');
                if (!isTredecim)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isQuatdecim(IEnumerable<char> chars)
        {
            bool isQuatdecim;
            foreach (var c in chars)
            {
                isQuatdecim = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'd') ||
                         (c >= 'A' && c <= 'D');
                if (!isQuatdecim)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isQuindecim(IEnumerable<char> chars)
        {
            bool isQuindecim;
            foreach (var c in chars)
            {
                isQuindecim = (c >= '0' && c <= '9') || (c >= 'a' && c <= 'e') ||
                         (c >= 'A' && c <= 'E');
                if (!isQuindecim)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isDecimal(IEnumerable<char> chars)
        {
            bool isDecimal;
            foreach (var c in chars)
            {
                isDecimal = (c >= '0' && c <= '9');
                if (!isDecimal)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isBinary(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '0' && num[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private long ConvertToDecimal(string number, int inputBase)
        {
            long sum = 0;
            long current;
            string revers = ReverseString(number);

            for (int i = 0; i < revers.Length; i++)
            {
                if ((revers[i] > 48 && (revers[i] < 58)))
                {
                    current = System.Convert.ToInt32(revers[i].ToString());
                    sum = sum + (current * (int)Math.Pow(inputBase, i));
                    current = 0;
                }

                switch (revers[i])
                {
                    case 'A': sum = sum + 10 * ((long)Math.Pow(inputBase, i)); break;
                    case 'B': sum = sum + 11 * ((long)Math.Pow(inputBase, i)); break;
                    case 'C': sum = sum + 12 * ((long)Math.Pow(inputBase, i)); break;
                    case 'D': sum = sum + 13 * ((long)Math.Pow(inputBase, i)); break;
                    case 'E': sum = sum + 14 * ((long)Math.Pow(inputBase, i)); break;
                    case 'F': sum = sum + 15 * ((long)Math.Pow(inputBase, i)); break;
                    case 'a': sum = sum + 10 * ((long)Math.Pow(inputBase, i)); break;
                    case 'b': sum = sum + 11 * ((long)Math.Pow(inputBase, i)); break;
                    case 'c': sum = sum + 12 * ((long)Math.Pow(inputBase, i)); break;
                    case 'd': sum = sum + 13 * ((long)Math.Pow(inputBase, i)); break;
                    case 'e': sum = sum + 14 * ((long)Math.Pow(inputBase, i)); break;
                    case 'f': sum = sum + 15 * ((long)Math.Pow(inputBase, i)); break;
                    default: sum += 0; break;
                }
            }
            return sum;
        }
        private string ReverseString(string str)
        {
            string revers = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revers = revers + str[i];
            }
            return revers;
        }
    }
}
