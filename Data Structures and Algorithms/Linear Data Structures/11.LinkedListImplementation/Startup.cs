namespace _11.LinkedListImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            ListItem<string> item = new ListItem<string>();
            item.Value = "Head";
            linkedList.FirstElement = item;
            item.NextItem = new ListItem<string>() { Value = "Second Item" };
            Console.WriteLine(linkedList.FirstElement.NextItem.Value);
        }
    }
}
