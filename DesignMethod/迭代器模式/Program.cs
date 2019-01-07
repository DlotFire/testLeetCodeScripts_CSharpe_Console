using System;

namespace DesignMethod.IteratorPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
        }
    }
}