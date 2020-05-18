using System;
using System.IO;
using System.Windows.Forms;

namespace Encryption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание дочерних форм
        }


        //-----------------------Работа с меню--------------------------------------

        //-----------------------Открытие файла-------------------------------------
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogMainForm = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialogMainForm.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialogMainForm.FileName;
                _ = File.ReadAllText(filename);
            }
        }

        //-----------------------Сохранение файла-------------------------------------
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formActive = ActiveMdiChild;

            // создаем каталог для файла
            string path = @"D:\Shipelov\Shifr";

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (formActive != null && !dirInfo.Exists) // если дочерняя форма есть, то
            {
                try
                {
                    dirInfo.Create();

                    TextBox textBox = (TextBox)formActive.ActiveControl; //  возвращает активный элемент на  Форме
                                                                         
                    // запись в файл Shifr.txt
                    using (StreamWriter sw = new StreamWriter($"{path}/Shifr.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(textBox.Text);
                        MessageBox.Show("Запись в файл успешно совершена!");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Копировать нечего");
                }
            }
        }

        //===================================================================================
        private void DiffiHallmanAlgotihmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DH_KeysChange dh = new DH_KeysChange
            {
                MdiParent = this
            };
            dh.Show();
        }

        //===================================================================================
        private void ShifrViginerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViginerPerestan fe = new FormViginerPerestan
            {
                MdiParent = this
            };
            fe.Show();
        }

        //===================================================================================
        private void ShifrViginerThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViginerThread fvt = new FormViginerThread
            {
                MdiParent = this
            };
            fvt.Show();
        }

        //===================================================================================
        private void ShifrViginerPolyABCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViginer fv = new FormViginer
            {
                MdiParent = this
            };
            fv.Show();
        }

        //===================================================================================
        private void RSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAShifr rSA = new RSAShifr
            {
                MdiParent = this
            };
            rSA.Show();

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeform = this.ActiveMdiChild; // возвращает активную  
                                                   //дочернюю форму

            if (activeform != null)       // если она открыта

                activeform.Close();     // то закрываем ее  
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formActive = ActiveMdiChild;
            if (formActive != null)
            {
                try
                {
                    TextBox theBox = (TextBox)formActive.ActiveControl;
                    if (theBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.Text))
                            theBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                    }
                }

                catch
                {
                    MessageBox.Show("некуда вставлять");
                }
            }

        }

        protected void CascadWindow_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);

        }

        protected void VerticalWindow_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CascadWindow_Click(sender, e);
        }

        private void VerticaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerticalWindow_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
