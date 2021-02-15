using System;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] Grocerylist;

        public SimpleArray()
        {
            Grocerylist = new String[4] {"Bread", "Milk", "Eggs", "Cheese"};
        }

        public override string ToString()
        {
            return "There are " + Grocerylist.Length + "and they are " + Grocerylist.ToString();
        }
    }
}