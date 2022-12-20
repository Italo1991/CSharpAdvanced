namespace CSharpAdvanced
{
    public class GarbageCollection
    {
        public void Call()
        {
            Console.WriteLine( Environment.NewLine + "Reference Type------------------");

            var obj1 = new ClasFinalizerGC();
            var generationObj1 = GC.GetGeneration(obj1);
            obj1 = null;

            GC.Collect();
            Console.WriteLine("Total Memory Collect:" + GC.GetTotalMemory(false));

            var obj2 = new ClasDisposableGC();

            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

            GC.Collect();

            Console.WriteLine("Total Memory Collect:" + GC.GetTotalMemory(false));
            Console.WriteLine("------------------");
        }

        public class ClasFinalizerGC
        {
            public ClasFinalizerGC()
            {

            }

            ~ClasFinalizerGC()
            {
                Console.WriteLine("ClasFinalizersGC");
            }
        }

        public class ClasDisposableGC : IDisposable
        {
            public ClasDisposableGC()
            {

            }

            ~ClasDisposableGC()
            {
                Console.WriteLine("This method won't be called");
            }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}
