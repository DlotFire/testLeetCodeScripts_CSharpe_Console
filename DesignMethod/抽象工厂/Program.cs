using System;

namespace DesignMethod.AbstractFactoryPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            AbstractFactory nanChangFac = new NanChangFactory();
            YaBo nanChangYaBo = nanChangFac.CreateYaBo();
            nanChangYaBo.Print();

            AbstractFactory shangHaiFac = new ShangHaiFactory();
            shangHaiFac.CreateYaJia().Print();
            shangHaiFac.CreateYaBo().Print();
            
        }
    }
}