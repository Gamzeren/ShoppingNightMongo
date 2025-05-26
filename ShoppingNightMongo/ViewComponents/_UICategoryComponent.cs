using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.CategoryServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class _UICategoryComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _UICategoryComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values= await _categoryService.GetAllCategoryAsync();
            var limitedCategories=values.Take(1).ToList();
            return View(limitedCategories);
        }
    }
}
