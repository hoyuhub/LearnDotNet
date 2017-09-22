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
            //����������
            this.DbContext = new LearnDotNetDbContext<Spending>();
        }
        public List<Spending> Find()
        {
            return DbContext.Set<Spending>().ToList();
        }
    }
}