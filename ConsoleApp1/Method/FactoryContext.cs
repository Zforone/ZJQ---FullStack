﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    
    //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，
    //外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
    public class FactoryContext
    {
        private static FactoryContext factory /*=new FactoryContext ()*/;
        private  FactoryContext()
        {

        }
        public static FactoryContext getFact()
        {
            if (factory ==null)
            {
                factory = new FactoryContext();
            }
            else
            {
                //
            }
            return factory ;
        }
    }
}
