using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class IQueryable
    {
        public IQueryable()
        {

        }

        public void Call()
        {
            IEnumerable<MyClass> list = new List<MyClass>();
            var query = list.AsQueryable();

            query = query.Where(p => p.Id == 0);
            query.Take(1).Skip(1);

            query.GroupBy(p => p.Id).Distinct();
        }

        public class MyClass
        {
            public int Id { get; set; }
        }
    }
}
