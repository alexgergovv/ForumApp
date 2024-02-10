using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static ForumApp.Infrastructure.Constants.ValidationConstants;


namespace ForumApp.Core.Models
{
    /// <summary>
    /// Post data transfer model
    /// </summary>
    public class PostModel
    {
        /// <summary>
        /// Post identificator
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Post title
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(TitleMaxLength,MinimumLength = TitleMinLength,ErrorMessage = StringLengthMessage)]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Post content
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = StringLengthMessage)]
        public string Content { get; set; } = string.Empty;
    }
}
