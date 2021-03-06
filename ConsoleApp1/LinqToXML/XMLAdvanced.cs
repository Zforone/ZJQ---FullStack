﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.LinqToXML
{
    class XMLAdvanced
    {
        //代码生成一个XML的users对象，能够存放用户的id、name和password，然后并存放到磁盘
        //扩展user和articles的内容，使其能够完成以下操作：

        public static void UserData()
        {
            XElement UserDatas =
                        new XElement("UserDatas",
                        new XComment("以下存放用户数据"),

                        new XElement("user",
                        new XElement("id", 1),
                        new XElement("name", "飞哥"),
                        new XElement("password", 1111)),

                        new XElement("user",
                        new XElement("id", 2),
                        new XElement("name", "小于"),
                        new XElement("password", 2222)),

                        new XElement("user",
                        new XElement("id", 3),
                        new XElement("name", "阿泰"),
                        new XElement("password", 3333))
                                    );

            //Console.WriteLine(UserDatas);
            //XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), UserDatas);
            //document.Save("E://UserDatas.xml");

            XElement GetUserDatas = XElement.Load("E://UserDatas.xml");
            XElement GetArticles = XElement.Load("E://XML.xml");

            //根据用户名查找他发布的全部文章
            Console.WriteLine("-----根据用户名查找他发布的全部文章-----");
            var allArticles = from a in GetArticles.Descendants("article")
                                   where a.Element("authorName").Value== "飞哥"
                                   select a;

            foreach (var item in allArticles)
            {
                Console.WriteLine(item.Element("title"));
            }

            //统计出每个用户各发表了多少篇文章
            Console.WriteLine("-----统计出每个用户各发表了多少篇文章-----");
            var userArticles = from a in GetArticles.Descendants("article")
                               group a by a.Element("authorName").Value into ga
                               select new
                               {
                                   name = ga.Key,
                                   count = ga.Count()
                               };

            foreach (var item in userArticles.ToList())
            {
                Console.WriteLine($"{item.name}:{item.count}");
            }

            //查出每个用户最近发布的一篇文章
            Console.WriteLine("-----查出每个用户最近发布的一篇文章-----");
            var recentArticles = from a in GetArticles.Descendants("article")
                                 group a by a.Element("authorName").Value into ga
                                 select new
                                 {
                                     name = ga.Key,
                                     art = ga.OrderByDescending(p => p.Element("publishDate").Value)
                                           .First().Element("title").Value
                                 };
            foreach (var item in recentArticles)
            {
                Console.WriteLine($"{item.name}:{item.art}");
            }

            //每个用户评论最多的一篇文章
            Console.WriteLine("-----每个用户评论最多的一篇文章-----");
            var countIsMax = from a in GetArticles.Descendants("article")
                             group a by a.Element("authorName").Value into ga
                             select new
                             {
                                 name = ga.Key,
                                 art = ga.OrderByDescending(c=>c.Descendants("comments")
                                         .Elements("comment").Count())
                                         .First().Element("title")
                             };
            foreach (var item in countIsMax)
            {
                Console.WriteLine($"{item.name}:{item.art}");
            }

            //删除没有发表文章的用户
            Console.WriteLine("-----删除没有发表文章的用户-----");
            var user = from u in GetUserDatas.Descendants("user")
                       join a in GetArticles.Descendants("article")
                       on u.Element("name").Value equals a.Element("authorName").Value into ja
                       from result in ja.DefaultIfEmpty()
                       where result==null
                       select u.Element("name");

            foreach (var item in user)
            {
                item.Remove();
            }

        }
    }
}
