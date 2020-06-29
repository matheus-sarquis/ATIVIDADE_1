namespace ATIVIDADE_1
{
    partial class frPrincipal
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnMovimenta = new System.Windows.Forms.Button();
            this.btnlistagem = new System.Windows.Forms.Button();
            this.pAmbiente = new System.Windows.Forms.Panel();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.btnBota = new System.Windows.Forms.Button();
            this.btnChoca = new System.Windows.Forms.Button();
            this.btnVoa = new System.Windows.Forms.Button();
            this.btnAmamenta = new System.Windows.Forms.Button();
            this.btnAtaca = new System.Windows.Forms.Button();
            this.btnAlimenta = new System.Windows.Forms.Button();
            this.btnCisca = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnComunica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pAmbiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnimal.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(198, 45);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Adcionar Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o animal:";
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(12, 86);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(198, 21);
            this.cbAnimal.TabIndex = 5;
            this.cbAnimal.SelectedIndexChanged += new System.EventHandler(this.cbAnimal_SelectedIndexChanged);
            this.cbAnimal.Click += new System.EventHandler(this.cbAnimal_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDireita.Enabled = false;
            this.btnDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireita.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireita.ForeColor = System.Drawing.Color.White;
            this.btnDireita.Location = new System.Drawing.Point(123, 618);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(87, 56);
            this.btnDireita.TabIndex = 7;
            this.btnDireita.Text = "→";
            this.btnDireita.UseVisualStyleBackColor = false;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEsquerda.Enabled = false;
            this.btnEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquerda.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquerda.ForeColor = System.Drawing.Color.White;
            this.btnEsquerda.Location = new System.Drawing.Point(12, 618);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(86, 56);
            this.btnEsquerda.TabIndex = 10;
            this.btnEsquerda.Text = "←";
            this.btnEsquerda.UseVisualStyleBackColor = false;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnMovimenta
            // 
            this.btnMovimenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMovimenta.Enabled = false;
            this.btnMovimenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimenta.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimenta.ForeColor = System.Drawing.Color.White;
            this.btnMovimenta.Location = new System.Drawing.Point(13, 566);
            this.btnMovimenta.Name = "btnMovimenta";
            this.btnMovimenta.Size = new System.Drawing.Size(198, 46);
            this.btnMovimenta.TabIndex = 11;
            this.btnMovimenta.Text = "Movimentar";
            this.btnMovimenta.UseVisualStyleBackColor = false;
            this.btnMovimenta.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnlistagem
            // 
            this.btnlistagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlistagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistagem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistagem.ForeColor = System.Drawing.Color.White;
            this.btnlistagem.Location = new System.Drawing.Point(216, 12);
            this.btnlistagem.Name = "btnlistagem";
            this.btnlistagem.Size = new System.Drawing.Size(169, 45);
            this.btnlistagem.TabIndex = 12;
            this.btnlistagem.Text = "Listagens";
            this.btnlistagem.UseVisualStyleBackColor = false;
            this.btnlistagem.Click += new System.EventHandler(this.btnlistagem_Click);
            // 
            // pAmbiente
            // 
            this.pAmbiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAmbiente.Controls.Add(this.pbAnimal);
            this.pAmbiente.Location = new System.Drawing.Point(217, 74);
            this.pAmbiente.Name = "pAmbiente";
            this.pAmbiente.Size = new System.Drawing.Size(1020, 595);
            this.pAmbiente.TabIndex = 14;
            // 
            // pbAnimal
            // 
            this.pbAnimal.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAnimal.Location = new System.Drawing.Point(110, 202);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(241, 197);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnimal.TabIndex = 24;
            this.pbAnimal.TabStop = false;
            // 
            // btnBota
            // 
            this.btnBota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBota.Enabled = false;
            this.btnBota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBota.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBota.ForeColor = System.Drawing.Color.White;
            this.btnBota.Location = new System.Drawing.Point(13, 202);
            this.btnBota.Name = "btnBota";
            this.btnBota.Size = new System.Drawing.Size(198, 46);
            this.btnBota.TabIndex = 15;
            this.btnBota.Text = "Botar";
            this.btnBota.UseVisualStyleBackColor = false;
            this.btnBota.Click += new System.EventHandler(this.btnBota_Click);
            // 
            // btnChoca
            // 
            this.btnChoca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChoca.Enabled = false;
            this.btnChoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoca.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoca.ForeColor = System.Drawing.Color.White;
            this.btnChoca.Location = new System.Drawing.Point(13, 254);
            this.btnChoca.Name = "btnChoca";
            this.btnChoca.Size = new System.Drawing.Size(198, 46);
            this.btnChoca.TabIndex = 16;
            this.btnChoca.Text = "Chocar";
            this.btnChoca.UseVisualStyleBackColor = false;
            this.btnChoca.Click += new System.EventHandler(this.btnChoca_Click);
            // 
            // btnVoa
            // 
            this.btnVoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVoa.Enabled = false;
            this.btnVoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoa.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoa.ForeColor = System.Drawing.Color.White;
            this.btnVoa.Location = new System.Drawing.Point(12, 306);
            this.btnVoa.Name = "btnVoa";
            this.btnVoa.Size = new System.Drawing.Size(198, 46);
            this.btnVoa.TabIndex = 17;
            this.btnVoa.Text = "Voar";
            this.btnVoa.UseVisualStyleBackColor = false;
            // 
            // btnAmamenta
            // 
            this.btnAmamenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAmamenta.Enabled = false;
            this.btnAmamenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmamenta.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmamenta.ForeColor = System.Drawing.Color.White;
            this.btnAmamenta.Location = new System.Drawing.Point(13, 358);
            this.btnAmamenta.Name = "btnAmamenta";
            this.btnAmamenta.Size = new System.Drawing.Size(198, 46);
            this.btnAmamenta.TabIndex = 18;
            this.btnAmamenta.Text = "Amamentar";
            this.btnAmamenta.UseVisualStyleBackColor = false;
            this.btnAmamenta.Click += new System.EventHandler(this.btnAmamenta_Click);
            // 
            // btnAtaca
            // 
            this.btnAtaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAtaca.Enabled = false;
            this.btnAtaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtaca.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaca.ForeColor = System.Drawing.Color.White;
            this.btnAtaca.Location = new System.Drawing.Point(12, 410);
            this.btnAtaca.Name = "btnAtaca";
            this.btnAtaca.Size = new System.Drawing.Size(198, 46);
            this.btnAtaca.TabIndex = 19;
            this.btnAtaca.Text = "Atacar";
            this.btnAtaca.UseVisualStyleBackColor = false;
            this.btnAtaca.Click += new System.EventHandler(this.btnAtaca_Click);
            // 
            // btnAlimenta
            // 
            this.btnAlimenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlimenta.Enabled = false;
            this.btnAlimenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimenta.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimenta.ForeColor = System.Drawing.Color.White;
            this.btnAlimenta.Location = new System.Drawing.Point(13, 462);
            this.btnAlimenta.Name = "btnAlimenta";
            this.btnAlimenta.Size = new System.Drawing.Size(198, 46);
            this.btnAlimenta.TabIndex = 20;
            this.btnAlimenta.Text = "Alimentar";
            this.btnAlimenta.UseVisualStyleBackColor = false;
            this.btnAlimenta.Click += new System.EventHandler(this.btnAlimenta_Click);
            // 
            // btnCisca
            // 
            this.btnCisca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCisca.Enabled = false;
            this.btnCisca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCisca.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCisca.ForeColor = System.Drawing.Color.White;
            this.btnCisca.Location = new System.Drawing.Point(12, 514);
            this.btnCisca.Name = "btnCisca";
            this.btnCisca.Size = new System.Drawing.Size(198, 46);
            this.btnCisca.TabIndex = 21;
            this.btnCisca.Text = "Ciscar";
            this.btnCisca.UseVisualStyleBackColor = false;
            this.btnCisca.Click += new System.EventHandler(this.btnCisca_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(391, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 23);
            this.lblInfo.TabIndex = 23;
            // 
            // btnComunica
            // 
            this.btnComunica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnComunica.Enabled = false;
            this.btnComunica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunica.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunica.ForeColor = System.Drawing.Color.White;
            this.btnComunica.Location = new System.Drawing.Point(12, 150);
            this.btnComunica.Name = "btnComunica";
            this.btnComunica.Size = new System.Drawing.Size(198, 46);
            this.btnComunica.TabIndex = 24;
            this.btnComunica.Text = "Comunicar";
            this.btnComunica.UseVisualStyleBackColor = false;
            this.btnComunica.Click += new System.EventHandler(this.btnComunica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ações :";
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1249, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCisca);
            this.Controls.Add(this.btnMovimenta);
            this.Controls.Add(this.btnAlimenta);
            this.Controls.Add(this.btnAtaca);
            this.Controls.Add(this.btnAmamenta);
            this.Controls.Add(this.btnVoa);
            this.Controls.Add(this.btnChoca);
            this.Controls.Add(this.btnBota);
            this.Controls.Add(this.btnComunica);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pAmbiente);
            this.Controls.Add(this.btnlistagem);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "frPrincipal";
            this.Text = "Menu";
            this.pAmbiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnMovimenta;
        private System.Windows.Forms.Button btnlistagem;
        private System.Windows.Forms.Panel pAmbiente;
        private System.Windows.Forms.Button btnBota;
        private System.Windows.Forms.Button btnChoca;
        private System.Windows.Forms.Button btnVoa;
        private System.Windows.Forms.Button btnAmamenta;
        private System.Windows.Forms.Button btnAtaca;
        private System.Windows.Forms.Button btnAlimenta;
        private System.Windows.Forms.Button btnCisca;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Button btnComunica;
        private System.Windows.Forms.Label label2;
    }
}

