using System.Drawing;

namespace GUI
{
    /// <summary>
    /// Interface for the logic used by the buttons on the form
    /// Author: Matthew Whitehouse
    /// Date: 13/12/2021
    /// </summary>
    public interface IFormLogicButtons
    {
        
        /// <summary>
        /// SELECT the image stored on the machine if there is one there
        /// </summary>
        void ImageSelect();

        /// <summary>
        /// ITERATE through the list of images selected 
        /// </summary>
        void IncreaseImageVal();

        /// <summary>
        /// MOVE backwards through the list of selected images
        /// </summary>
        void DecreaseImageVal();

        /// <summary>
        /// CALL the HorizontalFlipImage method in server
        /// </summary>
        void FlipHorizontal();

        /// <summary>
        /// CALL the VerticalFlipImage method in server
        /// </summary>
        void FlipVertical();

        /// <summary>
        /// CALL the RotateImage method in server
        /// </summary>
        void RotateImage();

        /// <summary>
        /// CALL the IncreaseBrightness method in server
        /// </summary>
        void IncreaseBrightness();

        /// <summary>
        /// CALL the DecreaseBrightness method in server
        /// </summary>
        void DecreaseBrightness();

        /// <summary>
        /// RETURN the image found using the file path selected
        /// </summary>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <returns>_image</returns>
        Image GetImage(int pWidth, int pHeight);

    }
}