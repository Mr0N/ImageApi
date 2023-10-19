using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interface
{
    public interface IChangeImageSize
    {
        public Stream ChangeSizeImage(Stream image, int newSizeWidth, int newSizeHeigth);
    }
}
