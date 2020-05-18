namespace Encryption
{
    partial class DH_KeysChange
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.textG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butP = new System.Windows.Forms.Button();
            this.butG = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butGenX = new System.Windows.Forms.Button();
            this.butGenerateA = new System.Windows.Forms.Button();
            this.butKeyA = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textKeyA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butGenY = new System.Windows.Forms.Button();
            this.butGenetateB = new System.Windows.Forms.Button();
            this.butKeyB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textKeyB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "простое число P = ";
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(205, 7);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(131, 20);
            this.textP.TabIndex = 1;
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(202, 48);
            this.textG.Name = "textG";
            this.textG.Size = new System.Drawing.Size(131, 20);
            this.textG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "общее основание G = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(124, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Абонент 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Абонент 2";
            // 
            // butP
            // 
            this.butP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butP.Location = new System.Drawing.Point(349, 1);
            this.butP.Name = "butP";
            this.butP.Size = new System.Drawing.Size(152, 29);
            this.butP.TabIndex = 6;
            this.butP.Text = "Случайное число";
            this.butP.UseVisualStyleBackColor = true;
            this.butP.Click += new System.EventHandler(this.ButP_Click);
            // 
            // butG
            // 
            this.butG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butG.Location = new System.Drawing.Point(349, 42);
            this.butG.Name = "butG";
            this.butG.Size = new System.Drawing.Size(152, 28);
            this.butG.TabIndex = 7;
            this.butG.Text = "Случайное число";
            this.butG.UseVisualStyleBackColor = true;
            this.butG.Click += new System.EventHandler(this.ButG_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-2, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Секретное число А = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Секретное число Б = ";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(176, 51);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 10;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(184, 54);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butGenX);
            this.panel1.Controls.Add(this.butGenerateA);
            this.panel1.Controls.Add(this.butKeyA);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textKeyA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textA);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 269);
            this.panel1.TabIndex = 12;
            // 
            // butGenX
            // 
            this.butGenX.Location = new System.Drawing.Point(176, 147);
            this.butGenX.Name = "butGenX";
            this.butGenX.Size = new System.Drawing.Size(100, 37);
            this.butGenX.TabIndex = 18;
            this.butGenX.Text = "Расчитать";
            this.butGenX.UseVisualStyleBackColor = true;
            this.butGenX.Click += new System.EventHandler(this.ButGenX_Click);
            // 
            // butGenerateA
            // 
            this.butGenerateA.Location = new System.Drawing.Point(176, 75);
            this.butGenerateA.Name = "butGenerateA";
            this.butGenerateA.Size = new System.Drawing.Size(100, 37);
            this.butGenerateA.TabIndex = 17;
            this.butGenerateA.Text = "Сгенерировать";
            this.butGenerateA.UseVisualStyleBackColor = true;
            this.butGenerateA.Click += new System.EventHandler(this.ButGenerateA_Click);
            // 
            // butKeyA
            // 
            this.butKeyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butKeyA.Location = new System.Drawing.Point(65, 216);
            this.butKeyA.Name = "butKeyA";
            this.butKeyA.Size = new System.Drawing.Size(211, 33);
            this.butKeyA.TabIndex = 15;
            this.butKeyA.Text = "Обший секретный ключ";
            this.butKeyA.UseVisualStyleBackColor = true;
            this.butKeyA.Click += new System.EventHandler(this.ButKeyA_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(62, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Общий ключ";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // textKeyA
            // 
            this.textKeyA.Location = new System.Drawing.Point(176, 189);
            this.textKeyA.Name = "textKeyA";
            this.textKeyA.Size = new System.Drawing.Size(100, 20);
            this.textKeyA.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Число для отправки = ";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(176, 122);
            this.textX.Name = "textX";
            this.textX.ReadOnly = true;
            this.textX.Size = new System.Drawing.Size(100, 20);
            this.textX.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.butGenY);
            this.panel2.Controls.Add(this.butGenetateB);
            this.panel2.Controls.Add(this.butKeyB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textKeyB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textY);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textB);
            this.panel2.Location = new System.Drawing.Point(349, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 269);
            this.panel2.TabIndex = 13;
            // 
            // butGenY
            // 
            this.butGenY.Location = new System.Drawing.Point(184, 147);
            this.butGenY.Name = "butGenY";
            this.butGenY.Size = new System.Drawing.Size(100, 37);
            this.butGenY.TabIndex = 19;
            this.butGenY.Text = "Расчитать";
            this.butGenY.UseVisualStyleBackColor = true;
            this.butGenY.Click += new System.EventHandler(this.ButGenY_Click);
            // 
            // butGenetateB
            // 
            this.butGenetateB.Location = new System.Drawing.Point(184, 79);
            this.butGenetateB.Name = "butGenetateB";
            this.butGenetateB.Size = new System.Drawing.Size(100, 37);
            this.butGenetateB.TabIndex = 18;
            this.butGenetateB.Text = "Сгенерировать";
            this.butGenetateB.UseVisualStyleBackColor = true;
            this.butGenetateB.Click += new System.EventHandler(this.ButGenetateB_Click);
            // 
            // butKeyB
            // 
            this.butKeyB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butKeyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butKeyB.Location = new System.Drawing.Point(50, 216);
            this.butKeyB.Name = "butKeyB";
            this.butKeyB.Size = new System.Drawing.Size(234, 33);
            this.butKeyB.TabIndex = 16;
            this.butKeyB.Text = "Обший секретный ключ";
            this.butKeyB.UseVisualStyleBackColor = false;
            this.butKeyB.Click += new System.EventHandler(this.ButKeyB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(83, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Общий ключ";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // textKeyB
            // 
            this.textKeyB.Location = new System.Drawing.Point(184, 190);
            this.textKeyB.Name = "textKeyB";
            this.textKeyB.Size = new System.Drawing.Size(100, 20);
            this.textKeyB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Число для отправки = ";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(184, 122);
            this.textY.Name = "textY";
            this.textY.ReadOnly = true;
            this.textY.Size = new System.Drawing.Size(100, 20);
            this.textY.TabIndex = 13;
            // 
            // DH_KeysChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(685, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butG);
            this.Controls.Add(this.butP);
            this.Controls.Add(this.textG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DH_KeysChange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ключевой обмен Диффи-Хеллмана";
            this.Load += new System.EventHandler(this.DH_KeysChange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butP;
        private System.Windows.Forms.Button butG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textKeyA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textKeyB;
        private System.Windows.Forms.Button butKeyA;
        private System.Windows.Forms.Button butKeyB;
        private System.Windows.Forms.Button butGenerateA;
        private System.Windows.Forms.Button butGenetateB;
        private System.Windows.Forms.Button butGenX;
        private System.Windows.Forms.Button butGenY;
    }
}