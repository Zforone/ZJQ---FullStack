﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法

    internal class Suggest : Content
    {
        private static string thekind;

        //public Suggest(string skind):base(thekind )
        //{

        //}
        public int Id { get; }

        public override void Publish()
        {
            
        }
    }
}
