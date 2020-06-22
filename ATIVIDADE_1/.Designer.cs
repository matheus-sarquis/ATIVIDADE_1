namespace ATIVIDADE_1
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAmbiente1 = new System.Windows.Forms.Button();
            this.btnAmbiente2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(216, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 501);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAmbiente1
            // 
            this.btnAmbiente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAmbiente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbiente1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbiente1.ForeColor = System.Drawing.Color.White;
            this.btnAmbiente1.Location = new System.Drawing.Point(216, 12);
            this.btnAmbiente1.Name = "btnAmbiente1";
            this.btnAmbiente1.Size = new System.Drawing.Size(419, 56);
            this.btnAmbiente1.TabIndex = 2;
            this.btnAmbiente1.Text = "Ambiente 1";
            this.btnAmbiente1.UseVisualStyleBackColor = false;
            // 
            // btnAmbiente2
            // 
            this.btnAmbiente2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAmbiente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbiente2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbiente2.ForeColor = System.Drawing.Color.White;
            this.btnAmbiente2.Location = new System.Drawing.Point(641, 12);
            this.btnAmbiente2.Name = "btnAmbiente2";
            this.btnAmbiente2.Size = new System.Drawing.Size(419, 56);
            this.btnAmbiente2.TabIndex = 3;
            this.btnAmbiente2.Text = "Ambiente 2";
            this.btnAmbiente2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1072, 587);
            this.Controls.Add(this.btnAmbiente2);
            this.Controls.Add(this.btnAmbiente1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAmbiente1;
        private System.Windows.Forms.Button btnAmbiente2;
    }
}

