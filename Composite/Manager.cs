using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Manager : IEmployee
    {
        private string _name;
        private string _position;
        private List<IEmployee> _subordinates;

        public Manager(string name, string position)
        {
            _name = name;
            _position = position;
            _subordinates = new List<IEmployee>();
        }

        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Manager: {_name}, Position: {_position}");
            Console.WriteLine("Subordinates:");
            foreach (var employee in _subordinates)
            {
                employee.ShowDetails();
            }
        }
    }

}
