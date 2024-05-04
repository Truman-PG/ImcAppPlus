namespace ImcAppPlus
{
    public partial class frmCalculaImc : Form
    {
        public frmCalculaImc()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pega o número do peso e coloca na varíavel
            decimal peso = numPeso.Value;

            // Pega a altura e coloca na variável
            decimal altura = numAltura.Value;

            // Calcula os valores resultando no IMC
            decimal imc = peso / (altura * altura);

            // Mostra o IMC no campo da legenda resultado
            lblResultado.Text = imc.ToString(".#");

            if (imc < 17)
            {
                lblSeta.Location = new Point(368, 370);
            }
            else if (imc > 17 && imc < 18.4m)
            {
                lblSeta.Location = new Point(467, 370);
            }
            else if(imc > 18.4m && imc < 25)
            {
                lblSeta.Location = new Point(569, 370);
            }
            else if(imc > 25 && imc < 30)
            {
                lblSeta.Location = new Point(664, 370);
            }
            else if(imc > 30 && imc < 35)
            {
                lblSeta.Location = new Point(762, 370);
            }
            else if (imc > 35 && imc < 40)
            {
                lblSeta.Location = new Point(860, 370);
            }
            else if(imc > 40)
            {
                lblSeta.Location = new Point(959, 370);
            }

            lblSeta.Visible = true;
        }
    }
}
