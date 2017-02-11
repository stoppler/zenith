using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ZenithDataLib.Models
{
    [MetadataType(typeof(ActivityMetaData))]
    public partial class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        
        public string Description { get; set; }

        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public virtual List<Event> Events { get; set; }

    }

    public class ActivityMetaData
    {
        [Required]
        public object Description { get; set; }
    }
}
