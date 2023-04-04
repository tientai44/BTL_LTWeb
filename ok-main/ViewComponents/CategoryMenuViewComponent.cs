using Microsoft.AspNetCore.Mvc;
using NotUseAuto.Data;
using NotUseAuto.Repository;
using System.Linq;

namespace NotUseAuto.ViewComponents
{
	public class CategoryMenuViewComponent : ViewComponent
	{
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenuViewComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories().OrderBy(x=>x.Id);
            return View(categories);
        }
    }
}
