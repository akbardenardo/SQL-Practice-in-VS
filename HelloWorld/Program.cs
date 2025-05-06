using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        var connString = @"Server=(localdb)\MSSQLLocalDB;Database=DemoDB;Trusted_Connection=True;";
        const string sql = "SELECT Id, FirstName, LastName FROM People";

        using var conn = new SqlConnection(connString);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;

        conn.Open();
        using var rdr = cmd.ExecuteReader();
        while (rdr.Read())
            Console.WriteLine($"{rdr["Id"]}: {rdr["FirstName"]} {rdr["LastName"]}");
    }
}
