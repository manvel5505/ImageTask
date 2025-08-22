using ImageTask.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Plugins
{
    internal class BlurEffect : IEffect
    {
        private int intnesity;
        public BlurEffect(int intnesity)
        {
            this.intnesity = intnesity;
        }
        public async Task ApplyAsync(Image image)
        {
            await Task.Delay(50);
            Console.WriteLine($"Blurring:\n {image.ImageName} => intnesity: {intnesity}");
        }
    }
}
