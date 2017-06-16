using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoJokempo
{
    public partial class Form1 : Form
    {
        enum Opcoes { Pedra, Papel, Tesoura };
        enum Resultado {  Player, CPU, Empate }
        Opcoes Player = new Opcoes();
        Opcoes CPU = new Opcoes();
        Random RMD = new Random();
        Resultado ganhador = new Resultado();

        public Form1()
        {
            InitializeComponent();
        }
        private void Pedra_Click(object sender, EventArgs e)
        {
            Player = Opcoes.Pedra;
            EscolhaPlayer();
            EscolhaCPU();
            VerificarGanhador();
        }

        private void Papel_Click(object sender, EventArgs e)
        {
            Player = Opcoes.Papel;
            EscolhaPlayer();
            EscolhaCPU();
            VerificarGanhador();
        }

        private void Tesoura_Click(object sender, EventArgs e)
        {
            Player = Opcoes.Tesoura;
            EscolhaPlayer();
            EscolhaCPU();
            VerificarGanhador();
        }

        void EscolhaPlayer()
        {
            switch (Player)
            {
                case Opcoes.Pedra:
                    imgEscolhaPlayer.Image = Properties.Resources.Pedra;
                    break;

                case Opcoes.Papel:
                    imgEscolhaPlayer.Image = Properties.Resources.Papel;
                    break;

                case Opcoes.Tesoura:
                    imgEscolhaPlayer.Image = Properties.Resources.Tesoura;
                    break;
            }
        }

        void EscolhaCPU()
        {
            int numero = RMD.Next(1, 4);

            if (numero == 1)
            {
                CPU = Opcoes.Pedra;
                imgEscolhaCPU.Image = Properties.Resources.Pedra;

            }
            else if (numero == 2)
            {
                CPU = Opcoes.Papel;
                imgEscolhaCPU.Image = Properties.Resources.Papel;
            }
            else if (numero == 3)
            {
                CPU = Opcoes.Tesoura;
                imgEscolhaCPU.Image = Properties.Resources.Tesoura;
            }
        }
                void VerificarGanhador()
        {
            switch(Player)
            {
                case Opcoes.Pedra:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.Empate;

                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.CPU;

                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.Player;
                    break;

                case Opcoes.Papel:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.Player;

                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.Empate;

                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.CPU;
                    break;

                case Opcoes.Tesoura:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.CPU;

                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.Player;

                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }
            if (ganhador == Resultado.Player)
            {
                Placar.BackColor = Color.Green;
                PlacarPlayer.Text = (int.Parse(PlacarPlayer.Text) + 1).ToString();

            }
            else if (ganhador == Resultado.CPU)
            {
                Placar.BackColor = Color.Red;
                PlacarCPU.Text = (int.Parse(PlacarCPU.Text) + 1).ToString();

            }
            else
                Placar.BackColor = Color.DarkGray;

            }

        void imgEscolhaCPU_Click(object sender, EventArgs e)
        {

        }

        private void imgEscolhaPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
