namespace BikeFitBasic
{
    partial class FormFit
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
            panelTitulo = new Panel();
            lblTitulo = new Label();
            btnCancelaFit = new Button();
            pictureBox1 = new PictureBox();
            lblDistanciaGuidaoCelim = new Label();
            lblNomeCiclista = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            lblAlturaCelimPedivela = new Label();
            lblTamanhoQuadro = new Label();
            lblPedivelaPontaCelim = new Label();
            lblAlturaGuidaoBanco = new Label();
            groupBox1 = new GroupBox();
            lblDataFit = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            label11 = new Label();
            lblfitideal = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            panelTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resultado Fit";
            // 
            // btnCancelaFit
            // 
            btnCancelaFit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelaFit.BackgroundImage = Properties.Resources.btn_fechar;
            btnCancelaFit.BackgroundImageLayout = ImageLayout.Center;
            btnCancelaFit.Location = new Point(893, 503);
            btnCancelaFit.Name = "btnCancelaFit";
            btnCancelaFit.Size = new Size(125, 35);
            btnCancelaFit.TabIndex = 3;
            btnCancelaFit.UseVisualStyleBackColor = true;
            btnCancelaFit.Click += btnCancelaFit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.quadro_medidas;
            pictureBox1.Location = new Point(394, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblDistanciaGuidaoCelim
            // 
            lblDistanciaGuidaoCelim.AutoSize = true;
            lblDistanciaGuidaoCelim.BorderStyle = BorderStyle.FixedSingle;
            lblDistanciaGuidaoCelim.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDistanciaGuidaoCelim.Location = new Point(599, 182);
            lblDistanciaGuidaoCelim.Name = "lblDistanciaGuidaoCelim";
            lblDistanciaGuidaoCelim.Size = new Size(37, 20);
            lblDistanciaGuidaoCelim.TabIndex = 5;
            lblDistanciaGuidaoCelim.Text = "000";
            // 
            // lblNomeCiclista
            // 
            lblNomeCiclista.AutoSize = true;
            lblNomeCiclista.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCiclista.ForeColor = Color.Teal;
            lblNomeCiclista.Location = new Point(220, 15);
            lblNomeCiclista.Name = "lblNomeCiclista";
            lblNomeCiclista.Size = new Size(207, 24);
            lblNomeCiclista.TabIndex = 7;
            lblNomeCiclista.Text = "CICLISTA TAL NOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(24, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(15, 15);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 135);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 9;
            label1.Text = "Tamanho do quadro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 155);
            label2.Name = "label2";
            label2.Size = new Size(218, 15);
            label2.TabIndex = 11;
            label2.Text = "Altura do celim até o centro do pedivela";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(24, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 15);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 175);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 13;
            label3.Text = "Distância entre o guidão e o selim";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(24, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 15);
            panel3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 195);
            label4.Name = "label4";
            label4.Size = new Size(234, 15);
            label4.TabIndex = 15;
            label4.Text = "Diferença de altura entre o gidão e o banco";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Orange;
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(24, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(15, 15);
            panel4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 215);
            label5.Name = "label5";
            label5.Size = new Size(282, 15);
            label5.TabIndex = 17;
            label5.Text = "Recuo entre o centro do pedivela e a ponta do celim";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.ForeColor = Color.Transparent;
            panel5.Location = new Point(24, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(15, 15);
            panel5.TabIndex = 16;
            // 
            // lblAlturaCelimPedivela
            // 
            lblAlturaCelimPedivela.AutoSize = true;
            lblAlturaCelimPedivela.BorderStyle = BorderStyle.FixedSingle;
            lblAlturaCelimPedivela.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAlturaCelimPedivela.Location = new Point(353, 181);
            lblAlturaCelimPedivela.Name = "lblAlturaCelimPedivela";
            lblAlturaCelimPedivela.Size = new Size(37, 20);
            lblAlturaCelimPedivela.TabIndex = 18;
            lblAlturaCelimPedivela.Text = "000";
            // 
            // lblTamanhoQuadro
            // 
            lblTamanhoQuadro.AutoSize = true;
            lblTamanhoQuadro.BorderStyle = BorderStyle.FixedSingle;
            lblTamanhoQuadro.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTamanhoQuadro.Location = new Point(322, 284);
            lblTamanhoQuadro.Name = "lblTamanhoQuadro";
            lblTamanhoQuadro.Size = new Size(37, 20);
            lblTamanhoQuadro.TabIndex = 19;
            lblTamanhoQuadro.Text = "000";
            // 
            // lblPedivelaPontaCelim
            // 
            lblPedivelaPontaCelim.AutoSize = true;
            lblPedivelaPontaCelim.BorderStyle = BorderStyle.FixedSingle;
            lblPedivelaPontaCelim.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPedivelaPontaCelim.Location = new Point(540, 510);
            lblPedivelaPontaCelim.Name = "lblPedivelaPontaCelim";
            lblPedivelaPontaCelim.Size = new Size(37, 20);
            lblPedivelaPontaCelim.TabIndex = 20;
            lblPedivelaPontaCelim.Text = "000";
            // 
            // lblAlturaGuidaoBanco
            // 
            lblAlturaGuidaoBanco.AutoSize = true;
            lblAlturaGuidaoBanco.BorderStyle = BorderStyle.FixedSingle;
            lblAlturaGuidaoBanco.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAlturaGuidaoBanco.Location = new Point(889, 126);
            lblAlturaGuidaoBanco.Name = "lblAlturaGuidaoBanco";
            lblAlturaGuidaoBanco.Size = new Size(37, 20);
            lblAlturaGuidaoBanco.TabIndex = 21;
            lblAlturaGuidaoBanco.Text = "000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDataFit);
            groupBox1.Controls.Add(panel7);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblfitideal);
            groupBox1.Controls.Add(lblNomeCiclista);
            groupBox1.Location = new Point(22, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 72);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // lblDataFit
            // 
            lblDataFit.AutoSize = true;
            lblDataFit.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataFit.ForeColor = Color.Teal;
            lblDataFit.Location = new Point(76, 42);
            lblDataFit.Name = "lblDataFit";
            lblDataFit.Size = new Size(118, 24);
            lblDataFit.TabIndex = 31;
            lblDataFit.Text = "00/00/0000";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.ForeColor = Color.Transparent;
            panel7.Location = new Point(5, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 23);
            panel7.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.ForeColor = Color.Transparent;
            panel6.Location = new Point(5, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 34);
            panel6.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(17, 42);
            label11.Name = "label11";
            label11.Size = new Size(61, 24);
            label11.TabIndex = 8;
            label11.Text = "Data:";
            // 
            // lblfitideal
            // 
            lblfitideal.AutoSize = true;
            lblfitideal.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblfitideal.Location = new Point(17, 15);
            lblfitideal.Name = "lblfitideal";
            lblfitideal.Size = new Size(206, 24);
            lblfitideal.TabIndex = 7;
            lblfitideal.Text = "Fit básico ideal para:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(363, 286);
            label6.Name = "label6";
            label6.Size = new Size(26, 16);
            label6.TabIndex = 23;
            label6.Text = "cm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(394, 183);
            label7.Name = "label7";
            label7.Size = new Size(26, 16);
            label7.TabIndex = 24;
            label7.Text = "cm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(640, 183);
            label8.Name = "label8";
            label8.Size = new Size(26, 16);
            label8.TabIndex = 25;
            label8.Text = "cm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(581, 512);
            label9.Name = "label9";
            label9.Size = new Size(26, 16);
            label9.TabIndex = 26;
            label9.Text = "cm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(930, 127);
            label10.Name = "label10";
            label10.Size = new Size(26, 16);
            label10.TabIndex = 27;
            label10.Text = "cm";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.btn_imprimir;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(757, 503);
            button1.Name = "button1";
            button1.Size = new Size(125, 35);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormFit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1030, 550);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(lblAlturaGuidaoBanco);
            Controls.Add(lblPedivelaPontaCelim);
            Controls.Add(lblTamanhoQuadro);
            Controls.Add(lblAlturaCelimPedivela);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblDistanciaGuidaoCelim);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelaFit);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFit";
            Text = "Resultado Fit";
            WindowState = FormWindowState.Maximized;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Button btnCancelaFit;
        private PictureBox pictureBox1;
        private Label lblDistanciaGuidaoCelim;
        private Label lblNomeCiclista;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label lblAlturaCelimPedivela;
        private Label lblTamanhoQuadro;
        private Label lblPedivelaPontaCelim;
        private Label lblAlturaGuidaoBanco;
        private GroupBox groupBox1;
        private Label lblfitideal;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label lblDataFit;
        private Panel panel7;
        private Panel panel6;
        private Label label11;
    }
}