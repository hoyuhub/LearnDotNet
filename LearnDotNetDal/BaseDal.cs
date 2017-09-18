using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
public abstract class BaseDal<T> where T : class, new()
{
    public string tableName { get; set; }
    public abstract void SetTableName();

    public BaseDal()
    {
        SetTableName();
    }

    public List<T> Load(string columnName, string value)
    {
sqlcommand
        string sql = "select * from ";
        return null;
    }
}