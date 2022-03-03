namespace Desafio.Entities
{
    public class Heroi
    {
        public string Nome;
        public int Nivel;
        public string TipoHeroi;

        public Heroi(){

        }
        public Heroi(string Nome, int Nivel, string TipoHeroi){
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.TipoHeroi = TipoHeroi;
        }

        public override string ToString()
        {
            return this.Nome + " " + this.Nivel + " " + this.TipoHeroi;   
        }

        public virtual string Ataque(){
            return this.Nome + " Atacou com sua espada";
        }
    }
}