using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace MVCDemo.Models
{
    [MetadataType(typeof(Mobile20160830Metadata))]

    public partial class Mobile20160830 { }

    public class Mobile20160830Metadata
    {
        [Required(ErrorMessage ="CID is required.")]
        [DisplayName("編號")]
        [StringLength(10,ErrorMessage ="exceed 10 char")]
        public int id { get; set; }

        //密碼
        //[DataType(DataType.Password)]
        //[Compare(CID,ErrorMessage ="test")]

        [Required(ErrorMessage = "Name is required.")]
        public string UserDisplayName { get; set; }
        public string DeviceOS { get; set; }
        public string DeviceType { get; set; }

    }
}