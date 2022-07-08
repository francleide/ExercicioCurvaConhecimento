using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Projeto2
{
    internal class Lanterna
    {

        //Construtor
        public Lanterna()
        {
            Desligar();
        }

        //Função para ligar Lanterna
        public void Ligar() 
        {
            _ligado = true;
            ConsumirBateriaAsync();
        }

        //Função para desligar Lanterna
        public void Desligar() 
        {
            _ligado = false;
        }

        //Função para trocar Bateria
        public void TrocarBateria()
        {
           _bateria = new Bateria();              
        }

        //Função para consumir Bateria
        //Para utilizar o 'await' a função deve ser async Task
        public async Task ConsumirBateriaAsync() 
        {
            int atraso = 1000;

            while(Ligado == true && _bateria.Carga > 0)
            {
                _bateria.Diminuir();
                await Task.Delay(atraso);
                if (BateriaAlterada != null) 
                {
                    BateriaAlterada();
                }
            }
            if (SemBateria != null)
            {
                SemBateria();            
            }
        }

        private bool _ligado = false;
        private Bateria _bateria = new Bateria();

        //Propriedade para status ligado e desligado
        public bool Ligado { get => _ligado;}

        //Propriedade para obter valor da Bateria
        public Bateria Bateria { get => _bateria; }
        
        //Propriedade para alteração da Bateria
        public Action BateriaAlterada { get; set; }

        public Action SemBateria { get; set; }
    }
}
