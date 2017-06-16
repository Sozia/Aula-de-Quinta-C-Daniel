namespace JogoJokempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Placar = new System.Windows.Forms.GroupBox();
            this.PlacarCPU = new System.Windows.Forms.Label();
            this.PlacarPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgEscolhaCPU = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgEscolhaPlayer = new System.Windows.Forms.PictureBox();
            this.Tesoura = new System.Windows.Forms.Button();
            this.Papel = new System.Windows.Forms.Button();
            this.Pedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Placar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaCPU)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.Placar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tesoura);
            this.splitContainer1.Panel2.Controls.Add(this.Papel);
            this.splitContainer1.Panel2.Controls.Add(this.Pedra);
            this.splitContainer1.Size = new System.Drawing.Size(625, 441);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // Placar
            // 
            this.Placar.Controls.Add(this.PlacarCPU);
            this.Placar.Controls.Add(this.PlacarPlayer);
            this.Placar.Controls.Add(this.label2);
            this.Placar.Controls.Add(this.label1);
            this.Placar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placar.Location = new System.Drawing.Point(213, 31);
            this.Placar.Name = "Placar";
            this.Placar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Placar.Size = new System.Drawing.Size(213, 181);
            this.Placar.TabIndex = 2;
            this.Placar.TabStop = false;
            this.Placar.Text = "Placar";
            this.Placar.UseWaitCursor = true;
            // 
            // PlacarCPU
            // 
            this.PlacarCPU.AutoSize = true;
            this.PlacarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarCPU.Location = new System.Drawing.Point(127, 70);
            this.PlacarCPU.Name = "PlacarCPU";
            this.PlacarCPU.Size = new System.Drawing.Size(57, 63);
            this.PlacarCPU.TabIndex = 3;
            this.PlacarCPU.Text = "0";
            this.PlacarCPU.UseWaitCursor = true;
            // 
            // PlacarPlayer
            // 
            this.PlacarPlayer.AutoSize = true;
            this.PlacarPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarPlayer.Location = new System.Drawing.Point(17, 70);
            this.PlacarPlayer.Name = "PlacarPlayer";
            this.PlacarPlayer.Size = new System.Drawing.Size(57, 63);
            this.PlacarPlayer.TabIndex = 2;
            this.PlacarPlayer.Text = "0";
            this.PlacarPlayer.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            this.label1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgEscolhaCPU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(443, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // imgEscolhaCPU
            // 
            this.imgEscolhaCPU.Location = new System.Drawing.Point(6, 19);
            this.imgEscolhaCPU.Name = "imgEscolhaCPU";
            this.imgEscolhaCPU.Size = new System.Drawing.Size(157, 150);
            this.imgEscolhaCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEscolhaCPU.TabIndex = 1;
            this.imgEscolhaCPU.TabStop = false;
            this.imgEscolhaCPU.Click += new System.EventHandler(this.imgEscolhaCPU_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgEscolhaPlayer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // imgEscolhaPlayer
            // 
            this.imgEscolhaPlayer.Location = new System.Drawing.Point(6, 19);
            this.imgEscolhaPlayer.Name = "imgEscolhaPlayer";
            this.imgEscolhaPlayer.Size = new System.Drawing.Size(172, 150);
            this.imgEscolhaPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEscolhaPlayer.TabIndex = 0;
            this.imgEscolhaPlayer.TabStop = false;
            this.imgEscolhaPlayer.Click += new System.EventHandler(this.imgEscolhaPlayer_Click);
            // 
            // Tesoura
            // 
            this.Tesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tesoura.BackgroundImage")));
            this.Tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tesoura.Location = new System.Drawing.Point(426, 0);
            this.Tesoura.Name = "Tesoura";
            this.Tesoura.Size = new System.Drawing.Size(199, 210);
            this.Tesoura.TabIndex = 2;
            this.Tesoura.UseVisualStyleBackColor = true;
            this.Tesoura.Click += new System.EventHandler(this.Tesoura_Click);
            // 
            // Papel
            // 
            this.Papel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Papel.BackgroundImage")));
            this.Papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Papel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Papel.Location = new System.Drawing.Point(213, 0);
            this.Papel.Name = "Papel";
            this.Papel.Size = new System.Drawing.Size(213, 210);
            this.Papel.TabIndex = 1;
            this.Papel.UseVisualStyleBackColor = true;
            this.Papel.Click += new System.EventHandler(this.Papel_Click);
            // 
            // Pedra
            // 
            this.Pedra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pedra.BackgroundImage")));
            this.Pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pedra.Location = new System.Drawing.Point(0, 0);
            this.Pedra.Name = "Pedra";
            this.Pedra.Size = new System.Drawing.Size(213, 210);
            this.Pedra.TabIndex = 0;
            this.Pedra.UseVisualStyleBackColor = false;
            this.Pedra.Click += new System.EventHandler(this.Pedra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 441);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Placar.ResumeLayout(false);
            this.Placar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaCPU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Tesoura;
        private System.Windows.Forms.Button Papel;
        private System.Windows.Forms.Button Pedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgEscolhaCPU;
        private System.Windows.Forms.PictureBox imgEscolhaPlayer;
        private System.Windows.Forms.GroupBox Placar;
        private System.Windows.Forms.Label PlacarCPU;
        private System.Windows.Forms.Label PlacarPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

