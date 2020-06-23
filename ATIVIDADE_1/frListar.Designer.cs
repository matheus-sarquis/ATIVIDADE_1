namespace ATIVIDADE_1
{
    partial class frListar
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
            this.btnMamiferos = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnOvip = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnVoa = new System.Windows.Forms.Button();
            this.btnIdade = new System.Windows.Forms.Button();
            this.btnAlfa = new System.Windows.Forms.Button();
            this.btnPred = new System.Windows.Forms.Button();
            this.txtGrande = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listar";
            // 
            // btnMamiferos
            // 
            this.btnMamiferos.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMamiferos.Location = new System.Drawing.Point(205, 6);
            this.btnMamiferos.Name = "btnMamiferos";
            this.btnMamiferos.Size = new System.Drawing.Size(138, 28);
            this.btnMamiferos.TabIndex = 2;
            this.btnMamiferos.Text = "Apenas Mamíferos";
            this.btnMamiferos.UseVisualStyleBackColor = true;
            // 
            // btnListAll
            // 
            this.btnListAll.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListAll.Location = new System.Drawing.Point(66, 6);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(133, 28);
            this.btnListAll.TabIndex = 3;
            this.btnListAll.Text = "Todos os Animais";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnOvip
            // 
            this.btnOvip.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOvip.Location = new System.Drawing.Point(349, 6);
            this.btnOvip.Name = "btnOvip";
            this.btnOvip.Size = new System.Drawing.Size(129, 28);
            this.btnOvip.TabIndex = 4;
            this.btnOvip.Text = "Apenas Ovíparos";
            this.btnOvip.UseVisualStyleBackColor = true;
            // 
            // btnAqua
            // 
            this.btnAqua.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAqua.Location = new System.Drawing.Point(484, 6);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(133, 28);
            this.btnAqua.TabIndex = 5;
            this.btnAqua.Text = "Apenas Aquáticos";
            this.btnAqua.UseVisualStyleBackColor = true;
            // 
            // btnVoa
            // 
            this.btnVoa.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVoa.Location = new System.Drawing.Point(623, 6);
            this.btnVoa.Name = "btnVoa";
            this.btnVoa.Size = new System.Drawing.Size(130, 28);
            this.btnVoa.TabIndex = 6;
            this.btnVoa.Text = "Apenas Voadores";
            this.btnVoa.UseVisualStyleBackColor = true;
            // 
            // btnIdade
            // 
            this.btnIdade.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIdade.Location = new System.Drawing.Point(66, 40);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(158, 28);
            this.btnIdade.TabIndex = 7;
            this.btnIdade.Text = "Por Ordem de Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            // 
            // btnAlfa
            // 
            this.btnAlfa.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlfa.Location = new System.Drawing.Point(230, 40);
            this.btnAlfa.Name = "btnAlfa";
            this.btnAlfa.Size = new System.Drawing.Size(164, 28);
            this.btnAlfa.TabIndex = 8;
            this.btnAlfa.Text = "Por Ordem Alfabética";
            this.btnAlfa.UseVisualStyleBackColor = true;
            // 
            // btnPred
            // 
            this.btnPred.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPred.Location = new System.Drawing.Point(400, 40);
            this.btnPred.Name = "btnPred";
            this.btnPred.Size = new System.Drawing.Size(164, 28);
            this.btnPred.TabIndex = 9;
            this.btnPred.Text = "Apenas Predadores";
            this.btnPred.UseVisualStyleBackColor = true;
            // 
            // txtGrande
            // 
            this.txtGrande.Location = new System.Drawing.Point(12, 74);
            this.txtGrande.Multiline = true;
            this.txtGrande.Name = "txtGrande";
            this.txtGrande.ReadOnly = true;
            this.txtGrande.Size = new System.Drawing.Size(749, 463);
            this.txtGrande.TabIndex = 10;
            // 
            // frListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(773, 549);
            this.Controls.Add(this.txtGrande);
            this.Controls.Add(this.btnPred);
            this.Controls.Add(this.btnAlfa);
            this.Controls.Add(this.btnIdade);
            this.Controls.Add(this.btnVoa);
            this.Controls.Add(this.btnAqua);
            this.Controls.Add(this.btnOvip);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnMamiferos);
            this.Controls.Add(this.label1);
            this.Name = "frListar";
            this.Text = "Listagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMamiferos;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnOvip;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.Button btnVoa;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Button btnAlfa;
        private System.Windows.Forms.Button btnPred;
        private System.Windows.Forms.TextBox txtGrande;
    }
}