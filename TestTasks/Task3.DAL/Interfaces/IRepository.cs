using System;
using System.Collections.Generic;

namespace Task3.DAL.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        /// <summary>
        /// Get all objects
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get ofject by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// Create item
        /// </summary>
        /// <param name="item"></param>
        void Create(T item);

        //Update Item
        void Update(T item);

        /// <summary>
        /// Delete Item
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Save changes
        /// </summary>
        void Save();
    }
}