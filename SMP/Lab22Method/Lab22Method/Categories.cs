﻿using System.Data;

namespace Lab22Method;

public class Categories:DataAccessObject
{
    public override void Select() 
    { 
        string sql = "select CategoryName from Categories"; 
        //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString); 
        dataSet = new DataSet(); 
        //dataAdapter.Fill(dataSet, "Categories"); 
    } 
    public override void Process() 
    { 
        Console.WriteLine("Categories ---- "); 
        DataTable dataTable = dataSet.Tables["Categories"]; 
        foreach (DataRow row in dataTable.Rows) 
        { 
            Console.WriteLine(row["CategoryName"]); 
        } 
        Console.WriteLine(); 
    } 
}