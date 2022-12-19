namespace CSharpAdvanced
{
    public class Boxing_Unboxing
    {
        public void Call()
        {
            // Value type
            var a = 123;
            object b = (object)a; // Boxing explicit - use separate memory locations (stack to heap)
            a = 1234;

            Console.WriteLine($"Boxing: Value-type value = {a}"); // 1234
            Console.WriteLine($"Boxing: Object-type value = {b}"); // 123

            // Unboxing explicit
            var c = (int)b; // (heap to stack)
            Console.WriteLine($"Unboxing: Value-type value = {c}");


            // Reference type
            var d = new ConcreteClass();
            d.Age = 1;
            object e = d; // boxing (heap to heap, is the same object)
            d.Age = 2;
            var f = (IMyInterface)e;
            f.Call(); // age 2

            var myInterface = e as IMyInterface; // Convert if is possible. It doesn't throw an exception
            myInterface?.Call(); 

            var myInterfaceWrong = e as IMyInterfaceWrong; // Convert if is possible. It doesn't throw an exception;
            myInterfaceWrong?.Call();

            Console.WriteLine(e is IMyInterface ? "IMyInterface" : "IMyInterfaceWrong"); // Verify if object is IMyInterface
        }

        public interface IMyInterface
        {
            void Call();
        }

        public interface IMyInterfaceWrong
        {
            void Call();
        }

        public class ConcreteClass : IMyInterface
        {
            public int Age { get; set; }
            public void Call()
            {
                Console.WriteLine($"ConcreteClass Age: {Age}");
            }
        }
    }
}
