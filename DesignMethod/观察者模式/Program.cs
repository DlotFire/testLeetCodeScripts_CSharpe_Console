using System;

namespace DesignMethod.ObserverPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            #region 观察者模式

            //TenXun tenXun = new TenXunGame("TenXun Game", "Have a new game published ....");
            ////添加订阅者
            //tenXun.AddObserver(new Subscriber("Learning Hard"));
            //tenXun.AddObserver(new Subscriber("Tom"));
            //tenXun.Update();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("移除Tom订阅者");
            //tenXun.RemoveObserver(new Subscriber("Tom"));
            //tenXun.Update();

            #endregion 观察者模式

            #region 观察者模式使用委托

            TenXunWt tenXun = new TenXunGameWt("TenXun Game", "Have a new game published ....");
            //添加订阅者
            SubscriberWt lh = new SubscriberWt("Learning Hard");
            SubscriberWt tom = new SubscriberWt("Tom");
            tenXun.AddObserver(new ObserverPattern.NotifyEventHandler(lh.ReceiveAndPrint));
            tenXun.AddObserver(new ObserverPattern.NotifyEventHandler(tom.ReceiveAndPrint));
            tenXun.Update();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("移除Tom订阅者");
            tenXun.RemoveObserver(new ObserverPattern.NotifyEventHandler(tom.ReceiveAndPrint));
            tenXun.Update();

            #endregion 观察者模式使用委托
        }
    }
}