using UnityEngine;
using System.Collections;
using System;
using System.Data;
using Mono.Data.SqliteClient;

public class Db : MonoBehaviour
{
    public ArrayList Resultd;
    public void Main()
    {
    }
    public ArrayList Select(string quer)
    {
        Resultd = new ArrayList();
        string connectionString = "URI=file:" + Application.dataPath + "/Qjournaldb.s3db";
        IDbConnection dbcon = new SqliteConnection(connectionString);
        dbcon.Open();
        IDbCommand dbcmd = dbcon.CreateCommand();
        dbcmd.CommandText = quer;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            Resultd.Add(reader.GetString(2));
            //Debug.Log(reader.GetString(2));
        }
       
        // clean up
        reader.Dispose();
        dbcmd.Dispose();
        dbcon.Close();
        return Resultd;
    }
}