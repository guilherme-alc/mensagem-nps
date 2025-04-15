﻿namespace MensagensNPS
{
    partial class FormCadastroTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroTemplate));
            btnCadastrar = new Button();
            txtConteudoTemplate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeTemplate = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.LightSkyBlue;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(469, 273);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 34);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += Cadastrar;
            // 
            // txtConteudoTemplate
            // 
            txtConteudoTemplate.Location = new Point(12, 60);
            txtConteudoTemplate.Multiline = true;
            txtConteudoTemplate.Name = "txtConteudoTemplate";
            txtConteudoTemplate.ScrollBars = ScrollBars.Vertical;
            txtConteudoTemplate.Size = new Size(532, 207);
            txtConteudoTemplate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(245, 17);
            label1.TabIndex = 2;
            label1.Text = "Informe abaixo o conteúdo do template:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(397, 15);
            label2.TabIndex = 3;
            label2.Text = "Substitua no template os dados que serão variáveis por [nome] e [link]";
            // 
            // txtNomeTemplate
            // 
            txtNomeTemplate.Location = new Point(142, 9);
            txtNomeTemplate.Name = "txtNomeTemplate";
            txtNomeTemplate.Size = new Size(127, 23);
            txtNomeTemplate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 5;
            label3.Text = "Nome do Template:";
            // 
            // FormCadastroTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 319);
            Controls.Add(label3);
            Controls.Add(txtNomeTemplate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConteudoTemplate);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(514, 313);
            Name = "FormCadastroTemplate";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "CadastroTemplate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtConteudoTemplate;
        private Label label1;
        private Label label2;
        private TextBox txtNomeTemplate;
        private Label label3;
    }
}