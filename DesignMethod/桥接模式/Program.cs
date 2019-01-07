using System;

namespace DesignMethod.BridgePattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            RemoteControl remote = new ConcreteRemote();
            remote.Implementor = new ChangHong();
            remote.On();
            remote.Off();
            remote.SetChannel();
            Console.WriteLine();

            remote.Implementor = new SanXing();
            remote.On();
            remote.Off();
            remote.SetChannel();
            Console.WriteLine();
        }
    }
}