using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escalator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] escalas = {     "CDEFGAB",     "OMFISLC",     "DEIGABO",    "MFGSLCD",    "EISABOM", "FGALCDE",     "ISLBOMF",     "GABCDEI", "SLCOMFG"
        , "ABODEIS",    "LCDMFGA",     "BOMEISL"};
        // C#= O , D#= M , F#= I , G#= S , A#= L
        string[] escalasNome = { "Dó Maior", "Dó Sus. Maior", "Ré Maior", "Ré Sus. Maior", "Mi Maior", "Fá Maior", "Fá Sus. Maior", "Sol Maior", "Sol Sus. Maior"
        , "Lá Maior", "Lá Sus. Maior", "Si Maior"};
        bool C, Cs, D, Ds, E, F, Fs, G, Gs, A, As, B;
        int cont=0;

        private void lbl_C_Click(object sender, EventArgs e)
        {
            if (lbl_C.BackColor == Color.Plum)
            {
                lbl_C.BackColor = Color.Green;
                C = true;
                cont = cont + 1;
            }
            else
            {
                lbl_C.BackColor = Color.Plum;
                C = false;
                cont--;
            }
        }

        private void lbl_Cs_Click(object sender, EventArgs e)
        {
            if (lbl_Cs.BackColor == Color.Plum)
            {
                lbl_Cs.BackColor = Color.Green;
                Cs = true;
                cont = cont + 1;
            }
            else
            {
                lbl_Cs.BackColor = Color.Plum;
                Cs = false;
                cont--;
            }
        }

        private void lbl_D_Click(object sender, EventArgs e)
        {
            if (lbl_D.BackColor == Color.Plum)
            {
                lbl_D.BackColor = Color.Green;
                D = true;
                cont = cont + 1;
            }
            else
            {
                lbl_D.BackColor = Color.Plum;
                D = false;
                cont--;
            }
        }

        private void lbl_Ds_Click(object sender, EventArgs e)
        {
            if (lbl_Ds.BackColor == Color.Plum)
            {
                lbl_Ds.BackColor = Color.Green;
                Ds = true;
                cont = cont + 1;
            }
            else
            {
                lbl_Ds.BackColor = Color.Plum;
                Ds = false;
                cont--;
            }
        }

        private void lbl_E_Click(object sender, EventArgs e)
        {
            if (lbl_E.BackColor == Color.Plum)
            {
                lbl_E.BackColor = Color.Green;
                E = true;
                cont = cont + 1;

            }
            else
            {
                lbl_E.BackColor = Color.Plum;
                E = false;
                cont--;
            }
        }

        private void lbl_F_Click(object sender, EventArgs e)
        {
            if (lbl_F.BackColor == Color.Plum)
            {
                lbl_F.BackColor = Color.Green;
                F = true;
                cont = cont + 1;
            }
            else
            {
                lbl_F.BackColor = Color.Plum;
                F = false;
                cont--;
            }
        }

        private void lbl_Fs_Click(object sender, EventArgs e)
        {
            if (lbl_Fs.BackColor == Color.Plum)
            {
                lbl_Fs.BackColor = Color.Green;
                Fs = true;
                cont = cont + 1;
            }
            else
            {
                lbl_Fs.BackColor = Color.Plum;
                Fs = false;
                cont--;
            }
        }

        private void lbl_G_Click(object sender, EventArgs e)
        {
            if (lbl_G.BackColor == Color.Plum)
            {
                lbl_G.BackColor = Color.Green;
                G = true;
                cont = cont + 1;
            }
            else
            {
                lbl_G.BackColor = Color.Plum;
                G = false;
                cont--;
            }
        }

        private void lbl_Gs_Click(object sender, EventArgs e)
        {
            if (lbl_Gs.BackColor == Color.Plum)
            {
                lbl_Gs.BackColor = Color.Green;
                Gs = true;
                cont = cont + 1;
            }
            else
            {
                lbl_Gs.BackColor = Color.Plum;
                Gs = false;
                cont--;
            }
        }

        private void lbl_A_Click(object sender, EventArgs e)
        {
            if (lbl_A.BackColor == Color.Plum)
            {
                lbl_A.BackColor = Color.Green;
                A = true;
                cont = cont + 1;

            }
            else
            {
                lbl_A.BackColor = Color.Plum;
                A = false;
                cont--;
            }
        }

        private void lbl_As_Click(object sender, EventArgs e)
        {
            if (lbl_As.BackColor == Color.Plum)
            {
                lbl_As.BackColor = Color.Green;
                As = true;
                cont = cont + 1;

            }
            else
            {
                lbl_As.BackColor = Color.Plum;
                As = false;
                cont--;
            }
        }

        private void lbl_B_Click(object sender, EventArgs e)
        {
            if (lbl_B.BackColor == Color.Plum)
            {
                lbl_B.BackColor = Color.Green;
                B = true;
                cont = cont + 1;
            }
            else
            {
                lbl_B.BackColor = Color.Plum;
                B = false;
                cont--;
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cont.ToString());
            if (cont > 7)
            {
                MessageBox.Show("Insira uma quantidade de notas Menor que 7");
            }
            else if(cont <= 0)
            {
                MessageBox.Show("Insira uma quantidade de notas maior que 0");
            }
            else
            {
                string[] escalaDigitada = Juntar(C, Cs, D, Ds, E, F, Fs, G, Gs, A, As, B);
                float[] porcen = new float[12];
                for(int p=0; p < 12; p++)
                {
                    porcen[p] = (testador(escalaDigitada, escalas[p]) * 14.285714285714285714285714285714f);
                    if (porcen[p] == 100)
                    {
                        string[] traducao = traduzir(escalaDigitada);
                        lbl_Painel.Text = traducao[0] + traducao[1] + traducao[2] + traducao[3] + traducao[4] + traducao[5] + traducao[6] + traducao[7] + traducao[8] + traducao[9] + traducao[10] + traducao[11];
                    }
                    else { 
                        lbl_Painel.Text = "???????";
                         }

                }
                MessageBox.Show("Nome: "+ escalasNome[0] + " | Chance de: "+ porcen[0].ToString()+"%\n" +
                    "Nome: " + escalasNome[1] + " | Chance de: " + porcen[1].ToString() + "%\n" +
                    "Nome: " + escalasNome[2] + " | Chance de: " + porcen[2].ToString() + "%\n" +
                    "Nome: " + escalasNome[3] + " | Chance de: " + porcen[3].ToString() + "%\n" +
                    "Nome: " + escalasNome[4] + " | Chance de: " + porcen[4].ToString() + "%\n" +
                    "Nome: " + escalasNome[5] + " | Chance de: " + porcen[5].ToString() + "%\n" +
                    "Nome: " + escalasNome[6] + " | Chance de: " + porcen[6].ToString() + "%\n" +
                    "Nome: " + escalasNome[7] + " | Chance de: " + porcen[7].ToString() + "%\n" +
                    "Nome: " + escalasNome[8] + " | Chance de: " + porcen[8].ToString() + "%\n" +
                    "Nome: " + escalasNome[9] + " | Chance de: " + porcen[9].ToString() + "%\n" +
                    "Nome: " + escalasNome[10] + " | Chance de: " + porcen[10].ToString() + "%\n" +
                    "Nome: " + escalasNome[11] + " | Chance de: " + porcen[11].ToString() + "%\n");
            }
        }

        static string[] Juntar(bool C, bool Cs, bool D, bool Ds, bool E, bool F, bool Fs, bool G, bool Gs, bool A, bool As, bool B)
        {
            string[] juntar = new string[12];

            switch (C)
            {
                case true:
                    juntar[0] = "C";
                    break;
                case false:
                    juntar[0] = "x";
                    break;
            }
            switch(Cs)
            {
                case true:
                    juntar[1] = "O";
                    break;
                    case false :
                    juntar[1] = "x";
                    break;
            }
            switch(D)
            {
                case true:
                    juntar[2] = "D";
                    break;
                case false:
                    juntar[2] = "x";
                    break;
            }
            switch (Ds)
            {
                case true :
                    juntar[3] = "M";
                    break;
                case false:
                    juntar[3] = "x";
                    break;
            }
            switch (E)
            {
                case true:
                    juntar[4] = "E";
                    break;
                case false:
                    juntar[4] = "x";
                    break;
            }
            switch (F)
            {
                case true:
                    juntar[5] = "F";
                    break;
                case false:
                    juntar[5] = "x";
                    break;
            }
            switch (Fs)
            {
                case true:
                    juntar[6] = "I";
                    break;
                case false:
                    juntar[6] = "x";
                    break;
            }
            switch (G)
            {
                case true:
                    juntar[7] = "G";
                    break;
                case false:
                    juntar[7] = "x";
                    break;
            }
            switch (Gs)
            {
                case true:
                    juntar[8] = "S";
                    break;
                case false:
                    juntar[8] = "x";
                    break;
            }
            switch (A)
            {
                case true:
                    juntar[9] = "A";
                    break;
                case false:
                    juntar[9] = "x";
                    break;
            }
            switch (As)
            {
                case true:
                    juntar[10] = "L";
                    break;
                case false:
                    juntar[10] = "x";
                    break;
            }
            switch (B)
            {
                case true:
                    juntar[11] = "B";
                    break;
                case false:
                    juntar[11] = "x";
                    break;
            }

            return juntar;
        }

        static int testador(string[] escalaDigitada, string escalaBase)
        {
            int seme = 0;
            for(int i = 0; i < escalaDigitada.Length; i++)
            {
                if (escalaBase.Contains(escalaDigitada[i])==true)
                {
                    seme++; 
                }
            }
            return seme;
        }
        static string[] traduzir(string[] escalaDigitada)
        {
            string[] traduzido = new string[escalaDigitada.Length];

            for(int q = 0;q < escalaDigitada.Length; q++)
            {
                switch (escalaDigitada[q])
                {
                    case "x":
                        traduzido[q] = "";
                        break;

                    case "O":
                        traduzido[q] = "C#";
                        break;
                    case "M":
                        traduzido[q] = "D#";
                        break;
                    case "I":
                        traduzido[q] = "F#";
                        break;
                    case "S":
                        traduzido[q] = "G#";
                        break;
                    case "L":
                        traduzido[q] = "A#";
                        break;

                    default:
                        traduzido[q] = escalaDigitada[q];
                        break;
                }
            }
            return traduzido;
        }
    }
}