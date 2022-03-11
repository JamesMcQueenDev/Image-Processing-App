using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

/// <summary>
/// Contains all delegates used 
/// Author: Matthew Whitehouse
/// Date: 13/12/2021
/// </summary>
namespace SERVER
{
    //DELEGATE which returns an Image, call it imageSizeDelegate
    public delegate Image ImageSizeDelegate(int pHeight, int pWidth);

    //DELEGATE which returns void, call it ImageSelectDelegate
    public delegate void ImageSelectDelegate();

    //DELEGATE which returns void, call it ImageIncreaseDelegate
    public delegate void ImageIncreaseDelegate();

    //DELEGATE which returns void, call it ImageDecreaseDelegate
    public delegate void ImageDecreaseDelegate();

    //DELEGATE which returns void, call it ImageRotateDelegate
    public delegate void ImageRotateDelegate();

    //DELEGATE which returns void, call it ImageHorDelegate
    public delegate void ImageFlipHorDelegate();

    //DELEGATE which returns void, call it ImageVertDelegate
    public delegate void ImageFlipVertDelegate();
}
