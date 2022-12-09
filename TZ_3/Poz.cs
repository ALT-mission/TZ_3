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

namespace TZ_3
{
    public partial class Poz : Form
    {
        public Poz()
        {
            InitializeComponent();
            ShowIcon = false;
            load();
        }
        private void load() {
            dataGridView1.Rows.Clear();


            string QueryEdit = "SELECT * FROM Poz  ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(QueryEdit, myCon);

            SqlParameter obj = new SqlParameter("@FindOBJ", textBox1.Text);

            command.Parameters.Add(obj);
            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
                data[data.Count - 1][4] = Reader[4].ToString();
                data[data.Count - 1][5] = Reader[5].ToString();
            }

            Reader.Close();

            myCon.Close();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();


            string QueryEdit = "SELECT * FROM Poz Where Num_zakaz like '%'+@FindOBJ+'%' or [Num_poz] like '%'+@FindOBJ+'%' or  [target_char_steel] like '%'+@FindOBJ+'%' or  V_poz like '%'+@FindOBJ+'%' or  [Unit_mes] like '%'+@FindOBJ+'%' or  [Statys] like '%'+@FindOBJ+'%' ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(QueryEdit, myCon);

            SqlParameter obj = new SqlParameter("@FindOBJ", textBox1.Text);

            command.Parameters.Add(obj);
            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
                data[data.Count - 1][4] = Reader[4].ToString();
                data[data.Count - 1][5] = Reader[5].ToString();
            }

            Reader.Close();

            myCon.Close();
        }

        private void P_del_Click(object sender, EventArgs e)
        {
            string QueryDel = "DELETE FROM Poz WHERE ([Num_zakaz]=@p2) and ([Num_poz]=@p1)";
            SqlConnection myCon = new SqlConnection(connectionString: G_forms.connection);
            myCon.Open();

            SqlCommand command1 = new SqlCommand(QueryDel, myCon);
            string T = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            command1.Parameters.Add("@p1", T);
            string T1 = string.Concat(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            command1.Parameters.Add("@p2", T1);

            command1.ExecuteReader();
            myCon.Close();


            load();
        }

        private void P_edit_Click(object sender, EventArgs e)
        {
            G_forms.Text1 = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            G_forms.Text2 = string.Concat(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            G_forms.Text3 = string.Concat(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            G_forms.Text4 = string.Concat(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            G_forms.Text5 = string.Concat(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            G_forms.Text6 = string.Concat(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            Form f = new P_edit();
            f.Show();
        }

        private void P_insert_Click(object sender, EventArgs e)
        {
            Form f = new P_insert();
            f.Show();
        }
    }
}
