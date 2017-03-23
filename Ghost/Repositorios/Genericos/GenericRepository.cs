using Ghost.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ghost.Repositorios.Genericos
{
    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {

        private GerenciamentoContexto _db = new GerenciamentoContexto();

        public void Atualizar(T entidade)
        {
            _db.Entry(entidade).State = EntityState.Modified;
        }

        public void Criar(T entidade)
        {
            _db.Set<T>().Add(entidade);
            this.SalvarMudanca();
        }

        public void Deletar(Func<T, bool> predicate)
        {
            _db.Set<T>()
                .Where(predicate).ToList()
                .ForEach(x => _db.Set<T>().Remove(x));
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<T> PegaTudo()
        {
            return _db.Set<T>().ToList();
        }

        public T Procura(params object[] key)
        {
            return _db.Set<T>().Find(key);
        }

        public void SalvarMudanca()
        {
            _db.SaveChanges();
        }
    }
}