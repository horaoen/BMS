using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BMS.Models.Entities;

namespace BMS.Dtos
{
    public class BookTitleForCreationDto : IValidatableObject
    {
        [Required(ErrorMessage = "书目名称不可为空")]   
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "书目作者不可为空")]
        [MaxLength(50)]
        public string Author { get; set; }
        
        public int TotalNumber { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TotalNumber <= 0)
            {
                yield return new ValidationResult(
                    "书目数量必需输入且大于零",
                    new[] { "BookTitleForCreationDto" });
            }
        }
    }
}