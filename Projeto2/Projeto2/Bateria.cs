using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Bateria
    {
        //Construtor
        public Bateria() 
        {
            _carga = 100;
        }

        //Função para diminuir carga
        public void Diminuir() 
        {
            if (_carga > 0) 
            {
                _carga -= 1;
            }
        }

        private int _carga = 100;

        public int Carga 
        { 
            get => _carga; 
        }  
    }
}
