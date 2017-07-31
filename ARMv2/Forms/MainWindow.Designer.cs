namespace ARMv2
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.NumFilter = new System.Windows.Forms.NumericUpDown();
            this.ClearFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PetFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FIOFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCardBtn = new System.Windows.Forms.Button();
            this.AddCardBtn = new System.Windows.Forms.Button();
            this.EditCardBtn = new System.Windows.Forms.Button();
            this.ShowCardBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowRecordBtn = new System.Windows.Forms.Button();
            this.DeleteRecBtn = new System.Windows.Forms.Button();
            this.EditRecBtn = new System.Windows.Forms.Button();
            this.AddRecBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApplyFilter);
            this.groupBox1.Controls.Add(this.NumFilter);
            this.groupBox1.Controls.Add(this.ClearFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PhoneFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PetFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FIOFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteCardBtn);
            this.groupBox1.Controls.Add(this.AddCardBtn);
            this.groupBox1.Controls.Add(this.EditCardBtn);
            this.groupBox1.Controls.Add(this.ShowCardBtn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Амбулаторные карты";
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyFilter.Location = new System.Drawing.Point(795, 273);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(108, 43);
            this.ApplyFilter.TabIndex = 19;
            this.ApplyFilter.Text = "Применить фильтр";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // NumFilter
            // 
            this.NumFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumFilter.Location = new System.Drawing.Point(77, 287);
            this.NumFilter.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumFilter.Name = "NumFilter";
            this.NumFilter.Size = new System.Drawing.Size(65, 20);
            this.NumFilter.TabIndex = 18;
            this.NumFilter.ThousandsSeparator = true;
            // 
            // ClearFilter
            // 
            this.ClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearFilter.Location = new System.Drawing.Point(925, 273);
            this.ClearFilter.Name = "ClearFilter";
            this.ClearFilter.Size = new System.Drawing.Size(106, 43);
            this.ClearFilter.TabIndex = 17;
            this.ClearFilter.Text = "Очистить фильтр";
            this.ClearFilter.UseVisualStyleBackColor = true;
            this.ClearFilter.Click += new System.EventHandler(this.ClearFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "№ карты";
            // 
            // PhoneFilter
            // 
            this.PhoneFilter.Location = new System.Drawing.Point(626, 286);
            this.PhoneFilter.Name = "PhoneFilter";
            this.PhoneFilter.Size = new System.Drawing.Size(122, 20);
            this.PhoneFilter.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Телефон:";
            // 
            // PetFilter
            // 
            this.PetFilter.Location = new System.Drawing.Point(413, 286);
            this.PetFilter.Name = "PetFilter";
            this.PetFilter.Size = new System.Drawing.Size(129, 20);
            this.PetFilter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Кличка:";
            // 
            // FIOFilter
            // 
            this.FIOFilter.Location = new System.Drawing.Point(210, 286);
            this.FIOFilter.Name = "FIOFilter";
            this.FIOFilter.Size = new System.Drawing.Size(129, 20);
            this.FIOFilter.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтрация:";
            // 
            // DeleteCardBtn
            // 
            this.DeleteCardBtn.Location = new System.Drawing.Point(1120, 110);
            this.DeleteCardBtn.Name = "DeleteCardBtn";
            this.DeleteCardBtn.Size = new System.Drawing.Size(105, 41);
            this.DeleteCardBtn.TabIndex = 6;
            this.DeleteCardBtn.Text = "Удалить карту";
            this.DeleteCardBtn.UseVisualStyleBackColor = true;
            this.DeleteCardBtn.Click += new System.EventHandler(this.DeleteCardBtn_Click);
            // 
            // AddCardBtn
            // 
            this.AddCardBtn.Location = new System.Drawing.Point(1120, 19);
            this.AddCardBtn.Name = "AddCardBtn";
            this.AddCardBtn.Size = new System.Drawing.Size(105, 39);
            this.AddCardBtn.TabIndex = 5;
            this.AddCardBtn.Text = "Добавить карту";
            this.AddCardBtn.UseVisualStyleBackColor = true;
            this.AddCardBtn.Click += new System.EventHandler(this.AddCardBtn_Click);
            // 
            // EditCardBtn
            // 
            this.EditCardBtn.Location = new System.Drawing.Point(1120, 64);
            this.EditCardBtn.Name = "EditCardBtn";
            this.EditCardBtn.Size = new System.Drawing.Size(105, 40);
            this.EditCardBtn.TabIndex = 4;
            this.EditCardBtn.Text = "Редактировать карту";
            this.EditCardBtn.UseVisualStyleBackColor = true;
            this.EditCardBtn.Click += new System.EventHandler(this.EditCardBtn_Click);
            // 
            // ShowCardBtn
            // 
            this.ShowCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowCardBtn.Location = new System.Drawing.Point(1120, 219);
            this.ShowCardBtn.Name = "ShowCardBtn";
            this.ShowCardBtn.Size = new System.Drawing.Size(105, 46);
            this.ShowCardBtn.TabIndex = 3;
            this.ShowCardBtn.Text = "Показать карту\r\n";
            this.ShowCardBtn.UseVisualStyleBackColor = true;
            this.ShowCardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowRecordBtn);
            this.groupBox2.Controls.Add(this.DeleteRecBtn);
            this.groupBox2.Controls.Add(this.EditRecBtn);
            this.groupBox2.Controls.Add(this.AddRecBtn);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1229, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Амбулаторные записи";
            // 
            // ShowRecordBtn
            // 
            this.ShowRecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecordBtn.Location = new System.Drawing.Point(1118, 228);
            this.ShowRecordBtn.Name = "ShowRecordBtn";
            this.ShowRecordBtn.Size = new System.Drawing.Size(104, 52);
            this.ShowRecordBtn.TabIndex = 5;
            this.ShowRecordBtn.Text = "Посмотреть запись";
            this.ShowRecordBtn.UseVisualStyleBackColor = true;
            this.ShowRecordBtn.Click += new System.EventHandler(this.ShowRecordBtn_Click);
            // 
            // DeleteRecBtn
            // 
            this.DeleteRecBtn.Location = new System.Drawing.Point(1118, 102);
            this.DeleteRecBtn.Name = "DeleteRecBtn";
            this.DeleteRecBtn.Size = new System.Drawing.Size(104, 38);
            this.DeleteRecBtn.TabIndex = 3;
            this.DeleteRecBtn.Text = "Удалить запись";
            this.DeleteRecBtn.UseVisualStyleBackColor = true;
            this.DeleteRecBtn.Click += new System.EventHandler(this.DeleteRecBtn_Click);
            // 
            // EditRecBtn
            // 
            this.EditRecBtn.Location = new System.Drawing.Point(1118, 61);
            this.EditRecBtn.Name = "EditRecBtn";
            this.EditRecBtn.Size = new System.Drawing.Size(105, 34);
            this.EditRecBtn.TabIndex = 2;
            this.EditRecBtn.Text = "Редактировать запись";
            this.EditRecBtn.UseVisualStyleBackColor = true;
            this.EditRecBtn.Click += new System.EventHandler(this.EditRecBtn_Click);
            // 
            // AddRecBtn
            // 
            this.AddRecBtn.Location = new System.Drawing.Point(1118, 19);
            this.AddRecBtn.Name = "AddRecBtn";
            this.AddRecBtn.Size = new System.Drawing.Size(105, 36);
            this.AddRecBtn.TabIndex = 1;
            this.AddRecBtn.Text = "Добавить запись";
            this.AddRecBtn.UseVisualStyleBackColor = true;
            this.AddRecBtn.Click += new System.EventHandler(this.AddRecBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(14, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1095, 261);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Новая карта";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton4.Text = "О программе";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button DeleteCardBtn;
        private System.Windows.Forms.Button AddCardBtn;
        private System.Windows.Forms.Button EditCardBtn;
        private System.Windows.Forms.Button ShowCardBtn;
        private System.Windows.Forms.Button ShowRecordBtn;
        private System.Windows.Forms.Button DeleteRecBtn;
        private System.Windows.Forms.Button EditRecBtn;
        private System.Windows.Forms.Button AddRecBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIOFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PetFilter;
        private System.Windows.Forms.NumericUpDown NumFilter;
        private System.Windows.Forms.Button ApplyFilter;
    }
}

