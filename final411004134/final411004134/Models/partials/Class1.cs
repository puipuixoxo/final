using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace final411004134.Models.partials
{
    [MetadataType(typeof(NewsMetadata))]

    public class News
    {
    }
    public class NewsMetadata
    {
        [Required(ErrorMessage = "欄位:標題必須為最大長度不超過50的文字")]
        [Display(Name = "標題")]
        [StringLength(50)]
        public int Id{ get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]
        public string Name { get; set; }


        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發布時間")]
        public string Number { get; set; }


    }
}