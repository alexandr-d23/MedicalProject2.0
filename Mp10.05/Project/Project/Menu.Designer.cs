﻿namespace Project
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatienName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitizenShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastSurvey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientListButton = new System.Windows.Forms.Button();
            this.addAnalysButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.PatienName,
            this.fName,
            this.Patronymic,
            this.sitizenShip,
            this.passportData,
            this.lastSurvey});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(279, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 670);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Number
            // 
            this.Number.HeaderText = "Num";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
            this.Number.Width = 125;
            // 
            // PatienName
            // 
            this.PatienName.HeaderText = "Имя";
            this.PatienName.MinimumWidth = 40;
            this.PatienName.Name = "PatienName";
            this.PatienName.ReadOnly = true;
            this.PatienName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PatienName.Width = 150;
            // 
            // fName
            // 
            this.fName.HeaderText = "Фамилия";
            this.fName.MinimumWidth = 6;
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            this.fName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fName.Width = 150;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Patronymic.Width = 150;
            // 
            // sitizenShip
            // 
            this.sitizenShip.HeaderText = "Гражданство";
            this.sitizenShip.MinimumWidth = 6;
            this.sitizenShip.Name = "sitizenShip";
            this.sitizenShip.ReadOnly = true;
            this.sitizenShip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sitizenShip.Width = 130;
            // 
            // passportData
            // 
            this.passportData.HeaderText = "Прикрепление";
            this.passportData.MinimumWidth = 6;
            this.passportData.Name = "passportData";
            this.passportData.ReadOnly = true;
            this.passportData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.passportData.Width = 230;
            // 
            // lastSurvey
            // 
            this.lastSurvey.HeaderText = "Дата обследования";
            this.lastSurvey.MinimumWidth = 6;
            this.lastSurvey.Name = "lastSurvey";
            this.lastSurvey.ReadOnly = true;
            this.lastSurvey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lastSurvey.Width = 135;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 102);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ";
            // 
            // PatientListButton
            // 
            this.PatientListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PatientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientListButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientListButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.PatientListButton.Location = new System.Drawing.Point(1331, 119);
            this.PatientListButton.Margin = new System.Windows.Forms.Padding(4);
            this.PatientListButton.Name = "PatientListButton";
            this.PatientListButton.Size = new System.Drawing.Size(184, 69);
            this.PatientListButton.TabIndex = 6;
            this.PatientListButton.Text = "Обновить список";
            this.PatientListButton.UseVisualStyleBackColor = false;
            this.PatientListButton.Click += new System.EventHandler(this.PatientListButton_Click_1);
            // 
            // addAnalysButton
            // 
            this.addAnalysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addAnalysButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAnalysButton.Enabled = false;
            this.addAnalysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnalysButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAnalysButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.addAnalysButton.Location = new System.Drawing.Point(38, 370);
            this.addAnalysButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAnalysButton.Name = "addAnalysButton";
            this.addAnalysButton.Size = new System.Drawing.Size(184, 69);
            this.addAnalysButton.TabIndex = 7;
            this.addAnalysButton.Text = "Добавить анализ";
            this.addAnalysButton.UseVisualStyleBackColor = false;
            this.addAnalysButton.Click += new System.EventHandler(this.addAnalysButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPatientButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.addPatientButton.Location = new System.Drawing.Point(38, 499);
            this.addPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(184, 69);
            this.addPatientButton.TabIndex = 8;
            this.addPatientButton.Text = "Добавить пациента";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.Enabled = false;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.FloralWhite;
            this.delete.Location = new System.Drawing.Point(38, 627);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(184, 69);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить пациента";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(331, 164);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 34);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = "Имя Фамилия";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BackgroundImage = global::Project.Properties.Resources.loupe_792573;
            this.pictureBox1.Location = new System.Drawing.Point(755, 164);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openProfile
            // 
            this.openProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.openProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openProfile.Enabled = false;
            this.openProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openProfile.ForeColor = System.Drawing.Color.FloralWhite;
            this.openProfile.Location = new System.Drawing.Point(38, 247);
            this.openProfile.Margin = new System.Windows.Forms.Padding(4);
            this.openProfile.Name = "openProfile";
            this.openProfile.Size = new System.Drawing.Size(184, 69);
            this.openProfile.TabIndex = 12;
            this.openProfile.Text = "Профиль пациента";
            this.openProfile.UseVisualStyleBackColor = false;
            this.openProfile.Click += new System.EventHandler(this.openProfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(38, 758);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1548, 892);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.addAnalysButton);
            this.Controls.Add(this.PatientListButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button PatientListButton;
        private System.Windows.Forms.Button addAnalysButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatienName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitizenShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastSurvey;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openProfile;
        private System.Windows.Forms.Button button1;
    }
}

