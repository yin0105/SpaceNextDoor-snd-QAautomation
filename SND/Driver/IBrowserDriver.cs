using System;
using System.Collections.Generic;
using System.Text;

namespace SND.Driver
{
   public interface IBrowserDriver
   { 
        void Navigate(string urlPart);
   }
}
