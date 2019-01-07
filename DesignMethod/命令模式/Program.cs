using System;

namespace DesignMethod.CommandPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoke i = new Invoke(c);
            i.ExecuteCommand();
        }
    }
}