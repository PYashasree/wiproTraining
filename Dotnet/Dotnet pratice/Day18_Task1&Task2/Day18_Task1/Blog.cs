using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppCodeFirstApproach
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }

        [Required]
        [MaxLength(100)]
        public string BlogName { get; set; }

        [MaxLength(50)]
        public string BlogType { get; set; }

        [MaxLength(200)]
        public string BlogHeader { get; set; }

        public string BlogDescription { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Blog()
        {
            Posts = new List<Post>();
        }

        public override string ToString()
        {
            return $"BlogId: {BlogId}, BlogName: {BlogName}, BlogType: {BlogType}, BlogHeader: {BlogHeader}, BlogDescription: {BlogDescription}";
        }
    }
}
