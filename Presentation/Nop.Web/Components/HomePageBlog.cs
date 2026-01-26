using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Blogs;
using Nop.Services.Media;
using Nop.Services.Seo;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Blogs;
using System.Collections.Generic;
using System.Threading.Tasks;

public class HomePageBlog : NopViewComponent
{
    private readonly IBlogService _blogService;
    private readonly IPictureService _pictureService;
    private readonly IUrlRecordService _urlRecordService;
    private readonly IWebHelper _webHelper;

    public HomePageBlog(
        IBlogService blogService,
        IPictureService pictureService,
        IUrlRecordService urlRecordService,
        IWebHelper webHelper)
    {
        _blogService = blogService;
        _pictureService = pictureService;
        _urlRecordService = urlRecordService;
        _webHelper = webHelper;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var blogs = await _blogService.GetAllBlogPostsAsync(
            pageIndex: 0,
            pageSize: 6,
            showHidden: false);

        var model = new List<HomepageBlogModel>();

        foreach (var blog in blogs)
        {
            var pictureUrl = string.Empty;

            if (blog.PictureId > 0)
            {
                pictureUrl = await _pictureService.GetPictureUrlAsync(
                    blog.PictureId,
                    600);
            }

            // 🔑 جلب الـ Slug الصحيح (حسب اللغة + النشط)
            var seName = await _urlRecordService.GetSeNameAsync(blog);

            model.Add(new HomepageBlogModel
            {
                Id = blog.Id,
                Title = blog.Title,
                ShortDescription = blog.BodyOverview,
                CreatedOn = blog.CreatedOnUtc,
                PictureUrl = pictureUrl,

                // ✅ SEO URL النهائي
                Url = _webHelper.GetStoreLocation() + seName
            });
        }

        return View(model);
    }

}
