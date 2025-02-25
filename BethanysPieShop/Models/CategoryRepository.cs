using NuGet.Frameworks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopContext;

        public CategoryRepository(BethanysPieShopDbContext bethanysPieShopContext)
        {
            _bethanysPieShopContext = bethanysPieShopContext;
        }

        public IEnumerable<Category> AllCategories =>
            _bethanysPieShopContext.Categories.OrderBy(p => p.CategoryName);
    }
}