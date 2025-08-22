using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask.Domain
{
    internal interface IEffect
    {
        Task ApplyAsync(Image image);
    }
}
