using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void mostra()
        {
            label1.Text = Math.Abs(valor).ToString();
            if (valor < 0) minus.Visible = false;
            else minus.Visible = true;
        }
        private void Clicar(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button0": valor = valor * 10 + 0; break;
                case "button1": valor = valor * 10 + 1; break;
                case "button2": valor = valor * 10 + 2; break;
                case "button3": valor = valor * 10 + 3; break;
                case "button4": valor = valor * 10 + 4; break;
                case "button5": valor = valor * 10 + 5; break;
                case "button6": valor = valor * 10 + 6; break;
                case "button7": valor = valor * 10 + 7; break;
                case "button8": valor = valor * 10 + 8; break;
                case "button9": valor = valor * 10 + 9; break;
                case "C": valor = 0; break;
                case "CE": valor = 0; break;
                case "MaisMenos": valor = -valor; break;
            }
            mostra();
        }
    }
}
