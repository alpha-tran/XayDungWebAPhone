using XayDungWebAphone.Models;

namespace XayDungWebAphone.ViewModels
{
    public class HomeViewModel
    {
        public List<User> Users { get; set; }
    /*    public List<Blog> Blogs { get; set; }
        public List<Slider> Sliders { get; set; }*/
        public List<Product> CatProds { get; set; }
        public List<Product> DogProds { get; set; }
        public List<Category> categories { get; set; }
    }

}
