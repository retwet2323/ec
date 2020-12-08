using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ec134.Common.Db
{
    /// <summary>
    /// Clase de EFRepository, que contiene las funcionalidades básicas para el uso de una Base de Datos
    /// </summary>
    public class EFRepository
    {
        #region < PROPIEDADES >
        private DbContext _dbContext;
        #endregion

        #region < CONSTRUCTORES >

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="dbContext">Instancia del contexto de la clase</param>
        public EFRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region < METODOS >
        /// <summary>
        /// Obtienen todos los datos
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="orderby">Expresion de ordenación LinQ</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>IQueryable con los datos pedidos</returns>
        public IQueryable<T> All<T>(Expression<Func<T, int>> orderby, string[] includes = null) where T : class
        {

            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _dbContext.Set<T>().OrderBy(orderby).AsQueryable().AsNoTracking();
        }

        /// <summary>
        /// Obtienen todos los datos
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="orderby">Expresion de ordenación LinQ</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>IQueryable con los datos pedidos</returns>
        public IQueryable<T> All<T>(string[] includes = null) where T : class
        {

            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _dbContext.Set<T>().AsQueryable().AsNoTracking();
        }

        /// <summary>
        /// Obtienen todos los datos
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="orderby">Expresion de ordenación LinQ</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>IQueryable con los datos pedidos</returns>
        public virtual IQueryable<T> All<T>(Expression<Func<T, string>> orderby, string[] includes = null) where T : class
        {

            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _dbContext.Set<T>().OrderBy(orderby).AsQueryable().AsNoTracking();
        }

        /// <summary>
        /// Obtiene un dato
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para encontrar el dato</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>T</returns>
        public T Find<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {

            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault<T>(predicate);
            }

            return _dbContext.Set<T>().FirstOrDefault<T>(predicate);
        }

        /// <summary>
        /// Obtiene un dato asincronamente
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para encontrar el dato</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>T</returns>
        public async Task<T> FindAsync<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return await query.FirstOrDefaultAsync<T>(predicate);
            }
            return await _dbContext.Set<T>().FirstOrDefaultAsync<T>(predicate);
        }

        /// <summary>
        /// Obtiene una lista de datos filtrada
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para encontrar el dato</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>IQueryable con los datos pedidos</returns>
        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, string[] includes = null) where T : class
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where<T>(predicate).AsQueryable<T>();
            }

            return _dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>().AsNoTracking();
        }

        /// <summary>
        /// Obtiene un lista de datos filtrada y paginada
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para encontrar el dato</param>
        /// <param name="orderby">Expresion de ordenación LinQ</param>
        /// <param name="total">Número total de datos</param>
        /// <param name="index">Posición desde la que se quiere emepazar a traer datos</param>
        /// <param name="size">Tamaño de página</param>
        /// <param name="includes">Array con el nombre de las Navigation Properties a rellenar</param>
        /// <returns>IQueryable con los datos pedidos</returns>
        public virtual IQueryable<T> Filter<T>(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> orderby, out int total, int index = 0, int size = 50, string[] includes = null) where T : class
        {
            int skipCount = index;// *size;
            IQueryable<T> _resetSet;

            if (includes != null && includes.Count() > 0)
            {
                DbQuery<T> query = _dbContext.Set<T>().Include(includes.First());
                foreach (string include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = predicate != null ? _dbContext.Set<T>().Where<T>(predicate).AsQueryable() : _dbContext.Set<T>().AsQueryable();
            }
            total = _resetSet.Count();
            _resetSet = skipCount == 0 ? _resetSet.OrderBy(orderby).Take(size) : _resetSet.OrderBy(orderby).Skip(skipCount).Take(size);

            return _resetSet.AsQueryable().AsNoTracking();
        }

        /// <summary>
        /// Inserta en BBDD un dato
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere insertar en BBDD</param>
        /// <returns>T</returns>
        public virtual T Create<T>(T tObject) where T : class
        {
            var newEntry = _dbContext.Set<T>().Add(tObject);
            this.SaveChanges();
            return newEntry;
        }

        /// <summary>
        /// Inserta en BBDD un dato asincronamente
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere insertar en BBDD</param>
        /// <returns>T</returns>
        public virtual async Task<T> CreateAsync<T>(T tObject) where T : class
        {

            var newEntry = _dbContext.Set<T>().Add(tObject);
            await this.SaveChangesAsync();
            return newEntry;
        }
        /// <summary>
        /// Inserta en BBDD una lista de datos
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Listado de objetos que se quieren insertar en BBDD</param>
        /// <returns>Lista de los objectos creados</returns>
        public virtual List<T> Create<T>(List<T> tObject) where T : class
        {
            foreach (T item in tObject)
            {
                _dbContext.Set<T>().Add(item);
            }
            this.SaveChanges();
            return tObject;
        }

        /// <summary>
        /// Inserta en BBDD una lista de datos asincronamente
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Listado de objetos que se quieren insertar en BBDD</param>
        /// <returns>Lista de los objectos creados</returns>
        public async virtual Task<List<T>> CreateAsync<T>(List<T> tObject) where T : class
        {
            foreach (T item in tObject)
            {
                _dbContext.Set<T>().Add(item);
            }
            await this.SaveChangesAsync();
            return tObject;
        }

        /// <summary>
        /// Elimina de BBDD un dato
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere eliminar de BBDD</param>
        /// <returns>int</returns>
        public virtual int Delete<T>(T tObject) where T : class
        {
            try
            {
                _dbContext.Set<T>().Attach(tObject);
                _dbContext.Set<T>().Remove(tObject);
                return this.SaveChanges();
            }
            catch (Exception ex)
            {
                _dbContext.Entry<T>(tObject).State = EntityState.Deleted;
                return this.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina de BBDD un dato asincronamente
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere eliminar de BBDD</param>
        /// <returns>int</returns>
        public async virtual Task<int> DeleteAsync<T>(T tObject) where T : class
        {
            try
            {
                _dbContext.Set<T>().Attach(tObject);
                _dbContext.Set<T>().Remove(tObject);
                return await this.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _dbContext.Entry<T>(tObject).State = EntityState.Deleted;
                return await this.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Modifica un dato en la BBDD
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere modificar en BBDD</param>
        /// <returns>int</returns>
        public virtual int Update<T>(T tObject) where T : class
        {
            DbEntityEntry<T> entry = _dbContext.Entry(tObject);

            ObjectContext objectContext = ((IObjectContextAdapter)_dbContext).ObjectContext;
            ObjectSet<T> set = objectContext.CreateObjectSet<T>();
            List<string> keyNames = set.EntitySet.ElementType
                                                        .KeyMembers
                                                        .Select(k => k.Name).ToList();

            if (!keyNames.Any())
            {
                throw new ArgumentException("Se esperaba una primarykey");
            }

            if (tObject == null)
            {
                throw new ArgumentException("Cannot add a null entity.");
            }

            if (entry.State == EntityState.Detached)
            {
                DbSet<T> setD = _dbContext.Set<T>();

                //--------------------

                object[] paramKeys = new object[0];
                foreach (string key in keyNames)
                {
                    Array.Resize(ref paramKeys, paramKeys.Length + 1);
                    paramKeys[paramKeys.Length - 1] = typeof(T).GetProperty(key).GetValue(tObject);
                }

                T attachedEntity = setD.Find(paramKeys);

                //------------------

                //T attachedEntity = setD.Find(typeof(T).GetProperty(keyNames.FirstOrDefault()).GetValue(tObject));
                ////T attachedEntity = setD.Find(setD.Create().GetType().GetProperty(keyNames[0]).GetValue(tObject));
                if (attachedEntity != null)
                {
                    DbEntityEntry<T> attachedEntry = _dbContext.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(tObject);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }

            return this.SaveChanges();
        }

        /// <summary>
        /// Modifica un dato en la BBDD
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="tObject">Objeto que se quiere modificar en BBDD</param>
        /// <returns>int</returns>
        public async virtual Task<int> UpdateAsync<T>(T tObject) where T : class
        {
            DbEntityEntry<T> entry = _dbContext.Entry(tObject);

            ObjectContext objectContext = ((IObjectContextAdapter)_dbContext).ObjectContext;
            ObjectSet<T> set = objectContext.CreateObjectSet<T>();
            List<string> keyNames = set.EntitySet.ElementType
                                                        .KeyMembers
                                                        .Select(k => k.Name).ToList();

            if (!keyNames.Any())
            {
                throw new ArgumentException("Se esperaba una primarykey");
            }

            if (tObject == null)
            {
                throw new ArgumentException("Cannot add a null entity.");
            }

            if (entry.State == EntityState.Detached)
            {
                DbSet<T> setD = _dbContext.Set<T>();

                //--------------------

                object[] paramKeys = new object[0];
                foreach (string key in keyNames)
                {
                    Array.Resize(ref paramKeys, paramKeys.Length + 1);
                    paramKeys[paramKeys.Length - 1] = typeof(T).GetProperty(key).GetValue(tObject);
                }

                T attachedEntity = await setD.FindAsync(paramKeys);

                //------------------

                //T attachedEntity = await setD.FindAsync(typeof(T).GetProperty(keyNames.FirstOrDefault()).GetValue(tObject));
                ////T attachedEntity = setD.Find(setD.Create().GetType().GetProperty(keyNames[0]).GetValue(tObject));

                if (attachedEntity != null)
                {
                    DbEntityEntry<T> attachedEntry = _dbContext.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(tObject);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }

            return await this.SaveChangesAsync();
        }

        /// <summary>
        /// Elimina datos de la BBDD
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para elimar los datos</param>
        /// <returns>int</returns>
        public virtual int Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            IQueryable<T> objects = Filter<T>(predicate);
            foreach (var obj in objects)
                _dbContext.Set<T>().Remove(obj);
            return this.SaveChanges();
        }

        /// <summary>
        /// Elimina datos de la BBDD asincronamente
        /// </summary>
        /// <typeparam name="T">Clase tipada</typeparam>
        /// <param name="predicate">Expresión con el filtro a realizar para elimar los datos</param>
        /// <returns>int</returns>
        public virtual async Task<int> DeleteAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            IQueryable<T> objects = Filter<T>(predicate);
            foreach (var obj in objects)
                _dbContext.Set<T>().Remove(obj);
            return await this.SaveChangesAsync();
        }

        /// <summary>
        /// Hace un commit en la base de datos 
        /// </summary>
        /// <returns>Número de filas moficadas</returns>
        public virtual int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    DbPropertyValues dbValue = entry.GetDatabaseValues();
                    if (dbValue != null)
                    {
                        if (entry.State == EntityState.Deleted)
                            entry.State = EntityState.Detached;
                        else
                            entry.OriginalValues.SetValues(dbValue);
                    }
                    else
                    {
                        entry.Reload();
                    }
                }
                return _dbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat(ex.Message, " Errors: ", fullErrorMessage);
                throw ex;
            }
        }
        /// <summary>
        /// Hace un commit en la base de datos asincronamente
        /// </summary>
        /// <returns>Número de filas moficadas</returns>
        public virtual async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    DbPropertyValues dbValue = entry.GetDatabaseValues();
                    if (dbValue != null)
                    {
                        if (entry.State == EntityState.Deleted)
                            entry.State = EntityState.Detached;
                        else
                            entry.OriginalValues.SetValues(dbValue);
                    }
                    else
                    {
                        entry.Reload();
                    }
                }
                return await _dbContext.SaveChangesAsync();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Libera el recurso
        /// </summary>
        public void Dispose()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Libera el recurso
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                    _dbContext.Dispose();

            }
        }

        private string GetNameWithParameters(string name, object[] parameters)
        {
            if (parameters == null || !parameters.Any())
                return name;
            for (int i = 0; i < parameters.Count(); i++)
            {
                name = string.Format("{0} @p{1}, ", name, i);
            }
            return name.Substring(0, name.Length - 2);
        }

        #endregion
    }
}
