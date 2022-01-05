using System;
using System.Collections.Generic;
using temp.series.interfaces;

namespace temp.series.classes
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> listSeries = new List<Series>();
        public void Delete(int id)
        {
            listSeries[id].excluir();
        }

        public List<Series> FindAll()
        {
            return listSeries;
        }

        public Series findById(int id)
        {
            return listSeries[id];
        }

        public void Insert(Series entidade)
        {
            listSeries.Add(entidade);
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public void update(int id, Series entidade)
        {
            listSeries[id] = entidade;
        }
    }
}