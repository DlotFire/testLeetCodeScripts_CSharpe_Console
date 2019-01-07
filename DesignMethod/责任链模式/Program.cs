using System;

namespace DesignMethod.ChainOfResponsibilityPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "Telphone");
            PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
            PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "Computers");

            Approver manager = new Manager("LearningHard");
            Approver Vp = new VicePresident("Tony");
            Approver Pre = new President("BoosTom");

            //设置责任链
            manager.NextApprover = Vp;
            Vp.NextApprover = Pre;

            //处理请求
            manager.ProcessRequest(requestTelphone);
            manager.ProcessRequest(requestSoftware);
            manager.ProcessRequest(requestComputers);
            Console.Read();
        }
    }
}