using System;
using System.Linq;
using System.Windows.Forms;

namespace Encryption
{
    public partial class FormViginer : Form
    {
        public FormViginer()
        {
            InitializeComponent();
        }
        // Алфавит для шифрования
        readonly string abc = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

//=========================================================================
        /// <summary>
        /// Обработчик кнопки Шифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShifr_Click(object sender, EventArgs e)
        {
            if (textMessage.TextLength == 0)
            { MessageBox.Show("Введите сообщение для зашифровки"); return; }

            if (textKeyVigin.TextLength == 0)
            { MessageBox.Show("Введите ключ"); return; }

            textGetKey.Text = textKeyVigin.Text;

            // проверка на символы, отличные от символов в строке abc
            foreach (var item in textKeyVigin.Text)
            {
                if (!abc.Contains(item))
                {
                    MessageBox.Show("Введены недопустимые символы");
                    return;
                }
            }

            FillKeyTable(textKeyVigin.Text);

            FillGrid();
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения ключевого грида
        /// </summary>
        /// <param name="key">ключ</param>
        void FillKeyTable(string key)
        {
            //Очищаем грид
            gridKey.Columns.Clear();

            gridKey.Rows.Clear();

            //установка  букв алфавита в шапку столбцов таблицы
            for (int i = 0; i < abc.Length; i++)
            {
                gridKey.Columns.Add("col_" + i, abc[i].ToString());
                gridKey.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;   //Отключаем сортировку
            }

            //установка букв ключа в отдельную строку таблицы
            for (int row = 0; row < key.Length; row++)
            {
                gridKey.Rows.Add();

                //Добавляем в заголовок строки букву ключа
                gridKey.Rows[row].HeaderCell.Value = key[row].ToString();

                int p = abc.IndexOf(key[row]);  //В переменную запоминаем смещение относительно алфавита

                if (p < 0) continue;

                for (int col = 0; col < abc.Length; col++)
                {
                    gridKey[col, row].Value = abc[(col + p)% abc.Length].ToString();    //Записываем в грид строку символов алфавита, начиная  со смещения P
                }
            }
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения первого грида
        /// </summary>
        void FillGrid()
        {
            //Очищаем грид
            gridV1.Columns.Clear();

            gridV1.Rows.Clear();

           /*
            * Заполняем грид символами из сообщения
            * Количество столбцов равно количеству букв в сообщении
            */
            // Вынести все циклы в отдельные методы
            for (int col = 0; col < textMessage.TextLength; col++)
            {
                gridV1.Columns.Add("col_" + col, textMessage.Text[col].ToString());

                gridV1.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;// Убираем возможность сортировки
            }

           /*
            * Заполняем строку грида символами из ключа 
            * под соответствующими символами из сообщения 
            */
            gridV1.Rows.Add();

            gridV1.Rows[0].HeaderCell.Value = "Ключ: "; //Создаем заголовочный столбец

            for (int col = 0; col < textMessage.TextLength; col++)
            {
                //Номеру строки присваиваем 0, т.е. строка не будет меняться в цикле
                gridV1[col, 0].Value = textKeyVigin.Text[col % textKeyVigin.TextLength].ToString(); 
            }

            // Добавляем строку, в которую будет записываться шифр
            gridV1.Rows.Add();

            gridV1.Rows[1].HeaderCell.Value = "Шифр: ";

            string shifr = null;    //Строка для формирования шифрованного сообщения

            char letter;            //Переменная для хранения текущего символа шифра

            for (int col = 0; col < textMessage.TextLength; col++)
            {

                //Проверяем, содержится ли буква сообщения в нашем алфавите
                if (abc.Contains(textMessage.Text[col]))
                {
                    /*
                     * Нужный зашифрованный символ находится
                     * на пересечении символов ключа и сообщения
                     * в ключевом гриде
                     */
                    letter = Convert.ToChar(gridKey[abc.IndexOf(textMessage.Text[col]),       // Из нашего алфавита получаем индекс текущего символа - получаем столбец
                                            col % textKeyVigin.TextLength].Value.ToString()); 
                }
                else
                    // Если в нашем алфавите отсутствует символ из сообщения, то добавляем его как есть
                    letter = Convert.ToChar(textMessage.Text[col].ToString());

                // Добавляем шифрованный символ в грид
                gridV1[col, 1].Value = letter;
                
                // Формируем строку с шифром
                shifr += letter;
            }

            // Помещаем шифр в текстовое поле
            textGetShifr.Text = shifr;
        }

//=========================================================================
        /// <summary>
        /// Метод для конвертайии вводимых символов в ерхней регистр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextKey_TextChanged(object sender, EventArgs e)
        {
            textKeyVigin.Text.ToUpper();
        }

//=========================================================================
        /// <summary>
        /// Обработчик кнопки дешифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeShifr_Click(object sender, EventArgs e)
        {
            if (textGetShifr.Text == null)
            { MessageBox.Show("Введите сообщение для дешифровки"); return; }

            if (textGetKey.Text == null)
            { MessageBox.Show("Введите ключ"); return; }

            FillKeyTable(textGetKey.Text);

            FillGrid2();
        }

//=========================================================================
        /// <summary>
        /// Метод для заполнения второго грида
        /// </summary>
        void FillGrid2()
        {

            gridV2.Columns.Clear();

            gridV2.Rows.Clear();

            //Вынести в отдельный метод
            for (int col = 0; col < textGetShifr.TextLength; col++)
            {
                gridV2.Columns.Add("col_" + col, textGetShifr.Text[col].ToString());

                gridV2.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            try
            {
                gridV2.Rows.Add();

                gridV2.Rows[0].HeaderCell.Value = "Ключ: ";

                for (int col = 0; col < textGetShifr.TextLength; col++)
                {
                    gridV2[col, 0].Value = textGetKey.Text[col % textGetKey.TextLength].ToString();
                }

                gridV2.Rows.Add();

                gridV2.Rows[1].HeaderCell.Value = "Текст: ";

                string deshifr = null;

                string letter = null;

                for (int col = 0; col < textMessage.TextLength; col++)
                {
                    if (abc.Contains(textGetShifr.Text[col]))
                    {
                        for (int k = 0; k < abc.Length; k++)
                            if (gridKey[k, col % textGetKey.TextLength].Value.ToString() == textGetShifr.Text[col].ToString())
                            {
                                letter = abc[k].ToString();

                                break;
                            }
                    }
                    else
                        letter = textGetShifr.Text[col].ToString();

                    gridV2[col, 1].Value = letter;

                    deshifr += letter;
                }

                textDeShifr.Text = deshifr;
            }
            catch (Exception ex)
            {
                MessageBox.Show( Convert.ToString(ex));
            }
        }
    }
}
