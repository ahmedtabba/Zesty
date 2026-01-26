using System;

namespace Nop.Web.Models.Blogs
{
    public class HomepageBlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PictureUrl { get; set; }
        public string SeName { get; set; }
        public string Url { get; set; } 
        public DateTime CreatedOn { get; set; }
    }

}
