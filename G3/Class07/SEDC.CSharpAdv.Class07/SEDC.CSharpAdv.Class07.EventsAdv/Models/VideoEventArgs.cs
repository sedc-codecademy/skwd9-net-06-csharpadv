using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.EventsAdv.Models
{
    public class VideoEventArgs : EventArgs
    {
        public Movie Movie { get; set; }
    }
}
