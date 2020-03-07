using System;
using System.Collections.Generic;

namespace Kibzee.Models
{
    public partial class Instruments
    {
        public int InstId { get; set; }
        public string InstrumentName { get; set; }
        public int? GradeSchemaId { get; set; }
        public string Icon { get; set; }
        public string Picture { get; set; }
    }
}
