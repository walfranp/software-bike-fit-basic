using BikeFitBasic.Models;

namespace BikeFitBasic
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // Apenas para fazer a primera consulta com o banco...
            BikeFitBasicContext db = new BikeFitBasicContext();
            List<Ciclista> lst = db.Ciclistas.ToList();
        }

        private void btnNovoFit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormNovoFit>().Count() > 0)
            {
                FormNovoFit frm = Application.OpenForms.OfType<FormNovoFit>().First();
                frm.BringToFront();
                frm.Focus();
            }
            else
            {   Ciclista ciclista = new Ciclista(); 
                FormNovoFit novoFit = new FormNovoFit(this, ciclista, false);
                novoFit.TopLevel = false;
                panelGeral.Controls.Add(novoFit);
                novoFit.BringToFront();
                novoFit.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarFit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormListagemFit>().Count() > 0)
            {
                FormListagemFit frm = Application.OpenForms.OfType<FormListagemFit>().First();
                frm.BringToFront();
                frm.Focus();
            }
            else
            {
                FormListagemFit listageFit = new FormListagemFit(this);
                listageFit.TopLevel = false;
                panelGeral.Controls.Add(listageFit);
                listageFit.BringToFront();
                listageFit.Show();
            }
        }

        public void visualizarFit(Ciclista ciclista)
        {
            FormFit formFit = new FormFit(ciclista);
            formFit.TopLevel = false;
            panelGeral.Controls.Add(formFit);
            formFit.BringToFront();
            formFit.Show();
        }

        public void editarFit(Ciclista ciclista)
        {
            FormNovoFit formFit = new FormNovoFit(this, ciclista, true);
            formFit.TopLevel = false;
            panelGeral.Controls.Add(formFit);
            formFit.BringToFront();
            formFit.Show();
        }
    }
}