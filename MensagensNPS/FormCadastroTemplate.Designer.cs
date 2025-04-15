namespace MensagensNPS
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
            txtTemplate = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.LightSkyBlue;
            btnCadastrar.Location = new Point(411, 239);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += Cadastrar;
            // 
            // txtTemplate
            // 
            txtTemplate.Location = new Point(12, 26);
            txtTemplate.Multiline = true;
            txtTemplate.Name = "txtTemplate";
            txtTemplate.ScrollBars = ScrollBars.Vertical;
            txtTemplate.Size = new Size(474, 207);
            txtTemplate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 2;
            label1.Text = "Informe abaixo o template que será utilizado:";
            // 
            // CadastroTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 274);
            Controls.Add(label1);
            Controls.Add(txtTemplate);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(514, 313);
            MinimumSize = new Size(514, 313);
            Name = "CadastroTemplate";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "CadastroTemplate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtTemplate;
        private Label label1;
    }
}