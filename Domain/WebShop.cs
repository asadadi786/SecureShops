using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WebShop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlStore { get; set; }
        public string headerImagePreview { get; set; }
        public string logoImagePreview { get; set; }
        public string color { get; set; }

        public DateTime CreatedDate{get; set;}  = DateTime.UtcNow;

        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set;}

    
        //public string Type { get; set; }
    }
}
