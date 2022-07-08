using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class Form1 : Form
    {
        Lanterna lanterna = new Lanterna();
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {         
            if (lanterna.Ligado == false)
            {
                lanterna.Ligar();
                AtualizarTela(lanterna.Ligado);
            }

            else 
            {
                lanterna.Desligar();
                AtualizarTela(lanterna.Ligado);
            }                                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTrocarBateria_Click(object sender, EventArgs e)
        {
            lanterna.TrocarBateria();
        }

        //Função para atualizar os componentes do Form
        public void AtualizarTela(bool estadoTela) 
        {
            Image imgLanternaLigada = Properties.Resources.ligado;
            Image imgLanternaDesligada = Properties.Resources.desligado;
            progressBarLanterna.Minimum = 0;
            progressBarLanterna.Maximum = 100;

            if (estadoTela == false)
            {
                btnLigaDesliga.Text = "Ligar";
                pictureBox1.Image = imgLanternaDesligada;
                labelEstadoLanterna.Text = "Desligado";
                progressBarLanterna.Value = 0;
                labelBateria.Text = "0%";                
            }

            else if (estadoTela == true)
            {
                btnLigaDesliga.Text = "Desligar";
                pictureBox1.Image = imgLanternaLigada;
                labelEstadoLanterna.Text = "Ligado";
                //Action para progressBar sincronizar com a bateria
                lanterna.BateriaAlterada = () =>
                {
                    progressBarLanterna.Value = lanterna.Bateria.Carga;
                    labelBateria.Text = Convert.ToString(lanterna.Bateria.Carga) + "%";                    
                };
                //Action para Form atualizar com o estado zero da bateria
                lanterna.SemBateria = () =>
                {
                    lanterna.Desligar();
                    AtualizarTela(lanterna.Ligado);
                };
            }
        }
    }
}
