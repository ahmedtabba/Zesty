namespace Nop.Web.Models.Widgets
{
    public record TestimonialModel
    {
        public string Quote { get; init; }
        public string Author { get; init; }
        public string Role { get; init; }
        public string AvatarUrl { get; init; }
    }
}