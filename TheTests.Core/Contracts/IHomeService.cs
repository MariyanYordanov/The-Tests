using TheTests.Core.Models.Test;

namespace TheTests.Core.Contracts
{
    public interface IHomeService
    {
        Task<IEnumerable<TestModel>> GetAllTestAsync();
    }
}
