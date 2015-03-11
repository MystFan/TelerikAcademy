/*Problem 5. Generic class

    Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
    Check all input parameters to avoid accessing elements at invalid positions.
*/
namespace _05.GenericClass
{
    using System;
    class GenericClass
    {
        static void Main()
        {
            GenericList<Test> list = new GenericList<Test>(10);

            for (int i = 0; i < list.Length; i++)
            {
                Test testObject = new Test();
                testObject.Id = i;
                testObject.Content = "Some text " + i;
                list.Add(testObject);
            }

            Console.WriteLine("Element at position 3, content: {0}", list[3].Content);
            list.RemoveAtPosition(3);
            Console.WriteLine("Element at position 3 after Remove, content: {0}", list[3].Content);
            list.InsertAtPosition(3, new Test() { Id = 3, Content = "Some text 3" });
            Console.WriteLine("Element at position 3 after Insert, content: {0}", list[3].Content);
        }
    }

    class Test
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
