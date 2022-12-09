using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TZ_3
{
    public partial class T_ins : Form
    {
        public T_ins()
        {
            InitializeComponent();
        }

        private void T_ins_Load(object sender, EventArgs e)
        {

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ins_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_Add = "INSERT INTO `target_char_mat` (`Steel_grade`, `Diam`, `Side`) VALUES ( ?, ?, ?)";

            using (SqlCommand command = new SqlCommand(query_Add, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Char).Value = textBox1.Text;
                command.Parameters.Add("Param2", SqlDbType.Char).Value = textBox2.Text;
                command.Parameters.Add("Param3", SqlDbType.Char).Value = textBox3.Text;
             
                command.ExecuteNonQuery();

            }
            myConnection.Close();

        }
    }
}
