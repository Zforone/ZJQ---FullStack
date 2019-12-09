﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Funtion
{
    public class BinarySeek
    {
        //实现二分查找，方法名BinarySeek()
        public void BinaryOfSeek(double[] arr, double num, int j, int i = 0)//传入数组，查找的数字，     
        {
            int k;
            k = (i + j) / 2;
            if (arr[0] > arr[arr.Length - 1])
            {
                if (arr[k] == num)
                {
                    Console.WriteLine("找出的数字：" + arr[k] + ",第" + (k + 1) + "个数字。");
                    return;
                }
                else if (arr[k] < num)
                {
                    BinaryOfSeek(arr, num, k, i);
                }
                else
                {
                    BinaryOfSeek(arr, num, k, j);
                }
            }
            else
            {
                if (arr[k] == num)
                {
                    Console.WriteLine("找出的数字：" + arr[k] + ",第" + (k + 1) + "个数字。");
                    return;
                }
                else if (arr[k] < num)
                {
                    BinaryOfSeek(arr, num, k, j);
                }
                else
                {
                    BinaryOfSeek(arr, num, k, i);
                }
            }
        }
    }
}