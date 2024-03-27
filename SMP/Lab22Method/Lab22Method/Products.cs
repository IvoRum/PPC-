﻿using System.Data;

namespace Lab22Method;

public class Products:DataAccessObject
{
    public override void Select() 
    { 
        string sql = "select ProductName from Products"; 
        //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString); 
        dataSet = new DataSet(); 
        //dataAdapter.Fill(dataSet, "Products"); 
    } 

    public override void Process() 
    { 
        Console.WriteLine("Products ---- "); 
        DataTable dataTable = dataSet.Tables["Products"]; 
        foreach (DataRow row in dataTable.Rows) 
        { 
            Console.WriteLine(row["ProductName"]); 
        } 
        Console.WriteLine(); 
    } 
}