using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraAPP
{
    
    public partial class MainPage : ContentPage
    {
        private double valor01;
        private double valor02;
        private string op;
        private double resultado;

        public MainPage()
        {           
            InitializeComponent();
        }      

        private void Button7_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "9";
        }

        private void ButtonSoma_Clicked(object sender, EventArgs e)
        {
            //this para dizer que a variável Valor faz parte da MainPage
            this.valor01 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.op = "SOMAR";
            
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "6";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "5";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "4";
        }

        private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
        {

            //this para dizer que a variável Valor faz parte da MainPage
            this.valor01 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.op = "MULTIPLICAR";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "3";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "2";
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "1";
        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {
            this.valor01 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.op = "SUBTRAIR";
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "0";
        }

        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            entryValor.Text = "";
        }

        private void ButtonResultado_Clicked(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            this.valor02 = Convert.ToDouble(entryValor.Text);

            switch (this.op)
            {
                case "SOMAR":       
                    entryValor.Text = calc.Somar(this.valor01, this.valor02).ToString();
                    break;

                case "SUBTRAÇÃO":
                    entryValor.Text = calc.Subtrair(this.valor01, this.valor02).ToString();
                    break;

                case "DIVIDIR":
                    entryValor.Text = calc.Dividir(this.valor01, this.valor02).ToString();
                    break;

                case "MULTIPLICAR":
                    entryValor.Text = calc.Multiplicar(this.valor01, this.valor02).ToString();
                    break;

                default:
                    DisplayAlert("Ops...", "A Calcullum falhou!\n Tente novamente :)", "Beleza!");
                    break;
            }
          
        }

        private void ButtonDividir_Clicked(object sender, EventArgs e)
        {
            this.valor01 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.op = "DIVIDIR";
        }
    }
}
