using BikeFitBasic.Models;
using BikeFitBasic.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeFitBasic
{
    public partial class FormFit : Form
    {
        Ciclista _ciclista;
        public FormFit(Ciclista ciclista)
        {
            InitializeComponent();
            _ciclista = ciclista;

            PreenchaDadosEcalculaFIT();
        }

        private void btnCancelaFit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PreenchaDadosEcalculaFIT()
        {
            calculaTamanhoDoQadroDaBike();
            calculaAlturaDoCelim();
            calculaRecuoCentroPedivelaPontaCelim();
            calculaAlturaGuidaoEBanco();
            calculaDistanciaGuidaoCelim();
            lblNomeCiclista.Text = _ciclista.Nome;
            lblDataFit.Text = _ciclista.Data.ToString();

        }

        public void calculaTamanhoDoQadroDaBike()
        {
            //medida do cavalo * 0,22 = tamanho do quadro em polegadas
            //medida do cavalo * 0,22 * 2,54 = tamanho do quadro em centimetros

            lblTamanhoQuadro.Text = Convert.ToString(Math.Round(_ciclista.MedidaCavalo * 0.22 * 2.54, 1));
        }

        public void calculaAlturaDoCelim()
        {
            //medida do cavalo * 0,889 = alura do celim até o centro do pé de vela
            lblAlturaCelimPedivela.Text = Convert.ToString(Math.Round(_ciclista.MedidaCavalo * 0.889, 1));
        }

        public void calculaRecuoCentroPedivelaPontaCelim()
        {
            //medida do cavalo - 76,5 / 4 + 6 = Recuo entre o centro do Pedivela e a ponta do Selim
            lblPedivelaPontaCelim.Text = Convert.ToString(Math.Round((_ciclista.MedidaCavalo - 76.5) / 4 + 6, 1));
        }

        public void calculaAlturaGuidaoEBanco()
        {
            //medida do cavalo - 76,5 / 4 + 5,5 = diferença de altura entre guidão e banco
            lblAlturaGuidaoBanco.Text = Convert.ToString(Math.Round((_ciclista.MedidaCavalo - 76.5) / 4 + 5.5, 1));
        }

        public void calculaDistanciaGuidaoCelim()
        {
            double result01 = _ciclista.MedidaAntebraco + 5.7;
            double result02 = (_ciclista.NivelFlexibilidade - 5) * 4;
            double result03 = result02 / 10;

            lblDistanciaGuidaoCelim.Text = Convert.ToString(Math.Round(result01 + result03, 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;    
            FormRelatorioFit frmRel = new FormRelatorioFit(_ciclista, lblTamanhoQuadro.Text, lblAlturaCelimPedivela.Text, lblPedivelaPontaCelim.Text, lblAlturaGuidaoBanco.Text, lblDistanciaGuidaoCelim.Text);
            frmRel.ShowDialog();
            Cursor = Cursors.Default;
        }
    }
}
