using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Widgets;

namespace Nop.Web.Components
{
    public class TestimonialsViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // „ƒﬁ : »Ì«‰«  À«» … ··«Œ »«—. »œ¯·Â« ·«Õﬁ« »ﬁ—«¡… „‰ DB √Ê ≈⁄œ«œ« .
            var model = new List<TestimonialModel>
            {
                new TestimonialModel { Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sit semper consequat in dolor mattis...", Author = "Brooklyn Simmons", Role = "Expert", AvatarUrl = "/Themes/Emporium/Content/img/avatar1.jpg" },
                new TestimonialModel { Quote = "Excellent service, highly recommended. Donec vitae sapien ut libero venenatis faucibus.", Author = "Maya Thompson", Role = "Manager", AvatarUrl = "/Themes/Emporium/Content/img/avatar2.jpg" },
                new TestimonialModel { Quote = "Great quality and support. Praesent commodo cursus magna, vel scelerisque nisl consectetur.", Author = "Liam Carter", Role = "Developer", AvatarUrl = "/Themes/Emporium/Content/img/avatar3.jpg" },
                new TestimonialModel { Quote = "Very satisfied with the results. Integer posuere erat a ante venenatis dapibus.", Author = "Olivia Brown", Role = "Designer", AvatarUrl = "/Themes/Emporium/Content/img/avatar4.jpg" },
                new TestimonialModel { Quote = "Top-notch experience and fast delivery. Cras mattis consectetur purus sit amet fermentum.", Author = "Noah Wilson", Role = "Consultant", AvatarUrl = "/Themes/Emporium/Content/img/avatar5.jpg" }
            };

            return View(model);
        }
    }
}