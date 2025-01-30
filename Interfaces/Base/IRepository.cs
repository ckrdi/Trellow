namespace Trellow.Interfaces.Base
{
    public interface IRepository<TModel>
        where TModel : Models.Base.Model, new()
    {
        Task<TModel?> ReadAsync(int id);

        Task<TModel> InsertAsync(TModel model);

        Task<TModel?> UpdateAsync(TModel model);

        Task<TModel?> DeleteAsync(int id);

        Task<IEnumerable<TModel>> ReadAllAsync();

        Task<bool> InsertManyAsync(IEnumerable<TModel> models);

        Task<bool> UpdateManyAsync(IEnumerable<TModel> models);

        Task<bool> DeleteManyAsync(IEnumerable<TModel> models);

        Task<bool> IsDataExistsAsync(int id);
    }
}
