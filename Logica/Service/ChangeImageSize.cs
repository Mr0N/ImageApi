using Logica.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Png;

namespace Logica.Service
{
    public class ChangeImageSize : IChangeImageSize
    {
        public Stream ChangeSizeImage(Stream image, int newSizeWidth, int newSizeHeigth)
        {
            var memory = new MemoryStream();
            using (Image img = Image.Load(image))
            {
                img.Mutate(x => x.Resize(newSizeWidth, newSizeHeigth));

                img.Save(memory, PngFormat.Instance);
            }
            memory.Position = 0;
            return memory;
        }
    }
}
