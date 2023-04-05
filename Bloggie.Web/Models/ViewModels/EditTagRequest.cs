﻿using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Models.ViewModels
{
    public class EditTagRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<BlogPost> BlogPost { get; set; }
    }
}
 