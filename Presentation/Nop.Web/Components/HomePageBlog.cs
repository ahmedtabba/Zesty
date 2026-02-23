using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Blogs;
using Nop.Services.Common;
using Nop.Services.Media;
using Nop.Services.Seo;
using Nop.Services.Configuration;
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
    private readonly IWorkContext _workContext;
    private readonly IStoreContext _storeContext;
    private readonly ISettingService _settingService;

    public HomePageBlog(
        IBlogService blogService,
        IPictureService pictureService,
        IUrlRecordService urlRecordService,
        IWebHelper webHelper,
        IWorkContext workContext,
        IStoreContext storeContext,
        ISettingService settingService)
    {
        _blogService = blogService;
        _pictureService = pictureService;
        _urlRecordService = urlRecordService;
        _webHelper = webHelper;
        _workContext = workContext;
        _storeContext = storeContext;
        _settingService = settingService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        // current UI language (0 = no language)
        var language = await _workContext.GetWorkingLanguageAsync();
        var store = await _storeContext.GetCurrentStoreAsync();

        // get number of blog posts to show from RichBlog settings (per store)
        var numberOfBlogPosts = await _settingService.GetSettingByKeyAsync<int>(
            "RichBlogSettings.NumberOfBlogPostsToShow", 3, store.Id);

        var blogs = await _blogService.GetAllBlogPostsAsync(
            store.Id,
            language.Id,
            pageIndex: 0,
            pageSize: numberOfBlogPosts,
            showHidden: false);

        var model = new List<HomepageBlogModel>();

        foreach (var blog in blogs)
        {
            // Skip blogs that don't belong to the current language (if a language is selected)

            // Skip blogs that don't belong to the current language (if a language is selected)
           

            var pictureUrl = string.Empty;

            if (blog.PictureId > 0)
            {
                pictureUrl = await _pictureService.GetPictureUrlAsync(
                    blog.PictureId,
                    600);
            }   

            // get correct SEO slug for the selected language (languageId may be 0)
            var seName = await _urlRecordService.GetSeNameAsync(blog, language.Id);

            model.Add(new HomepageBlogModel
            {
                Id = blog.Id,
                Title = blog.Title,
                ShortDescription = blog.BodyOverview,
                CreatedOn = blog.CreatedOnUtc,
                PictureUrl = pictureUrl,

                // final SEO URL
                Url = _webHelper.GetStoreLocation() + seName
            });
        }

        return View(model);
    }

}
