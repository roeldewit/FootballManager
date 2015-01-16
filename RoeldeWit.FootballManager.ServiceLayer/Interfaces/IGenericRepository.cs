using RoeldeWit.FootballManager.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RoeldeWit.FootballManager.ServiceLayer.Interfaces
{
    /// <summary>
    /// Interface for the GenenericRepository
    /// </summary>
    public interface IGenericRepository
    {
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>All entities</returns>
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : EntityBase, new();

        /// <summary>
        /// Find entities by predicate
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="predicate">Predicate</param>
        /// <returns>Found entities</returns>
        IQueryable<TEntity> FindBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : EntityBase, new();

        /// <summary>
        /// List all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>Collection of all entities</returns>
        IEnumerable<TEntity> ListAll<TEntity>() where TEntity : EntityBase, new();

        /// <summary>
        /// Get single entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        /// <returns>Entity</returns>
        TEntity Details<TEntity>(int id) where TEntity : EntityBase, new();

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        void Insert<TEntity>(TEntity entity) where TEntity : EntityBase, new();

        /// <summary>
        /// Insert collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new();

        /// <summary>
        /// Update entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        void Update<TEntity>(TEntity entity) where TEntity : EntityBase, new();

        /// <summary>
        /// Update collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new();

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        void Delete<TEntity>(int id) where TEntity : EntityBase, new();

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        void Delete<TEntity>(TEntity entity) where TEntity : EntityBase, new();

        /// <summary>
        /// Delete collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        void DeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new();

        /// <summary>
        /// Save changes
        /// </summary>
        void Save();
    }
}
