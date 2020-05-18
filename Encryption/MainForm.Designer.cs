namespace Encryption
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shifrViginerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shifrViginerThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shifrViginerPolyABCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffiHallmanAlgotihmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shifrViginerToolStripMenuItem,
            this.shifrViginerThreadToolStripMenuItem,
            this.shifrViginerPolyABCToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.diffiHallmanAlgotihmToolStripMenuItem,
            this.newToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createToolStripMenuItem.Text = "Open Algorithm Encrypting";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // shifrViginerToolStripMenuItem
            // 
            this.shifrViginerToolStripMenuItem.Name = "shifrViginerToolStripMenuItem";
            this.shifrViginerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.shifrViginerToolStripMenuItem.Text = "Shifr Viginer";
            this.shifrViginerToolStripMenuItem.Click += new System.EventHandler(this.ShifrViginerToolStripMenuItem_Click);
            // 
            // shifrViginerThreadToolStripMenuItem
            // 
            this.shifrViginerThreadToolStripMenuItem.Name = "shifrViginerThreadToolStripMenuItem";
            this.shifrViginerThreadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.shifrViginerThreadToolStripMenuItem.Text = "Shifr Viginer Thread";
            this.shifrViginerThreadToolStripMenuItem.Click += new System.EventHandler(this.ShifrViginerThreadToolStripMenuItem_Click);
            // 
            // shifrViginerPolyABCToolStripMenuItem
            // 
            this.shifrViginerPolyABCToolStripMenuItem.Name = "shifrViginerPolyABCToolStripMenuItem";
            this.shifrViginerPolyABCToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.shifrViginerPolyABCToolStripMenuItem.Text = "Shifr Viginer PolyABC";
            this.shifrViginerPolyABCToolStripMenuItem.Click += new System.EventHandler(this.ShifrViginerPolyABCToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.RSAToolStripMenuItem_Click);
            // 
            // diffiHallmanAlgotihmToolStripMenuItem
            // 
            this.diffiHallmanAlgotihmToolStripMenuItem.Name = "diffiHallmanAlgotihmToolStripMenuItem";
            this.diffiHallmanAlgotihmToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.diffiHallmanAlgotihmToolStripMenuItem.Text = "Diffi Hallman Algotihm";
            this.diffiHallmanAlgotihmToolStripMenuItem.Click += new System.EventHandler(this.DiffiHallmanAlgotihmToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.closeToolStripMenuItem.Text = "Close Form";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openFileToolStripMenuItem.Text = "OpenFile";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveFileToolStripMenuItem.Text = "SaveFile";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowLayoutToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // windowLayoutToolStripMenuItem
            // 
            this.windowLayoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.verticaiToolStripMenuItem});
            this.windowLayoutToolStripMenuItem.Name = "windowLayoutToolStripMenuItem";
            this.windowLayoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.windowLayoutToolStripMenuItem.Text = "window layout";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // verticaiToolStripMenuItem
            // 
            this.verticaiToolStripMenuItem.Name = "verticaiToolStripMenuItem";
            this.verticaiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.verticaiToolStripMenuItem.Text = "Verticai";
            this.verticaiToolStripMenuItem.Click += new System.EventHandler(this.VerticaiToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "начальная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ContextMenuStripChanged += new System.EventHandler(this.InsertToolStripMenuItem_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shifrViginerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shifrViginerThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffiHallmanAlgotihmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shifrViginerPolyABCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}