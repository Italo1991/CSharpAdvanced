namespace CSharpAdvanced
{
    public class AbstractClass_Interface
    {
        public void Call()
        {
            //var myAbstractClass = new MyAbstractClass(); // cannot create instance from abstract class

            var concreteA = new ConcreteA();
            concreteA.TestB(); // ConcreteA

            var concreteB = new ConcreteB();
            concreteB.TestB(); // ConcreteB

            var concreteC = new ConcreteC();
            concreteC.TestB(); // MyAbstractClass bacause New operator
            concreteC.Test();  // ConcreteC

            Console.Write(Environment.NewLine);

            foreach (var item in new List<MyInterface>{ new ConcreteD(), new ConcreteA() }) 
                item.TestB();

            Console.Write(Environment.NewLine);

            foreach (var item in new List<MyAbstractClass> { new ConcreteB(), new ConcreteC() }) 
                item.TestB();
        }

        public interface MyInterface
        {
            public int PropA { get; set; }
            void TestB();
        }

        public abstract class MyAbstractClass
        {
            public int PropA { get; set; }
            public virtual void Test() => Console.WriteLine("MyAbstractClass");
            public void TestB() => Test();
        }

        public class ConcreteA : MyInterface
        {
            public int PropA { get; set; }

            public void TestB() => Console.WriteLine("ConcreteA");
        }

        public class ConcreteB : MyAbstractClass
        {
            public override void Test() => Console.WriteLine("ConcreteB");
        }

        public class ConcreteC : MyAbstractClass
        {
            public new void Test() => Console.WriteLine("ConcreteC");
        }

        public class ConcreteD : MyInterface
        {
            public int PropA { get; set; }

            public void TestB() => Console.WriteLine("ConcreteD");
        }
    }
}
