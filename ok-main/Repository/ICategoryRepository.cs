using NotUseAuto.Models;
using System.Collections.Generic;

namespace NotUseAuto.Repository
{
	public interface ICategoryRepository
	{
        Category Add(Category category);

        Category Update(Category category);

        Category Delete(int categoryID);

        Category GetCategory(int categoryID);

        IEnumerable<Category> GetAllCategories();
    }
}
