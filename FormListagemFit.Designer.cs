namespace BikeFitBasic
{
    partial class FormListagemFit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagemFit));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            groupBoxBusca = new GroupBox();
            textBoxBusca = new TextBox();
            btnCancelaFit = new Button();
            dataGridViewFit = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            btnEditarFit = new DataGridViewButtonColumn();
            btnVisualizarFit = new DataGridViewButtonColumn();
            btnExcluir = new DataGridViewButtonColumn();
            panelTitulo.SuspendLayout();
            groupBoxBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFit).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Teal;
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1014, 40);
            panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(97, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listagem Fit";
            // 
            // groupBoxBusca
            // 
            groupBoxBusca.Controls.Add(textBoxBusca);
            groupBoxBusca.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxBusca.Location = new Point(12, 46);
            groupBoxBusca.Name = "groupBoxBusca";
            groupBoxBusca.Size = new Size(990, 60);
            groupBoxBusca.TabIndex = 3;
            groupBoxBusca.TabStop = false;
            groupBoxBusca.Text = "Busca por nome do ciclista";
            // 
            // textBoxBusca
            // 
            textBoxBusca.CharacterCasing = CharacterCasing.Upper;
            textBoxBusca.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBusca.Location = new Point(12, 22);
            textBoxBusca.Name = "textBoxBusca";
            textBoxBusca.Size = new Size(966, 26);
            textBoxBusca.TabIndex = 0;
            textBoxBusca.TextChanged += textBoxBusca_TextChanged;
            // 
            // btnCancelaFit
            // 
            btnCancelaFit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelaFit.BackgroundImage = (Image)resources.GetObject("btnCancelaFit.BackgroundImage");
            btnCancelaFit.BackgroundImageLayout = ImageLayout.Center;
            btnCancelaFit.Location = new Point(877, 497);
            btnCancelaFit.Name = "btnCancelaFit";
            btnCancelaFit.Size = new Size(125, 35);
            btnCancelaFit.TabIndex = 4;
            btnCancelaFit.UseVisualStyleBackColor = true;
            btnCancelaFit.Click += btnCancelaFit_Click;
            // 
            // dataGridViewFit
            // 
            dataGridViewFit.AllowUserToAddRows = false;
            dataGridViewFit.AllowUserToDeleteRows = false;
            dataGridViewFit.AllowUserToResizeColumns = false;
            dataGridViewFit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFit.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Data, btnEditarFit, btnVisualizarFit, btnExcluir });
            dataGridViewFit.Location = new Point(12, 122);
            dataGridViewFit.Name = "dataGridViewFit";
            dataGridViewFit.ReadOnly = true;
            dataGridViewFit.RowHeadersVisible = false;
            dataGridViewFit.RowTemplate.Height = 25;
            dataGridViewFit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFit.Size = new Size(990, 356);
            dataGridViewFit.TabIndex = 5;
            dataGridViewFit.CellClick += dataGridViewFit_CellClick;
            dataGridViewFit.DataBindingComplete += dataGridViewFit_DataBindingComplete;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.FillWeight = 50F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.FillWeight = 400F;
            Nome.HeaderText = "Ciclista";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 400;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.FillWeight = 120F;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Width = 120;
            // 
            // btnEditarFit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            btnEditarFit.DefaultCellStyle = dataGridViewCellStyle2;
            btnEditarFit.FillWeight = 120F;
            btnEditarFit.FlatStyle = FlatStyle.Flat;
            btnEditarFit.HeaderText = "Editar";
            btnEditarFit.Name = "btnEditarFit";
            btnEditarFit.ReadOnly = true;
            btnEditarFit.Resizable = DataGridViewTriState.True;
            btnEditarFit.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEditarFit.Text = "Editar";
            btnEditarFit.UseColumnTextForButtonValue = true;
            btnEditarFit.Width = 120;
            // 
            // btnVisualizarFit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            btnVisualizarFit.DefaultCellStyle = dataGridViewCellStyle3;
            btnVisualizarFit.FillWeight = 120F;
            btnVisualizarFit.FlatStyle = FlatStyle.Flat;
            btnVisualizarFit.HeaderText = "Visualizar Fit";
            btnVisualizarFit.Name = "btnVisualizarFit";
            btnVisualizarFit.ReadOnly = true;
            btnVisualizarFit.SortMode = DataGridViewColumnSortMode.Automatic;
            btnVisualizarFit.Text = "Visualizar Fit";
            btnVisualizarFit.UseColumnTextForButtonValue = true;
            btnVisualizarFit.Width = 120;
            // 
            // btnExcluir
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Tomato;
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle4;
            btnExcluir.FillWeight = 120F;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ReadOnly = true;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 120;
            // 
            // FormListagemFit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 544);
            Controls.Add(dataGridViewFit);
            Controls.Add(btnCancelaFit);
            Controls.Add(groupBoxBusca);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListagemFit";
            Text = "FormListagemFit";
            WindowState = FormWindowState.Maximized;
            Load += FormListagemFit_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            groupBoxBusca.ResumeLayout(false);
            groupBoxBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private GroupBox groupBoxBusca;
        private TextBox textBoxBusca;
        private Button btnCancelaFit;
        private DataGridView dataGridViewFit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewButtonColumn btnEditarFit;
        private DataGridViewButtonColumn btnVisualizarFit;
        private DataGridViewButtonColumn btnExcluir;
    }
}