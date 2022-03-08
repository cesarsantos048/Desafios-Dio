using System;
using System.Collections.Generic;
using AppSerie.Interfaces;

namespace AppSerie.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }
        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Atualizar(int id, Serie entidade){
           listaSerie[id] = entidade;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

    }
}