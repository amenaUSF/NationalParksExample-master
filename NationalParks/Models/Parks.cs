using System;
using System.Collections.Generic;

namespace NationalParks.Models
{
  // Model for parks data. These classes can be obtained by either using 
  // the Visual Studio editor (right-click -> Paste Special -> Paste Json as Classes)
  // or sites such as JsonToCSHarp
  public class detail
  {
        public string objective { get; set; }
        public string title { get; set; }
        public string classification { get; set; }
        public string specification { get; set; }
    }

    public class Parks
  {
        public string classification { get; set; }
        public string title { get; set; }
        public string section { get; set; }
        public string topic { get; set; }
        public string subtopic { get; set; }
        public string desired_outcome { get; set; }
        public List<detail> details { get; set; }
  }
}