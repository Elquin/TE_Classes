using System;
using System.Collections.Generic;

namespace ShoppingListAPI.Services
{
    public interface IDataAccessObject<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(T t);
        void Delete(int id);
    }
}