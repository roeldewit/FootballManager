using RoeldeWit.FootballManager.Domain.Classes;
using RoeldeWit.FootballManager.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RoeldeWit.FootballManager.ServiceLayer.Repositories
{
    /// <summary>
    /// Generic repository
    /// </summary>
    public class GenericRepository : IGenericRepository
    {
        /// <summary>
        /// DbContext to use
        /// </summary>
        protected DbContext Context;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(DbContext dbContext)
        {
            Context = dbContext;
        }

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>All entities</returns>
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : EntityBase, new()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            return query;
        }

        /// <summary>
        /// Find entities by predicate
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="predicate">Predicate</param>
        /// <returns>Found entities</returns>
        public IQueryable<TEntity> FindBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : EntityBase, new()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().Where(predicate);
            return query;
        }

        /// <summary>
        /// List all entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>Collection of all entities</returns>
        public IEnumerable<TEntity> ListAll<TEntity>() where TEntity : EntityBase, new()
        {
            IEnumerable<TEntity> result = GetAll<TEntity>().ToList();
            return result;
        }

        /// <summary>
        /// Get single entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        /// <returns>Entity</returns>
        public TEntity Details<TEntity>(int id) where TEntity : EntityBase, new()
        {
            TEntity entity = GetAll<TEntity>().FirstOrDefault(item => item.Id == id);
            return entity;
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Insert<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            Context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Insert collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void InsertRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Update<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Update collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            foreach (TEntity entity in entities)
            {
                Update(entity);
            }
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="id">Id</param>
        public void Delete<TEntity>(int id) where TEntity : EntityBase, new()
        {
            TEntity entity = Details<TEntity>(id);

            if (entity != null)
                Delete(entity);
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entity">Entity</param>
        public void Delete<TEntity>(TEntity entity) where TEntity : EntityBase, new()
        {
            Context.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Delete collection of entities
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="entities">Collection of entities</param>
        public void DeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : EntityBase, new()
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        /// <summary>
        /// Save changes
        /// </summary>
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
