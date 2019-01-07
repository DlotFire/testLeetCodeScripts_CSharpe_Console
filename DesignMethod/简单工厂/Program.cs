﻿using System;

namespace DesignMethod.SimpleFactoryPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            // 客户想点一个西红柿炒蛋
            Food food1 = FoodSimpleFactory.CreateFood("西红柿炒蛋");
            food1.Print();

            // 客户想点一个土豆肉丝
            Food food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food2.Print();
        }
    }
}