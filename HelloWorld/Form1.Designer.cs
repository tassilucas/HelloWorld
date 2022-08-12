namespace HelloWorld
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
            this.btnInclui = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.lstRegistros = new System.Windows.Forms.ListBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.checkBoxMasc = new System.Windows.Forms.CheckBox();
            this.checkBoxFem = new System.Windows.Forms.CheckBox();
            this.txtRegistros = new System.Windows.Forms.TextBox();
            this.btnContarNoCtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInclui
            // 
            this.btnInclui.Location = new System.Drawing.Point(300, 144);
            this.btnInclui.Name = "btnInclui";
            this.btnInclui.Size = new System.Drawing.Size(75, 23);
            this.btnInclui.TabIndex = 0;
            this.btnInclui.Text = "Inclui";
            this.btnInclui.UseVisualStyleBackColor = true;
            this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.Location = new System.Drawing.Point(381, 144);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(75, 23);
            this.btnAltera.TabIndex = 1;
            this.btnAltera.Text = "Altera";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(462, 144);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 2;
            this.btnExclui.Text = "Exclui";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // lstRegistros
            // 
            this.lstRegistros.FormattingEnabled = true;
            this.lstRegistros.Location = new System.Drawing.Point(34, 25);
            this.lstRegistros.Name = "lstRegistros";
            this.lstRegistros.Size = new System.Drawing.Size(244, 186);
            this.lstRegistros.TabIndex = 3;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(335, 44);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 4;
            this.Cidade.Text = "Cidade";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(335, 73);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(31, 13);
            this.Sexo.TabIndex = 5;
            this.Sexo.Text = "Sexo";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(335, 105);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(381, 41);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(156, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(381, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 8;
            // 
            // checkBoxMasc
            // 
            this.checkBoxMasc.AutoSize = true;
            this.checkBoxMasc.Location = new System.Drawing.Point(381, 73);
            this.checkBoxMasc.Name = "checkBoxMasc";
            this.checkBoxMasc.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMasc.TabIndex = 9;
            this.checkBoxMasc.Text = "Masculino";
            this.checkBoxMasc.UseVisualStyleBackColor = true;
            // 
            // checkBoxFem
            // 
            this.checkBoxFem.AutoSize = true;
            this.checkBoxFem.Location = new System.Drawing.Point(463, 72);
            this.checkBoxFem.Name = "checkBoxFem";
            this.checkBoxFem.Size = new System.Drawing.Size(68, 17);
            this.checkBoxFem.TabIndex = 10;
            this.checkBoxFem.Text = "Feminino";
            this.checkBoxFem.UseVisualStyleBackColor = true;
            // 
            // txtRegistros
            // 
            this.txtRegistros.Location = new System.Drawing.Point(34, 227);
            this.txtRegistros.Multiline = true;
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegistros.Size = new System.Drawing.Size(503, 116);
            this.txtRegistros.TabIndex = 11;
            // 
            // btnContarNoCtt
            // 
            this.btnContarNoCtt.Location = new System.Drawing.Point(34, 349);
            this.btnContarNoCtt.Name = "btnContarNoCtt";
            this.btnContarNoCtt.Size = new System.Drawing.Size(222, 23);
            this.btnContarNoCtt.TabIndex = 12;
            this.btnContarNoCtt.Text = "contar no de contatos por cidade";
            this.btnContarNoCtt.UseVisualStyleBackColor = true;
            this.btnContarNoCtt.Click += new System.EventHandler(this.btnContarNoCtt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 391);
            this.Controls.Add(this.btnContarNoCtt);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.checkBoxFem);
            this.Controls.Add(this.checkBoxMasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.lstRegistros);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnInclui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInclui;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.ListBox lstRegistros;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox checkBoxMasc;
        private System.Windows.Forms.CheckBox checkBoxFem;
        private System.Windows.Forms.TextBox txtRegistros;
        private System.Windows.Forms.Button btnContarNoCtt;
    }
}

