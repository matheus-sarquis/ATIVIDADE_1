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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gpPadrao = new System.Windows.Forms.GroupBox();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.gpPadrao.SuspendLayout();
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
            "Esquilo",
            "Gato",
            "Gavião",
            "Leão",
            "Morcego",
            "Ornitorrinco",
            "Pato",
            "Pinguim",
            "Pombo",
            "Tartaruga",
            "Tubarão"});
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(340, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(160, 45);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(243, 20);
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
            this.cbSexo.Size = new System.Drawing.Size(348, 21);
            this.cbSexo.TabIndex = 10;
            // 
            // gpPadrao
            // 
            this.gpPadrao.Controls.Add(this.label2);
            this.gpPadrao.Controls.Add(this.label3);
            this.gpPadrao.Controls.Add(this.label4);
            this.gpPadrao.Controls.Add(this.cbSexo);
            this.gpPadrao.Controls.Add(this.txtData);
            this.gpPadrao.Controls.Add(this.txtNome);
            this.gpPadrao.Location = new System.Drawing.Point(12, 69);
            this.gpPadrao.Name = "gpPadrao";
            this.gpPadrao.Size = new System.Drawing.Size(409, 104);
            this.gpPadrao.TabIndex = 14;
            this.gpPadrao.TabStop = false;
            this.gpPadrao.Text = "Padrão";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcionar.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.ForeColor = System.Drawing.Color.White;
            this.btnAdcionar.Location = new System.Drawing.Point(12, 179);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(409, 40);
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
            this.ClientSize = new System.Drawing.Size(436, 231);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.gpPadrao);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label1);
            this.Name = "frAddAnimal";
            this.Text = "Adcionar Animal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frAddAnimal_FormClosing);
            this.gpPadrao.ResumeLayout(false);
            this.gpPadrao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox gpPadrao;
        private System.Windows.Forms.Button btnAdcionar;
    }
}