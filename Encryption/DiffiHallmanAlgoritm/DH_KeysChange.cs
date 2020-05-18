using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class DH_KeysChange : Form
    {

        static Random rand = new Random();
        long maxPrime = 999;
        long minPrime = 100;
        long p;
        long g;
        long X;
        long Y;

        public DH_KeysChange()
        {
            InitializeComponent();
        }

        //========================================
        /// <summary>
        /// Метод для нахождения числа по модулю p
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="b">Степень</param>
        /// <returns></returns>
        long MultMod(long a, long b)
        {
            return (a * b) % p;
        }

        //========================================
        /// <summary>
        /// Метод для возведения в степень
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="exp">Степень</param>
        /// <returns></returns>
        public long Powermod(long a, long exp)
        {
            long result = 1;
            for (long i = 0; i < exp; i++)
            {
                result = MultMod(result, a);
            }
            return result;
        }

        //========================================
        /// <summary>
        /// Метод, проверяющий простое число или нет
        /// </summary>
        /// <param name="num">заданное число</param>
        /// <returns></returns>
        bool IsPrime(long num)
        {
            if (num < 2) return false;
            if (num == 2 || num == 3) return true;
            if (num % 2 == 0) return false;
            long max = Convert.ToInt64(Math.Sqrt(num));
            for (int i = 3; i <= max; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        //========================================
        /// <summary>
        /// Метод для считывания значений P и G из текстовых полей
        /// </summary>
        void GetPG()
        {
            p = Convert.ToInt32(textP.Text);
            g = Convert.ToInt32(textG.Text);
        }

        //========================================
        private void Label7_Click(object sender, EventArgs e)
        {
           toolTip1.SetToolTip(label7, "X = G^A mod P");
        }

        //========================================
        private void Label8_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label8, "Y = G^B mod P");
        }

        //========================================
        private void Label9_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label9, "keyX = Y^А mod P = G^B^A mod P");
        }

        //========================================
        private void Label10_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label10, "keyY = X^B mod P = G^A^B mod P");
        }

        //========================================
        /// <summary>
        /// Метод для генерации простого числа P
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButP_Click(object sender, EventArgs e)
        {
            p = rand.Next((int)minPrime, (int)maxPrime);
            while (!IsPrime(p))
            {
                p++;
            }
            textP.Text = p.ToString();
        }
        //========================================
        /// <summary>
        /// Метод для генерации простого числа G
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButG_Click(object sender, EventArgs e)
        {
          g = rand.Next(2, (int)p);
          textG.Text = g.ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генерации секретного числа A абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenerateA_Click(object sender, EventArgs e)
        {
            GetPG();
            textA.Text = rand.Next(2, (int)p).ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генерации секретного числа B абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenetateB_Click(object sender, EventArgs e)
        {
            GetPG();
            textB.Text = rand.Next(2, (int)p).ToString();
        }

        //========================================
        /// <summary>
        /// Метод для генераци общего секретного ключа Абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButKeyA_Click(object sender, EventArgs e)
        {
            GetPG();
            long AKey = Powermod(Y, Convert.ToInt32(textA.Text));
            textKeyA.Text = Convert.ToString(AKey);
        }

        //========================================
        /// <summary>
        /// Метод для генераци общего секретного ключа Абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButKeyB_Click(object sender, EventArgs e)
        {
            GetPG();
            long BKey = Powermod(X, Convert.ToInt32(textB.Text));
            textKeyB.Text = Convert.ToString(BKey);

        }

        //========================================
        /// <summary>
        /// Метод для расчета числа для отправки Абонента 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenX_Click(object sender, EventArgs e)
        {
            GetPG();
            X = Powermod(g, Convert.ToInt32(textA.Text));
            textX.Text = Convert.ToString(X);
        }

        //========================================
        /// <summary>
        /// Метод для расчета числа для отправки Абонента 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButGenY_Click(object sender, EventArgs e)
        {
            GetPG();
            Y = Powermod(g, Convert.ToInt32(textB.Text));
            textY.Text = Convert.ToString(Y);
        }

        //========================================
        /// <summary>
        /// Установка начальных значений  P и G
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DH_KeysChange_Load(object sender, EventArgs e)
        {
            //начальные значения по умолчанию
            textP.Text = 43.ToString();
            textG.Text = 17.ToString();
        }
    }
}
