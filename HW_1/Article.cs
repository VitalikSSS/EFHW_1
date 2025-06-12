using System;
using System.Collections.Generic;
using System.Linq;
namespace HW_1
{
    public class Article
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedAt { get; set; }
        public Guid UserId { get; set; }
        public AppUser? AppUser { get;set; }
    }
}
