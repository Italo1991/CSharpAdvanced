namespace CSharpAdvanced
{
    public class Overload
    {
        public void Call()
        {
            Test();
            Test(int.MaxValue);
            Test(string.Empty);
            Test(int.MaxValue, int.MaxValue);
        }

        private bool Test() => true;
        private bool Test(int a) => true;
        private bool Test(string a) => true;
        private bool Test(int a, int b) => true;
    }
}
