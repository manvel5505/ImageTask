using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Domain
{
    internal class Image
    {
        private string? imageName;
        public string? ImageName
        {
            get => imageName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Image is empty!!!");
                }
                else
                {
                    imageName = value;
                }
            }
        }
        public List<IEffect> ImageEffects { get; set; } = new List<IEffect>();
        public override string ToString()
        {
            return $"Image > {ImageName}\n,Effects > {ImageEffects.Count}";
        }
    }
}
