using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;


namespace Blog.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("[User]")]
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
            Posts = new List<Post>();
        }
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }

        [Write(false)]
        public List<Post> Posts { get; set; }
    }
}