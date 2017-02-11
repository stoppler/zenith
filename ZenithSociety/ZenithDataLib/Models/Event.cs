using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ZenithDataLib.Models.CustomValidation;

namespace ZenithDataLib.Models
{
    [MetadataType(typeof(EventMetaData))]
    public partial class Event
    {
        [Key]
        public int EventId { get; set; }

      
        [DataType(DataType.DateTime)]
        [Display(Name = "Event From")]
        public DateTime EventFrom { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Event To")]
        public DateTime EventTo { get; set; }

        [DataType(DataType.Date)]
        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public int ActivityId { get; set; }

        [ForeignKey("ActivityId")]
        public virtual Activity Activity { get; set; }

    }

    public class EventMetaData
    {
        [Required]
        [DateRange]
        public object EventFrom { get; set; }

        [Required]
        [DateTimeFromTo(ErrorMessage = "{0} is greater than the Date of Event From")]
        [DateRange]
        public object EventTo { get; set; }
    }
}
