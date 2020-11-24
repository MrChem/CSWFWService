using System;
using System.Collections.Generic;
using System.Text;

namespace CSWFWModel
{
    [Serializable]
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
    }
}
