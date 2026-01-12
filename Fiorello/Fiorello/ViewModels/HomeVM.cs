using Fiorello.Models;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; } = new List<Slider>();
        public SliderDetail SliderDetail { get; set; } = new SliderDetail();
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
