using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.SliderServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class _UISliderComponent:ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _UISliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values=await _sliderService.GetAllSliderAsync();
            return View(values);
        }
    }
}
