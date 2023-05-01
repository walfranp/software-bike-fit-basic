using BikeFitBasic.Models;
using BikeFitBasic.Relatorio;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BikeFitBasic
{
    public partial class FormRelatorioFit : Form
    {
        public FormRelatorioFit(Ciclista ciclista, string tamanhoQuadro, string alturaCelimPedivela, string pedivelaPontaCelim, string alturaGuidaoBanco, string distanciaGuidaoCelim)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource = "BikeFitBasic.Relatorio.ReportFit.rdlc";
            ReportParameter nome = new ReportParameter("Nome", ciclista.Nome);
            reportViewer1.LocalReport.SetParameters(nome);
            ReportParameter data = new ReportParameter("Data", ciclista.Data.ToString());
            reportViewer1.LocalReport.SetParameters(data);
            ReportParameter medidaCavalo = new ReportParameter("MedidaCavalo", ciclista.MedidaCavalo.ToString() + " cm");
            reportViewer1.LocalReport.SetParameters(medidaCavalo);
            ReportParameter medidaAntiBraco = new ReportParameter("MedidaAntiBraco", ciclista.MedidaAntebraco.ToString() + " cm");
            reportViewer1.LocalReport.SetParameters(medidaAntiBraco);
            ReportParameter nivelFlexibilidade = new ReportParameter("NivelFlexibilidade", ciclista.NivelFlexibilidade.ToString());
            reportViewer1.LocalReport.SetParameters(nivelFlexibilidade);
            ReportParameter ptamanhoQuadro = new ReportParameter("TamanhoQuadro", tamanhoQuadro + " cm");
            reportViewer1.LocalReport.SetParameters(ptamanhoQuadro);
            ReportParameter palturaCelimPedivela = new ReportParameter("AlturaCelimPedivela", alturaCelimPedivela + " cm");
            reportViewer1.LocalReport.SetParameters(palturaCelimPedivela);
            ReportParameter ppedivelaPontaCelim = new ReportParameter("PedivelaPontaCelim", pedivelaPontaCelim + " cm");
            reportViewer1.LocalReport.SetParameters(ppedivelaPontaCelim);
            ReportParameter palturaGuidaoBanco = new ReportParameter("AlturaGuidaoBanco", alturaGuidaoBanco + " cm");
            reportViewer1.LocalReport.SetParameters(palturaGuidaoBanco);
            ReportParameter pdistanciaGuidaoCelim = new ReportParameter("DistanciaGuidaoCelim", distanciaGuidaoCelim + " cm");
            reportViewer1.LocalReport.SetParameters(pdistanciaGuidaoCelim);

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout); reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            Cursor = Cursors.Default;
            reportViewer1.RefreshReport();

        }

        private void FormRelatorioFit_Load(object sender, EventArgs e)
        {

        }
    }
}
