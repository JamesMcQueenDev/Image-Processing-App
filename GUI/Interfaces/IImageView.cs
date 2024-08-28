using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Authors: Jack Hughes & Matthew Whitehouse
/// Date: 23/03/2022
/// The code for the ImageView
/// </summary>
namespace GUI
{
    /// <summary>
    /// Interface for the ImageView class
    /// </summary>
    public interface IImageView
    {
        void Initialize(Action<ICommand> pInvokeCommand, ICommand pLoadImage, ICommand pRotateLeft, ICommand pRotateRight, ICommand pBrightness, ICommand pContrast, ICommand pPixelate, ICommand pOpacity, ICommand pHue, ICommand pGaussian, ICommand pSaturation);
    }
}
