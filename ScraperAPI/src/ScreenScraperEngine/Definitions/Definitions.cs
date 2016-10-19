using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ScreenScraperEngine.Definitions
{
    /// <summary> 
    ///  
    /// </summary> 
    public enum DefinitionFormat
    {
        Json, Xml
    }

    /// <summary> 
    ///  
    /// </summary> 
    public sealed class Definitions
    {
        #region Properties 

        /// <summary> 
        ///  
        /// </summary> 
        public string Name { get; set; }

        /// <summary>  
        /// Target URI  
        /// </summary>  
        public Uri Target { get; set; }

        /// <summary> 
        ///  
        /// </summary> 
        public IList<Definition> DefinitionList { get; set; }

        /// <summary>  
        /// Used to flag is a target has changed  
        /// </summary>  
        public bool IsReady { get; private set; }

        #endregion

        #region Constructors 

        /// <summary> 
        ///  
        /// </summary> 
        public Definitions()
        {
            this.DefinitionList = new List<Definition>();
        }

        #endregion



    }
}
