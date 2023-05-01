namespace BikeFitBasic
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelGeral = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnNovoFit = new Button();
            btnListarFit = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelGeral
            // 
            panelGeral.BackColor = Color.Silver;
            panelGeral.BorderStyle = BorderStyle.FixedSingle;
            panelGeral.Location = new Point(149, 93);
            panelGeral.Name = "panelGeral";
            panelGeral.Size = new Size(1023, 540);
            panelGeral.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 639);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(213, 17);
            toolStripStatusLabel1.Text = "Bike Fit Basic By Walfran Paiva V.1.00";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNovoFit
            // 
            btnNovoFit.BackgroundImage = Properties.Resources.btn_novo1;
            btnNovoFit.BackgroundImageLayout = ImageLayout.Center;
            btnNovoFit.Location = new Point(12, 93);
            btnNovoFit.Name = "btnNovoFit";
            btnNovoFit.Size = new Size(125, 35);
            btnNovoFit.TabIndex = 2;
            btnNovoFit.UseVisualStyleBackColor = true;
            btnNovoFit.Click += btnNovoFit_Click;
            // 
            // btnListarFit
            // 
            btnListarFit.BackgroundImage = Properties.Resources.btn_listar;
            btnListarFit.BackgroundImageLayout = ImageLayout.Center;
            btnListarFit.Location = new Point(12, 134);
            btnListarFit.Name = "btnListarFit";
            btnListarFit.Size = new Size(125, 35);
            btnListarFit.TabIndex = 3;
            btnListarFit.UseVisualStyleBackColor = true;
            btnListarFit.Click += btnListarFit_Click;
            // 
            // btnSair
            // 
            btnSair.BackgroundImage = Properties.Resources.btn_sair;
            btnSair.BackgroundImageLayout = ImageLayout.Center;
            btnSair.Location = new Point(12, 598);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(125, 35);
            btnSair.TabIndex = 4;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 63);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 661);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnListarFit);
            Controls.Add(btnNovoFit);
            Controls.Add(statusStrip1);
            Controls.Add(panelGeral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bike Fit Basic";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGeral;
        private StatusStrip statusStrip1;
        private Button btnNovoFit;
        private Button btnListarFit;
        private Button btnSair;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
    }
}