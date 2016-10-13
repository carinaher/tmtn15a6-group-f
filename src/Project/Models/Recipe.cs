﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Comments = new HashSet<Comment>();
            Directions = new HashSet<Direction>(); 
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "MissingName")]
        [StringLength(70, MinimumLength = 5, ErrorMessage = "NameWrongLength")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "MissingDescription")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "DescriptionWrongLength")]
        public string Description { get; set; }

        [StringLength(200, MinimumLength = 10)]
        public string Image { get; set; }
        public int Created { get; set; }

        public string CreatorId {get;set;}

        public ICollection<Comment> Comments { get; set; } 
        public ICollection<Direction> Directions { get; set; } 
        public ICollection<Favorites> Favorites { get; set; }

        public AccountIdentity AccountIdentity { get; set; } 
    }
}
