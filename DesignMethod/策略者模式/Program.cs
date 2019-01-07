using System;

namespace DesignMethod.StrategyPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            //个人所得税
            InterestOperation operation = new InterestOperation(new PersonalTaxStrategy());
            Console.WriteLine("个人支付税为：{0}", operation.GetTax(5000.00));
            Console.WriteLine("-----------------------------");
            operation = new InterestOperation(new EnterpriseTaxStrategy());
            Console.WriteLine("企业支付税为：{0}", operation.GetTax(5000.00));
        }
    }
}