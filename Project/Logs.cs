using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project
{
    public partial class Logs : Form
    {

        private SqlConnection conn;
        public Logs()
        {
            InitializeComponent();

        }

        public Logs(UInt32 id)
        {
            int idd = Convert.ToInt32(id);
            string path = System.Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "DataBase" + "\\DB.mdf";
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path2 + ";Integrated Security=True");
            InitializeComponent();
            display_data_Transactions(idd);

        }
        public  void display_data_Transactions(int idd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from TransactionRecords where ID like '%" + idd + "%'";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGrid.DataSource = dta;
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
