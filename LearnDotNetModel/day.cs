using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDotNetModel
{
    public class day
    {
        //无参构造函数
        public day() { }
        //构造函数
        public day(DateTime time, decimal money, string reason)
        {
            this.time = time;
            this.money = money;
            this.reason = reason;
        }
        //花费产生的时间
        public DateTime time { get; set; }

        //花费金额
        public decimal money { get; set; }

        //花费原因
        public string reason { get; set; }
    }
}
