using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson16Webserver.ViewModels
{
    public class InMemStore<T> where T : IStoreType
    {
        private readonly List<T> _store;
        private int _nextId = 0;

        public InMemStore()
        {
            _store = new List<T>();
        }

        public InMemStore(List<T> initItems)
        {
            _store = new List<T>(initItems);
            _nextId = _store.Select(x => x.Id).Max() + 1;
        }

        public List<T> GetAll()
        {
            return new List<T>(_store);
        }

        public T Get(int id)
        {
            return _store.First(x => x.Id == id);
        }

        public T Create(T item)
        {
            item.Id = _nextId++;
            _store.Add(item);
            return item;
        }

        public T Update(T item)
        {
            _store.RemoveAll(x => x.Id == item.Id);
            _store.Add(item);
            return item;
        }
    }

    public interface IStoreType
    {
        int Id { get; set; }
    }

}
