using Microsoft.AspNetCore.Mvc;

namespace ImageApi.Models
{
    public class SizeInfo
    {
        public IFormFile image { set; get; }
        public int width { set; get; }
        public int height { set; get; }
    }
}
