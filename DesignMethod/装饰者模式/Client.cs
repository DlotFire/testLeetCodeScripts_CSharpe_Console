﻿using System;

namespace DesignMethod.DecoratorPattern
{
    //挂件
    public class Accessories : Decorator
    {
        public Accessories(Phone p)
            : base(p)
        { }

        public void AddAccessories()
        {
            Console.WriteLine("有挂件");
        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }
    }

    //苹果手机
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体的对象---苹果手机");
        }
    }

    //装饰抽象类
    public abstract class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone p)
        {
            this.phone = p;
        }

        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }

    //手机抽象类
    public abstract class Phone
    {
        public abstract void Print();
    }

    //贴膜
    public class Sticker : Decorator
    {
        public Sticker(Phone p)
            : base(p)
        { }

        public void AddSticker()
        {
            Console.WriteLine("有贴膜");
        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }
    }
}