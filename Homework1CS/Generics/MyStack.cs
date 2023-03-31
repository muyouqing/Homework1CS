using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Mystack<T>
    {
        public int Count() { return 0; }
        public T Pop() { }
        public void Push() { }
    }

    public class MyList<T>
    {
        private List<T> list;
        public MyList()
        {
            list = new List<T>;
        }
        public void Add(T element)
        {
            list.add(element);
        }
        public T Remove(int index)
        {
            if (index < 0 || index > list.Count - 1) throw new Exception();
            return list.remove(index);
        }
        public bool Contains(T element)
        {
            return list.contains(element);
        }
        public void Clear()
        {
            list.Clear();
        }
        public void Insert(int index, T element)
        {
            list.insert(index, element);
        }
        public void DeleteAt(int index)
        {
            list.remove(index);
        }
        public T Find(int index)
        {
            return list.find(index);
        }
    }
    public GenericRepository<T>:IRepository<T> where T:class,IEntity
    {
    private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}