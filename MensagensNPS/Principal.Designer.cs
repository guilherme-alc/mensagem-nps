namespace MensagensNPS
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            comboBox1 = new ComboBox();
            lblTemplate = new Label();
            menuSuperior = new MenuStrip();
            inserirPlanilhaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnCadastrarTemplate = new Button();
            label1 = new Label();
            radObrigatorioSim = new RadioButton();
            radObrigatorioNao = new RadioButton();
            label2 = new Label();
            groupBox1 = new GroupBox();
            statusRodape = new StatusStrip();
            planilhaSelecionada = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            btnGerarMensagem = new Button();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            txtMensagem = new TextBox();
            btnProximaMensagem = new Button();
            btnAnterior = new Button();
            groupBox3 = new GroupBox();
            menuSuperior.SuspendLayout();
            groupBox1.SuspendLayout();
            statusRodape.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 0;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Location = new Point(8, 89);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(198, 15);
            lblTemplate.TabIndex = 1;
            lblTemplate.Text = "Selecione o template da mensagem:";
            // 
            // menuSuperior
            // 
            menuSuperior.BackColor = Color.SteelBlue;
            menuSuperior.Items.AddRange(new ToolStripItem[] { inserirPlanilhaToolStripMenuItem, sairToolStripMenuItem });
            menuSuperior.Location = new Point(0, 0);
            menuSuperior.Name = "menuSuperior";
            menuSuperior.Size = new Size(800, 24);
            menuSuperior.TabIndex = 2;
            menuSuperior.Text = "menu";
            // 
            // inserirPlanilhaToolStripMenuItem
            // 
            inserirPlanilhaToolStripMenuItem.Name = "inserirPlanilhaToolStripMenuItem";
            inserirPlanilhaToolStripMenuItem.Size = new Size(96, 20);
            inserirPlanilhaToolStripMenuItem.Text = "Inserir Planilha";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // btnCadastrarTemplate
            // 
            btnCadastrarTemplate.BackColor = Color.LightSkyBlue;
            btnCadastrarTemplate.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrarTemplate.Location = new Point(271, 17);
            btnCadastrarTemplate.Name = "btnCadastrarTemplate";
            btnCadastrarTemplate.Size = new Size(131, 23);
            btnCadastrarTemplate.TabIndex = 3;
            btnCadastrarTemplate.Text = "Cadastrar Template";
            btnCadastrarTemplate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(248, 15);
            label1.TabIndex = 4;
            label1.Text = "Clique aqui para cadastrar um template novo:";
            // 
            // radObrigatorioSim
            // 
            radObrigatorioSim.AutoSize = true;
            radObrigatorioSim.Location = new Point(304, 53);
            radObrigatorioSim.Name = "radObrigatorioSim";
            radObrigatorioSim.Size = new Size(45, 19);
            radObrigatorioSim.TabIndex = 5;
            radObrigatorioSim.TabStop = true;
            radObrigatorioSim.Text = "Sim";
            radObrigatorioSim.UseVisualStyleBackColor = true;
            // 
            // radObrigatorioNao
            // 
            radObrigatorioNao.AutoSize = true;
            radObrigatorioNao.Location = new Point(355, 53);
            radObrigatorioNao.Name = "radObrigatorioNao";
            radObrigatorioNao.Size = new Size(47, 19);
            radObrigatorioNao.TabIndex = 6;
            radObrigatorioNao.TabStop = true;
            radObrigatorioNao.Text = "Não";
            radObrigatorioNao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(290, 15);
            label2.TabIndex = 7;
            label2.Text = "Todas as variáves são obrigatórias para esse template?";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCadastrarTemplate);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblTemplate);
            groupBox1.Controls.Add(radObrigatorioNao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radObrigatorioSim);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 145);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // statusRodape
            // 
            statusRodape.BackColor = Color.SteelBlue;
            statusRodape.Items.AddRange(new ToolStripItem[] { planilhaSelecionada });
            statusRodape.Location = new Point(0, 428);
            statusRodape.Name = "statusRodape";
            statusRodape.Size = new Size(800, 22);
            statusRodape.TabIndex = 9;
            statusRodape.Text = "rodape";
            // 
            // planilhaSelecionada
            // 
            planilhaSelecionada.Name = "planilhaSelecionada";
            planilhaSelecionada.Size = new Size(0, 17);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnGerarMensagem);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(427, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 145);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Variáveis";
            // 
            // btnGerarMensagem
            // 
            btnGerarMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGerarMensagem.BackColor = Color.LightSkyBlue;
            btnGerarMensagem.ForeColor = SystemColors.ControlText;
            btnGerarMensagem.Location = new Point(280, 110);
            btnGerarMensagem.Name = "btnGerarMensagem";
            btnGerarMensagem.Size = new Size(75, 23);
            btnGerarMensagem.TabIndex = 8;
            btnGerarMensagem.Text = "Gerar";
            btnGerarMensagem.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(113, 110);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(54, 23);
            numericUpDown2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 114);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 6;
            label6.Text = "Coluna do Link:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(113, 48);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 52);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Coluna do Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Link:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(50, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(50, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 0;
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMensagem.Location = new Point(8, 42);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ScrollBars = ScrollBars.Vertical;
            txtMensagem.Size = new Size(762, 199);
            txtMensagem.TabIndex = 11;
            // 
            // btnProximaMensagem
            // 
            btnProximaMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProximaMensagem.BackColor = Color.LightSkyBlue;
            btnProximaMensagem.ForeColor = SystemColors.ControlText;
            btnProximaMensagem.Location = new Point(695, 13);
            btnProximaMensagem.Name = "btnProximaMensagem";
            btnProximaMensagem.Size = new Size(75, 23);
            btnProximaMensagem.TabIndex = 13;
            btnProximaMensagem.Text = "Próximo";
            btnProximaMensagem.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.BackColor = Color.LightGray;
            btnAnterior.ForeColor = SystemColors.ControlText;
            btnAnterior.Location = new Point(614, 13);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 14;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnAnterior);
            groupBox3.Controls.Add(btnProximaMensagem);
            groupBox3.Controls.Add(txtMensagem);
            groupBox3.Location = new Point(12, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 247);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mensagem";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(statusRodape);
            Controls.Add(groupBox1);
            Controls.Add(menuSuperior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuSuperior;
            MinimumSize = new Size(816, 489);
            Name = "Principal";
            Text = " Gerador de mensagem";
            menuSuperior.ResumeLayout(false);
            menuSuperior.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusRodape.ResumeLayout(false);
            statusRodape.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblTemplate;
        private MenuStrip menuSuperior;
        private ToolStripMenuItem inserirPlanilhaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnCadastrarTemplate;
        private Label label1;
        private RadioButton radObrigatorioSim;
        private RadioButton radObrigatorioNao;
        private Label label2;
        private GroupBox groupBox1;
        private StatusStrip statusRodape;
        private ToolStripStatusLabel planilhaSelecionada;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox txtMensagem;
        private Button btnProximaMensagem;
        private Button btnGerarMensagem;
        private Button btnAnterior;
        private GroupBox groupBox3;
    }
}
