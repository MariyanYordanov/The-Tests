using Microsoft.EntityFrameworkCore;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Common;
using TheTests.Infrastructure.Data.Models;

public class HomeService : IHomeService
{
    private readonly IRepository _repository;

    public HomeService(IRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task<IEnumerable<TestModel>> GetAllTestAsync()
    {
        return await _repository.AllReadonly<Test>()
            .Select(t => new TestModel
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CategoryId = t.CategoryId
            }).ToListAsync();
    }
}
