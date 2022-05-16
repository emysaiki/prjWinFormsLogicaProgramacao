using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinFormsLogicaProgramacao
{
    public partial class frmMetadeNumero : Form
    {
        public frmMetadeNumero()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            double numero, metadeNumero;
            numero = Convert.ToDouble(txtNumero.Text);
            metadeNumero = numero / 2;
            if (numero > 50) 
            {
                txtResultado.Text = "O número informado é maior que 50 e sua metade é " + metadeNumero;            
            }
            else
            {
                txtResultado.Text = "O número informado não é maior que 50";
            }
        }
    }
}
