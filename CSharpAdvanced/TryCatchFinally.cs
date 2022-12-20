using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class TryCatchFinally
    {
        public TryCatchFinally()
        {

        }

        public void Call()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Try-catch-finally");
            try
            {
                Console.WriteLine("try");
                throw new Exception();
            }
            catch(Exception ex)
            {
                Console.WriteLine("catch");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("All Stack is returned - throw;");
            try
            {
                try
                {
                    new TestClass();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Only message is returned - throw new Exception(ex.Message)");
            try
            {
                try
                {
                    new TestClass();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Only message is returned - throw ex;");
            try
            {
                try
                {
                    new TestClass();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public class TestClass
        {
            public TestClass()
            {
                throw new NotImplementedException();
            }
        }

    }
}
