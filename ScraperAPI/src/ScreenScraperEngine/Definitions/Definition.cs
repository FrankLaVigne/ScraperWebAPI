using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenScraperEngine.Definitions
{
    public sealed class Definition
    {
        /// <summary> 
        ///  
        /// </summary> 
        public string Name { get; set; }

        /// <summary> 
        ///  
        /// </summary> 
        public string StartMarker { get; set; }

        /// <summary> 
        ///  
        /// </summary> 
        public IList<Marker> EndMarkers { get; set; }

        public Definition()
        {
            this.EndMarkers = new List<Marker>();
        }

    }
}
