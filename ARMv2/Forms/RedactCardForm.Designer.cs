namespace ARMv2.Forms
{
    partial class RedactCardForm
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
            this.CancelBut = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DontHaveBD = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IsFemale = new System.Windows.Forms.RadioButton();
            this.IsMale = new System.Windows.Forms.RadioButton();
            this.NamePet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Breed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeAnimal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BreedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.NumericUpDown();
            this.months = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.years)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(12, 277);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(130, 45);
            this.CancelBut.TabIndex = 17;
            this.CancelBut.Text = "Отменить";
            this.CancelBut.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(509, 277);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 45);
            this.Add.TabIndex = 16;
            this.Add.Text = "Отредактировать карту";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.days);
            this.groupBox2.Controls.Add(this.months);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.years);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.DontHaveBD);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.IsFemale);
            this.groupBox2.Controls.Add(this.IsMale);
            this.groupBox2.Controls.Add(this.NamePet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Breed);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TypeAnimal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 129);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Питомец";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(405, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // DontHaveBD
            // 
            this.DontHaveBD.AutoSize = true;
            this.DontHaveBD.Location = new System.Drawing.Point(304, 52);
            this.DontHaveBD.Name = "DontHaveBD";
            this.DontHaveBD.Size = new System.Drawing.Size(166, 17);
            this.DontHaveBD.TabIndex = 11;
            this.DontHaveBD.Text = "Неизвестна дата рождения";
            this.DontHaveBD.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Дата рождения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Особь";
            // 
            // IsFemale
            // 
            this.IsFemale.AutoSize = true;
            this.IsFemale.Location = new System.Drawing.Point(201, 102);
            this.IsFemale.Name = "IsFemale";
            this.IsFemale.Size = new System.Drawing.Size(72, 17);
            this.IsFemale.TabIndex = 7;
            this.IsFemale.TabStop = true;
            this.IsFemale.Text = "Женская";
            this.IsFemale.UseVisualStyleBackColor = true;
            // 
            // IsMale
            // 
            this.IsMale.AutoSize = true;
            this.IsMale.Checked = true;
            this.IsMale.Location = new System.Drawing.Point(124, 102);
            this.IsMale.Name = "IsMale";
            this.IsMale.Size = new System.Drawing.Size(71, 17);
            this.IsMale.TabIndex = 6;
            this.IsMale.TabStop = true;
            this.IsMale.Text = "Мужская";
            this.IsMale.UseVisualStyleBackColor = true;
            // 
            // NamePet
            // 
            this.NamePet.Location = new System.Drawing.Point(111, 76);
            this.NamePet.Name = "NamePet";
            this.NamePet.Size = new System.Drawing.Size(171, 20);
            this.NamePet.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Кличка";
            // 
            // Breed
            // 
            this.Breed.Location = new System.Drawing.Point(111, 50);
            this.Breed.Name = "Breed";
            this.Breed.Size = new System.Drawing.Size(171, 20);
            this.Breed.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Порода:";
            // 
            // TypeAnimal
            // 
            this.TypeAnimal.FormattingEnabled = true;
            this.TypeAnimal.Items.AddRange(new object[] {
            "Собака",
            "Кошка",
            "Птица",
            "Пресмыкающееся",
            "Паук",
            "Грызун",
            "Ракообразные",
            "Лошадь",
            "Корова",
            "Мелкий Рогатый Скот"});
            this.TypeAnimal.Location = new System.Drawing.Point(111, 23);
            this.TypeAnimal.Name = "TypeAnimal";
            this.TypeAnimal.Size = new System.Drawing.Size(171, 21);
            this.TypeAnimal.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вид животного: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Telephone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BreedName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Владелец";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(114, 49);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(470, 20);
            this.Address.TabIndex = 6;
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(114, 75);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(130, 20);
            this.Telephone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес:";
            // 
            // BreedName
            // 
            this.BreedName.Location = new System.Drawing.Point(114, 22);
            this.BreedName.Name = "BreedName";
            this.BreedName.Size = new System.Drawing.Size(242, 20);
            this.BreedName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО Владельца:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "месяцев";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(580, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "дней";
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(535, 79);
            this.days.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(42, 20);
            this.days.TabIndex = 25;
            // 
            // months
            // 
            this.months.Location = new System.Drawing.Point(432, 79);
            this.months.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(41, 20);
            this.months.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "лет";
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(358, 79);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(48, 20);
            this.years.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(301, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Возраст:";
            // 
            // RedactCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBut;
            this.ClientSize = new System.Drawing.Size(651, 335);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RedactCardForm";
            this.Text = "Редактирование карты";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.years)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox DontHaveBD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton IsFemale;
        private System.Windows.Forms.RadioButton IsMale;
        private System.Windows.Forms.TextBox NamePet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Breed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TypeAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BreedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown days;
        private System.Windows.Forms.NumericUpDown months;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown years;
        private System.Windows.Forms.Label label17;
    }
}