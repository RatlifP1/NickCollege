using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using NickCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section = NickCollege.Models.Section;

namespace NickCollege.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Application> Applications { get; set; }
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<CourseInfo> CourseInfos { get; set; }
    }
}
