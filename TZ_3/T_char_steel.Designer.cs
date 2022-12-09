namespace TZ_3
{
    partial class T_char_steel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Steel_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_ins = new System.Windows.Forms.Button();
            this.B_edit = new System.Windows.Forms.Button();
            this.b_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Steel_grade,
            this.Diam,
            this.Side});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(410, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Steel_grade
            // 
            this.Steel_grade.HeaderText = "Марка стали";
            this.Steel_grade.Name = "Steel_grade";
            this.Steel_grade.ReadOnly = true;
            // 
            // Diam
            // 
            this.Diam.HeaderText = "Диаметр";
            this.Diam.Name = "Diam";
            this.Diam.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.HeaderText = "Стенка";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // B_ins
            // 
            this.B_ins.Location = new System.Drawing.Point(12, 230);
            this.B_ins.Name = "B_ins";
            this.B_ins.Size = new System.Drawing.Size(75, 23);
            this.B_ins.TabIndex = 2;
            this.B_ins.Text = "Внести";
            this.B_ins.UseVisualStyleBackColor = true;
            this.B_ins.Click += new System.EventHandler(this.B_ins_Click);
            // 
            // B_edit
            // 
            this.B_edit.Location = new System.Drawing.Point(173, 230);
            this.B_edit.Name = "B_edit";
            this.B_edit.Size = new System.Drawing.Size(95, 23);
            this.B_edit.TabIndex = 3;
            this.B_edit.Text = "Редактировать";
            this.B_edit.UseVisualStyleBackColor = true;
            this.B_edit.Click += new System.EventHandler(this.B_edit_Click);
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(347, 230);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(75, 23);
            this.b_del.TabIndex = 4;
            this.b_del.Text = "Удалить";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // T_char_steel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 264);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.B_edit);
            this.Controls.Add(this.B_ins);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "T_char_steel";
            this.Text = "Целевые характеристики материала";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Steel_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button B_ins;
        private System.Windows.Forms.Button B_edit;
        private System.Windows.Forms.Button b_del;
    }
}