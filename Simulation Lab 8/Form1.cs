using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p = 0.55;

        double[] pred = { 0.1, 0.05, 0.15, 0.02, 0.08, 0.1, 0.03, 0.01, 0.05, 0.02, 0.3, 0.09, 0.17, 0.32, 0.02 };
        string[] answer = { 
            "Никаких сомнений", 
            "Определённо да", 
            "Можешь быть уверен в этом", 
            "Вероятнее всего", 
            "Хорошие перспективы", 
            "Да", 
            "Пока не ясно, попробуй снова", 
            "Лучше не рассказывать", 
            "Даже не думай", 
            "Мой ответ — «нет»", 
            "Больше да, чем нет",
            "Перспективы не очень хорошие", 
            "Весьма сомнительно", 
            "Нет ничего невозможного", 
            "Больше нет, чем да"
        };

        double ran;
        Random r = new Random();

        double[] prob;
        double[] freq;
        int N;
        int[] stat;
        private void btAnswer_Click(object sender, EventArgs e)
        {
            tbAnswer.Clear();
            if (tbAsk.Text != String.Empty)
            {
                ran = r.NextDouble();
                if (ran < p) tbAnswer.Text = "Да";
                else tbAnswer.Text = "Нет";
            }
        }

        private void btAnswer2_Click(object sender, EventArgs e)
        {
            tbAnswer2.Clear();
            double sum = 0;
            if (tbAsk2.Text != String.Empty)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum += pred[i];
                    ran = r.NextDouble();
                    if (ran < sum)
                    {
                        tbAnswer2.Text = answer[i];
                        break;
                    }
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            prob = new double[5];
            stat = new int[5];
            freq = new double[5];
            N = (int)edN.Value;
            prob[0] = (double)ed1.Value;
            prob[1] = (double)ed2.Value;
            prob[2] = (double)ed3.Value;
            prob[3] = (double)ed4.Value;
            prob[4] = 1;

            for (int i = 0; i < 4; i++) prob[4] -= prob[i];
            tb5.Text = prob[4].ToString();

            for (int i = 0; i < N; i++)
            {
                ran = r.NextDouble();
                double sum = 0;
                for (int k = 0; k < 5; k++)
                {
                    sum += prob[k];
                    if (ran <= sum)
                    {
                        stat[k]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 5; i++) freq[i] = stat[i] / (double)N;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);

            textBox1.Text = "Вывод: чем больше число испытаний, тем точнее статистические результаты.";
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
