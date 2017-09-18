using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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
        SqlCommand command = new SqlCommand();
        string sql = "select * from ";
        return null;
    }
}