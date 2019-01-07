using System;

namespace DesignMethod.VisitorPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            ObjectStructure objectstructure = new ObjectStructure();
            foreach (Element e in objectstructure.Element)
            {
                e.Accept(new ConcreteVistor());
            }
        }
    }
}