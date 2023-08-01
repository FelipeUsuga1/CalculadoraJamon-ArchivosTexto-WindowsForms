using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using libOpenPunto1;

namespace Punto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lbCantNormal.Text = String.Empty;
            this.lbCantAdicional.Text = String.Empty;
            this.lbTotalJamon.Text = String.Empty;
            this.lbTotalPag.Text = String.Empty;
            //this.grbPagar.Visible = false;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int intDia;
            bool blTipoQuinc, blTipoFest;

            try
            {
                //Captura de info

                intDia = this.cbDia.SelectedIndex + 1;

                blTipoQuinc = Convert.ToBoolean(this.chkQuincena.Checked);
                blTipoFest = Convert.ToBoolean(this.chkFestivo.Checked);

                clsOpenPunto1 cOp = new clsOpenPunto1();

                //Envio de la info
                cOp.diaSem = intDia;
                cOp.tipoQuinc = blTipoQuinc;
                cOp.tipoFest = blTipoFest;

                //Invocacion del metodo y tratamiento del error

                if (!cOp.Calcular())
                {
                    MessageBox.Show(cOp.Error);
                    cOp = null;
                    return;
                }

                //Mostramos la informacion
                this.lbCantNormal.Text = cOp.cantNorm.ToString();
                this.lbCantAdicional.Text = cOp.cantAdicional.ToString();
                this.lbTotalJamon.Text = cOp.totalJamon.ToString();
                this.lbTotalPag.Text = cOp.ValTotalPag.ToString();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
