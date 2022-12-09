namespace TZ_3
{
    partial class Zak
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N_zak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заказыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.позицииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.целевыеХаркиМатериалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_zak,
            this.W_shop,
            this.D_start,
            this.D_end,
            this.St});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // N_zak
            // 
            this.N_zak.HeaderText = "№ заказа";
            this.N_zak.Name = "N_zak";
            // 
            // W_shop
            // 
            this.W_shop.HeaderText = "Цех";
            this.W_shop.Name = "W_shop";
            // 
            // D_start
            // 
            this.D_start.HeaderText = "Дата начала";
            this.D_start.Name = "D_start";
            // 
            // D_end
            // 
            this.D_end.HeaderText = "Дата окончания";
            this.D_end.Name = "D_end";
            // 
            // St
            // 
            this.St.HeaderText = "Статус";
            this.St.Name = "St";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem1,
            this.позицииToolStripMenuItem1,
            this.целевыеХаркиМатериалаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заказыToolStripMenuItem1
            // 
            this.заказыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.заказыToolStripMenuItem1.Name = "заказыToolStripMenuItem1";
            this.заказыToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.заказыToolStripMenuItem1.Text = "Заказы";
            // 
            // позицииToolStripMenuItem1
            // 
            this.позицииToolStripMenuItem1.Name = "позицииToolStripMenuItem1";
            this.позицииToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.позицииToolStripMenuItem1.Text = "Позиции";
            this.позицииToolStripMenuItem1.Click += new System.EventHandler(this.позицииToolStripMenuItem1_Click);
            // 
            // целевыеХаркиМатериалаToolStripMenuItem
            // 
            this.целевыеХаркиМатериалаToolStripMenuItem.Name = "целевыеХаркиМатериалаToolStripMenuItem";
            this.целевыеХаркиМатериалаToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.целевыеХаркиМатериалаToolStripMenuItem.Text = "Целевые хар-ки материала";
            this.целевыеХаркиМатериалаToolStripMenuItem.Click += new System.EventHandler(this.целевыеХаркиМатериалаToolStripMenuItem_Click);
            // 
            // внестиToolStripMenuItem
            // 
            this.внестиToolStripMenuItem.Name = "внестиToolStripMenuItem";
            this.внестиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.внестиToolStripMenuItem.Text = "Внести";
            this.внестиToolStripMenuItem.Click += new System.EventHandler(this.внестиToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Zak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 223);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zak";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_zak;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn St;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem внестиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem позицииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem целевыеХаркиМатериалаToolStripMenuItem;
    }
}

