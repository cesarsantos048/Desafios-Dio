namespace Desafio.Entities
{
    public class Mago : Heroi
    {
        public Mago(){

        }
        public Mago(string Nome, int Nivel, string TipoHeroi){
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.TipoHeroi = TipoHeroi;
        }
        public override string Ataque()
        {
            return this.Nome + " lançou magia";
        }
        public string Ataque(int Bonus)
        {
            return this.Nome + " lançou magia com bônus de ataque de " + Bonus;
        }
    }
}