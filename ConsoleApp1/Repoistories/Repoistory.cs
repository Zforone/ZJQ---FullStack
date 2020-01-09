﻿using ConsoleApp1._17bang;
using ConsoleApp1.AboutDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Repoistories
{
    //定义一个仓库（Repoistory）类，其中包含：
    //一个int类型的常量version
    //一个静态只读的字符串connection，
    //以后可用于连接数据库,思考Respoitory应该是static类还是实例类更好
    
    public class Repoistory<T> : DbContext
        where T:class
    {
        //const int version = 99;
        const string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bangDB;Integrated Security=True;";

        //public DbSet<HelpMoney> HelpMoney { get; set; }
        //public DbContext CurrentContext { get; set; }
        //public Repoistory()
        //{
        //    CurrentContext = new DbContext();
        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);  
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelpMoney>()
                .HasKey(k => k.Id);
        }

        public void Save(T entity)
        {
            Set<T>().Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            Set<T>().Remove(entity);
            SaveChanges();
        }

        public T Get(int id)
        {
            return Set<T>().Find(id) ;
        }


        public void SaveMore(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
                {
                Set<T>().Add(entity[i]);
                }
            SaveChanges();
        }

        public void DeleteMoe(params T[] entity)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                Set<T>().Remove(entity[i]);
            }
            SaveChanges();
        }

        //public SqlDataReader Find()
        //{
        //    SqlDataReader dataReader = _dbHepler.ExecuteReader($"SELET * FROM Student WHERE ID = {Id}");
        //    return dataReader;
        //}

    }
}
