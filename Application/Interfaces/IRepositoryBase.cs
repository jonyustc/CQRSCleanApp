using Domain;

namespace Application.Interfaces
{
    public interface IRepositoryBase<T> where T : Base
    {
        void Add(T Entity);
        Task<IReadOnlyList<T>> GetListAsync();
        Task<int> CompleteAsync();
    }
}