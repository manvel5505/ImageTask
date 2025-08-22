using ImageTask.Domain;
using ImageTask.Plugins;
using ImageTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Configuration
{
    public class ExampleUse
    {
        public static async Task RunAll()
        {
            var image1 = new Image { ImageName = "Image1" };
            image1.ImageEffects.Add(new ResizeEffect(150));
            image1.ImageEffects.Add(new BlurEffect(2));

            var image2 = new Image { ImageName = "Image2" };
            image2.ImageEffects.Add(new ResizeEffect(100));
            image2.ImageEffects.Add(new GrayscaleEffect());

            var action = new ImageAction();
            action.AddImage(image1);
            action.AddImage(image2);

            await action.RunAsync();
        }
    }
}
