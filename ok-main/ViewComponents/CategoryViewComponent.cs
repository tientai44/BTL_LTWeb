using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Repository;
using System.Linq;

namespace NotUseAuto.ViewComponents
{
	public class CategoryViewComponent : ViewComponent
	{
        private readonly ICategoryRepository _categoryRepository;

        public CategoryViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke(int categoryID)
        {
            var categories = _categoryRepository.GetCategory(categoryID);
            return View(categories);
        }
    }
}
