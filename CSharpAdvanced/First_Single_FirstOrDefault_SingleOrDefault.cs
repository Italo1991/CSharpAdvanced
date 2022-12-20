namespace CSharpAdvanced
{
    public class First_Single_FirstOrDefault_SingleOrDefault
    {
        public First_Single_FirstOrDefault_SingleOrDefault()
        {

        }

        public void Call()
        {
            IEnumerable<int?> list = new List<int?> { 1, 2, 3, 1 };
            var item1 = list.FirstOrDefault(p => p == 4);
            var item2 = list.First(p => p == 3);
            //var item3 = list.First(p => p == 4); //exception

            var item4 = list.SingleOrDefault(p => p == 5);
            //var item5 = list.Single(p => p == 1); //exception
            //var item6 = list.SingleOrDefault(p => p == 1); //exception
        }
    }
}
