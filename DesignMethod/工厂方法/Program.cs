using System;

namespace DesignMethod.FactoryMethod
{
    public class Program : OpenDesign
    {
        /// <summary>
        /// 工厂模式：Factory Method
        /// Provides an abstraction or an interface and lets subclass or implementing classes decide which class or method should be
        /// instantiated or called, based on the conditions or parameters given.
        /// </summary>
        public override void Open()
        {
            //初始化工厂类
            Creator shrFactory = new ShreddedPorkWithPotatoesFactory();
            Creator tomFactory = new TomatoScrambledEggsFactory();

            //开始西红柿
            Food tom = tomFactory.CreateFoodFactory();
            tom.Print();

            //开始土豆
            Food shr = shrFactory.CreateFoodFactory();
            shr.Print();
        }
    }
}