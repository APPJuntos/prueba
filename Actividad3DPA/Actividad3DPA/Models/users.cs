namespace Actividad3DPA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string nickname { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        public byte[] profilePic { get; set; }
    }
}
