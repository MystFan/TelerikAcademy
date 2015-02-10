
namespace TheHorror
{
    using System;
    class TheHorror
    {
        static void Main()
        {
            string number = Console.ReadLine();

            long counter = 0;
            long sum = 0;
            if (number[0] == '-')
            {
                counter++;
                sum += int.Parse(number[1].ToString());
                number = number.Substring(1, number.Length - 1);
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int digit;
                    bool result = Int32.TryParse(number[i].ToString(), out digit);
                    if (result)
                    {
                        sum += digit;
                        counter++;
                    }
                }
            }

            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
