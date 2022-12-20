using System.Collections.Generic;

namespace CSharpAdvanced
{
    public class IList_IEnumerable_ICollection
    {
        public IList_IEnumerable_ICollection()
        {

        }

        public void Call()
        {
            // IList
            IList<MyClass> iList = new List<MyClass> // ICollection<T>, IEnumerable<T>
            {
                new MyClass(),
                new MyClass()
            };

            var item = new MyClass();
            iList.Insert(0, new MyClass()); // new
            iList.RemoveAt(1); // new
            iList.Add(item);
            iList.IndexOf(item);
            iList.Remove(item);
            iList.Add(item);
            iList.Clear();
            iList.Contains(item);

            // ICollection
            ICollection<MyClass> iCollection = new List<MyClass> // IEnumerable<T>
            {
                new MyClass(),
                new MyClass()
            }; 
            var item2 = new MyClass();
            iCollection.Add(item2); // new
            iCollection.Remove(item2); // new
            iCollection.Clear(); // new
            iCollection.Contains(item2);

            // IEnumerable
            var item3 = new MyClass();
            IEnumerable<MyClass> iEnumerable = new List<MyClass>() { new MyClass(), new MyClass(), item3 };
            var result = iEnumerable.Contains(item3);
            iEnumerable.First();
            iEnumerable.Where(p => p.Id == 0);

            // List
            var list = new List<MyClass> // ICollection<T>, IEnumerable<T>
            {
                new MyClass(),
                new MyClass()
            };

            list.RemoveAt(1);
            list.Add(new MyClass());
            list.First();


            // IReadOnly


            // IReadOnlyList
            IReadOnlyList<MyClass> iReadOnlyList = new List<MyClass>
            {
                new MyClass(),
                new MyClass()
            };
            var itemIReadOnlyList = iReadOnlyList[1];

            // IReadOnlyCollection
            IReadOnlyCollection<MyClass> iReadOnlyCollection = new List<MyClass> // IEnumerable<T>
            {
                new MyClass(),
                new MyClass()
            };
            var test = iReadOnlyCollection.Count;

        }

        public class MyClass
        {
            public int Id { get; set; }
        }
    }
}
