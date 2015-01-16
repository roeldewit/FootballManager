using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RoeldeWit.FootballManager.Domain.Classes;
using RoeldeWit.FootballManager.ServiceLayer.Interfaces;

namespace RoeldeWit.FootballManager.ServiceLayer.Repositories
{
    /// <summary>
    /// Generic repository
    /// </summary>
    public class GenericRepository : IGenericRepository
    {
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>All entities</returns>
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find entities by predicate
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="predicate">Predicate</param>
        /// <returns>Found entities</returns>
        public IQueryable<TEntity> FindBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>Collection of all entities</returns>
        public IEnumerable<TEntity> ListAll<TEntity>() where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get single entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        /// <returns>Entity</returns>
        public TEntity Details<TEntity>(int id) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Insert<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insert collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Update<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        public void Delete<TEntity>(int id) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Delete<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void DeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save changes
        /// </summary>
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
