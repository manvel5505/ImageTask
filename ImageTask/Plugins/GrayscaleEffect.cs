using ImageTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Plugins
{
    internal class GrayscaleEffect : IEffect
    {
        public async Task ApplyAsync(Image image)
        {
            await Task.Delay(50);
            Console.WriteLine($"Resizing:\n {image.ImageName} => grayscaled");
        }
    }
}
