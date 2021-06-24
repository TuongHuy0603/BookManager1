namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Id không được để trống")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được quá 100 ký tự")]
        [StringLength(100)]
        public string Title { get; set; }

     
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(250)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tác giả không được quá 30 ký tự")]
        [StringLength(30)]
        public string Author { get; set; }

      
        public string Images { get; set; }
 
        [Range(1000, 1000000, ErrorMessage = "Giá Từ 1000 - 1000000")]
        public int Price { get; set; }
    }
}
