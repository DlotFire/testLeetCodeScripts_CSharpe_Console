using System;

namespace DesignMethod.AdapterPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            #region OpenClass

            IThreeHole threehole = new PowerAdpter();
            threehole.Requset();
            Console.ReadLine();

            #endregion OpenClass

            #region OpenObject

            ThreeHole2 three = new PowerAdapter();
            three.Request();
            Console.ReadLine();

            #endregion OpenObject
        }
    }
}