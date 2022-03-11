using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace SERVER
{
    /// <summary>
    /// Contains all of the logic for image collection and manipulation
    /// Author: Matthew Whitehouse and Marc Price
    /// Date: 13/12/2021
    /// </summary>
    public class Server : IServer
    {
        //CREATES a new dictionary for image references to be stored
        IDictionary<String, Image> _imageDict = new Dictionary<String, Image>();

        //CREATES a temporary image variable
        Image _tempImage;

        /// <summary>
        /// Load the media items pointed to by 'pPathfilenames' into the Server's data store.
        /// The strings in the collection act as unique identifiers for images in the Server's data store.
        /// </summary>
        /// <param name="pPathfilenames">a collection of one or more strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        public IList<String> Load(IList<String> pPathfilenames)
        {
            //ITERATES through the list of filepaths
            foreach (String _imagePath in pPathfilenames)
            {
                if (_imageDict.ContainsKey(_imagePath))
                {
                    //do nothing
                }
                else 
                {
                    //ADDS the temporary image to the dictionary
                    _imageDict.Add(_imagePath, _tempImage = new Bitmap(Path.GetFullPath(_imagePath)));

                }
            }
            //RETURNS the file path image list
            return pPathfilenames;

        }

        /// <summary>
        /// Request a copy of the image specified by 'pUid', scaled according to the dimensions given by pFrameWidth and pFrameHeight.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image requested</param>
        /// <param name="pFrameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="pFrameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image identified by pUid</returns>
        public Image GetImage(String pUid, int pFrameWidth, int pFrameHeight)
        {
            //SET temporary image to the image ID in the dictionary
            _tempImage = _imageDict[pUid];

            //CREATE new image, sized to the new bitmap paramaters
            _tempImage = new Bitmap(_tempImage, new Size(pFrameWidth, pFrameHeight));

            //RETURN the image
            return _tempImage;

        }

        /// <summary>
        /// Rotate the image specified by 'pUid'.
        /// The client will need to request a copy of the Image to update its view-copy of the image accordingly.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be rotated</param>
        /// <returns>the rotated Image</returns>
        public void RotateImage(String pUid)
        {
            //Rotate the image 90 degrees
            _imageDict[pUid].RotateFlip(RotateFlipType.Rotate90FlipNone);

        }

        /// <summary>
        /// Flip the image specified by 'pUid' horizontally.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be flipped</param>
        /// <returns>the flipped Image</returns>
        public void HorizontalFlipImage(String pUid)
        {
            //FLIP the image in the dictionary along the horizontal axis
            _imageDict[pUid].RotateFlip(RotateFlipType.RotateNoneFlipX);

        }

        /// <summary>
        /// Flip the image specified by 'pUid' vertically.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be flipped</param>
        /// <returns>the flipped Image</returns>
        public void VerticalFlipImage(String pUid)
        {
            //Flip the image in the dictionary along the vertical axis
            _imageDict[pUid].RotateFlip(RotateFlipType.RotateNoneFlipY);

        }
    }
}
