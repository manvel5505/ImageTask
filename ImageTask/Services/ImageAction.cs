using ImageTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Services
{
    internal class ImageAction
    {
        private readonly IList<Image> images;
        public ImageAction()
        {
            images = new List<Image>();
        }
        public void AddImage(Image image)
        {
            images.Add(image); 
        }
        public async Task RunAsync()
        {
            foreach (var image in images)
            {
                foreach (var effect in image.ImageEffects)
                {
                    try
                    {
                        await effect.ApplyAsync(image);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error {effect.GetType().Name} => {image.ImageName}, {ex.Message}");
                    }
                }
            }
        }
    }
}
