using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVER
{
    public interface IPublisher
    {
        void Initialize(IFactory pFactory);

        void Subscribe(EventHandler<ImageEventArgs> pListener);
    }
}
