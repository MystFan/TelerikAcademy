using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    public class MultyThreadLibrary
    {
        private static volatile MultyThreadLibrary instance;

        private readonly List<IReadable> readableItems = new List<IReadable>();

        private static object syncLock = new object();
        private MultyThreadLibrary() { }
        public static MultyThreadLibrary Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new MultyThreadLibrary();
                        }
                    }
                } 
                return instance;
            }
        }

        public List<IReadable> ReadableItems
        {
            get
            {
                return new List<IReadable>(this.readableItems);
            }
        }

        public void Add(IReadable readableItem)
        {
            if (readableItem == null)
            {
                throw new ArgumentException("Library item cannot be null");
            }

            this.readableItems.Add(readableItem);
        }
    }
}
