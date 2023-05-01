namespace BikeFitBasic
{
    partial class FormNovoFit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoFit));
            panelTitulo = new Panel();
            lblTitulo = new Label();
            btnCancelaFit = new Button();
            groupBox1 = new GroupBox();
            txt_NomeCiclista = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            ud_MedidaAnteBraco = new NumericUpDown();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            ud_NivelFlexibilidade = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            ud_MedidaCavalo = new NumericUpDown();
            btnGravarFit = new Button();
            groupBoxData = new GroupBox();
            dt_DataFif = new DateTimePicker();
            panelTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ud_MedidaAnteBraco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ud_NivelFlexibilidade).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ud_MedidaCavalo).BeginInit();
            groupBoxData.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Teal;
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1030, 40);
            panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(69, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Fit";
            // 
            // btnCancelaFit
            // 
            btnCancelaFit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelaFit.BackgroundImage = Properties.Resources.btn_cancelar;
            btnCancelaFit.BackgroundImageLayout = ImageLayout.Center;
            btnCancelaFit.Location = new Point(893, 503);
            btnCancelaFit.Name = "btnCancelaFit";
            btnCancelaFit.Size = new Size(125, 35);
            btnCancelaFit.TabIndex = 1;
            btnCancelaFit.UseVisualStyleBackColor = true;
            btnCancelaFit.Click += btnCancelaFit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_NomeCiclista);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 60);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome do ciclista";
            // 
            // txt_NomeCiclista
            // 
            txt_NomeCiclista.CharacterCasing = CharacterCasing.Upper;
            txt_NomeCiclista.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NomeCiclista.Location = new Point(12, 22);
            txt_NomeCiclista.Name = "txt_NomeCiclista";
            txt_NomeCiclista.Size = new Size(812, 26);
            txt_NomeCiclista.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(634, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 334);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(ud_MedidaAnteBraco);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(502, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(143, 54);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Medida anti-braço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(114, 25);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 4;
            label10.Text = "cm";
            // 
            // ud_MedidaAnteBraco
            // 
            ud_MedidaAnteBraco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ud_MedidaAnteBraco.Location = new Point(10, 22);
            ud_MedidaAnteBraco.Name = "ud_MedidaAnteBraco";
            ud_MedidaAnteBraco.Size = new Size(103, 22);
            ud_MedidaAnteBraco.TabIndex = 3;
            ud_MedidaAnteBraco.Enter += ud_MedidaAnteBraco_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(305, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(202, 251);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(961, 236);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 10;
            label1.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ud_NivelFlexibilidade);
            groupBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(684, 383);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(129, 54);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Flexibilidade";
            // 
            // ud_NivelFlexibilidade
            // 
            ud_NivelFlexibilidade.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ud_NivelFlexibilidade.Location = new Point(13, 22);
            ud_NivelFlexibilidade.Name = "ud_NivelFlexibilidade";
            ud_NivelFlexibilidade.Size = new Size(103, 22);
            ud_NivelFlexibilidade.TabIndex = 4;
            ud_NivelFlexibilidade.Enter += ud_NivelFlexibilidade_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(863, 236);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 12;
            label2.Text = "Dedos tocam o joelho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(863, 280);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 13;
            label3.Text = "Dedos tocam a canela";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(863, 326);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 14;
            label4.Text = "Dedos tocam os pés";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(863, 349);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 15;
            label5.Text = "Dedos tocam o chão";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(862, 379);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 16;
            label6.Text = "Polegares tocam o chão";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(863, 408);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 17;
            label7.Text = "Dedos dentam no chão";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(862, 437);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 18;
            label8.Text = "Palma da mão no chão";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(ud_MedidaCavalo);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(187, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(143, 54);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medida do cavalo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(114, 26);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 3;
            label9.Text = "cm";
            // 
            // ud_MedidaCavalo
            // 
            ud_MedidaCavalo.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ud_MedidaCavalo.Location = new Point(9, 22);
            ud_MedidaCavalo.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            ud_MedidaCavalo.Name = "ud_MedidaCavalo";
            ud_MedidaCavalo.Size = new Size(103, 22);
            ud_MedidaCavalo.TabIndex = 2;
            ud_MedidaCavalo.Enter += ud_MedidaCavalo_Enter;
            // 
            // btnGravarFit
            // 
            btnGravarFit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravarFit.Image = Properties.Resources.btn_gravar_gerar_fit;
            btnGravarFit.Location = new Point(722, 503);
            btnGravarFit.Name = "btnGravarFit";
            btnGravarFit.Size = new Size(156, 35);
            btnGravarFit.TabIndex = 20;
            btnGravarFit.UseVisualStyleBackColor = true;
            btnGravarFit.Click += btnGravarFit_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(dt_DataFif);
            groupBoxData.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxData.Location = new Point(855, 46);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(152, 60);
            groupBoxData.TabIndex = 6;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Data";
            // 
            // dt_DataFif
            // 
            dt_DataFif.CustomFormat = "dd/MM/yyyy";
            dt_DataFif.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dt_DataFif.Format = DateTimePickerFormat.Custom;
            dt_DataFif.Location = new Point(11, 22);
            dt_DataFif.Name = "dt_DataFif";
            dt_DataFif.Size = new Size(130, 26);
            dt_DataFif.TabIndex = 1;
            // 
            // FormNovoFit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1030, 550);
            Controls.Add(groupBoxData);
            Controls.Add(btnGravarFit);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox4);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelaFit);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNovoFit";
            Text = "FormNovoFit";
            WindowState = FormWindowState.Maximized;
            Load += FormNovoFit_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ud_MedidaAnteBraco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ud_NivelFlexibilidade).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ud_MedidaCavalo).EndInit();
            groupBoxData.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Button btnCancelaFit;
        private GroupBox groupBox1;
        private TextBox txt_NomeCiclista;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private NumericUpDown ud_MedidaAnteBraco;
        private PictureBox pictureBox3;
        private Label label1;
        private GroupBox groupBox4;
        private NumericUpDown ud_NivelFlexibilidade;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private NumericUpDown ud_MedidaCavalo;
        private Button btnGravarFit;
        private GroupBox groupBoxData;
        private DateTimePicker dt_DataFif;
        private Label label10;
        private Label label9;
    }
}