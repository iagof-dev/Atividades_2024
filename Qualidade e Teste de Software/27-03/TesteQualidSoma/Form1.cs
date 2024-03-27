namespace TesteQualidSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_n2.ReadOnly = true;
            txt_Resultado.ReadOnly = true;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            bool tudo_ok = false;

            string value_1 = txt_n1.Text;
            double vn1;
            if (double.TryParse(value_1, out vn1))
            {
                n1 = Convert.ToDouble(value_1);
            }
            else
            {
                tudo_ok = false;
            }

            string value_2 = txt_n2.Text;
            double vn2;
            if (double.TryParse(value_2, out vn2))
            {
                n2 = Convert.ToDouble(value_2);
                tudo_ok = true;
            }
            else
            {
                tudo_ok = false;
            }

            if (n1 == 0 || n2 == 0)
            {
                MessageBox.Show($"Apenas números para somar.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Clear();
                txt_n2.Clear();
                txt_Resultado.Clear();
                txt_n1.Focus();
            }

            if (tudo_ok && n1 != 0 && n2 != 0)
            {
                double result = n1 + n2;
                txt_Resultado.Text = result.ToString();
                txt_n1.Clear();
                txt_n2.Clear();
                MessageBox.Show($"Resultado da soma: {n1 + n2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_n2.ReadOnly = true;
                txt_n1.Focus();

            }

        }


        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_Resultado.Clear();
            txt_n2.ReadOnly = true;
            txt_n1.Focus();
        }

        private void txt_n1_TextChanged(object sender, EventArgs e)
        {
            txt_n2.ReadOnly = false;

        }
    }
}
