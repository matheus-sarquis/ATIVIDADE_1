namespace ATIVIDADE_1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.nupIdade = new System.Windows.Forms.NumericUpDown();
            this.cbCarnivoro = new System.Windows.Forms.ComboBox();
            this.cbPeconhento = new System.Windows.Forms.ComboBox();
            this.gpPadrao = new System.Windows.Forms.GroupBox();
            this.gpMamifero = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nupQtdMamas = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPelos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).BeginInit();
            this.gpPadrao.SuspendLayout();
            this.gpMamifero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdMamas)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Carnívoro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Peçonhento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(160, 48);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(93, 20);
            this.txtData.TabIndex = 9;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cbSexo.Location = new System.Drawing.Point(55, 77);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(198, 21);
            this.cbSexo.TabIndex = 10;
            // 
            // nupIdade
            // 
            this.nupIdade.Location = new System.Drawing.Point(63, 107);
            this.nupIdade.Name = "nupIdade";
            this.nupIdade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupIdade.Size = new System.Drawing.Size(190, 20);
            this.nupIdade.TabIndex = 11;
            // 
            // cbCarnivoro
            // 
            this.cbCarnivoro.FormattingEnabled = true;
            this.cbCarnivoro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbCarnivoro.Location = new System.Drawing.Point(91, 136);
            this.cbCarnivoro.Name = "cbCarnivoro";
            this.cbCarnivoro.Size = new System.Drawing.Size(162, 21);
            this.cbCarnivoro.TabIndex = 12;
            // 
            // cbPeconhento
            // 
            this.cbPeconhento.FormattingEnabled = true;
            this.cbPeconhento.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbPeconhento.Location = new System.Drawing.Point(102, 166);
            this.cbPeconhento.Name = "cbPeconhento";
            this.cbPeconhento.Size = new System.Drawing.Size(151, 21);
            this.cbPeconhento.TabIndex = 13;
            // 
            // gpPadrao
            // 
            this.gpPadrao.Controls.Add(this.cbPeconhento);
            this.gpPadrao.Controls.Add(this.label2);
            this.gpPadrao.Controls.Add(this.cbCarnivoro);
            this.gpPadrao.Controls.Add(this.label3);
            this.gpPadrao.Controls.Add(this.nupIdade);
            this.gpPadrao.Controls.Add(this.label4);
            this.gpPadrao.Controls.Add(this.cbSexo);
            this.gpPadrao.Controls.Add(this.label5);
            this.gpPadrao.Controls.Add(this.txtData);
            this.gpPadrao.Controls.Add(this.label6);
            this.gpPadrao.Controls.Add(this.txtNome);
            this.gpPadrao.Controls.Add(this.label7);
            this.gpPadrao.Location = new System.Drawing.Point(12, 69);
            this.gpPadrao.Name = "gpPadrao";
            this.gpPadrao.Size = new System.Drawing.Size(269, 205);
            this.gpPadrao.TabIndex = 14;
            this.gpPadrao.TabStop = false;
            this.gpPadrao.Text = "Padrão";
            // 
            // gpMamifero
            // 
            this.gpMamifero.Controls.Add(this.comboBox1);
            this.gpMamifero.Controls.Add(this.label10);
            this.gpMamifero.Controls.Add(this.cbPelos);
            this.gpMamifero.Controls.Add(this.label9);
            this.gpMamifero.Controls.Add(this.nupQtdMamas);
            this.gpMamifero.Controls.Add(this.label8);
            this.gpMamifero.Location = new System.Drawing.Point(12, 280);
            this.gpMamifero.Name = "gpMamifero";
            this.gpMamifero.Size = new System.Drawing.Size(269, 118);
            this.gpMamifero.TabIndex = 15;
            this.gpMamifero.TabStop = false;
            this.gpMamifero.Text = "Mamífero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade de Mamas:";
            // 
            // nupQtdMamas
            // 
            this.nupQtdMamas.Location = new System.Drawing.Point(177, 20);
            this.nupQtdMamas.Name = "nupQtdMamas";
            this.nupQtdMamas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupQtdMamas.Size = new System.Drawing.Size(76, 20);
            this.nupQtdMamas.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pelos:";
            // 
            // cbPelos
            // 
            this.cbPelos.FormattingEnabled = true;
            this.cbPelos.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbPelos.Location = new System.Drawing.Point(58, 48);
            this.cbPelos.Name = "cbPelos";
            this.cbPelos.Size = new System.Drawing.Size(195, 21);
            this.cbPelos.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cor dos pelos:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // frAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.gpMamifero);
            this.Controls.Add(this.gpPadrao);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label1);
            this.Name = "frAddAnimal";
            this.Text = "frAddAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).EndInit();
            this.gpPadrao.ResumeLayout(false);
            this.gpPadrao.PerformLayout();
            this.gpMamifero.ResumeLayout(false);
            this.gpMamifero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdMamas)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.NumericUpDown nupIdade;
        private System.Windows.Forms.ComboBox cbCarnivoro;
        private System.Windows.Forms.ComboBox cbPeconhento;
        private System.Windows.Forms.GroupBox gpPadrao;
        private System.Windows.Forms.GroupBox gpMamifero;
        private System.Windows.Forms.ComboBox cbPelos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupQtdMamas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
    }
}