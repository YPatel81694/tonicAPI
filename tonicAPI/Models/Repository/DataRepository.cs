namespace tonicAPI.Models.Repository
{
    public interface DataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long Id);
        void Add(TEntity entity);
        void Update(long Id, TEntity entity);
        void Delete(long Id);
    }
}
