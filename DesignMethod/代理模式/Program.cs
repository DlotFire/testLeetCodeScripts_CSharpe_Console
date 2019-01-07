using System;

namespace DesignMethod.ProxyPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Person proxy = new Friend();
            proxy.BuyProduct();
        }
    }
}