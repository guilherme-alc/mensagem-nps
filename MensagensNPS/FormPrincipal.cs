using System.Runtime.Versioning;
using MensagensNPS.Models;

namespace MensagensNPS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public List<Template> TemplatesCadastrados { get; set; }

        private void CarregarFormPrincipal(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.WhiteSmoke;
                    break;
                }
            }
            //Image iconCopiar = Properties.Resources.;
            //Image iconCopiarRedimensionado = new Bitmap(iconCopiar, new Size(20, 20));
            //btnCopiarTemplate.Image = iconCopiarRedimensionado;
        }

        private void CadastrarTemplate(object sender, EventArgs e)
        {

            using (var modalCadastro = new FormCadastroTemplate())
            {
                modalCadastro.FormBorderStyle = FormBorderStyle.FixedDialog;
                modalCadastro.StartPosition = FormStartPosition.CenterParent;


                var resultado = modalCadastro.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    TemplatesCadastrados.Add(modalCadastro.NovoTemplate);
                }
            }
        }

        private void SairAplicação(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
