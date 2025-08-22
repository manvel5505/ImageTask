using ImageTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Plugins
{
    internal class ResizeEffect : IEffect
    {
        private int size;
        public ResizeEffect(int size)
        {
            this.size = size;
        }
        public async Task ApplyAsync(Image image)
        {
            await Task.Delay(50);
            Console.WriteLine($"Resizing:\n {image.ImageName} => {size} pixels!");
        }
    }
}
