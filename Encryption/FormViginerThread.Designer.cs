namespace Encryption
{
    partial class FormViginerThread
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
            this.textMessageT = new System.Windows.Forms.TextBox();
            this.gridKey = new System.Windows.Forms.DataGridView();
            this.labelABCT = new System.Windows.Forms.Label();
            this.labelDeshifrT = new System.Windows.Forms.Label();
            this.textDeShifrT = new System.Windows.Forms.TextBox();
            this.gridV2 = new System.Windows.Forms.DataGridView();
            this.buttonDeshifrT = new System.Windows.Forms.Button();
            this.labelKey2T = new System.Windows.Forms.Label();
            this.labelShifrT = new System.Windows.Forms.Label();
            this.textGetKeyT = new System.Windows.Forms.TextBox();
            this.textGetShifrT = new System.Windows.Forms.TextBox();
            this.gridV1 = new System.Windows.Forms.DataGridView();
            this.buttonShifrT = new System.Windows.Forms.Button();
            this.labelKey1T = new System.Windows.Forms.Label();
            this.labelMessageT = new System.Windows.Forms.Label();
            this.textKeyViginT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMessageT
            // 
            this.textMessageT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMessageT.BackColor = System.Drawing.Color.Gainsboro;
            this.textMessageT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMessageT.ForeColor = System.Drawing.Color.DarkOrange;
            this.textMessageT.Location = new System.Drawing.Point(161, 3);
            this.textMessageT.Multiline = true;
            this.textMessageT.Name = "textMessageT";
            this.textMessageT.Size = new System.Drawing.Size(235, 29);
            this.textMessageT.TabIndex = 104;
            // 
            // gridKey
            // 
            this.gridKey.AllowUserToDeleteRows = false;
            this.gridKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridKey.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKey.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridKey.Location = new System.Drawing.Point(2, 467);
            this.gridKey.Name = "gridKey";
            this.gridKey.ReadOnly = true;
            this.gridKey.RowHeadersWidth = 70;
            this.gridKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridKey.Size = new System.Drawing.Size(795, 233);
            this.gridKey.TabIndex = 103;
            // 
            // labelABCT
            // 
            this.labelABCT.AutoSize = true;
            this.labelABCT.BackColor = System.Drawing.Color.Transparent;
            this.labelABCT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABCT.ForeColor = System.Drawing.Color.Lime;
            this.labelABCT.Location = new System.Drawing.Point(202, 445);
            this.labelABCT.Name = "labelABCT";
            this.labelABCT.Size = new System.Drawing.Size(445, 19);
            this.labelABCT.TabIndex = 102;
            this.labelABCT.Text = "Таблица алфавита для шифрования/дешифрования по ключу";
            // 
            // labelDeshifrT
            // 
            this.labelDeshifrT.AutoSize = true;
            this.labelDeshifrT.BackColor = System.Drawing.Color.Transparent;
            this.labelDeshifrT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeshifrT.ForeColor = System.Drawing.Color.Lime;
            this.labelDeshifrT.Location = new System.Drawing.Point(37, 393);
            this.labelDeshifrT.Name = "labelDeshifrT";
            this.labelDeshifrT.Size = new System.Drawing.Size(108, 19);
            this.labelDeshifrT.TabIndex = 101;
            this.labelDeshifrT.Text = "Расшифровка";
            // 
            // textDeShifrT
            // 
            this.textDeShifrT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDeShifrT.BackColor = System.Drawing.Color.Gainsboro;
            this.textDeShifrT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDeShifrT.ForeColor = System.Drawing.Color.DarkOrange;
            this.textDeShifrT.Location = new System.Drawing.Point(161, 380);
            this.textDeShifrT.Multiline = true;
            this.textDeShifrT.Name = "textDeShifrT";
            this.textDeShifrT.Size = new System.Drawing.Size(495, 32);
            this.textDeShifrT.TabIndex = 100;
            // 
            // gridV2
            // 
            this.gridV2.AllowUserToAddRows = false;
            this.gridV2.AllowUserToDeleteRows = false;
            this.gridV2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridV2.Location = new System.Drawing.Point(2, 255);
            this.gridV2.Name = "gridV2";
            this.gridV2.ReadOnly = true;
            this.gridV2.RowHeadersWidth = 70;
            this.gridV2.Size = new System.Drawing.Size(795, 110);
            this.gridV2.TabIndex = 99;
            // 
            // buttonDeshifrT
            // 
            this.buttonDeshifrT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeshifrT.BackColor = System.Drawing.Color.Red;
            this.buttonDeshifrT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeshifrT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeshifrT.Location = new System.Drawing.Point(662, 195);
            this.buttonDeshifrT.Name = "buttonDeshifrT";
            this.buttonDeshifrT.Size = new System.Drawing.Size(135, 35);
            this.buttonDeshifrT.TabIndex = 98;
            this.buttonDeshifrT.Text = "Дешифровать";
            this.buttonDeshifrT.UseVisualStyleBackColor = false;
            this.buttonDeshifrT.Click += new System.EventHandler(this.ButtonDeShifrT_Click);
            // 
            // labelKey2T
            // 
            this.labelKey2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey2T.AutoSize = true;
            this.labelKey2T.BackColor = System.Drawing.Color.Transparent;
            this.labelKey2T.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey2T.ForeColor = System.Drawing.Color.Lime;
            this.labelKey2T.Location = new System.Drawing.Point(411, 204);
            this.labelKey2T.Name = "labelKey2T";
            this.labelKey2T.Size = new System.Drawing.Size(47, 19);
            this.labelKey2T.TabIndex = 97;
            this.labelKey2T.Text = "Ключ";
            // 
            // labelShifrT
            // 
            this.labelShifrT.AutoSize = true;
            this.labelShifrT.BackColor = System.Drawing.Color.Transparent;
            this.labelShifrT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifrT.ForeColor = System.Drawing.Color.Lime;
            this.labelShifrT.Location = new System.Drawing.Point(61, 208);
            this.labelShifrT.Name = "labelShifrT";
            this.labelShifrT.Size = new System.Drawing.Size(84, 19);
            this.labelShifrT.TabIndex = 96;
            this.labelShifrT.Text = "Шифровка";
            // 
            // textGetKeyT
            // 
            this.textGetKeyT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textGetKeyT.BackColor = System.Drawing.Color.Gainsboro;
            this.textGetKeyT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGetKeyT.ForeColor = System.Drawing.Color.DarkOrange;
            this.textGetKeyT.Location = new System.Drawing.Point(464, 198);
            this.textGetKeyT.Multiline = true;
            this.textGetKeyT.Name = "textGetKeyT";
            this.textGetKeyT.Size = new System.Drawing.Size(192, 29);
            this.textGetKeyT.TabIndex = 95;
            // 
            // textGetShifrT
            // 
            this.textGetShifrT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textGetShifrT.BackColor = System.Drawing.Color.Gainsboro;
            this.textGetShifrT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGetShifrT.ForeColor = System.Drawing.Color.DarkOrange;
            this.textGetShifrT.Location = new System.Drawing.Point(161, 195);
            this.textGetShifrT.Multiline = true;
            this.textGetShifrT.Name = "textGetShifrT";
            this.textGetShifrT.Size = new System.Drawing.Size(235, 32);
            this.textGetShifrT.TabIndex = 94;
            // 
            // gridV1
            // 
            this.gridV1.AllowUserToAddRows = false;
            this.gridV1.AllowUserToDeleteRows = false;
            this.gridV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridV1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridV1.Location = new System.Drawing.Point(2, 49);
            this.gridV1.Name = "gridV1";
            this.gridV1.ReadOnly = true;
            this.gridV1.RowHeadersWidth = 70;
            this.gridV1.Size = new System.Drawing.Size(795, 110);
            this.gridV1.TabIndex = 93;
            // 
            // buttonShifrT
            // 
            this.buttonShifrT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShifrT.BackColor = System.Drawing.Color.Red;
            this.buttonShifrT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShifrT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShifrT.Location = new System.Drawing.Point(662, 5);
            this.buttonShifrT.Name = "buttonShifrT";
            this.buttonShifrT.Size = new System.Drawing.Size(135, 33);
            this.buttonShifrT.TabIndex = 92;
            this.buttonShifrT.Text = "Шифровать";
            this.buttonShifrT.UseVisualStyleBackColor = false;
            this.buttonShifrT.Click += new System.EventHandler(this.ButtonShifrT_Click);
            // 
            // labelKey1T
            // 
            this.labelKey1T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey1T.AutoSize = true;
            this.labelKey1T.BackColor = System.Drawing.Color.Transparent;
            this.labelKey1T.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey1T.ForeColor = System.Drawing.Color.Lime;
            this.labelKey1T.Location = new System.Drawing.Point(411, 9);
            this.labelKey1T.Name = "labelKey1T";
            this.labelKey1T.Size = new System.Drawing.Size(47, 19);
            this.labelKey1T.TabIndex = 91;
            this.labelKey1T.Text = "Ключ";
            // 
            // labelMessageT
            // 
            this.labelMessageT.AutoSize = true;
            this.labelMessageT.BackColor = System.Drawing.Color.Transparent;
            this.labelMessageT.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageT.ForeColor = System.Drawing.Color.Lime;
            this.labelMessageT.Location = new System.Drawing.Point(-5, 13);
            this.labelMessageT.Name = "labelMessageT";
            this.labelMessageT.Size = new System.Drawing.Size(160, 19);
            this.labelMessageT.TabIndex = 90;
            this.labelMessageT.Text = "Исходное сообщение";
            // 
            // textKeyViginT
            // 
            this.textKeyViginT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textKeyViginT.BackColor = System.Drawing.Color.Gainsboro;
            this.textKeyViginT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textKeyViginT.ForeColor = System.Drawing.Color.DarkOrange;
            this.textKeyViginT.Location = new System.Drawing.Point(464, 3);
            this.textKeyViginT.Multiline = true;
            this.textKeyViginT.Name = "textKeyViginT";
            this.textKeyViginT.Size = new System.Drawing.Size(192, 29);
            this.textKeyViginT.TabIndex = 89;
            // 
            // FormViginerThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 732);
            this.Controls.Add(this.textMessageT);
            this.Controls.Add(this.gridKey);
            this.Controls.Add(this.labelABCT);
            this.Controls.Add(this.labelDeshifrT);
            this.Controls.Add(this.textDeShifrT);
            this.Controls.Add(this.gridV2);
            this.Controls.Add(this.buttonDeshifrT);
            this.Controls.Add(this.labelKey2T);
            this.Controls.Add(this.labelShifrT);
            this.Controls.Add(this.textGetKeyT);
            this.Controls.Add(this.textGetShifrT);
            this.Controls.Add(this.gridV1);
            this.Controls.Add(this.buttonShifrT);
            this.Controls.Add(this.labelKey1T);
            this.Controls.Add(this.labelMessageT);
            this.Controls.Add(this.textKeyViginT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(825, 693);
            this.Name = "FormViginerThread";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поточный шифр Виженера";
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMessageT;
        private System.Windows.Forms.DataGridView gridKey;
        private System.Windows.Forms.Label labelABCT;
        private System.Windows.Forms.Label labelDeshifrT;
        private System.Windows.Forms.TextBox textDeShifrT;
        private System.Windows.Forms.DataGridView gridV2;
        private System.Windows.Forms.Button buttonDeshifrT;
        private System.Windows.Forms.Label labelKey2T;
        private System.Windows.Forms.Label labelShifrT;
        private System.Windows.Forms.TextBox textGetKeyT;
        private System.Windows.Forms.TextBox textGetShifrT;
        private System.Windows.Forms.DataGridView gridV1;
        private System.Windows.Forms.Button buttonShifrT;
        private System.Windows.Forms.Label labelKey1T;
        private System.Windows.Forms.Label labelMessageT;
        private System.Windows.Forms.TextBox textKeyViginT;
    }
}