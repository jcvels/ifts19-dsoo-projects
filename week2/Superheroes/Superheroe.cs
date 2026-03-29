namespace Superheroes
{
    internal class Superheroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        private int validarValor(int valor)
        {
            if (valor < 0) return 0;
            else if (valor > 100) return 100;
            else return valor;
        }

        public Superheroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            setNombre(nombre);
            setFuerza(fuerza);
            setResistencia(resistencia);
            setSuperpoderes(superpoderes);
        }

        private void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        private void setFuerza(int fuerza)
        {
            this.fuerza = validarValor(fuerza);
        }

        public int getFuerza()
        {
            return this.fuerza;
        }

        private void setResistencia(int resistencia)
        {
            this.resistencia = validarValor(resistencia);
        }

        public int getResistencia()
        {
            return this.resistencia;
        }

        private void setSuperpoderes(int superpoderes)
        {
            this.superpoderes = validarValor(superpoderes);
        }

        public int getSuperpoderes()
        {
            return this.superpoderes;
        }

        public string competir(Superheroe competidor)
        {
            int cuentaGanados = 0;
            int cuentaPerdidos = 0;
            
            int[] comparacion = {
                this.fuerza - competidor.getFuerza(),
                this.resistencia - competidor.getResistencia(),
                this.superpoderes - competidor.getSuperpoderes()
            };

            foreach (int resultado in comparacion)
            {
                if(resultado > 0)
                {
                    cuentaGanados++;
                }
                if(resultado < 0)
                {
                    cuentaPerdidos++;
                }
            };

            if (cuentaGanados >= 2)
            {
                return "TRIUNFO";
            }
            if (cuentaPerdidos >= 2)
            {
                return "DERROTA";
            }
            return "EMPATE";
        }
    }
}
