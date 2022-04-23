using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUni1PedroCazorla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Double total = 0;
            double numero1;
            ConvertirMonedas objeto1 = new ConvertirMonedas();
            numero1 = double.Parse(txtCantidad1.Text);
                        
            if (lista1.Text == "PesoArgentino") 
            {
                if (lista2.Text == "ConvertirMXN")
                {
                    total = objeto1.ARSConvertirMXN(numero1);
                }
                if (lista2.Text == "ConvertirARS")
                {
                    total = objeto1.ARSConvertirARS(numero1);
                }
                if (lista2.Text == "ConvertirBOB") 
                {
                    total = objeto1.ARSConvertirBOB(numero1);
                }
                if (lista2.Text == "ConvertirBRL") 
                {
                    total = objeto1.ARSConvertirBRL(numero1);
                }
                if (lista2.Text == "ConvertirVEF")
                {
                    total = objeto1.ARSConvertirVEF(numero1);
                }
            }

            /*----------------------------------------------------------------------*/

            if (lista1.Text == "Boliviano")
            {
                if (lista2.Text == "ConvertirMXN")
                {
                    total = objeto1.BOBConvertirMXN(numero1);
                }
                if (lista2.Text == "ConvertirARS")
                {
                    total = objeto1.BOBConvertirARS(numero1);
                }
                if (lista2.Text == "ConvertirBOB")
                {
                    total = objeto1.BOBConvertirBOB(numero1);
                }
                if (lista2.Text == "ConvertirBRL") 
                {
                    total = objeto1.BOBConvertirBRL(numero1);
                }
                if (lista2.Text == "ConvertirVEF")
                {
                    total = objeto1.BOBConvertirVEF(numero1);
                }
            }

            /*----------------------------------------------------------------------*/

            if (lista1.Text == "RealBrasileño")
            {
                if (lista2.Text == "ConvertirMXN")
                {
                    total = objeto1.BRLConvertirMXN(numero1);
                }
                if (lista2.Text == "ConvertirARS")
                {
                    total = objeto1.BRLConvertirARS(numero1);
                }
                if (lista2.Text == "ConvertirBOB")
                {
                    total = objeto1.BRLConvertirBOB(numero1);
                }
                if (lista2.Text == "ConvertirBRL") 
                {
                    total = objeto1.BRLConvertirBRL(numero1);
                }
                if (lista2.Text == "ConvertirVEF")
                {
                    total = objeto1.BRLConvertirVEF(numero1);
                }
            }

            /*----------------------------------------------------------------------*/

            if (lista1.Text == "Bolivar")
            {
                if (lista2.Text == "ConvertirMXN")
                {
                    total = objeto1.VEFConvertirMXN(numero1);
                }
                if (lista2.Text == "ConvertirARS")
                {
                    total = objeto1.VEFConvertirARS(numero1);
                }
                if (lista2.Text == "ConvertirBOB")
                {
                    total = objeto1.VEFConvertirBOB(numero1);
                }
                if (lista2.Text == "ConvertirBRL") 
                {
                    total = objeto1.VEFConvertirBRL(numero1);
                }
                if (lista2.Text == "ConvertirVEF")
                {
                    total = objeto1.VEFConvertirVEF(numero1);
                }
            }

            /*----------------------------------------------------------------------*/

            if (lista1.Text == "PesoMexicano")
            {
                if (lista2.Text == "ConvertirMXN")
                {
                    total = objeto1.MXNConvertirMXN(numero1);
                }
                if (lista2.Text == "ConvertirARS")
                {
                    total = objeto1.MXNConvertirARS(numero1);
                }
                if (lista2.Text == "ConvertirBOB")
                {
                    total = objeto1.MXNConvertirBOB(numero1);
                }
                if (lista2.Text == "ConvertirBRL") 
                {
                    total = objeto1.MXNConvertirBRL(numero1);
                }
                if (lista2.Text == "ConvertirVEF")
                {
                    total = objeto1.MXNConvertirVEF(numero1);
                }
            }
            txtConvertir.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad1.Text = " ";
            txtConvertir.Text = " ";
            lista1.Text = " ";
            lista2.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
