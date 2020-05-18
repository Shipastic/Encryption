namespace Encryption
{
    partial class FormViginer
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
            this.labelKey1 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textKeyVigin = new System.Windows.Forms.TextBox();
            this.buttonShifr = new System.Windows.Forms.Button();
            this.gridV1 = new System.Windows.Forms.DataGridView();
            this.gridV2 = new System.Windows.Forms.DataGridView();
            this.buttonDeshifr = new System.Windows.Forms.Button();
            this.labelKey2 = new System.Windows.Forms.Label();
            this.labelShifr = new System.Windows.Forms.Label();
            this.textGetKey = new System.Windows.Forms.TextBox();
            this.textGetShifr = new System.Windows.Forms.TextBox();
            this.labelDeshifr = new System.Windows.Forms.Label();
            this.textDeShifr = new System.Windows.Forms.TextBox();
            this.labelABC = new System.Windows.Forms.Label();
            this.gridKey = new System.Windows.Forms.DataGridView();
            this.textMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKey1
            // 
            this.labelKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey1.AutoSize = true;
            this.labelKey1.BackColor = System.Drawing.Color.Transparent;
            this.labelKey1.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey1.ForeColor = System.Drawing.Color.Lime;
            this.labelKey1.Location = new System.Drawing.Point(508, 18);
            this.labelKey1.Name = "labelKey1";
            this.labelKey1.Size = new System.Drawing.Size(47, 19);
            this.labelKey1.TabIndex = 75;
            this.labelKey1.Text = "Ключ";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Lime;
            this.labelMessage.Location = new System.Drawing.Point(8, 18);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(160, 19);
            this.labelMessage.TabIndex = 74;
            this.labelMessage.Text = "Исходное сообщение";
            // 
            // textKeyVigin
            // 
            this.textKeyVigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textKeyVigin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textKeyVigin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textKeyVigin.ForeColor = System.Drawing.Color.Lime;
            this.textKeyVigin.Location = new System.Drawing.Point(561, 8);
            this.textKeyVigin.Multiline = true;
            this.textKeyVigin.Name = "textKeyVigin";
            this.textKeyVigin.Size = new System.Drawing.Size(145, 29);
            this.textKeyVigin.TabIndex = 73;
            this.textKeyVigin.TextChanged += new System.EventHandler(this.TextKey_TextChanged);
            // 
            // buttonShifr
            // 
            this.buttonShifr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShifr.BackColor = System.Drawing.Color.Silver;
            this.buttonShifr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShifr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShifr.Location = new System.Drawing.Point(712, 8);
            this.buttonShifr.Name = "buttonShifr";
            this.buttonShifr.Size = new System.Drawing.Size(135, 33);
            this.buttonShifr.TabIndex = 76;
            this.buttonShifr.Text = "Шифровать";
            this.buttonShifr.UseVisualStyleBackColor = false;
            this.buttonShifr.Click += new System.EventHandler(this.ButtonShifr_Click);
            // 
            // gridV1
            // 
            this.gridV1.AllowUserToAddRows = false;
            this.gridV1.AllowUserToDeleteRows = false;
            this.gridV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridV1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridV1.Location = new System.Drawing.Point(15, 54);
            this.gridV1.Name = "gridV1";
            this.gridV1.ReadOnly = true;
            this.gridV1.RowHeadersWidth = 70;
            this.gridV1.Size = new System.Drawing.Size(835, 110);
            this.gridV1.TabIndex = 77;
            // 
            // gridV2
            // 
            this.gridV2.AllowUserToAddRows = false;
            this.gridV2.AllowUserToDeleteRows = false;
            this.gridV2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gridV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridV2.Location = new System.Drawing.Point(15, 260);
            this.gridV2.Name = "gridV2";
            this.gridV2.ReadOnly = true;
            this.gridV2.RowHeadersWidth = 70;
            this.gridV2.Size = new System.Drawing.Size(835, 110);
            this.gridV2.TabIndex = 83;
            // 
            // buttonDeshifr
            // 
            this.buttonDeshifr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeshifr.BackColor = System.Drawing.Color.Silver;
            this.buttonDeshifr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeshifr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeshifr.Location = new System.Drawing.Point(715, 200);
            this.buttonDeshifr.Name = "buttonDeshifr";
            this.buttonDeshifr.Size = new System.Drawing.Size(135, 35);
            this.buttonDeshifr.TabIndex = 82;
            this.buttonDeshifr.Text = "Дешифровать";
            this.buttonDeshifr.UseVisualStyleBackColor = false;
            this.buttonDeshifr.Click += new System.EventHandler(this.ButtonDeShifr_Click);
            // 
            // labelKey2
            // 
            this.labelKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey2.AutoSize = true;
            this.labelKey2.BackColor = System.Drawing.Color.Transparent;
            this.labelKey2.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey2.ForeColor = System.Drawing.Color.Lime;
            this.labelKey2.Location = new System.Drawing.Point(508, 213);
            this.labelKey2.Name = "labelKey2";
            this.labelKey2.Size = new System.Drawing.Size(47, 19);
            this.labelKey2.TabIndex = 81;
            this.labelKey2.Text = "Ключ";
            // 
            // labelShifr
            // 
            this.labelShifr.AutoSize = true;
            this.labelShifr.BackColor = System.Drawing.Color.Transparent;
            this.labelShifr.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifr.ForeColor = System.Drawing.Color.Lime;
            this.labelShifr.Location = new System.Drawing.Point(74, 213);
            this.labelShifr.Name = "labelShifr";
            this.labelShifr.Size = new System.Drawing.Size(84, 19);
            this.labelShifr.TabIndex = 80;
            this.labelShifr.Text = "Шифровка";
            // 
            // textGetKey
            // 
            this.textGetKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textGetKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textGetKey.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGetKey.ForeColor = System.Drawing.Color.Lime;
            this.textGetKey.Location = new System.Drawing.Point(561, 203);
            this.textGetKey.Multiline = true;
            this.textGetKey.Name = "textGetKey";
            this.textGetKey.Size = new System.Drawing.Size(147, 29);
            this.textGetKey.TabIndex = 79;
            // 
            // textGetShifr
            // 
            this.textGetShifr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textGetShifr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textGetShifr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGetShifr.ForeColor = System.Drawing.Color.Lime;
            this.textGetShifr.Location = new System.Drawing.Point(174, 200);
            this.textGetShifr.Multiline = true;
            this.textGetShifr.Name = "textGetShifr";
            this.textGetShifr.Size = new System.Drawing.Size(328, 32);
            this.textGetShifr.TabIndex = 78;
            // 
            // labelDeshifr
            // 
            this.labelDeshifr.AutoSize = true;
            this.labelDeshifr.BackColor = System.Drawing.Color.Transparent;
            this.labelDeshifr.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeshifr.ForeColor = System.Drawing.Color.Lime;
            this.labelDeshifr.Location = new System.Drawing.Point(50, 398);
            this.labelDeshifr.Name = "labelDeshifr";
            this.labelDeshifr.Size = new System.Drawing.Size(108, 19);
            this.labelDeshifr.TabIndex = 85;
            this.labelDeshifr.Text = "Расшифровка";
            // 
            // textDeShifr
            // 
            this.textDeShifr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDeShifr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textDeShifr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDeShifr.ForeColor = System.Drawing.Color.Lime;
            this.textDeShifr.Location = new System.Drawing.Point(174, 385);
            this.textDeShifr.Multiline = true;
            this.textDeShifr.Name = "textDeShifr";
            this.textDeShifr.Size = new System.Drawing.Size(381, 32);
            this.textDeShifr.TabIndex = 84;
            // 
            // labelABC
            // 
            this.labelABC.AutoSize = true;
            this.labelABC.BackColor = System.Drawing.Color.Transparent;
            this.labelABC.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABC.ForeColor = System.Drawing.Color.Lime;
            this.labelABC.Location = new System.Drawing.Point(215, 450);
            this.labelABC.Name = "labelABC";
            this.labelABC.Size = new System.Drawing.Size(445, 19);
            this.labelABC.TabIndex = 86;
            this.labelABC.Text = "Таблица алфавита для шифрования/дешифрования по ключу";
            // 
            // gridKey
            // 
            this.gridKey.AllowUserToDeleteRows = false;
            this.gridKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKey.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gridKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKey.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridKey.Location = new System.Drawing.Point(15, 472);
            this.gridKey.Name = "gridKey";
            this.gridKey.ReadOnly = true;
            this.gridKey.RowHeadersWidth = 70;
            this.gridKey.Size = new System.Drawing.Size(835, 203);
            this.gridKey.TabIndex = 87;
            // 
            // textMessage
            // 
            this.textMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMessage.ForeColor = System.Drawing.Color.Lime;
            this.textMessage.Location = new System.Drawing.Point(174, 8);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(328, 29);
            this.textMessage.TabIndex = 88;
            // 
            // FormViginer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 700);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.gridKey);
            this.Controls.Add(this.labelABC);
            this.Controls.Add(this.labelDeshifr);
            this.Controls.Add(this.textDeShifr);
            this.Controls.Add(this.gridV2);
            this.Controls.Add(this.buttonDeshifr);
            this.Controls.Add(this.labelKey2);
            this.Controls.Add(this.labelShifr);
            this.Controls.Add(this.textGetKey);
            this.Controls.Add(this.textGetShifr);
            this.Controls.Add(this.gridV1);
            this.Controls.Add(this.buttonShifr);
            this.Controls.Add(this.labelKey1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textKeyVigin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(825, 693);
            this.Name = "FormViginer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полиалфавитный Шифр Виженера";
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textKeyVigin;
        private System.Windows.Forms.Button buttonShifr;
        private System.Windows.Forms.DataGridView gridV1;
        private System.Windows.Forms.DataGridView gridV2;
        private System.Windows.Forms.Button buttonDeshifr;
        private System.Windows.Forms.Label labelKey2;
        private System.Windows.Forms.Label labelShifr;
        private System.Windows.Forms.TextBox textGetKey;
        private System.Windows.Forms.TextBox textGetShifr;
        private System.Windows.Forms.Label labelDeshifr;
        private System.Windows.Forms.TextBox textDeShifr;
        private System.Windows.Forms.Label labelABC;
        private System.Windows.Forms.DataGridView gridKey;
        private System.Windows.Forms.TextBox textMessage;
    }
}