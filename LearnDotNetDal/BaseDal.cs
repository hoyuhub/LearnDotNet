using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace LearnDotNet.Dal
{
    public abstract class BaseDal<T> where T : class, new()
    {
        DbContext dbContext;

        public DbContext DbContext { get => dbContext; set => dbContext = value; }


        //EF 的泛型添加方法
        public T Add(T m)
        {
            DbContext.Set<T>().Add(m);
            DbContext.SaveChanges();
            return m;
        }

        // EF的泛型修改方法
        //有待调整
        public T Update(T m)
        {
            if (DbContext.Entry<T>(m).State == EntityState.Modified)
            {
                DbContext.SaveChanges();
            }
            else if (DbContext.Entry<T>(m).State == EntityState.Detached)
            {
                try
                {
                    DbContext.Set<T>().Attach(m);
                    DbContext.Entry<T>(m).State = EntityState.Modified;
                }
                catch (System.Exception)
                {
                    throw;
                }
                DbContext.SaveChanges();
            }
            return m;
        }

        //EF 的泛型删除方法
        public void Delete(T m)
        {
            DbContext.Set<T>().Remove(m);
            DbContext.SaveChanges();
        }
    }

}