using System;

namespace DesignMethod.PrototypePattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            //原型
            MonkeyKingPrototype prototypeKing = new ConcretePrototype("1");
            //变一个
            MonkeyKingPrototype cloneMokeyKing = prototypeKing.Clone() as ConcretePrototype;
            Console.Write(cloneMokeyKing.Id);

            //变两个
            MonkeyKingPrototype cloneMokeyKing2 = prototypeKing.Clone() as ConcretePrototype;
            Console.Write(cloneMokeyKing2.Id);
            Console.Read();
        }
    }
}