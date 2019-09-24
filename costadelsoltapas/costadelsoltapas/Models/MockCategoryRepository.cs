using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costadelsoltapas.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=0, CategoryName="Classic", Description="From the good ol' grandma's recipes book. This tapas continue to stand the test of time, just as granny does."},
                new Category{CategoryId=1, CategoryName="Fusion", Description="The best combinations are sometimes the weidest. Dare to try?"},
                new Category{CategoryId=2, CategoryName="Gourmet", Description="From the chef's imagination to your table. Carefully created Tapas for the more educated palate."}
            };
    }
}
