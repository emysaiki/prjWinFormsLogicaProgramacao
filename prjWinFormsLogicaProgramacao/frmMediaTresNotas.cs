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
    public partial class frmMediaTresNotas : Form
    {
        public frmMediaTresNotas()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, mediaFinal;
            //Console.WriteLine("Entre com a 1ª nota");
            //nota1 = Convert.ToDouble(Console.ReadLine());
            nota1 = Convert.ToDouble(txtNota1.Text);
            //Console.WriteLine("Entre com a 2ª nota");
            //nota2 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(txtNota2.Text);
            //Console.WriteLine("Entre com a 3ª nota");
            //nota3 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(txtNota3.Text);
            mediaFinal = (nota1 + nota2 + nota3) / 3;
            if (mediaFinal > 6)
            {
                txtResultado.Text="O aluno está aprovado";
            }
            else
            {
                txtResultado.Text="O aluno está reprovado";
            }
        }
    }
}
