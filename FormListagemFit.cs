using BikeFitBasic.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
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
    public partial class FormListagemFit : Form
    {
        FormPrincipal _frmPrincipal;
        public FormListagemFit(FormPrincipal frm)
        {
            InitializeComponent();
            _frmPrincipal = frm;
        }

        private void btnCancelaFit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void preencherDataTable()
        {
            BikeFitBasicContext db = new BikeFitBasicContext();
            dataGridViewFit.DataSource = db.Ciclistas.ToList();
        }

        private void FormListagemFit_Load(object sender, EventArgs e)
        {
            preencherDataTable();
        }

        private void buscaFitByNomeCiclista(string nome)
        {
            using (BikeFitBasicContext db = new BikeFitBasicContext())
            {
                dataGridViewFit.DataSource = db.Ciclistas.Where(obj => obj.Nome.Contains(nome)).ToList();
            }

        }

        private void dataGridViewFit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewFit.Columns.Remove(dataGridViewFit.Columns["MedidaCavalo"]);
            dataGridViewFit.Columns.Remove(dataGridViewFit.Columns["MedidaAntebraco"]);
            dataGridViewFit.Columns.Remove(dataGridViewFit.Columns["NivelFlexibilidade"]);

            dataGridViewFit.Columns["btnEditarFit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFit.Columns["btnVisualizarFit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridViewFit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.btnVisualizarFit.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dataGridViewFit.Rows[e.RowIndex];

                Ciclista? ciclista = currentRow.DataBoundItem as Ciclista;
                // mostra o form...
                _frmPrincipal.visualizarFit(ciclista);

            }

            if (e.ColumnIndex == this.btnEditarFit.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dataGridViewFit.Rows[e.RowIndex];

                Ciclista? ciclista = currentRow.DataBoundItem as Ciclista;
                // mostra o form...
                _frmPrincipal.editarFit(ciclista);
                this.Close();

            }

            if (e.ColumnIndex == this.btnExcluir.Index && e.RowIndex >= 0)
            {
                // pega a linha atual...
                DataGridViewRow currentRow = this.dataGridViewFit.Rows[e.RowIndex];

                Ciclista? ciclista = currentRow.DataBoundItem as Ciclista;

                DialogResult dialogResult = MessageBox.Show("Excluir o Fit do ciclista: " + ciclista.Nome + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    using (BikeFitBasicContext db = new BikeFitBasicContext())
                    {
                        db.Ciclistas.Attach(ciclista);
                        db.Ciclistas.Entry(ciclista).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    preencherDataTable();
                }
            }
        }

        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {
            buscaFitByNomeCiclista(textBoxBusca.Text);
        }
    }
}
