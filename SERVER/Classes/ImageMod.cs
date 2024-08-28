using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace SERVER
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 20/04/2022
    /// Modifies the image
    /// </summary>
    public class ImageMod : IImageMod, IPublisher
    {
        // DEFINE boolean, call it _isInitialized
        private bool _isInitialized = false;

        // DEFINE IFactory, call it _factory 
        private IFactory _factory;

        // DEFINE EventHandler, call it _listeners
        private EventHandler<ImageEventArgs> _listeners;

        // DEFINE string, call it _state
        private string _state = "Created";

        /// <summary>
        /// INTIALISE the class
        /// </summary>
        /// <param name="pFactory"></param>
        public void Initialize(IFactory pFactory)
        {
            // SET pFactory to _factory  
            _factory = pFactory;

            //SET boolean to TRUE
            _isInitialized = true;
        }

        /// <summary>
        /// SUBSCRIBE to event
        /// </summary>
        /// <param name="pListener"></param>
        public void Subscribe(EventHandler<ImageEventArgs> pListener)
        {
            // IF not initialised
            if (!_isInitialized)
            {
                // THROW exception
                throw new NotInitializedException();
            }

            // SET _listeners
            _listeners += pListener;

            // CALL method
            OnStateChange();
        }

        /// <summary>
        /// LOAD a new Image.
        /// </summary>
        public void LoadImage()
        {
            //SET State.
           _state = "Load";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// ROTATE a new Image.
        /// </summary>
        public void RotateImage()
        {
            //SET State.
            _state = "Rotate";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// FLIP a new Image.
        /// </summary>
        public void FlipImage()
        {
            //SET State.
            _state = "Flip";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// BRIGHTNESS a new Image.
        /// </summary>
        public void Brightness()
        {
            //SET State.
            _state = "Brightness";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CONTRAST a new Image.
        /// </summary>
        public void Contrast()
        {
            //SET State.
            _state = "Contrast";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CONTRAST a new Image.
        /// </summary>
        public void Pixelate()
        {
            //SET State.
            _state = "Pixelate";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CONTRAST a new Image.
        /// </summary>
        public void Gaussian()
        {
            //SET State.
            _state = "Gaussian";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CONTRAST a new Image.
        /// </summary>
        public void Hue()
        {
            //SET State.
            _state = "Hue";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CONTRAST a new Image.
        /// </summary>
        public void Opacity()
        {
            //SET State.
            _state = "Opacity";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Saturation()
        {
            //SET State.
            _state = "Saturation";

            // CALL Change State.
            OnStateChange();
        }

        /// <summary>
        /// CHANGES state
        /// </summary>
        private void OnStateChange()
        {
            // SETS _args
            ImageEventArgs _args = _factory.Create<EventArgs, ImageEventArgs>() as ImageEventArgs;

            // SETS _args.State as _state
            _args.State = _state;

            // INVOKE _args, sending information to the ImageView
            _listeners?.Invoke(this, _args);
        }
    }
}
