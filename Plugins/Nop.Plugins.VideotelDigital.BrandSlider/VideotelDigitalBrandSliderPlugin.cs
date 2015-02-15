using System.Collections.Generic;
using System.IO;
using System.Web.Routing;
using Nop;
using Nop.Core;
using Nop.Core.Plugins;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;

namespace Nop.Plugin.VideotelDigital.BrandSlider
{
    public class VideotelDigitalBrandSliderPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;

        public VideotelDigitalBrandSliderPlugin(IPictureService pictureService, 
            ISettingService settingService, IWebHelper webHelper)
        {
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._webHelper = webHelper;
        }

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string>() { "VideotelBrandSlider" };
        }

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "VideotelDigitalBrandSlider";
            routeValues = new RouteValueDictionary() { { "Namespaces", "Nop.Plugin.VideotelDigital.BrandSlider.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Gets a route for displaying widget
        /// </summary>
        /// <param name="widgetZone">Widget zone where it's displayed</param>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "PublicInfo";
            controllerName = "VideotelDigitalBrandSlider";
            routeValues = new RouteValueDictionary()
            {
                {"Namespaces", "Nop.Plugin.VideotelDigital.BrandSlider.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            ////pictures
            //var sampleImagesPath = _webHelper.MapPath("~/Plugins/VideotelDigital.BrandSlider/Content/testimonialslider/sample-images/");


            ////settings
            //var settings = new VideotelDigitalBrandSliderSettings()
            //{
            //    //Picture1Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner1.jpg"), "image/pjpeg", "banner_1", true).Id,
            //    //Text1 = "",
            //    //Link1 = _webHelper.GetStoreLocation(false),
            //    //Picture2Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner2.jpg"), "image/pjpeg", "banner_2", true).Id,
            //    //Text2 = "",
            //    //Link2 = _webHelper.GetStoreLocation(false),
            //    //Picture3Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner3.jpg"), "image/pjpeg", "banner_3", true).Id,
            //    //Text3 = "",
            //    //Link3 = _webHelper.GetStoreLocation(false),
            //    //Picture4Id = _pictureService.InsertPicture(File.ReadAllBytes(sampleImagesPath + "banner4.jpg"), "image/pjpeg", "banner_4", true).Id,
            //    //Text4 = "",
            //    //Link4 = _webHelper.GetStoreLocation(false),
            //};
            //_settingService.SaveSetting(settings);

            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture1", "Picture 1");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture2", "Picture 2");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture3", "Picture 3");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture4", "Picture 4");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture5", "Picture 5");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture6", "Picture 6");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture7", "Picture 7");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture8", "Picture 8");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture9", "Picture 9");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture10", "Picture 10");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture", "Picture");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture.Hint", "Upload picture.");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Text", "Comment");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Text.Hint", "Enter comment for picture. Leave empty if you don't want to display any text.");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Link", "URL");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Link.Hint", "Enter URL. Leave empty if you don't want this picture to be clickable.");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Author", "Testimonial Name");
            //this.AddOrUpdatePluginLocaleResource("VideotelDigital.TestimonialSlider.Company", "Company Name");

            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            //settings
            //_settingService.DeleteSetting<VideotelDigitalTestimonialSliderSettings>();

            //locales
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture1");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture2");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture3");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture4");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture5");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture6");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture7");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture8");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture9");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture10");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Picture.Hint");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Text");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Text.Hint");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Link");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Link.Hint");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Author");
            //this.DeletePluginLocaleResource("VideotelDigital.TestimonialSlider.Company");

            base.Uninstall();
        }
    }
}
