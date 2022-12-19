namespace CSharpAdvanced
{
    public class Boxing_Unboxing
    {
        public void Call()
        {
            // Value type
            var a = 123;
            object b = (object)a; // Boxing explicit - use separate memory locations
            a = 1234;

            Console.WriteLine($"Boxing: Value-type value = {a}");
            Console.WriteLine($"Boxing: Object-type value = {b}");

            // Unboxing explicit
            var c = (int)b;
            Console.WriteLine($"Unboxing: Value-type value = {c}");


            // Interface
            var d = new ConcreteClass();
            object e = d; // boxing
            var f = (IMyInterface)e;
            f.Call();

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
            public void Call()
            {
                Console.WriteLine("ConcreteClass");
            }
        }
    }
}
