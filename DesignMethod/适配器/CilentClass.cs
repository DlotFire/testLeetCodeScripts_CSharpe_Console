using System;

namespace DesignMethod.AdapterPattern
{
    /// <summary>
    /// 目标角色
    /// </summary>
    public interface IThreeHole
    {
        void Requset();
    }

    /// <summary>
    /// 适配器类
    /// </summary>
    public class PowerAdpter : TwoHole, IThreeHole
    {
        public void Requset()
        {
            this.SpecificRequest();
        }
    }

    /// <summary>
    /// 源角色需要适配的类
    /// </summary>
    public class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}