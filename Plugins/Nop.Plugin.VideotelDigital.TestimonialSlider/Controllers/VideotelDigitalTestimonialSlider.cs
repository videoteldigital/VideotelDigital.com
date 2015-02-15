using System.Web.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.VideotelDigital.TestimonialSlider.Infrastructure.Cache;
using Nop.Plugin.VideotelDigital.TestimonialSlider.Models;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Plugin.VideotelDigital.TestimonialSlider.Controllers
{
    public class VideotelDigitalTestimonialSliderController : BasePluginController
    {
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly IStoreService _storeService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly ICacheManager _cacheManager;

        public VideotelDigitalTestimonialSliderController(IWorkContext workContext,
            IStoreContext storeContext,
            IStoreService storeService, 
            IPictureService pictureService,
            ISettingService settingService,
            ICacheManager cacheManager)
        {
            this._workContext = workContext;
            this._storeContext = storeContext;
            this._storeService = storeService;
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._cacheManager = cacheManager;
        }

        protected string GetPictureUrl(int pictureId)
        {
            string cacheKey = string.Format(ModelCacheEventConsumer.PICTURE_URL_MODEL_KEY, pictureId);
            return _cacheManager.Get(cacheKey, () =>
            {
                var url = _pictureService.GetPictureUrl(pictureId, showDefaultPicture: false);
                //little hack here. nulls aren't cacheable so set it to ""
                if (url == null)
                    url = "";

                return url;
            });
        }

        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var testimonialSliderSettings = _settingService.LoadSetting<VideotelDigitalTestimonialSliderSettings>(storeScope);
            var model = new ConfigurationModel();

            //IList<TestimonialModel> list = new List<TestimonialModel>();
            //IEnumerable<TestimonialModel> sortedEnum = list.OrderBy(f => f.SortOrder);
            //IList<TestimonialModel> sortedList = sortedEnum.ToList();

            //TestimonialListModels x = new TestimonialListModels();
            //x.Testimonials = sortedList;


            model.SectionHeader = testimonialSliderSettings.SectionHeader;
            model.Picture1Id = testimonialSliderSettings.Picture1Id;
            model.Text1 = testimonialSliderSettings.Text1;
            model.Link1 = testimonialSliderSettings.Link1;
            model.Author1 = testimonialSliderSettings.Author1;
            model.Company1 = testimonialSliderSettings.Company1;
            model.SortOrder1 = testimonialSliderSettings.SortOrder1;

            model.Picture2Id = testimonialSliderSettings.Picture2Id;
            model.Text2 = testimonialSliderSettings.Text2;
            model.Link2 = testimonialSliderSettings.Link2;
            model.Author2 = testimonialSliderSettings.Author2;
            model.Company2 = testimonialSliderSettings.Company2;
            model.SortOrder2 = testimonialSliderSettings.SortOrder2;

            model.Picture3Id = testimonialSliderSettings.Picture3Id;
            model.Text3 = testimonialSliderSettings.Text3;
            model.Link3 = testimonialSliderSettings.Link3;
            model.Author3 = testimonialSliderSettings.Author3;
            model.Company3 = testimonialSliderSettings.Company3;
            model.SortOrder3 = testimonialSliderSettings.SortOrder3;

            model.Picture4Id = testimonialSliderSettings.Picture4Id;
            model.Text4 = testimonialSliderSettings.Text4;
            model.Link4 = testimonialSliderSettings.Link4;
            model.Author4 = testimonialSliderSettings.Author4;
            model.Company4 = testimonialSliderSettings.Company4;
            model.SortOrder4 = testimonialSliderSettings.SortOrder4;

            model.Picture5Id = testimonialSliderSettings.Picture5Id;
            model.Text5 = testimonialSliderSettings.Text5;
            model.Link5 = testimonialSliderSettings.Link5;
            model.Author5 = testimonialSliderSettings.Author5;
            model.Company5 = testimonialSliderSettings.Company5;
            model.SortOrder5 = testimonialSliderSettings.SortOrder5;

            model.Picture6Id = testimonialSliderSettings.Picture6Id;
            model.Text6 = testimonialSliderSettings.Text6;
            model.Link6 = testimonialSliderSettings.Link6;
            model.Author6 = testimonialSliderSettings.Author6;
            model.Company6 = testimonialSliderSettings.Company6;
            model.SortOrder6 = testimonialSliderSettings.SortOrder6;

            model.Picture7Id = testimonialSliderSettings.Picture7Id;
            model.Text7 = testimonialSliderSettings.Text7;
            model.Link7 = testimonialSliderSettings.Link7;
            model.Author7 = testimonialSliderSettings.Author7;
            model.Company7 = testimonialSliderSettings.Company7;
            model.SortOrder7 = testimonialSliderSettings.SortOrder7;

            model.Picture8Id = testimonialSliderSettings.Picture8Id;
            model.Text8 = testimonialSliderSettings.Text8;
            model.Link8 = testimonialSliderSettings.Link8;
            model.Author8 = testimonialSliderSettings.Author8;
            model.Company8 = testimonialSliderSettings.Company8;
            model.SortOrder8 = testimonialSliderSettings.SortOrder8;

            model.Picture9Id = testimonialSliderSettings.Picture9Id;
            model.Text9 = testimonialSliderSettings.Text9;
            model.Link9 = testimonialSliderSettings.Link9;
            model.Author9 = testimonialSliderSettings.Author9;
            model.Company9 = testimonialSliderSettings.Company9;
            model.SortOrder9 = testimonialSliderSettings.SortOrder9;

            model.Picture10Id = testimonialSliderSettings.Picture10Id;
            model.Text10 = testimonialSliderSettings.Text10;
            model.Link10 = testimonialSliderSettings.Link10;
            model.Author10 = testimonialSliderSettings.Author10;
            model.Company10 = testimonialSliderSettings.Company10;
            model.SortOrder10 = testimonialSliderSettings.SortOrder10;

            model.Picture11Id = testimonialSliderSettings.Picture11Id;
            model.Text11 = testimonialSliderSettings.Text11;
            model.Link11 = testimonialSliderSettings.Link11;
            model.Author11 = testimonialSliderSettings.Author11;
            model.Company11 = testimonialSliderSettings.Company11;
            model.SortOrder11 = testimonialSliderSettings.SortOrder11;

            model.Picture12Id = testimonialSliderSettings.Picture12Id;
            model.Text12 = testimonialSliderSettings.Text12;
            model.Link12 = testimonialSliderSettings.Link12;
            model.Author12 = testimonialSliderSettings.Author12;
            model.Company12 = testimonialSliderSettings.Company12;
            model.SortOrder12 = testimonialSliderSettings.SortOrder12;

            model.Picture13Id = testimonialSliderSettings.Picture13Id;
            model.Text13 = testimonialSliderSettings.Text13;
            model.Link13 = testimonialSliderSettings.Link13;
            model.Author13 = testimonialSliderSettings.Author13;
            model.Company13 = testimonialSliderSettings.Company13;
            model.SortOrder13 = testimonialSliderSettings.SortOrder13;

            model.Picture14Id = testimonialSliderSettings.Picture14Id;
            model.Text14 = testimonialSliderSettings.Text14;
            model.Link14 = testimonialSliderSettings.Link14;
            model.Author14 = testimonialSliderSettings.Author14;
            model.Company14 = testimonialSliderSettings.Company14;
            model.SortOrder14 = testimonialSliderSettings.SortOrder14;

            model.Picture15Id = testimonialSliderSettings.Picture15Id;
            model.Text15 = testimonialSliderSettings.Text15;
            model.Link15 = testimonialSliderSettings.Link15;
            model.Author15 = testimonialSliderSettings.Author15;
            model.Company15 = testimonialSliderSettings.Company15;
            model.SortOrder15 = testimonialSliderSettings.SortOrder15;

            model.ActiveStoreScopeConfiguration = storeScope;
            if (storeScope > 0)
            {
                model.SectionHeader_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SectionHeader, storeScope);

                model.Picture1Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture1Id, storeScope);
                model.Text1_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text1, storeScope);
                model.Link1_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link1, storeScope);
                model.Author1_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author1, storeScope);
                model.Company1_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company1, storeScope);
                model.SortOrder1_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder1, storeScope);

                model.Picture2Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture2Id, storeScope);
                model.Text2_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text2, storeScope);
                model.Link2_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link2, storeScope);
                model.Author2_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author2, storeScope);
                model.Company2_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company2, storeScope);
                model.SortOrder2_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder2, storeScope);

                model.Picture3Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture3Id, storeScope);
                model.Text3_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text3, storeScope);
                model.Link3_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link3, storeScope);
                model.Author3_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author3, storeScope);
                model.Company3_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company3, storeScope);
                model.SortOrder3_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder3, storeScope);

                model.Picture4Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture4Id, storeScope);
                model.Text4_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text4, storeScope);
                model.Link4_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link4, storeScope);
                model.Author4_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author4, storeScope);
                model.Company4_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company4, storeScope);
                model.SortOrder4_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder4, storeScope);

                model.Picture5Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture5Id, storeScope);
                model.Text5_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text5, storeScope);
                model.Link5_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link5, storeScope);
                model.Author5_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author5, storeScope);
                model.Company5_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company5, storeScope);
                model.SortOrder5_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder5, storeScope);

                model.Picture6Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture6Id, storeScope);
                model.Text6_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text6, storeScope);
                model.Link6_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link6, storeScope);
                model.Author6_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author6, storeScope);
                model.Company6_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company6, storeScope);
                model.SortOrder6_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder6, storeScope);

                model.Picture7Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture7Id, storeScope);
                model.Text7_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text7, storeScope);
                model.Link7_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link7, storeScope);
                model.Author7_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author7, storeScope);
                model.Company7_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company7, storeScope);
                model.SortOrder7_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder7, storeScope);

                model.Picture8Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture8Id, storeScope);
                model.Text8_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text8, storeScope);
                model.Link8_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link8, storeScope);
                model.Author8_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author8, storeScope);
                model.Company8_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company8, storeScope);
                model.SortOrder8_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder8, storeScope);

                model.Picture9Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture9Id, storeScope);
                model.Text9_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text9, storeScope);
                model.Link9_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link9, storeScope);
                model.Author9_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author9, storeScope);
                model.Company9_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company9, storeScope);
                model.SortOrder9_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder9, storeScope);

                model.Picture10Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture10Id, storeScope);
                model.Text10_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text10, storeScope);
                model.Link10_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link10, storeScope);
                model.Author10_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author10, storeScope);
                model.Company10_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company10, storeScope);
                model.SortOrder10_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder10, storeScope);

                model.Picture11Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture11Id, storeScope);
                model.Text11_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text11, storeScope);
                model.Link11_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link11, storeScope);
                model.Author11_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author11, storeScope);
                model.Company11_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company11, storeScope);
                model.SortOrder11_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder11, storeScope);

                model.Picture12Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture12Id, storeScope);
                model.Text12_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text12, storeScope);
                model.Link12_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link12, storeScope);
                model.Author12_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author12, storeScope);
                model.Company12_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company12, storeScope);
                model.SortOrder12_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder12, storeScope);

                model.Picture13Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture13Id, storeScope);
                model.Text13_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text13, storeScope);
                model.Link13_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link13, storeScope);
                model.Author13_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author13, storeScope);
                model.Company13_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company13, storeScope);
                model.SortOrder13_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder13, storeScope);

                model.Picture14Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture14Id, storeScope);
                model.Text14_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text14, storeScope);
                model.Link14_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link14, storeScope);
                model.Author14_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author14, storeScope);
                model.Company14_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company14, storeScope);
                model.SortOrder14_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder14, storeScope);

                model.Picture15Id_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Picture15Id, storeScope);
                model.Text15_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Text15, storeScope);
                model.Link15_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Link15, storeScope);
                model.Author15_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Author15, storeScope);
                model.Company15_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.Company15, storeScope);
                model.SortOrder15_OverrideForStore = _settingService.SettingExists(testimonialSliderSettings, x => x.SortOrder15, storeScope);
            }

            return View("Nop.Plugin.VideotelDigital.TestimonialSlider.Views.VideotelDigitalTestimonialSlider.Configure", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var testimonialSliderSettings = _settingService.LoadSetting<VideotelDigitalTestimonialSliderSettings>(storeScope);

            testimonialSliderSettings.SectionHeader = model.SectionHeader;

            testimonialSliderSettings.Picture1Id = model.Picture1Id;
            testimonialSliderSettings.Text1 = model.Text1;
            testimonialSliderSettings.Link1 = model.Link1;
            testimonialSliderSettings.Author1 = model.Author1;
            testimonialSliderSettings.Company1 = model.Company1;
            testimonialSliderSettings.SortOrder1 = model.SortOrder1;

            testimonialSliderSettings.Picture2Id = model.Picture2Id;
            testimonialSliderSettings.Text2 = model.Text2;
            testimonialSliderSettings.Link2 = model.Link2;
            testimonialSliderSettings.Author2 = model.Author2;
            testimonialSliderSettings.Company2 = model.Company2;
            testimonialSliderSettings.SortOrder2 = model.SortOrder2;

            testimonialSliderSettings.Picture3Id = model.Picture3Id;
            testimonialSliderSettings.Text3 = model.Text3;
            testimonialSliderSettings.Link3 = model.Link3;
            testimonialSliderSettings.Author3 = model.Author3;
            testimonialSliderSettings.Company3 = model.Company3;
            testimonialSliderSettings.SortOrder3 = model.SortOrder3;

            testimonialSliderSettings.Picture4Id = model.Picture4Id;
            testimonialSliderSettings.Text4 = model.Text4;
            testimonialSliderSettings.Link4 = model.Link4;
            testimonialSliderSettings.Author4 = model.Author4;
            testimonialSliderSettings.Company4 = model.Company4;
            testimonialSliderSettings.SortOrder4 = model.SortOrder4;

            testimonialSliderSettings.Picture5Id = model.Picture5Id;
            testimonialSliderSettings.Text5 = model.Text5;
            testimonialSliderSettings.Link5 = model.Link5;
            testimonialSliderSettings.Author5 = model.Author5;
            testimonialSliderSettings.Company5 = model.Company5;
            testimonialSliderSettings.SortOrder5 = model.SortOrder5;

            testimonialSliderSettings.Picture6Id = model.Picture6Id;
            testimonialSliderSettings.Text6 = model.Text6;
            testimonialSliderSettings.Link6 = model.Link6;
            testimonialSliderSettings.Author6 = model.Author6;
            testimonialSliderSettings.Company6 = model.Company6;
            testimonialSliderSettings.SortOrder6 = model.SortOrder6;

            testimonialSliderSettings.Picture7Id = model.Picture7Id;
            testimonialSliderSettings.Text7 = model.Text7;
            testimonialSliderSettings.Link7 = model.Link7;
            testimonialSliderSettings.Author7 = model.Author7;
            testimonialSliderSettings.Company7 = model.Company7;
            testimonialSliderSettings.SortOrder7 = model.SortOrder7;

            testimonialSliderSettings.Picture8Id = model.Picture8Id;
            testimonialSliderSettings.Text8 = model.Text8;
            testimonialSliderSettings.Link8 = model.Link8;
            testimonialSliderSettings.Author8 = model.Author8;
            testimonialSliderSettings.Company8 = model.Company8;
            testimonialSliderSettings.SortOrder8 = model.SortOrder8;

            testimonialSliderSettings.Picture9Id = model.Picture9Id;
            testimonialSliderSettings.Text9 = model.Text9;
            testimonialSliderSettings.Link9 = model.Link9;
            testimonialSliderSettings.Author9 = model.Author9;
            testimonialSliderSettings.Company9 = model.Company9;
            testimonialSliderSettings.SortOrder9 = model.SortOrder9;

            testimonialSliderSettings.Picture10Id = model.Picture10Id;
            testimonialSliderSettings.Text10 = model.Text10;
            testimonialSliderSettings.Link10 = model.Link10;
            testimonialSliderSettings.Author10 = model.Author10;
            testimonialSliderSettings.Company10 = model.Company10;
            testimonialSliderSettings.SortOrder10 = model.SortOrder10;

            testimonialSliderSettings.Picture11Id = model.Picture11Id;
            testimonialSliderSettings.Text11 = model.Text11;
            testimonialSliderSettings.Link11 = model.Link11;
            testimonialSliderSettings.Author11 = model.Author11;
            testimonialSliderSettings.Company11 = model.Company11;
            testimonialSliderSettings.SortOrder11 = model.SortOrder11;

            testimonialSliderSettings.Picture12Id = model.Picture12Id;
            testimonialSliderSettings.Text12 = model.Text12;
            testimonialSliderSettings.Link12 = model.Link12;
            testimonialSliderSettings.Author12 = model.Author12;
            testimonialSliderSettings.Company12 = model.Company12;
            testimonialSliderSettings.SortOrder12 = model.SortOrder12;

            testimonialSliderSettings.Picture13Id = model.Picture13Id;
            testimonialSliderSettings.Text13 = model.Text13;
            testimonialSliderSettings.Link13 = model.Link13;
            testimonialSliderSettings.Author13 = model.Author13;
            testimonialSliderSettings.Company13 = model.Company13;
            testimonialSliderSettings.SortOrder13 = model.SortOrder13;

            testimonialSliderSettings.Picture14Id = model.Picture14Id;
            testimonialSliderSettings.Text14 = model.Text14;
            testimonialSliderSettings.Link14 = model.Link14;
            testimonialSliderSettings.Author14 = model.Author14;
            testimonialSliderSettings.Company14 = model.Company14;
            testimonialSliderSettings.SortOrder14 = model.SortOrder14;

            testimonialSliderSettings.Picture15Id = model.Picture15Id;
            testimonialSliderSettings.Text15 = model.Text15;
            testimonialSliderSettings.Link15 = model.Link15;
            testimonialSliderSettings.Author15 = model.Author15;
            testimonialSliderSettings.Company15 = model.Company15;
            testimonialSliderSettings.SortOrder15 = model.SortOrder15;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */

            if (model.SectionHeader_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SectionHeader, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SectionHeader, storeScope);


            if (model.Picture1Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture1Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture1Id, storeScope);
            
            if (model.Text1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text1, storeScope);
            
            if (model.Link1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link1, storeScope);

            if (model.Author1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author1, storeScope);

            if (model.Company1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company1, storeScope);

            if (model.SortOrder1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder1, storeScope);
            
            if (model.Picture2Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture2Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture2Id, storeScope);
            
            if (model.Text2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text2, storeScope);
            
            if (model.Link2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link2, storeScope);

            if (model.Author2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author2, storeScope);

            if (model.Company2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company2, storeScope);

            if (model.SortOrder2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder2, storeScope);


            if (model.Picture3Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture3Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture3Id, storeScope);
            
            if (model.Text3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text3, storeScope);
            
            if (model.Link3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link3, storeScope);

            if (model.Author3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author3, storeScope);

            if (model.Company3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company3, storeScope);

            if (model.SortOrder3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder3, storeScope);



            if (model.Picture4Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture4Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture4Id, storeScope);
            
            if (model.Text4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text4, storeScope);

            if (model.Link4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link4, storeScope);

            if (model.Author4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author4, storeScope);

            if (model.Company4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company4, storeScope);

            if (model.SortOrder4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder4, storeScope);


            if (model.Picture5Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture5Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture5Id, storeScope);

            if (model.Text5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text5, storeScope);

            if (model.Link5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link5, storeScope);

            if (model.Author5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author5, storeScope);

            if (model.Company5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company5, storeScope);

            if (model.SortOrder5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder5, storeScope);




            if (model.Picture6Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture6Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture6Id, storeScope);

            if (model.Text6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text6, storeScope);

            if (model.Link6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link6, storeScope);

            if (model.Author6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author6, storeScope);

            if (model.Company6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company6, storeScope);

            if (model.SortOrder6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder6, storeScope);




            if (model.Picture7Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture7Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture7Id, storeScope);

            if (model.Text7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text7, storeScope);

            if (model.Link7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link7, storeScope);

            if (model.Author7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author7, storeScope);

            if (model.Company7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company7, storeScope);

            if (model.SortOrder7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder7, storeScope);



            if (model.Picture8Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture8Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture8Id, storeScope);

            if (model.Text8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text8, storeScope);

            if (model.Link8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link8, storeScope);

            if (model.Author8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author8, storeScope);

            if (model.Company8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company8, storeScope);

            if (model.SortOrder8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder8, storeScope);




            if (model.Picture9Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture9Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture9Id, storeScope);

            if (model.Text9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text9, storeScope);

            if (model.Link9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link9, storeScope);

            if (model.Author9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author9, storeScope);

            if (model.Company9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company9, storeScope);

            if (model.SortOrder9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder9, storeScope);



            if (model.Picture10Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture10Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture10Id, storeScope);

            if (model.Text10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text10, storeScope);

            if (model.Link10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link10, storeScope);

            if (model.Author10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author10, storeScope);

            if (model.Company10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company10, storeScope);

            if (model.SortOrder10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder10, storeScope);




            if (model.Picture11Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture11Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture11Id, storeScope);

            if (model.Text11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text11, storeScope);

            if (model.Link11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link11, storeScope);

            if (model.Author11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author11, storeScope);

            if (model.Company11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company11, storeScope);

            if (model.SortOrder11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder11, storeScope);



            if (model.Picture12Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture12Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture12Id, storeScope);

            if (model.Text12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text12, storeScope);

            if (model.Link12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link12, storeScope);

            if (model.Author12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author12, storeScope);

            if (model.Company12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company12, storeScope);

            if (model.SortOrder12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder12, storeScope);



            if (model.Picture13Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture13Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture13Id, storeScope);

            if (model.Text13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text13, storeScope);

            if (model.Link13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link13, storeScope);

            if (model.Author13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author13, storeScope);

            if (model.Company13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company13, storeScope);

            if (model.SortOrder13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder13, storeScope);



            if (model.Picture14Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture14Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture14Id, storeScope);

            if (model.Text14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text14, storeScope);

            if (model.Link14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link14, storeScope);

            if (model.Author14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author14, storeScope);

            if (model.Company14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company14, storeScope);

            if (model.SortOrder14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder14, storeScope);



            if (model.Picture15Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Picture15Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Picture15Id, storeScope);

            if (model.Text15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Text15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Text15, storeScope);

            if (model.Link15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Link15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Link15, storeScope);

            if (model.Author15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Author15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Author15, storeScope);

            if (model.Company15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.Company15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.Company15, storeScope);

            if (model.SortOrder15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(testimonialSliderSettings, x => x.SortOrder15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(testimonialSliderSettings, x => x.SortOrder15, storeScope);

            //now clear settings cache
            _settingService.ClearCache();
            
            return Configure();
        }

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone)
        {
            var testimonialSliderSettings = _settingService.LoadSetting<VideotelDigitalTestimonialSliderSettings>(_storeContext.CurrentStore.Id);

            //IList<TestimonialModel> list = new List<TestimonialModel>();
            //IEnumerable<TestimonialModel> sortedEnum = list.OrderBy(f => f.SortOrder);
            //IList<TestimonialModel> sortedList = sortedEnum.ToList();

            //TestimonialListModels x = new TestimonialListModels();
            //x.Testimonials = sortedList;

            var testimonials = new List<TestimonialModel>();
            var testimonial = new TestimonialModel();

            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture1Id);
            testimonial.Text = testimonialSliderSettings.Text1;
            testimonial.Link = testimonialSliderSettings.Link1;
            testimonial.Author = testimonialSliderSettings.Author1;
            testimonial.Company = testimonialSliderSettings.Company1;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder1;
            testimonials.Add(testimonial);


            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture2Id);
            testimonial.Text = testimonialSliderSettings.Text2;
            testimonial.Link = testimonialSliderSettings.Link2;
            testimonial.Author = testimonialSliderSettings.Author2;
            testimonial.Company = testimonialSliderSettings.Company2;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder2;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture3Id);
            testimonial.Text = testimonialSliderSettings.Text3;
            testimonial.Link = testimonialSliderSettings.Link3;
            testimonial.Author = testimonialSliderSettings.Author3;
            testimonial.Company = testimonialSliderSettings.Company3;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder3;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture4Id);
            testimonial.Text = testimonialSliderSettings.Text4;
            testimonial.Link = testimonialSliderSettings.Link4;
            testimonial.Author = testimonialSliderSettings.Author4;
            testimonial.Company = testimonialSliderSettings.Company4;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder4;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture5Id);
            testimonial.Text = testimonialSliderSettings.Text5;
            testimonial.Link = testimonialSliderSettings.Link5;
            testimonial.Author = testimonialSliderSettings.Author5;
            testimonial.Company = testimonialSliderSettings.Company5;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder5;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture6Id);
            testimonial.Text = testimonialSliderSettings.Text6;
            testimonial.Link = testimonialSliderSettings.Link6;
            testimonial.Author = testimonialSliderSettings.Author6;
            testimonial.Company = testimonialSliderSettings.Company6;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder6;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture7Id);
            testimonial.Text = testimonialSliderSettings.Text7;
            testimonial.Link = testimonialSliderSettings.Link7;
            testimonial.Author = testimonialSliderSettings.Author7;
            testimonial.Company = testimonialSliderSettings.Company7;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder7;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture8Id);
            testimonial.Text = testimonialSliderSettings.Text8;
            testimonial.Link = testimonialSliderSettings.Link8;
            testimonial.Author = testimonialSliderSettings.Author8;
            testimonial.Company = testimonialSliderSettings.Company8;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder8;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture9Id);
            testimonial.Text = testimonialSliderSettings.Text9;
            testimonial.Link = testimonialSliderSettings.Link9;
            testimonial.Author = testimonialSliderSettings.Author9;
            testimonial.Company = testimonialSliderSettings.Company9;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder9;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture10Id);
            testimonial.Text = testimonialSliderSettings.Text10;
            testimonial.Link = testimonialSliderSettings.Link10;
            testimonial.Author = testimonialSliderSettings.Author10;
            testimonial.Company = testimonialSliderSettings.Company10;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder10;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture11Id);
            testimonial.Text = testimonialSliderSettings.Text11;
            testimonial.Link = testimonialSliderSettings.Link11;
            testimonial.Author = testimonialSliderSettings.Author11;
            testimonial.Company = testimonialSliderSettings.Company11;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder11;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture12Id);
            testimonial.Text = testimonialSliderSettings.Text12;
            testimonial.Link = testimonialSliderSettings.Link12;
            testimonial.Author = testimonialSliderSettings.Author12;
            testimonial.Company = testimonialSliderSettings.Company12;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder12;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture13Id);
            testimonial.Text = testimonialSliderSettings.Text13;
            testimonial.Link = testimonialSliderSettings.Link13;
            testimonial.Author = testimonialSliderSettings.Author13;
            testimonial.Company = testimonialSliderSettings.Company13;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder13;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture14Id);
            testimonial.Text = testimonialSliderSettings.Text14;
            testimonial.Link = testimonialSliderSettings.Link14;
            testimonial.Author = testimonialSliderSettings.Author14;
            testimonial.Company = testimonialSliderSettings.Company14;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder14;
            testimonials.Add(testimonial);

            testimonial = new TestimonialModel();
            testimonial.PictureUrl = GetPictureUrl(testimonialSliderSettings.Picture15Id);
            testimonial.Text = testimonialSliderSettings.Text15;
            testimonial.Link = testimonialSliderSettings.Link15;
            testimonial.Author = testimonialSliderSettings.Author15;
            testimonial.Company = testimonialSliderSettings.Company15;
            testimonial.SortOrder = testimonialSliderSettings.SortOrder15;
            testimonials.Add(testimonial);

            List<TestimonialModel> sortedTestimonialList = testimonials.OrderBy(o => o.SortOrder).ToList();

            TestimonialListModels model = new TestimonialListModels();
            model.Testimonials = sortedTestimonialList;
            model.SectionHeader = testimonialSliderSettings.SectionHeader;


            //var model = new PublicInfoModel();

            //model.SectionHeader = testimonialSliderSettings.SectionHeader;

            //model.Picture1Url = GetPictureUrl(testimonialSliderSettings.Picture1Id);
            //model.Text1 = testimonialSliderSettings.Text1;
            //model.Link1 = testimonialSliderSettings.Link1;
            //model.Author1 = testimonialSliderSettings.Author1;
            //model.Company1 = testimonialSliderSettings.Company1;
            //model.SortOrder1 = testimonialSliderSettings.SortOrder1;

            //model.Picture2Url = GetPictureUrl(testimonialSliderSettings.Picture2Id);
            //model.Text2 = testimonialSliderSettings.Text2;
            //model.Link2 = testimonialSliderSettings.Link2;
            //model.Author2 = testimonialSliderSettings.Author2;
            //model.Company2 = testimonialSliderSettings.Company2;
            //model.SortOrder2 = testimonialSliderSettings.SortOrder2;

            //model.Picture3Url = GetPictureUrl(testimonialSliderSettings.Picture3Id);
            //model.Text3 = testimonialSliderSettings.Text3;
            //model.Link3 = testimonialSliderSettings.Link3;
            //model.Author3 = testimonialSliderSettings.Author3;
            //model.Company3 = testimonialSliderSettings.Company3;
            //model.SortOrder3 = testimonialSliderSettings.SortOrder3;

            //model.Picture4Url = GetPictureUrl(testimonialSliderSettings.Picture4Id);
            //model.Text4 = testimonialSliderSettings.Text4;
            //model.Link4 = testimonialSliderSettings.Link4;
            //model.Author4 = testimonialSliderSettings.Author4;
            //model.Company4 = testimonialSliderSettings.Company4;
            //model.SortOrder4 = testimonialSliderSettings.SortOrder4;

            //model.Picture5Url = GetPictureUrl(testimonialSliderSettings.Picture5Id);
            //model.Text5 = testimonialSliderSettings.Text5;
            //model.Link5 = testimonialSliderSettings.Link5;
            //model.Author5 = testimonialSliderSettings.Author5;
            //model.Company5 = testimonialSliderSettings.Company5;
            //model.SortOrder5 = testimonialSliderSettings.SortOrder5;

            //model.Picture6Url = GetPictureUrl(testimonialSliderSettings.Picture6Id);
            //model.Text6 = testimonialSliderSettings.Text6;
            //model.Link6 = testimonialSliderSettings.Link6;
            //model.Author6 = testimonialSliderSettings.Author6;
            //model.Company6 = testimonialSliderSettings.Company6;
            //model.SortOrder6 = testimonialSliderSettings.SortOrder6;

            //model.Picture7Url = GetPictureUrl(testimonialSliderSettings.Picture7Id);
            //model.Text7 = testimonialSliderSettings.Text7;
            //model.Link7 = testimonialSliderSettings.Link7;
            //model.Author7 = testimonialSliderSettings.Author7;
            //model.Company7 = testimonialSliderSettings.Company7;
            //model.SortOrder7 = testimonialSliderSettings.SortOrder7;

            //model.Picture8Url = GetPictureUrl(testimonialSliderSettings.Picture8Id);
            //model.Text8 = testimonialSliderSettings.Text8;
            //model.Link8 = testimonialSliderSettings.Link8;
            //model.Author8 = testimonialSliderSettings.Author8;
            //model.Company8 = testimonialSliderSettings.Company8;
            //model.SortOrder8 = testimonialSliderSettings.SortOrder8;

            //model.Picture9Url = GetPictureUrl(testimonialSliderSettings.Picture9Id);
            //model.Text9 = testimonialSliderSettings.Text9;
            //model.Link9 = testimonialSliderSettings.Link9;
            //model.Author9 = testimonialSliderSettings.Author9;
            //model.Company9 = testimonialSliderSettings.Company9;
            //model.SortOrder9 = testimonialSliderSettings.SortOrder9;

            //model.Picture10Url = GetPictureUrl(testimonialSliderSettings.Picture10Id);
            //model.Text10 = testimonialSliderSettings.Text10;
            //model.Link10 = testimonialSliderSettings.Link10;
            //model.Author10 = testimonialSliderSettings.Author10;
            //model.Company10 = testimonialSliderSettings.Company10;
            //model.SortOrder10 = testimonialSliderSettings.SortOrder10;

            //model.Picture11Url = GetPictureUrl(testimonialSliderSettings.Picture11Id);
            //model.Text11 = testimonialSliderSettings.Text11;
            //model.Link11 = testimonialSliderSettings.Link11;
            //model.Author11 = testimonialSliderSettings.Author11;
            //model.Company11 = testimonialSliderSettings.Company11;
            //model.SortOrder11 = testimonialSliderSettings.SortOrder11;

            //model.Picture12Url = GetPictureUrl(testimonialSliderSettings.Picture12Id);
            //model.Text12 = testimonialSliderSettings.Text12;
            //model.Link12 = testimonialSliderSettings.Link12;
            //model.Author12 = testimonialSliderSettings.Author12;
            //model.Company12 = testimonialSliderSettings.Company12;
            //model.SortOrder12 = testimonialSliderSettings.SortOrder12;

            //model.Picture13Url = GetPictureUrl(testimonialSliderSettings.Picture13Id);
            //model.Text13 = testimonialSliderSettings.Text13;
            //model.Link13 = testimonialSliderSettings.Link13;
            //model.Author13 = testimonialSliderSettings.Author13;
            //model.Company13 = testimonialSliderSettings.Company13;
            //model.SortOrder13 = testimonialSliderSettings.SortOrder13;

            //model.Picture14Url = GetPictureUrl(testimonialSliderSettings.Picture14Id);
            //model.Text14 = testimonialSliderSettings.Text14;
            //model.Link14 = testimonialSliderSettings.Link14;
            //model.Author14 = testimonialSliderSettings.Author14;
            //model.Company14 = testimonialSliderSettings.Company14;
            //model.SortOrder14 = testimonialSliderSettings.SortOrder14;

            //model.Picture15Url = GetPictureUrl(testimonialSliderSettings.Picture15Id);
            //model.Text15 = testimonialSliderSettings.Text15;
            //model.Link15 = testimonialSliderSettings.Link15;
            //model.Author15 = testimonialSliderSettings.Author15;
            //model.Company15 = testimonialSliderSettings.Company15;
            //model.SortOrder15 = testimonialSliderSettings.SortOrder15;

            //if (string.IsNullOrEmpty(model.Picture1Url) && string.IsNullOrEmpty(model.Picture2Url) &&
            //    string.IsNullOrEmpty(model.Picture3Url) && string.IsNullOrEmpty(model.Picture4Url) &&
            //    string.IsNullOrEmpty(model.Picture5Url))
            //    //no pictures uploaded
            //    return Content("");

            

            return View("Nop.Plugin.VideotelDigital.TestimonialSlider.Views.VideotelDigitalTestimonialSlider.PublicInfo", model);
        }
    }
}
