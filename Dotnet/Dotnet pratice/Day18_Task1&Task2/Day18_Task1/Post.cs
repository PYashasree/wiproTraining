using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppCodeFirstApproach
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }

        [Required]
        [MaxLength(200)]
        public string PostDescription { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Blog Blog { get; set; }

        public override string ToString()
        {
            return $"PostId: {PostId}, BlogId: {BlogId}, PostDescription: {PostDescription}, CreationDate: {CreationDate}";
        }
    }
}
