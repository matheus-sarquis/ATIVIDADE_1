﻿namespace ATIVIDADE_1
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
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnlistagem = new System.Windows.Forms.Button();
            this.pAmbiente = new System.Windows.Forms.Panel();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
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
            this.btnAddAnimal.Size = new System.Drawing.Size(198, 56);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Adcionar Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o animal:";
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(12, 100);
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
            this.btnDireita.Location = new System.Drawing.Point(142, 614);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(56, 56);
            this.btnDireita.TabIndex = 7;
            this.btnDireita.Text = "→";
            this.btnDireita.UseVisualStyleBackColor = false;
            // 
            // btnCima
            // 
            this.btnCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCima.Enabled = false;
            this.btnCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCima.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCima.ForeColor = System.Drawing.Color.White;
            this.btnCima.Location = new System.Drawing.Point(79, 552);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(56, 56);
            this.btnCima.TabIndex = 8;
            this.btnCima.Text = "↑";
            this.btnCima.UseVisualStyleBackColor = false;
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBaixo.Enabled = false;
            this.btnBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixo.ForeColor = System.Drawing.Color.White;
            this.btnBaixo.Location = new System.Drawing.Point(79, 614);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(56, 56);
            this.btnBaixo.TabIndex = 9;
            this.btnBaixo.Text = "↓";
            this.btnBaixo.UseVisualStyleBackColor = false;
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEsquerda.Enabled = false;
            this.btnEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsquerda.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquerda.ForeColor = System.Drawing.Color.White;
            this.btnEsquerda.Location = new System.Drawing.Point(16, 614);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(56, 56);
            this.btnEsquerda.TabIndex = 10;
            this.btnEsquerda.Text = "←";
            this.btnEsquerda.UseVisualStyleBackColor = false;
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMovimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentar.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentar.ForeColor = System.Drawing.Color.White;
            this.btnMovimentar.Location = new System.Drawing.Point(12, 502);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(198, 44);
            this.btnMovimentar.TabIndex = 11;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = false;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnlistagem
            // 
            this.btnlistagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlistagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistagem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistagem.ForeColor = System.Drawing.Color.White;
            this.btnlistagem.Location = new System.Drawing.Point(216, 12);
            this.btnlistagem.Name = "btnlistagem";
            this.btnlistagem.Size = new System.Drawing.Size(169, 56);
            this.btnlistagem.TabIndex = 12;
            this.btnlistagem.Text = "Listagens";
            this.btnlistagem.UseVisualStyleBackColor = false;
            this.btnlistagem.Click += new System.EventHandler(this.btnlistagem_Click);
            // 
            // pAmbiente
            // 
            this.pAmbiente.BackgroundImage = global::ATIVIDADE_1.Properties.Resources.FundoFazenda;
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
            this.pbAnimal.BackgroundImage = global::ATIVIDADE_1.Properties.Resources.Tartaruga;
            this.pbAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAnimal.Location = new System.Drawing.Point(107, 210);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(241, 197);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnimal.TabIndex = 24;
            this.pbAnimal.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Botar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Chocar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Voar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 44);
            this.button4.TabIndex = 18;
            this.button4.Text = "Amamentar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 44);
            this.button5.TabIndex = 19;
            this.button5.Text = "Atacar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 44);
            this.button6.TabIndex = 20;
            this.button6.Text = "Alimentar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 452);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 44);
            this.button7.TabIndex = 21;
            this.button7.Text = "Ciscar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ações:";
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
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1249, 682);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pAmbiente);
            this.Controls.Add(this.btnlistagem);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnCima);
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
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnlistagem;
        private System.Windows.Forms.Panel pAmbiente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbAnimal;
    }
}

