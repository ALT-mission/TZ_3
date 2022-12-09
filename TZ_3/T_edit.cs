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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TZ_3
{
    public partial class T_edit : Form
    {
        public T_edit()
        {
            InitializeComponent();
        }

        private void T_edit_Load(object sender, EventArgs e)
        {
            textBox1.Text = G_forms.Text2;
            textBox2.Text = G_forms.Text3;
            textBox3.Text = G_forms.Text4;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            string queryED = " UPDATE `Zakaz` SET  `W_shop_P` = ?, `Data_start` = ?, `Data_end` = ?, `Statys` = ? WHERE(`Num_zakaz` = ?)";
            SqlConnection myConnection = new SqlConnection(G_forms.connection);

            myConnection.Open();

            using (SqlCommand command = new SqlCommand(queryED, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Char).Value = textBox1.Text;
                command.Parameters.Add("Param2", SqlDbType.Char).Value = textBox2.Text;
                command.Parameters.Add("Param3", SqlDbType.Char).Value = textBox3.Text;
             
                command.Parameters.Add("Param4", SqlDbType.Int).Value = G_forms.Text1;
                command.ExecuteNonQuery();
            }

            myConnection.Close();




        }
    }
}
