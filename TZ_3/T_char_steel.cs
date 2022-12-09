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
    public partial class T_char_steel : Form
    {
        public T_char_steel()
        {
            InitializeComponent();
            this.ShowIcon = false;

        }

        private void load()
        {
            dataGridView1.Rows.Clear();


            string QueryEdit = "SELECT * FROM target_char_mat  ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(QueryEdit, myCon);

            SqlParameter obj = new SqlParameter("@FindOBJ", textBox1.Text);

            command.Parameters.Add(obj);
            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
                
            }

            Reader.Close();

            myCon.Close();
        }
        private void b_del_Click(object sender, EventArgs e)
        {
            string QueryDel = "DELETE FROM target_char_mat WHERE ([ID]=@p1) ";
            SqlConnection myCon = new SqlConnection(connectionString: G_forms.connection);
            myCon.Open();

            SqlCommand command1 = new SqlCommand(QueryDel, myCon);
            string T = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            command1.Parameters.Add("@p1", T);
           

            command1.ExecuteReader();
            myCon.Close();


            load();
        }

        private void B_edit_Click(object sender, EventArgs e)
        {
            G_forms.Text1 = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            G_forms.Text2 = string.Concat(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            G_forms.Text3 = string.Concat(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            G_forms.Text4 = string.Concat(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            G_forms.Text5 = string.Concat(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Form f = new T_edit();
            f.Show();

        }

        private void B_ins_Click(object sender, EventArgs e)
        {
            Form f = new T_ins();
            f.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();


            string QueryEdit = "SELECT * FROM target_char_mat Where ID like '%'+@FindOBJ+'%' or [Steel_grade] like '%'+@FindOBJ+'%' or  [Diam] like '%'+@FindOBJ+'%' or  Side like '%'+@FindOBJ+'%'  ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(QueryEdit, myCon);

            SqlParameter obj = new SqlParameter("@FindOBJ", textBox1.Text);

            command.Parameters.Add(obj);
            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
          
               
            }

            Reader.Close();

            myCon.Close();

        }
    }
}
