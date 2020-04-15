using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Производитель
    /// </summary>
    public class spManufacturer : BaseModel
    {
        public int Id { get; set; }

        [Index]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Required]
        public int CountryId { get; set; }
        public spCountry Country { get; set; }

    }
}
