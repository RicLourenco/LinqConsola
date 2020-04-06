namespace LinqUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_TodosAlunos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numeric_DisciplinasFeitas = new System.Windows.Forms.NumericUpDown();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Listbox_filtro = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DisciplinasFeitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os alunos:";
            // 
            // CB_TodosAlunos
            // 
            this.CB_TodosAlunos.FormattingEnabled = true;
            this.CB_TodosAlunos.Location = new System.Drawing.Point(12, 25);
            this.CB_TodosAlunos.Name = "CB_TodosAlunos";
            this.CB_TodosAlunos.Size = new System.Drawing.Size(121, 21);
            this.CB_TodosAlunos.TabIndex = 1;
            this.CB_TodosAlunos.SelectedIndexChanged += new System.EventHandler(this.CB_TodosAlunos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplinas feitas:";
            // 
            // Numeric_DisciplinasFeitas
            // 
            this.Numeric_DisciplinasFeitas.Location = new System.Drawing.Point(106, 72);
            this.Numeric_DisciplinasFeitas.Name = "Numeric_DisciplinasFeitas";
            this.Numeric_DisciplinasFeitas.Size = new System.Drawing.Size(50, 20);
            this.Numeric_DisciplinasFeitas.TabIndex = 3;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(12, 111);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alunos filtrados:";
            // 
            // Listbox_filtro
            // 
            this.Listbox_filtro.FormattingEnabled = true;
            this.Listbox_filtro.Location = new System.Drawing.Point(184, 25);
            this.Listbox_filtro.Name = "Listbox_filtro";
            this.Listbox_filtro.Size = new System.Drawing.Size(120, 108);
            this.Listbox_filtro.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 146);
            this.Controls.Add(this.Listbox_filtro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Numeric_DisciplinasFeitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_TodosAlunos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_DisciplinasFeitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_TodosAlunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Numeric_DisciplinasFeitas;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Listbox_filtro;
    }
}

