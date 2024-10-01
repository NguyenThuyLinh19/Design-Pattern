using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Meal
    {
        private StringBuilder items = new StringBuilder();

        public void AddItem(string item)
        {
            items.Append(item + "\n");
        }

        public string GetMealDetails()
        {
            return items.ToString();
        }
    }
}
