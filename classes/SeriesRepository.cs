using System;
using System.Collections.Generic;
using temp.series.interfaces;

namespace temp.series.classes
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> listSeries = new List<Series>();
        void IRepository<Series>.Delete(int id)
        {
            listSeries[id].excluir();
        }

        List<Series> IRepository<Series>.FindAll()
        {
            return listSeries;
        }

        Series IRepository<Series>.findById(int id)
        {
            return listSeries[id];
        }

        void IRepository<Series>.Insert(Series entidade)
        {
            listSeries.Add(entidade);
        }

        int IRepository<Series>.NextId()
        {
            return listSeries.Count;
        }

        void IRepository<Series>.update(int id, Series entidade)
        {
            listSeries[id] = entidade;
        }
    }
}