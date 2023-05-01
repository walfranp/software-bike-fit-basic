using BikeFitBasic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeFitBasic
{
    public partial class FormNovoFit : Form
    {
        FormPrincipal _frmPrincipal;
        Ciclista _ciclista;
        bool _alteracao;
        public FormNovoFit(FormPrincipal frm, Ciclista ciclista, bool alteracao)
        {
            InitializeComponent();
            _frmPrincipal = frm;
            _ciclista = ciclista;
            _alteracao = alteracao;

            if(alteracao)
            {
                preencheDadosCiclista();
            }
        }

        private void btnCancelaFit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preencheDadosCiclista()
        {
            txt_NomeCiclista.Text = _ciclista.Nome;
            dt_DataFif.Value = _ciclista.Data;
            ud_MedidaCavalo.Value = _ciclista.MedidaCavalo;
            ud_MedidaAnteBraco.Value = _ciclista.MedidaAntebraco;
            ud_NivelFlexibilidade.Value = _ciclista.NivelFlexibilidade;
        }

        private bool validaCampos()
        {
            if ((txt_NomeCiclista.Text != "") && (ud_MedidaCavalo.Value != 0) && (ud_MedidaAnteBraco.Value != 0) && (ud_NivelFlexibilidade.Value != 0))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        private void btnGravarFit_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {

                using (var db = new BikeFitBasicContext())
                {
                    this.Cursor = Cursors.WaitCursor;

                    if (!_alteracao)
                    {
                        _ciclista.Nome = txt_NomeCiclista.Text;
                        _ciclista.Data = dt_DataFif.Value;
                        _ciclista.MedidaCavalo = Convert.ToInt32(ud_MedidaCavalo.Value);
                        _ciclista.MedidaAntebraco = Convert.ToInt32(ud_MedidaAnteBraco.Value);
                        _ciclista.NivelFlexibilidade = Convert.ToInt32(ud_NivelFlexibilidade.Value);

                        db.Ciclistas.Add(_ciclista);
                        db.SaveChanges();
                    }
                    else
                    {
                        _ciclista.Nome = txt_NomeCiclista.Text;
                        _ciclista.Data = dt_DataFif.Value;
                        _ciclista.MedidaCavalo = Convert.ToInt32(ud_MedidaCavalo.Value);
                        _ciclista.MedidaAntebraco = Convert.ToInt32(ud_MedidaAnteBraco.Value);
                        _ciclista.NivelFlexibilidade = Convert.ToInt32(ud_NivelFlexibilidade.Value);

                        db.Ciclistas.Attach(_ciclista);
                        db.Entry(_ciclista).State = EntityState.Modified;
                        db.SaveChanges();
                    }


                    this.Cursor = Cursors.Default;
                }

                //_ciclista.Nome = txt_NomeCiclista.Text;
                //_ciclista.Data = dt_DataFif.Value;
                //_ciclista.MedidaCavalo = Convert.ToInt32(ud_MedidaCavalo.Value);
                //_ciclista.MedidaAntebraco = Convert.ToInt32(ud_MedidaAnteBraco.Value);
                //_ciclista.NivelFlexibilidade = Convert.ToInt32(ud_NivelFlexibilidade.Value);

                this.Close();
                _frmPrincipal.visualizarFit(_ciclista);
            }
            else
            {
                MessageBox.Show("Informe os dados do ciclista!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NomeCiclista.Focus();
            }
        }

        private void FormNovoFit_Load(object sender, EventArgs e)
        {
            txt_NomeCiclista.Focus();

        }

        private void ud_MedidaCavalo_Enter(object sender, EventArgs e)
        {
            ud_MedidaCavalo.Select(0, ud_MedidaCavalo.Value.ToString().Length);
        }

        private void ud_MedidaAnteBraco_Enter(object sender, EventArgs e)
        {
            ud_MedidaAnteBraco.Select(0, ud_MedidaAnteBraco.Value.ToString().Length);
        }

        private void ud_NivelFlexibilidade_Enter(object sender, EventArgs e)
        {
            ud_NivelFlexibilidade.Select(0, ud_NivelFlexibilidade.Value.ToString().Length);
        }
    }
}
