namespace CSharpAdvanced
{
    public class Override_New
    {
        public void Call()
        {
            var derivedClass = new DerivedWithNewClass();
            derivedClass.Test(); // Base

            var baseClassWithNew = new DerivedWithNewClass();
            baseClassWithNew.Method(); // Derived
            baseClassWithNew.Test(); // Base

            var baseClassWithOverride = new DerivedWithOverrideClass();
            baseClassWithOverride.Test(); // Derived
        }

        public class BaseClass
        {
            public void Test()
            {
                Method();
                Console.Write(Environment.NewLine);
            }

            public virtual void Method() => Console.WriteLine("Base");
        }

        public class DerivedWithNewClass : BaseClass
        {
            public new void Method() => Console.WriteLine("Derived");
        }

        public class DerivedWithOverrideClass : BaseClass
        {
            public override void Method() => Console.WriteLine("Derived");
        }
    }
}
