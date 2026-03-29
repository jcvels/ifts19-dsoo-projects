using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFormativa1
{
    internal class Televisor
    {
        private int CANAL_LIMITE_INF = 1;
        private int CANAL_LIMITE_SUP = 150;

        private string marca;
        private string modelo;
        private int pulgadas;
        private bool estado;
        private int canal;

        public Televisor(string marca, string modelo, int pulgadas, bool estado, int canal)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.pulgadas = pulgadas;
            this.estado = estado;
            this.canal = canal;
        }
        public string Marca 
        {
            get { return marca; }
        }
        public string Modelo
        {
            get { return modelo; }
        }
        public int Pulgadas
        {
            get { return pulgadas; }
        }
        public bool verPrendido()
        {
            return this.estado;
        }
        public void cambiarEstado()
        {
            this.estado = !this.estado;
        }
        public int obtenerCanalActual()
        {
            return this.canal;
        }
        public bool cambiarCanal()
        {
            if (this.verPrendido() == false)
            {
                return false;
            }
            else
            {
                if (canal < CANAL_LIMITE_SUP)
                {
                    this.canal++;
                }
                else
                {
                    this.canal = CANAL_LIMITE_INF;
                }
                return true;
            }
        }
        public bool cambiarCanal(int value)
        {
            if (this.verPrendido() == false)
            {
                return false;
            }
            else
            {
                if(value >= CANAL_LIMITE_INF && value < CANAL_LIMITE_SUP)
                {
                    this.canal = value;
                }
                return true;
            }
        }
    }
}
