namespace DesignMethod.SingletonPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Singleton let = Singleton.GetInstance();
            let.Co();
        }
    }
}