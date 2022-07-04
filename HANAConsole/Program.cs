using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sap.Data.Hana;

namespace HANAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new HanaConnection("Server = 192.168.1.233:30015; UserName = SYSTEM; Password = Kaiser$641");
            //https://blogs.sap.com/2015/04/15/creating-a-c-application-using-sap-hana-and-adonet/
            HanaDataAdapter dataAdapter = new HanaDataAdapter("SELECT * from SCHEMAS", conn);
            conn.Open();
            System.Data.DataTable testTable = new System.Data.DataTable();
            dataAdapter.Fill(testTable);
            var a = testTable.Rows[0][0];
            conn.Close();


            
        }
    }
}
