using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encryption
{
    public partial class FormViginerPerestan : Form
    {
        public FormViginerPerestan()
        {
            InitializeComponent();
        }

//================================================================================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShifr_Click(object sender, EventArgs e)
        {
            string err = CheckDataError();
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            } 
            
            FillGrid1();

            //Помещаем отсортированный по алфавиту ключ в текстовое поле
            textKeyABC.Text = GetABC(textKey.Text);

            FillGrid2();

            // В текстовое поле помещаем сформированную шифрованную строку
            textShifr.Text = Shifr();

            textGetShifr.Text = textShifr.Text;

        }

//================================================================================================================================
        /// <summary>
        /// Метод для проверки входных данных
        /// </summary>
        /// <returns></returns>
        private string CheckDataError()
        {
            if (textMessage.Text == string.Empty)
            {
                return "Введите сообщение для зашифровки";
            }

            if (IsEqualsLetters(textKey.Text))
            {
               return "В ключе не должны повторяться символы!!!";
            }

            return "";
        }

//================================================================================================================================
        /// <summary>
        /// Метод для проверки одинаковых символов в ключе
        /// </summary>
        /// <param name="text">Ключ</param>
        /// <returns></returns>
        private bool IsEqualsLetters(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i + 1).IndexOf(text[i]) >= 0)
                    return true;
            }
            return false;
        }

 //================================================================================================================================
        /// <summary>
        /// Обработчик кнопки расшифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeShifr_Click(object sender, EventArgs e)
        {
            if (textGetKey.Text == string.Empty || textGetShifr.Text == string.Empty)
            {
                MessageBox.Show("Введите данные для расшифровки");
                return;
            }
            //Помещаем отсортированный по алфавиту ключ в текстовое поле
            textGetKeyABC.Text = GetABC(textGetKey.Text);

            FillGrid3();

            FillGrid4();

            //записываем расшифрованное сообщение в тестовое поле и удаляем лишние символы вконце
            textGetMessage.Text = Deshifr().TrimEnd('.');
            MessageBox.Show("Расшифрованное сообщение: " + textGetMessage.Text);

            try
            {
                grid4.Rows.Clear();
                grid4.Rows.Add(grid3.Rows.Count);
            }
            catch (Exception)
            {
                MessageBox.Show("Без ключа не получиться дешифровать!");
            }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для заполнения первого грида
        /// </summary>
        private void FillGrid1()
        {
           
            //Очищаем грид
            grid1.Columns.Clear();

            grid1.Rows.Clear();

            try
            {
                AddColumns(grid1, textKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите ключ!!");
            }

            int cols = textKey.TextLength;

            //Вычисляем количество строк
            int rows = textMessage.TextLength / cols;

            if (textMessage.TextLength % cols > 0)
            {
                rows++;
            }

            grid1.Rows.Add(rows);

            int row = 0; //нулевая строка

            int col = 0; //нулевой столбец

            for (int j = 0; j < textMessage.TextLength; j++)
            {
                col = j % cols; // вычисляем номер мтолбца
                row = j / cols; //вычисляем номер строки
                grid1[col, row].Value = textMessage.Text[j];
            }

            //Добавляем точки в конец, если длина сообщения не кратна длине ключа
            for (col++; col < textKey.TextLength; col++)
            {
                grid1[col, row].Value = '.';
            }

        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования второго грида
        /// </summary>
        private void FillGrid2()
        {

            AddColumns(grid2, textKeyABC.Text);

            try
            {
                grid2.Rows.Clear();
                grid2.Rows.Add(grid1.RowCount); //Добавляем такое же количество строк. как в первом гриде
            }
            catch (Exception)
            {
                MessageBox.Show("Введите текст!");
            }
            //установка алфавитного ключа в грид
            //Заполнение грида по  столбцу
            for (int columnIndex = 0; columnIndex < textKeyABC.TextLength; columnIndex++)
                // Заполнение грида по-строчно
                for (int rowIndex = 0; rowIndex < grid1.RowCount; rowIndex++)
                {
                    // В  ячейку грида записываем соответствующее значение для данного символа из первого грида
                    int colABC = textKey.Text.IndexOf(textKeyABC.Text[columnIndex]);
                    grid2[columnIndex, rowIndex].Value = grid1[colABC, rowIndex].Value;
                }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования третьего грида
        /// </summary>
        private void FillGrid3()
        {        
            AddColumns(grid3, textGetKeyABC.Text);
           
            grid3.Rows.Clear();

            int position = 0;

            int rows = 0;

            // Высчитываем количество строк
            if (textGetKey.TextLength != 0 && textGetShifr.TextLength != 0)
            {
                rows = textGetShifr.TextLength / textGetKey.TextLength;
            }
            else return;

            //Добавляем полученное количество строк в грид
            grid3.Rows.Add(rows);


            //Для каждого символа ключа в гриде добавляем новый столбец
            for (int col = 0; col < textGetKey.TextLength; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    // Шифрованное сообщение посимвольно добавляем в грид
                    grid3[col, row].Value = textGetShifr.Text.Substring(position++, 1);
                }
            }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования четвертого грида
        /// </summary>
        private void FillGrid4()
        {
            AddColumns(grid4, textGetKey.Text);

            grid4.Rows.Clear();

            //добавляем количество строк равное числу строк в третьем гриде
            grid4.Rows.Add(grid3.Rows.Count);

            
            for (int col = 0; col < textGetKeyABC.TextLength; col++)
            {
                for (int row = 0; row < grid4.Rows.Count; row++)
                {
                    int colABC = textGetKeyABC.Text.IndexOf(textGetKey.Text[col]);// запоминаем номер столбца в переменную colABC
                        grid4[col, row].Value = grid3[colABC, row].Value;
                }
            }
           
        }

 //================================================================================================================================
        /// <summary>
        /// Метод для формирования расшифрованного сообщения в строку
        /// </summary>
        /// <returns></returns>
        private string Deshifr()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < grid4.RowCount; row++)
                for (int col = 0; col < textGetKeyABC.TextLength; col++)
                {
                    sb.Append(grid4[col, row].Value);
                }
            return sb.ToString();
        }

//================================================================================================================================
        /// <summary>
        /// Метод для добавления строк
        /// </summary>
        /// <param name="grid">сетка</param>
        /// <param name="letters">строка, из которой формируеются заголовки столбцов в гриде</param>
        private void AddColumns(DataGridView grid, string letters)
        {
            grid.Columns.Clear();

            for (int j = 0; j < letters.Length; j++)
            {
                grid.Columns.Add("", letters[j].ToString());
                grid.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable; //запретить сортировку в гриде по столбцам
            }
        }

//================================================================================================================================
        /// <summary>
        /// Метод для сортировки ключа по алфавиту
        /// </summary>
        /// <param name="text">ключ</param>
        /// <returns></returns>
        private string GetABC(string text)
        {
            char[] ch = text.ToCharArray(); // Переводим сообщение в массив символов
            Array.Sort(ch); //Делаем сортировку массива
            return new string(ch);   //Конвертируем в строку и возвращаем
        }

//================================================================================================================================
        /// <summary>
        /// Метод для формирования шифра
        /// </summary>
        /// <returns>возвращаем сформированную строку</returns>
        private string Shifr()
        {
            //формируем строку
            // Обход двухмерного массива с записью значений в переменную strShifr
            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < grid2.ColumnCount; col++)
                for (int row = 0; row < grid2.RowCount; row++)
                {
                    sb.Append(grid2[col, row].Value);
                }

                    return sb.ToString();
        }

//================================================================================================================================
        private void NewCryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViginer form2 = new FormViginer();
            form2.Show();
        }

        private void PerestanovkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            textKey.Text.ToUpper();
        }

        private void RSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAShifr form3 = new RSAShifr();
            form3.Show();
        }

        private void ViginerThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViginerThread form4 = new FormViginerThread();
            form4.Show();
        }

        private void DiffiHelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DH_KeysChange form5 = new DH_KeysChange();
            form5.Show();
        }
    }
}
