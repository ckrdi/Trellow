using Microsoft.EntityFrameworkCore;
using Trellow.Interfaces.Base;

namespace Trellow.Repositories.Base
{
    public abstract class Repository<TContext, TModel> : IRepository<TModel>
        where TContext : DbContext, new()
        where TModel : Models.Base.Model, new()
    {
        protected TContext _context;

        protected Repository(TContext context)
        {
            _context = context;
        }

        public virtual async Task<TModel?> ReadAsync(int id)
        {
            var dbSet = _context.Set<TModel>();
            var model = await dbSet.FindAsync(id);
            if (model == null) return null;

            return model;
        }

        public virtual async Task<TModel> InsertAsync(TModel model)
        {
            var dbSet = _context.Set<TModel>();
            dbSet.Add(model);

            await _context.SaveChangesAsync();
            return model;
        }

        public virtual async Task<TModel?> UpdateAsync(TModel model)
        {
            var dbSet = _context.Set<TModel>();
            var currentModel = await dbSet.FindAsync(model.Id);
            if (currentModel == null) return null;

            _context.Entry(currentModel).CurrentValues.SetValues(model);

            await _context.SaveChangesAsync();

            return model;
        }

        public virtual async Task<TModel?> DeleteAsync(int id)
        {
            var dbSet = _context.Set<TModel>();

            var model = await dbSet.FindAsync(id);
            if (model == null) return null;

            dbSet.Remove(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public virtual async Task<IEnumerable<TModel>> ReadAllAsync()
        {
            var dbSet = _context.Set<TModel>();
            var models = await dbSet.ToListAsync();

            return models;
        }

        public virtual async Task<bool> InsertManyAsync(IEnumerable<TModel> models)
        {
            var dbSet = _context.Set<TModel>();
            foreach (var model in models)
            {
                dbSet.Add(model);
            }

            var numObj = await _context.SaveChangesAsync();

            return numObj > 0;
        }

        public virtual async Task<bool> UpdateManyAsync(IEnumerable<TModel> models)
        {
            var dbSet = _context.Set<TModel>();
            foreach (var model in models)
            {
                var currentModel = await dbSet.FindAsync(model.Id);
                if (currentModel == null) continue;

                _context.Entry(currentModel).CurrentValues.SetValues(model);
            }

            var numObj = await _context.SaveChangesAsync();

            return numObj > 0;
        }

        public virtual async Task<bool> DeleteManyAsync(IEnumerable<TModel> models)
        {
            var dbSet = _context.Set<TModel>();
            foreach (var model in models)
            {
                var currentModel = await dbSet.FindAsync(model.Id);
                if (currentModel == null) continue;

                dbSet.Remove(currentModel);
            }

            var numObj = await _context.SaveChangesAsync();

            return numObj > 0;
        }
    }
}
