using System.Drawing;

namespace SERVER
{
    /// <summary>
    /// Interface for the logic used by the buttons on the form
    /// Author: Matthew Whitehouse
    /// Date: 13/12/2021
    /// </summary>
    public interface IImageMod
    {
        void LoadImage();

        void RotateImage();

        void FlipImage();

        void Brightness();

        void Contrast();

        void Pixelate();

        void Hue();

        void Gaussian();

        void Opacity();

        void Saturation();
    }
}