using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {
        private int _minLength = 1;
        private int _minWidth = 1;
        private int _minHeight = 1;

        private int _maxLength = 100;
        private int _maxWidth = 100;
        private int _maxHeight = 100;

        private int _length;
        private int _width;
        private int _height;
        public int Length {
            get { return _length; }
            set
            {
                if (value > _minLength && value < _maxLength)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Length is outside valid range");
                }
            }
        }

       public int Width { get; set; }

       public int Height { get; set; }

    
        //access modifier    return type      signature
        public int RoomSize()
        {
            
                return Length * Width * Height;
            
        }




    }
    
    
}
