﻿using ConsoleApp1._17bang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.LinqToXML
{
    //public static class UsedLinq
    //{
    //    public static void Do()
    //    {
    //        Keyword sql = new Keyword() { KeywordName = "SQL" };
    //        Keyword js = new Keyword() { KeywordName = "JS" };
    //        Keyword html = new Keyword() { KeywordName = "html" };
    //        Keyword css = new Keyword() { KeywordName = "css" };
    //        Keyword csharp = new Keyword() { KeywordName = "C#" };
    //        Keyword net = new Keyword() { KeywordName = ".NET" };


    //        Article article1 = new Article()
    //        {
    //            Author = new User() { Name = "飞哥" },
    //            Title = "飞哥真帅",
    //            KeyWords = new List<Keyword> { sql, css, csharp }
    //        };
    //        new ContentService().Publish(article1);

    //        Article article2 = new Article()
    //        {
    //            Author = new User() { Name = "小于" },
    //            Title = "源栈之花",
    //            KeyWords = new List<Keyword> { js }
    //        };
    //        new ContentService().Publish(article2);

    //        Article article3 = new Article()
    //        {
    //            Author = new User() { Name = "阿泰" },
    //            Title = "沙区扛把子",
    //            KeyWords = new List<Keyword> { net, html }
    //        };
    //        new ContentService().Publish(article3);

    //        Article article4 = new Article()
    //        {
    //            Author = article1.Author,
    //            Title = "飞哥非常帅",
    //            KeyWords = new List<Keyword> { net, html, net }
    //        };
    //        new ContentService().Publish(article4);

    //        Problem problem1 = new Problem()
    //        {
    //            Author = new User() { Name = "阿泰" },
    //            Title = "js是什么",
    //            Reward = 10
    //        };

    //        Problem problem2 = new Problem()
    //        {
    //            Author = problem1.Author,
    //            Title = "c#是什么",
    //            Reward = 3
    //        };

    //        Problem problem3 = new Problem()
    //        {
    //            Author = new User() { Name = "王新" },
    //            Title = ".net是什么",
    //            Reward = 10
    //        };

    //        Problem problem4 = new Problem()
    //        {
    //            Author = problem3.Author,
    //            Title = "sql是什么",
    //            Reward = 20
    //        };

    //        Comment comment1 = new Comment(article1) { Contents = "帅" };
    //        Comment comment2 = new Comment(article1) { Contents = "真帅" };
    //        Comment comment3 = new Comment(article1) { Contents = "非常帅" };
    //        Comment comment4 = new Comment(article2) { Contents = "源栈之花啊" };
    //        Comment comment5 = new Comment(article3) { Contents = "大佬" };
    //        Comment comment6 = new Comment(article4) { Contents = "非常帅啊" };


    //        article1.Comments = new List<Comment> { comment1, comment2, comment3 };
    //        article2.Comments = new List<Comment> { comment4 };
    //        article3.Comments = new List<Comment> { comment5 };
    //        article4.Comments = new List<Comment> { comment6 };

    //        IEnumerable<Article> articles = new List<Article> { article1, article2, article3, article4 };
    //        IEnumerable<Problem> problems = new List<Problem> { problem1, problem2, problem3, problem4 };

    //        //将之前作业的Linq查询表达式用Linq方法实现
    //        //找出“飞哥”发布的文章
    //        Console.WriteLine("找出“飞哥”发布的文章:");
    //        var fgPaper1 = from a in articles
    //                       where a.Author.Name == "飞哥"
    //                       select a;

    //        var fgPaper2 =
    //            articles.Where(a => a.Author.Name.Equals("飞哥"));

    //        foreach (var item in fgPaper2)
    //        {
    //            Console.WriteLine(item.Title);
    //        }
    //        Console.WriteLine("----------");


    //        //找出2019年1月1日以后“小鱼”发布的文章
    //        Console.WriteLine("找出2019年1月1日以后“小鱼”发布的文章:");
    //        var xyPaper1 = from a in articles
    //                       where a.Author.Name == "小于" && a.PublishTime > new DateTime(2019, 1, 1)
    //                       select a;

    //        var xyPaper2 =
    //            articles.Where(a => a.Author.Name.Equals("小于") && a.PublishTime > new DateTime(2019, 1, 1));

    //        foreach (var item in xyPaper2)
    //        {
    //            Console.WriteLine(item.Title);
    //        }
    //        Console.WriteLine("----------");


    //        //按发布时间升序 / 降序排列显示文章
    //        Console.WriteLine("按发布时间升序 / 降序排列显示文章:");
    //        var time1 = from a in articles
    //                    orderby a.PublishTime ascending //升序
    //                                                    //orderby a.PublishTime descending  //降序
    //                    select a;

    //        //var time2 = articles.OrderByDescending(a => a.PublishTime);
    //        var time2 = articles.OrderBy(a => a.PublishTime);//升序

    //        foreach (var item in time2)
    //        {
    //            Console.WriteLine(item.Title);
    //        }
    //        Console.WriteLine("----------");


    //        //统计每个用户各发布了多少篇文章
    //        Console.WriteLine("统计每个用户各发布了多少篇文章:");
    //        var articlesNum1 = from a in articles
    //                           group a by a.Author into ua
    //                           select new
    //                           {
    //                               name = ua.Key.Name,
    //                               art = ua.Count()
    //                           };

    //        var articlesNum2 = articles.GroupBy(a => a.Author)
    //            .Select(ua => new
    //            {
    //                name = ua.Key.Name,
    //                art = ua.Count()
    //            });

    //        foreach (var item in articlesNum2)
    //        {
    //            Console.WriteLine(item.name + ":" + item.art);
    //        }
    //        Console.WriteLine("----------");


    //        //找出包含关键字“C#”或“.NET”的文章
    //        Console.WriteLine("找出包含关键字“C#”或“.NET”的文章:");
    //        var papers1 = from a in articles
    //                      where a.KeyWords.Contains(csharp) || a.KeyWords.Contains(net)
    //                      select a;

    //        var papers2 =
    //            articles.Where(a => a.KeyWords.Contains(csharp) || a.KeyWords.Contains(net));

    //        foreach (var item in papers2)
    //        {
    //            Console.WriteLine(item.Title);
    //        }
    //        Console.WriteLine("----------");


    //        //找出评论数量最多的文章
    //        Console.WriteLine("找出评论数量最多的文章:");
    //        var max1 = from a in articles
    //                   orderby a.Comments.Count() descending
    //                   select a;

    //        var max2 = articles.OrderByDescending(a => a.Comments.Count);

    //        Console.WriteLine(max2.ToList().First().Title);
    //        Console.WriteLine("----------");


    //        //找出每个作者最近发布的一篇文章 
    //        Console.WriteLine("找出每个作者最近发布的一篇文章 :");
    //        var art =
    //        articles.GroupBy(g => g.Author).Select(a => a.OrderByDescending(p => p.PublishTime).First().Title);
    //        //from a in articles
    //        //group a by a.Author into ga
    //        //select (from a in ga
    //        //        orderby a.PublishTime descending
    //        //        select a).First();
    //        foreach (var item in art)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.WriteLine("----------");

    //        //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的文章作者 
    //        Console.WriteLine("找出每一篇求助的悬赏都大于5个帮帮币的文章作者 :");
    //        var authors = problems
    //            .GroupBy(p => p.Author)
    //            .Where(gp => gp.Min(r => r.Reward) > 5)
    //            .Select(a => a.Key.Name);

    //        foreach (var item in authors)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.WriteLine("----------");



    //    }


    //    //public static void ArticlesOfFg(List<Article> articles)
    //    //{

    //    //}
    //    //public static void ArticlesOfXy(List<Article> articles)
    //    //{

    //    //}

    //    //public static void TimeSort(List<Article> articles)
    //    //{

    //    //}

    //    //public static void ArticlesNum(List<Article> articles)
    //    //{

    //    //}

    //    //public static void FindArticle(List<Article> articles)
    //    //{

    //    //}

    //    //public static void Max(List<Article> articles)
    //    //{

    //    //}    
    //}
}
