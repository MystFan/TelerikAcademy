using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    public class SingletonPattern
    {
        static void Main()
        {
            var firstOneThreadLibrary = OneThreadLibrary.Instance;

            firstOneThreadLibrary.Add(new Book { Title = "It", Author = "Steven King" });
            firstOneThreadLibrary.Add(new Book { Title = "Cujo", Author = "Steven King" });

            var secondOneThreadLibrary = OneThreadLibrary.Instance;
            secondOneThreadLibrary.Add(new Magazine { Title = "People", Publisher = "New York Times" });

            Console.WriteLine("One Thread Library");
            firstOneThreadLibrary.ReadableItems.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Multy Thread Library");
            var multyThreadLibrary = MultyThreadLibrary.Instance;
            multyThreadLibrary.Add(new Book { Title = "The Dead Zone", Author = "Steven King" });
            multyThreadLibrary.Add(new Book { Title = "Book1", Author = "Author1" });
            multyThreadLibrary.Add(new Book { Title = "Book2", Author = "Author2" });
            multyThreadLibrary.Add(new Book { Title = "Book3", Author = "Author3" });
            multyThreadLibrary.Add(new Book { Title = "Book4", Author = "Author4" });
            multyThreadLibrary.Add(new Book { Title = "Book5", Author = "Author5" });

            Parallel.ForEach(multyThreadLibrary.ReadableItems, currentItem =>
            {
                Console.WriteLine(currentItem);
            });
        }
    }
}
