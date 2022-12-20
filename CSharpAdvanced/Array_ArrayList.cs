using System.Collections;

namespace CSharpAdvanced
{
    public class Array_ArrayList
    {
        public Array_ArrayList()
        {

        }

        public void Call()
        {
            var array = new int[10];
            for (int i = 0; i < 9; i++)
                array[i] = i + 10;

            var itemA = new MyClass();
            var arrayList = new ArrayList
            {
                "1",
                2,
                3,
                "9",
                new MyClass(),
                itemA
            };

            arrayList.Remove(2);
            arrayList.Remove(itemA);
            arrayList.Add(DateTime.Now);

            foreach (var item in arrayList)
            {
                if (item is string)
                {
                    Console.WriteLine("string");
                }
                else if (item is MyClass)
                {
                    Console.WriteLine("MyClass");
                }
                else if (item is DateTime)
                {
                    Console.WriteLine("DateTime");
                }
                else if (item is int)
                {
                    Console.WriteLine("int");
                }
            }
        }

        public class MyClass
        {
            public int Id { get; set; }
        }
    }
}
