﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //●帮帮币版块，定义一个类HelpMoney,包含你认为应该包含的字段和方法
    public class HelpMoney :Entity<int> 
    {
        //将之前User/Problem/HelpMoney类的字段封装成属性，
        //internal HelpMoney(int integrals)
        //{

        //}
        public int hasHelpMoney { get; set; }

        public DateTime DateTime { get; set; }

        public string Kind { get; set; }

        public int ChangeNum { get; set; }

        public string Notes { get; set; }

        internal void changeCoins(int changeNum)
        {
            
        }
    }
}
