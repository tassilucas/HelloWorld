using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace HelloWorld
{
    public partial class Form1 : Form
    {

        public SqlConnection cn;
        public CultureInfo br;

        public Form1()
        {
            InitializeComponent();

            this.br = new CultureInfo("pt-BR");

            try
            {
                this.cn = new SqlConnection("Data Source=DESKTOP-FJJBHMH;Initial Catalog=aueDB;Integrated Security=True");
                this.cn.Open();
            }
            catch
            {
                Console.WriteLine("Couldnt connect to database");
            }
        }

        private bool validCheckBox()
        {
            if ((checkBoxMasc.Checked && checkBoxFem.Checked) ||
                (!checkBoxMasc.Checked && !checkBoxFem.Checked))
            {
                System.Windows.Forms.MessageBox.Show("Marque apenas um sexo.");
                return false;
            }
            else
                return true;
        }

        private int checkSexo()
        {
            if (checkBoxMasc.Checked && !checkBoxFem.Checked)
                return 1;
            else
                return 0;
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCidade.Text) && validCheckBox())
            {
                string strCmd = "INSERT INTO registro " +
                    "VALUES (" + "'" + txtNome.Text + "'" + ", " + checkSexo() + ", CURRENT_TIMESTAMP, " + "'" + txtCidade.Text + "'" + ");";
                SqlCommand cmd = new SqlCommand(strCmd, this.cn);
                cmd.ExecuteNonQuery();

                lstRegistros.Items.Add("Inserido: " + txtCidade.Text + " -> " + txtNome.Text);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCidade.Text) && validCheckBox())
            {
                string strCmd = "UPDATE registro SET cidade = " + "'" + txtCidade.Text + "' " + "WHERE nome = " + "'" + txtNome.Text + "';";
                SqlCommand cmd = new SqlCommand(strCmd, this.cn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE registro SET sexo = " + checkSexo() + "WHERE nome = " + "'" + txtNome.Text + "';";
                cmd.ExecuteNonQuery();
                lstRegistros.Items.Add("Alterado: " + txtNome.Text + " -> " + txtCidade.Text);
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                string strCmd = "DELETE FROM registro WHERE nome = '" + txtNome.Text + "' AND cidade = '" + txtCidade.Text + "';";
                SqlCommand cmd = new SqlCommand(strCmd, this.cn);
                cmd.ExecuteNonQuery();
                lstRegistros.Items.Add("Excluido: " + txtNome.Text + " -> " + txtCidade.Text);
            }
        }

        private void headerRow()
        {
            using (SqlCommand cmd = new SqlCommand("select sum(case when sexo = 1 then 1 else 0 end) as homem," +
                "sum(case when sexo = 0 then 1 else 0 end) as mulher " +
                "from registro;", this.cn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        txtRegistros.Text += ". Numero de contatos no banco de dados: Total: " + (Convert.ToInt32(reader["homem"]) + Convert.ToInt32(reader["mulher"]))
                    + ", " + reader["homem"] + " homens e " + reader["mulher"] + " mulheres" + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        private void btnContarNoCtt_Click(object sender, EventArgs e)
        {
            txtRegistros.Text = "";
            headerRow();

            SqlCommand cmd = new SqlCommand("select cidade, month(data_reg) as mes," +
                "sum(case when sexo = 1 then 1 else 0 end) as homem," +
                "sum(case when sexo = 0 then 1 else 0 end) as mulher " +
                "from registro " +
                "group by cidade, month(data_reg);", this.cn);

            txtRegistros.Text += "Analise dos contatos:" + Environment.NewLine + Environment.NewLine;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                int total = 0;
                string ultimaCidade = "";

                // To help output formatting
                bool firstRow = true;

                while (reader.Read())
                {
                    int homem = Convert.ToInt32(reader["homem"]);
                    int mulher = Convert.ToInt32(reader["mulher"]);
                    int month = Convert.ToInt32(reader["mes"]);
                    string cidade = Convert.ToString(reader["cidade"]);

                    if (!String.Equals(cidade, ultimaCidade))
                    {

                        if (!firstRow)
                            txtRegistros.Text += "Total: " + total + Environment.NewLine + Environment.NewLine;

                        txtRegistros.Text += ". Contatos em " + cidade.ToUpper() + Environment.NewLine;
                        total = 0;
                        firstRow = false;
                    }

                    string sent = String.Format("{0}: {1}, {2} homens e {3} mulher", this.br.DateTimeFormat.GetMonthName(month), homem + mulher, homem, mulher);
                    txtRegistros.Text += sent + Environment.NewLine;
                    total += homem + mulher;
                    ultimaCidade = cidade;
                }

                txtRegistros.Text += "Total: " + total + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        ~Form1()
        {
            this.cn.Close();
        }
    }
}