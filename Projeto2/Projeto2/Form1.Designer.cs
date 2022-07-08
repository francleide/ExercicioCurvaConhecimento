namespace Projeto2
{
    partial class Form1
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
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.btnTrocarBateria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarLanterna = new System.Windows.Forms.ProgressBar();
            this.labelBateria = new System.Windows.Forms.Label();
            this.labelEstadoLanterna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.Location = new System.Drawing.Point(269, 12);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(75, 23);
            this.btnLigaDesliga.TabIndex = 0;
            this.btnLigaDesliga.Text = "Ligar";
            this.btnLigaDesliga.UseVisualStyleBackColor = true;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // btnTrocarBateria
            // 
            this.btnTrocarBateria.Location = new System.Drawing.Point(134, 296);
            this.btnTrocarBateria.Name = "btnTrocarBateria";
            this.btnTrocarBateria.Size = new System.Drawing.Size(95, 23);
            this.btnTrocarBateria.TabIndex = 1;
            this.btnTrocarBateria.Text = "Trocar Bateria";
            this.btnTrocarBateria.UseVisualStyleBackColor = true;
            this.btnTrocarBateria.Click += new System.EventHandler(this.btnTrocarBateria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto2.Properties.Resources.desligado;
            this.pictureBox1.Location = new System.Drawing.Point(120, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBarLanterna
            // 
            this.progressBarLanterna.Location = new System.Drawing.Point(12, 260);
            this.progressBarLanterna.Name = "progressBarLanterna";
            this.progressBarLanterna.Size = new System.Drawing.Size(332, 23);
            this.progressBarLanterna.TabIndex = 3;
            // 
            // labelBateria
            // 
            this.labelBateria.AutoSize = true;
            this.labelBateria.Location = new System.Drawing.Point(166, 242);
            this.labelBateria.Name = "labelBateria";
            this.labelBateria.Size = new System.Drawing.Size(23, 15);
            this.labelBateria.TabIndex = 4;
            this.labelBateria.Text = "0%";
            this.labelBateria.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEstadoLanterna
            // 
            this.labelEstadoLanterna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEstadoLanterna.AutoSize = true;
            this.labelEstadoLanterna.Location = new System.Drawing.Point(151, 54);
            this.labelEstadoLanterna.Name = "labelEstadoLanterna";
            this.labelEstadoLanterna.Size = new System.Drawing.Size(59, 15);
            this.labelEstadoLanterna.TabIndex = 5;
            this.labelEstadoLanterna.Text = "Desligado";
            this.labelEstadoLanterna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEstadoLanterna.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 331);
            this.Controls.Add(this.labelEstadoLanterna);
            this.Controls.Add(this.labelBateria);
            this.Controls.Add(this.progressBarLanterna);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTrocarBateria);
            this.Controls.Add(this.btnLigaDesliga);
            this.Name = "Form1";
            this.Text = "Lanterna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLigaDesliga;
        private Button btnTrocarBateria;
        private PictureBox pictureBox1;
        private ProgressBar progressBarLanterna;
        private Label labelBateria;
        private Label labelEstadoLanterna;
    }
}