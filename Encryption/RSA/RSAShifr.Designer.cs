﻿namespace Encryption
{
    partial class RSAShifr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.textQ = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textF = new System.Windows.Forms.TextBox();
            this.textE = new System.Windows.Forms.TextBox();
            this.textD = new System.Windows.Forms.TextBox();
            this.butGenE = new System.Windows.Forms.Button();
            this.butGenP = new System.Windows.Forms.Button();
            this.butGenQ = new System.Windows.Forms.Button();
            this.butFindD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPublicMessage = new System.Windows.Forms.TextBox();
            this.butEncrypt = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textGetN_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textGetE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPrivateMessage = new System.Windows.Forms.TextBox();
            this.butDecrypt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textGetN_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textGetD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gridRSA = new System.Windows.Forms.DataGridView();
            this.colLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRSA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "p = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "q = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(138, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "n = p * q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "φ(n) = (p-1)*(q-1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(69, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "e = ,GCD(e,φ(n)) = 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "d = e^-1 mod φ(n)";
            // 
            // textP
            // 
            this.textP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textP.Location = new System.Drawing.Point(206, 12);
            this.textP.Margin = new System.Windows.Forms.Padding(4);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(182, 22);
            this.textP.TabIndex = 6;
            // 
            // textQ
            // 
            this.textQ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQ.Location = new System.Drawing.Point(206, 39);
            this.textQ.Margin = new System.Windows.Forms.Padding(4);
            this.textQ.Name = "textQ";
            this.textQ.Size = new System.Drawing.Size(182, 22);
            this.textQ.TabIndex = 7;
            // 
            // textN
            // 
            this.textN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textN.Location = new System.Drawing.Point(206, 69);
            this.textN.Margin = new System.Windows.Forms.Padding(4);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(182, 22);
            this.textN.TabIndex = 8;
            // 
            // textF
            // 
            this.textF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textF.Location = new System.Drawing.Point(206, 99);
            this.textF.Margin = new System.Windows.Forms.Padding(4);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(182, 22);
            this.textF.TabIndex = 9;
            // 
            // textE
            // 
            this.textE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textE.Location = new System.Drawing.Point(206, 129);
            this.textE.Margin = new System.Windows.Forms.Padding(4);
            this.textE.Name = "textE";
            this.textE.Size = new System.Drawing.Size(182, 22);
            this.textE.TabIndex = 10;
            // 
            // textD
            // 
            this.textD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD.Location = new System.Drawing.Point(206, 159);
            this.textD.Margin = new System.Windows.Forms.Padding(4);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(182, 22);
            this.textD.TabIndex = 11;
            // 
            // butGenE
            // 
            this.butGenE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGenE.Location = new System.Drawing.Point(396, 129);
            this.butGenE.Margin = new System.Windows.Forms.Padding(4);
            this.butGenE.Name = "butGenE";
            this.butGenE.Size = new System.Drawing.Size(102, 22);
            this.butGenE.TabIndex = 12;
            this.butGenE.Text = "Generate E";
            this.butGenE.UseVisualStyleBackColor = true;
            this.butGenE.Click += new System.EventHandler(this.ButGenE_Click);
            // 
            // butGenP
            // 
            this.butGenP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGenP.Location = new System.Drawing.Point(396, 13);
            this.butGenP.Margin = new System.Windows.Forms.Padding(4);
            this.butGenP.Name = "butGenP";
            this.butGenP.Size = new System.Drawing.Size(102, 21);
            this.butGenP.TabIndex = 13;
            this.butGenP.Text = "Generate P";
            this.butGenP.UseVisualStyleBackColor = true;
            this.butGenP.Click += new System.EventHandler(this.ButGenP_Click);
            // 
            // butGenQ
            // 
            this.butGenQ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGenQ.Location = new System.Drawing.Point(396, 39);
            this.butGenQ.Margin = new System.Windows.Forms.Padding(4);
            this.butGenQ.Name = "butGenQ";
            this.butGenQ.Size = new System.Drawing.Size(102, 23);
            this.butGenQ.TabIndex = 14;
            this.butGenQ.Text = "Generate Q";
            this.butGenQ.UseVisualStyleBackColor = true;
            this.butGenQ.Click += new System.EventHandler(this.ButGenQ_Click);
            // 
            // butFindD
            // 
            this.butFindD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butFindD.Location = new System.Drawing.Point(397, 158);
            this.butFindD.Margin = new System.Windows.Forms.Padding(4);
            this.butFindD.Name = "butFindD";
            this.butFindD.Size = new System.Drawing.Size(102, 22);
            this.butFindD.TabIndex = 15;
            this.butFindD.Text = "Calculate D";
            this.butFindD.UseVisualStyleBackColor = true;
            this.butFindD.Click += new System.EventHandler(this.Butfindd_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textPublicMessage);
            this.panel1.Controls.Add(this.butEncrypt);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textGetN_1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textGetE);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 133);
            this.panel1.TabIndex = 18;
            // 
            // textPublicMessage
            // 
            this.textPublicMessage.Location = new System.Drawing.Point(88, 93);
            this.textPublicMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textPublicMessage.Name = "textPublicMessage";
            this.textPublicMessage.Size = new System.Drawing.Size(263, 23);
            this.textPublicMessage.TabIndex = 8;
            this.textPublicMessage.Text = "Perpetuum Mobile";
            // 
            // butEncrypt
            // 
            this.butEncrypt.Location = new System.Drawing.Point(359, 91);
            this.butEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.butEncrypt.Name = "butEncrypt";
            this.butEncrypt.Size = new System.Drawing.Size(100, 25);
            this.butEncrypt.TabIndex = 7;
            this.butEncrypt.Text = "Шифровать";
            this.butEncrypt.UseVisualStyleBackColor = true;
            this.butEncrypt.Click += new System.EventHandler(this.ButEncrypt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(4, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Сообщение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(467, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "}";
            // 
            // textGetN_1
            // 
            this.textGetN_1.Location = new System.Drawing.Point(280, 52);
            this.textGetN_1.Margin = new System.Windows.Forms.Padding(4);
            this.textGetN_1.Name = "textGetN_1";
            this.textGetN_1.Size = new System.Drawing.Size(179, 23);
            this.textGetN_1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(246, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = ", n =";
            // 
            // textGetE
            // 
            this.textGetE.Location = new System.Drawing.Point(88, 52);
            this.textGetE.Margin = new System.Windows.Forms.Padding(4);
            this.textGetE.Name = "textGetE";
            this.textGetE.Size = new System.Drawing.Size(150, 23);
            this.textGetE.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(38, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "{ e = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(200, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Открытый ключ:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textPrivateMessage);
            this.panel2.Controls.Add(this.butDecrypt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textGetN_2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textGetD);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(13, 334);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 133);
            this.panel2.TabIndex = 19;
            // 
            // textPrivateMessage
            // 
            this.textPrivateMessage.Location = new System.Drawing.Point(88, 93);
            this.textPrivateMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textPrivateMessage.Name = "textPrivateMessage";
            this.textPrivateMessage.Size = new System.Drawing.Size(263, 23);
            this.textPrivateMessage.TabIndex = 8;
            // 
            // butDecrypt
            // 
            this.butDecrypt.Location = new System.Drawing.Point(359, 91);
            this.butDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.butDecrypt.Name = "butDecrypt";
            this.butDecrypt.Size = new System.Drawing.Size(100, 25);
            this.butDecrypt.TabIndex = 7;
            this.butDecrypt.Text = "Дешифровать";
            this.butDecrypt.UseVisualStyleBackColor = true;
            this.butDecrypt.Click += new System.EventHandler(this.ButDecrypt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(4, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Сообщение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(467, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "}";
            // 
            // textGetN_2
            // 
            this.textGetN_2.Location = new System.Drawing.Point(280, 52);
            this.textGetN_2.Margin = new System.Windows.Forms.Padding(4);
            this.textGetN_2.Name = "textGetN_2";
            this.textGetN_2.Size = new System.Drawing.Size(179, 23);
            this.textGetN_2.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(246, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = ", n =";
            // 
            // textGetD
            // 
            this.textGetD.Location = new System.Drawing.Point(88, 52);
            this.textGetD.Margin = new System.Windows.Forms.Padding(4);
            this.textGetD.Name = "textGetD";
            this.textGetD.Size = new System.Drawing.Size(150, 23);
            this.textGetD.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(38, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "{ d = ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(200, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Секретный ключ:";
            // 
            // gridRSA
            // 
            this.gridRSA.AllowUserToAddRows = false;
            this.gridRSA.AllowUserToDeleteRows = false;
            this.gridRSA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRSA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLetter,
            this.colASCII,
            this.colEncrypt,
            this.colDecrypt,
            this.colReLetter});
            this.gridRSA.Location = new System.Drawing.Point(506, 13);
            this.gridRSA.Name = "gridRSA";
            this.gridRSA.ReadOnly = true;
            this.gridRSA.Size = new System.Drawing.Size(403, 454);
            this.gridRSA.TabIndex = 20;
            // 
            // colLetter
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLetter.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLetter.HeaderText = "Letter";
            this.colLetter.Name = "colLetter";
            this.colLetter.ReadOnly = true;
            // 
            // colASCII
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colASCII.DefaultCellStyle = dataGridViewCellStyle2;
            this.colASCII.HeaderText = "ASCII";
            this.colASCII.Name = "colASCII";
            this.colASCII.ReadOnly = true;
            // 
            // colEncrypt
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEncrypt.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEncrypt.HeaderText = "Encrypt";
            this.colEncrypt.Name = "colEncrypt";
            this.colEncrypt.ReadOnly = true;
            // 
            // colDecrypt
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDecrypt.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDecrypt.HeaderText = "Decrypt";
            this.colDecrypt.Name = "colDecrypt";
            this.colDecrypt.ReadOnly = true;
            // 
            // colReLetter
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colReLetter.DefaultCellStyle = dataGridViewCellStyle5;
            this.colReLetter.HeaderText = "ReLetter";
            this.colReLetter.Name = "colReLetter";
            this.colReLetter.ReadOnly = true;
            // 
            // RSAShifr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.Controls.Add(this.gridRSA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butFindD);
            this.Controls.Add(this.butGenQ);
            this.Controls.Add(this.butGenP);
            this.Controls.Add(this.butGenE);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.textE);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.textQ);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(940, 530);
            this.Name = "RSAShifr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр RSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.TextBox textQ;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.TextBox textE;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Button butGenE;
        private System.Windows.Forms.Button butGenP;
        private System.Windows.Forms.Button butGenQ;
        private System.Windows.Forms.Button butFindD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPublicMessage;
        private System.Windows.Forms.Button butEncrypt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textGetN_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textGetE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPrivateMessage;
        private System.Windows.Forms.Button butDecrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textGetN_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textGetD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gridRSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDecrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReLetter;
    }
}