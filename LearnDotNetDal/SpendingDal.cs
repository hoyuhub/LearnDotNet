using System;
using System.Collections.Generic;
using System.Linq;
using LearnDotNet.Model;

namespace LearnDotNet.Dal
{
    public class SpendingDal : BaseDal<Spending>
    {
        public SpendingDal()
        {
            //生成上下文
            this.DbContext = new LearnDotNetDbContext<Spending>();
        }
        public List<Spending> Find()
        {
            return DbContext.Set<Spending>().ToList();
        }
    }
}