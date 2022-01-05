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
            throw new System.NotImplementedException();
        }

        Series IRepository<Series>.findById(int id)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<Series>.Insert(Series entidade)
        {
            throw new System.NotImplementedException();
        }

        int IRepository<Series>.NextId()
        {
            throw new System.NotImplementedException();
        }

        void IRepository<Series>.update(int id, Series entidade)
        {
            listSeries[id] = entidade;
        }
    }
}