using System.Collections.Generic;
using System.Linq;

namespace Module3HW4
{
    public class TaskTwo
    {
        private List<Contact> _list;

        public TaskTwo()
        {
            Init();
        }

        public void Init()
        {
            _list = new List<Contact>();
            var tempContact = new Contact { FirstName = "Dima", SecondName = "Lapenko", PhoneNumber = "+2649861189" };
            _list.Add(new Contact { FirstName = "Vadik", SecondName = "Bilyi", PhoneNumber = "+380564651689" });
            _list.Add(new Contact { FirstName = "Dyi", SecondName = "Byi", PhoneNumber = "+3805568484" });
            _list.Add(new Contact { FirstName = "Cyi", SecondName = "Salo", PhoneNumber = "+9865412132" });
            _list.Add(new Contact { FirstName = "Denis", SecondName = "Vano", PhoneNumber = "+86946531221" });
            _list.Add(tempContact);
            _list.Add(tempContact);
        }

        public IEnumerable<Contact> FullNameStartWithD()
        {
            return from t in _list where t.FullName.StartsWith("D") orderby t.SecondName select t;
        }

        public Contact FirstOrDefaultStartWithV()
        {
            return _list.FirstOrDefault(f => f.FullName.StartsWith("V"));
        }

        public IEnumerable<Contact> TakeList(int count)
        {
            return _list.Take(count);
        }

        public IEnumerable<Contact> RemoveDuplicateElements()
        {
            return _list.Distinct();
        }

        public void Run()
        {
            var list = new List<Contact>(FullNameStartWithD());
            System.Console.WriteLine($"Count element start with D: {list.Count}");
            var item = FirstOrDefaultStartWithV();
            System.Console.WriteLine($"First element start with V: {item.FullName}");
            list = new List<Contact>(TakeList(3));
            System.Console.WriteLine($"Count element in list with 3 element: {list.Count}");
            list = new List<Contact>(RemoveDuplicateElements());
            System.Console.WriteLine($"Count element in list without duplicate: {list.Count}");
        }
    }
}
