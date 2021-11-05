using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace baseCF
{
    public class Globals
    {
      public static string pasta = @"../../../BDP2-WMSV2.mdb";
        
      public static string ConnString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pasta;

    }

    class SelectItem
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }
}
