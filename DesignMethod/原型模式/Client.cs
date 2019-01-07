namespace DesignMethod.PrototypePattern
{
    /// <summary>
    /// 创建具体
    /// </summary>
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id)
            : base(id)
        { }

        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 孙悟空原型
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        public string Id { get; set; }

        //克隆方法
        public abstract MonkeyKingPrototype Clone();
    }
}