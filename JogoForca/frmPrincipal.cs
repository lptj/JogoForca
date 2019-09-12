using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        string[] PalavraSort = new string[20];
        List<string> LetraDig = new List<string>();        
        Palavras objPalavra = new Palavras();

        int chances = 0;
        int acertos = 0;
        string dica = "";
        string palavra_sort = "";
        
        //métodos
        private void LimparJogo()
        {
            objPalavra.LimparPalavra();
            for(int i = 0; i < PalavraSort.Length; i++)
            {
                PalavraSort[i] = " ";
            }

            LetraDig.Clear();
            chances = 0;
            acertos = 0;
            palavra_sort = "";
            dica = "";
            txtLetra.Text = "";
        }

        private void JogarNovamente()
        {
            LimparJogo();
            btnSortearNov.Enabled = true;
            btnJogar.Enabled = true;
            lblDica.Visible = false;
            lblChances.Visible = false;
            lblPalavraSort.Visible = false;
            gpbJogoForca.Enabled = false;
        }

        private void ComecaJogo()
        {
            LimparJogo();
            VerificaNivel();
            dica = objPalavra.SorteioCategoria();
            palavra_sort = objPalavra.SorteiaPalavra(dica);
            ContaLetra();

            btnJogar.Enabled = false;
            btnJogarNovamente.Enabled = false;
            lblDica.Text = dica;
            lblDica.Visible = true;
            lblChances.Visible = true;
            lblPalavraSort.Visible = true;
            btnOk.Enabled = true;
            txtLetra.Enabled = true;
            gpbJogoForca.Enabled = true;
        }        

        private void VerificaNivel()
        {
            if (rbtnNivel1.Checked == true)
            {
                chances = 10;
                lblChances.Text = Convert.ToString(chances);
            }
            else
            {
                chances = 5;
                lblChances.Text = Convert.ToString(chances);
            }
        }

        private void ContaLetra()
        {
            string separador = " ";

            for (int i = 0; i < palavra_sort.Length; i++)
            {
                PalavraSort[i] = "_";
            }
            lblPalavraSort.Text = string.Join(separador, PalavraSort);
        }

        private void VerificaLetraDig()
        {
            bool letra = false;

            for (int i = 0; i < LetraDig.Count; i++)
            {
                if(txtLetra.Text == LetraDig[i])
                {
                    letra = true;
                }
            }

            if (letra)
            {
                MessageBox.Show("Letra já digitada, tente outra!");
            }
            else
            {
                LetraDig.Add(txtLetra.Text);
                if (VerificaPalavra())
                {
                    SubstituiLetra();
                    VerificaFim();                    
                }
                else
                {
                    MessageBox.Show("A palavra não tem essa letra, tente outra!");
                    chances--;
                    lblChances.Text = Convert.ToString(chances);
                    VerificaFim();
                } 
            }

        }

        private bool VerificaPalavra()
        {
            var chars = palavra_sort.ToCharArray();

            for (int i = 0; i < palavra_sort.Length; i++)
            {
                if (txtLetra.Text == Convert.ToString(chars[i]))
                {
                    return true;                    
                }
            }
            return false;
        }

        private void SubstituiLetra()
        {
            string separador = " ";
            var chars = palavra_sort.ToCharArray();

            for (int i = 0; i < palavra_sort.Length; i++)
            {
                if (txtLetra.Text == Convert.ToString(chars[i]))
                {
                    PalavraSort[i] = Convert.ToString(chars[i]);
                    acertos++;
                }
            }
            lblPalavraSort.Text = string.Join(separador, PalavraSort);
        }

        private void VerificaFim()
        {
            if(chances == 0)
            {
                MessageBox.Show("Você perdeu!!\nA palavra era: "+ palavra_sort);
                txtLetra.Enabled = false;
                btnOk.Enabled = false;
                btnJogarNovamente.Enabled = true;
            }
            else if(acertos == palavra_sort.Length)
            {
                MessageBox.Show("Parabés, você ganhou!!");
                txtLetra.Enabled = false;
                btnOk.Enabled = false;
                btnJogarNovamente.Enabled = true;
            }
        }

        
        //botões
        private void btnJogar_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            txtLetra.Focus();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            VerificaLetraDig();
            txtLetra.SelectAll();
            txtLetra.Focus();
            btnSortearNov.Enabled = false;
        }
        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            JogarNovamente();
        }        
        private void btnSortearNov_Click(object sender, EventArgs e)
        {
            ComecaJogo();
            txtLetra.SelectAll();
            txtLetra.Focus();
        }
    }
}
