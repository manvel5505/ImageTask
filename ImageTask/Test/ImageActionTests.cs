using ImageTask.Domain;
using ImageTask.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ImageTask.Test
{
    public class ImageActionTests
    {
        [Fact]
        public async Task ProcessAllAsync_AppliesAllEffects()
        {
            var image = new Image { ImageName = "TestImage" };

            var effect1 = new Mock<IEffect>();
            var effect2 = new Mock<IEffect>();

            image.ImageEffects.Add(effect1.Object);
            image.ImageEffects.Add(effect2.Object);

            var action = new ImageAction();
            action.AddImage(image);

            await action.RunAsync();

            effect1.Verify(x => x.ApplyAsync(image), Times.Once);
            effect2.Verify(x => x.ApplyAsync(image), Times.Once);
        }

        [Fact]
        public async Task ProcessAllAsync_CatchsException_DoesNotStopPtherEffects()
        {
            var image = new Image { ImageName = "TestImage" };

            var goodeffect = new Mock<IEffect>();
            var badeffect = new Mock<IEffect>();

            badeffect.Setup(x => x.ApplyAsync(image)).ThrowsAsync(new Exception("Test exception"));

            image.ImageEffects.Add(badeffect.Object);
            image.ImageEffects.Add(goodeffect.Object);

            var action = new ImageAction();
            action.AddImage(image);

            await action.RunAsync();

            goodeffect.Verify(x => x.ApplyAsync(image), Times.Once);
        }
    }
}
