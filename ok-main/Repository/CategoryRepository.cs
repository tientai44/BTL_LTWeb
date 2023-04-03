using NotUseAuto.Data;
using NotUseAuto.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotUseAuto.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext _context;

		public CategoryRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public Category Add(Category category)
		{
			throw new System.NotImplementedException();
		}

		public Category Delete(int categoryID)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Category> GetAllCategories()
		{
			return _context.Category;
		}

		public Category GetCategory(int categoryID)
		{
			return _context.Category.FirstOrDefault(x=>x.Id==categoryID);
		}

		public Category Update(Category category)
		{
			throw new System.NotImplementedException();
		}
	}
}
