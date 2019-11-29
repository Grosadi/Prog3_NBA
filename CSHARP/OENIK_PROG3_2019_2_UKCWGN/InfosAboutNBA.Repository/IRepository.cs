// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// Repository interface
// </summary>

namespace InfosAboutNBA.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Basic Interface.
    /// </summary>
    /// <typeparam name="T">Where T is a class.</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Returns one item from the database.
        /// </summary>
        /// <param name="id"> id of a T type item from database.</param>
        /// <returns> T type item.</returns>
        T GetOne(int id);

        /// <summary>
        /// Returns all elements from the database.
        /// </summary>
        /// <returns> All T type item.</returns>
        IQueryable<T> GetAll();
    }
}
