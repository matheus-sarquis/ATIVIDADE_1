﻿namespace ATIVIDADE_1
{
    partial class frAddAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.nupIdade = new System.Windows.Forms.NumericUpDown();
            this.gpPadrao = new System.Windows.Forms.GroupBox();
            this.gpMamifero = new System.Windows.Forms.GroupBox();
            this.cbCorPelos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbAve = new System.Windows.Forms.GroupBox();
            this.cbCorPena = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).BeginInit();
            this.gpPadrao.SuspendLayout();
            this.gpMamifero.SuspendLayout();
            this.gbAve.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o animal a ser adcionado:";
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Items.AddRange(new object[] {
            "Baleia",
            "Cachorro",
            "Coruja",
            "Gato",
            "Gavião",
            "Leão",
            "Morcego",
            "Ornitorrinco",
            "Pato",
            "Pinguim",
            "Pombo",
            "Tartaruga"});
            this.cbAnimal.Location = new System.Drawing.Point(265, 28);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(156, 21);
            this.cbAnimal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Idade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(160, 45);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(103, 20);
            this.txtData.TabIndex = 9;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cbSexo.Location = new System.Drawing.Point(55, 71);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(208, 21);
            this.cbSexo.TabIndex = 10;
            // 
            // nupIdade
            // 
            this.nupIdade.Location = new System.Drawing.Point(63, 98);
            this.nupIdade.Name = "nupIdade";
            this.nupIdade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupIdade.Size = new System.Drawing.Size(200, 20);
            this.nupIdade.TabIndex = 11;
            // 
            // gpPadrao
            // 
            this.gpPadrao.Controls.Add(this.label2);
            this.gpPadrao.Controls.Add(this.label3);
            this.gpPadrao.Controls.Add(this.nupIdade);
            this.gpPadrao.Controls.Add(this.label4);
            this.gpPadrao.Controls.Add(this.cbSexo);
            this.gpPadrao.Controls.Add(this.label5);
            this.gpPadrao.Controls.Add(this.txtData);
            this.gpPadrao.Controls.Add(this.txtNome);
            this.gpPadrao.Location = new System.Drawing.Point(12, 69);
            this.gpPadrao.Name = "gpPadrao";
            this.gpPadrao.Size = new System.Drawing.Size(269, 134);
            this.gpPadrao.TabIndex = 14;
            this.gpPadrao.TabStop = false;
            this.gpPadrao.Text = "Padrão";
            // 
            // gpMamifero
            // 
            this.gpMamifero.Controls.Add(this.cbCorPelos);
            this.gpMamifero.Controls.Add(this.label10);
            this.gpMamifero.Location = new System.Drawing.Point(287, 69);
            this.gpMamifero.Name = "gpMamifero";
            this.gpMamifero.Size = new System.Drawing.Size(269, 54);
            this.gpMamifero.TabIndex = 15;
            this.gpMamifero.TabStop = false;
            this.gpMamifero.Text = "Mamífero";
            // 
            // cbCorPelos
            // 
            this.cbCorPelos.FormattingEnabled = true;
            this.cbCorPelos.Location = new System.Drawing.Point(111, 19);
            this.cbCorPelos.Name = "cbCorPelos";
            this.cbCorPelos.Size = new System.Drawing.Size(152, 21);
            this.cbCorPelos.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cor dos pelos:";
            // 
            // gbAve
            // 
            this.gbAve.Controls.Add(this.cbCorPena);
            this.gbAve.Controls.Add(this.label12);
            this.gbAve.Location = new System.Drawing.Point(287, 129);
            this.gbAve.Name = "gbAve";
            this.gbAve.Size = new System.Drawing.Size(269, 53);
            this.gbAve.TabIndex = 16;
            this.gbAve.TabStop = false;
            this.gbAve.Text = "Voa";
            // 
            // cbCorPena
            // 
            this.cbCorPena.FormattingEnabled = true;
            this.cbCorPena.Location = new System.Drawing.Point(108, 19);
            this.cbCorPena.Name = "cbCorPena";
            this.cbCorPena.Size = new System.Drawing.Size(155, 21);
            this.cbCorPena.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cor da pena:";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcionar.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.ForeColor = System.Drawing.Color.White;
            this.btnAdcionar.Location = new System.Drawing.Point(12, 209);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(544, 40);
            this.btnAdcionar.TabIndex = 17;
            this.btnAdcionar.Text = "Adcionar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // frAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(567, 273);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.gbAve);
            this.Controls.Add(this.gpMamifero);
            this.Controls.Add(this.gpPadrao);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label1);
            this.Name = "frAddAnimal";
            this.Text = "Adcionar Animal";
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).EndInit();
            this.gpPadrao.ResumeLayout(false);
            this.gpPadrao.PerformLayout();
            this.gpMamifero.ResumeLayout(false);
            this.gpMamifero.PerformLayout();
            this.gbAve.ResumeLayout(false);
            this.gbAve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.NumericUpDown nupIdade;
        private System.Windows.Forms.GroupBox gpPadrao;
        private System.Windows.Forms.GroupBox gpMamifero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAve;
        private System.Windows.Forms.ComboBox cbCorPelos;
        private System.Windows.Forms.ComboBox cbCorPena;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdcionar;
    }
}