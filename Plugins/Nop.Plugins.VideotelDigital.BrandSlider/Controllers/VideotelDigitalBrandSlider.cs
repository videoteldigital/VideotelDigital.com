using System.Web.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.VideotelDigital.BrandSlider.Infrastructure.Cache;
using Nop.Plugin.VideotelDigital.BrandSlider.Models;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Plugin.VideotelDigital.BrandSlider.Controllers
{
    public class VideotelDigitalBrandSliderController : BasePluginController
    {
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly IStoreService _storeService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly ICacheManager _cacheManager;

        public VideotelDigitalBrandSliderController(IWorkContext workContext,
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
            var brandSliderSettings = _settingService.LoadSetting<VideotelDigitalBrandSliderSettings>(storeScope);
            var model = new ConfigurationModel();

            //IList<BrandModel> list = new List<BrandModel>();
            //IEnumerable<BrandModel> sortedEnum = list.OrderBy(f => f.SortOrder);
            //IList<BrandModel> sortedList = sortedEnum.ToList();

            //brandListModels x = new brandListModels();
            //x.brands = sortedList;


            model.SectionHeader = brandSliderSettings.SectionHeader;
            model.Picture1Id = brandSliderSettings.Picture1Id;
            model.Link1 = brandSliderSettings.Link1;
            model.Company1 = brandSliderSettings.Company1;
            model.SortOrder1 = brandSliderSettings.SortOrder1;

            model.Picture2Id = brandSliderSettings.Picture2Id;
            model.Link2 = brandSliderSettings.Link2;
            model.Company2 = brandSliderSettings.Company2;
            model.SortOrder2 = brandSliderSettings.SortOrder2;

            model.Picture3Id = brandSliderSettings.Picture3Id;
            model.Link3 = brandSliderSettings.Link3;
            model.Company3 = brandSliderSettings.Company3;
            model.SortOrder3 = brandSliderSettings.SortOrder3;

            model.Picture4Id = brandSliderSettings.Picture4Id;
            model.Link4 = brandSliderSettings.Link4;
            model.Company4 = brandSliderSettings.Company4;
            model.SortOrder4 = brandSliderSettings.SortOrder4;

            model.Picture5Id = brandSliderSettings.Picture5Id;
            model.Link5 = brandSliderSettings.Link5;
            model.Company5 = brandSliderSettings.Company5;
            model.SortOrder5 = brandSliderSettings.SortOrder5;

            model.Picture6Id = brandSliderSettings.Picture6Id;
            model.Link6 = brandSliderSettings.Link6;
            model.Company6 = brandSliderSettings.Company6;
            model.SortOrder6 = brandSliderSettings.SortOrder6;

            model.Picture7Id = brandSliderSettings.Picture7Id;
            model.Link7 = brandSliderSettings.Link7;
            model.Company7 = brandSliderSettings.Company7;
            model.SortOrder7 = brandSliderSettings.SortOrder7;

            model.Picture8Id = brandSliderSettings.Picture8Id;
            model.Link8 = brandSliderSettings.Link8;
            model.Company8 = brandSliderSettings.Company8;
            model.SortOrder8 = brandSliderSettings.SortOrder8;

            model.Picture9Id = brandSliderSettings.Picture9Id;
            model.Link9 = brandSliderSettings.Link9;
            model.Company9 = brandSliderSettings.Company9;
            model.SortOrder9 = brandSliderSettings.SortOrder9;

            model.Picture10Id = brandSliderSettings.Picture10Id;
            model.Link10 = brandSliderSettings.Link10;
            model.Company10 = brandSliderSettings.Company10;
            model.SortOrder10 = brandSliderSettings.SortOrder10;

            model.Picture11Id = brandSliderSettings.Picture11Id;
            model.Link11 = brandSliderSettings.Link11;
            model.Company11 = brandSliderSettings.Company11;
            model.SortOrder11 = brandSliderSettings.SortOrder11;

            model.Picture12Id = brandSliderSettings.Picture12Id;
            model.Link12 = brandSliderSettings.Link12;
            model.Company12 = brandSliderSettings.Company12;
            model.SortOrder12 = brandSliderSettings.SortOrder12;

            model.Picture13Id = brandSliderSettings.Picture13Id;
            model.Link13 = brandSliderSettings.Link13;
            model.Company13 = brandSliderSettings.Company13;
            model.SortOrder13 = brandSliderSettings.SortOrder13;

            model.Picture14Id = brandSliderSettings.Picture14Id;
            model.Link14 = brandSliderSettings.Link14;
            model.Company14 = brandSliderSettings.Company14;
            model.SortOrder14 = brandSliderSettings.SortOrder14;

            model.Picture15Id = brandSliderSettings.Picture15Id;
            model.Link15 = brandSliderSettings.Link15;
            model.Company15 = brandSliderSettings.Company15;
            model.SortOrder15 = brandSliderSettings.SortOrder15;

            model.ActiveStoreScopeConfiguration = storeScope;
            if (storeScope > 0)
            {
                model.SectionHeader_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SectionHeader, storeScope);

                model.Picture1Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture1Id, storeScope);
                model.Link1_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link1, storeScope);
                model.Company1_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company1, storeScope);
                model.SortOrder1_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder1, storeScope);

                model.Picture2Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture2Id, storeScope);
                model.Link2_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link2, storeScope);
                model.Company2_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company2, storeScope);
                model.SortOrder2_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder2, storeScope);

                model.Picture3Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture3Id, storeScope);
                model.Link3_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link3, storeScope);
                model.Company3_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company3, storeScope);
                model.SortOrder3_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder3, storeScope);

                model.Picture4Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture4Id, storeScope);
                model.Link4_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link4, storeScope);
                model.Company4_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company4, storeScope);
                model.SortOrder4_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder4, storeScope);

                model.Picture5Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture5Id, storeScope);
                model.Link5_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link5, storeScope);
                model.Company5_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company5, storeScope);
                model.SortOrder5_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder5, storeScope);

                model.Picture6Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture6Id, storeScope);
                model.Link6_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link6, storeScope);
                model.Company6_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company6, storeScope);
                model.SortOrder6_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder6, storeScope);

                model.Picture7Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture7Id, storeScope);
                model.Link7_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link7, storeScope);
                model.Company7_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company7, storeScope);
                model.SortOrder7_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder7, storeScope);

                model.Picture8Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture8Id, storeScope);
                model.Link8_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link8, storeScope);
                model.Company8_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company8, storeScope);
                model.SortOrder8_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder8, storeScope);

                model.Picture9Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture9Id, storeScope);
                model.Link9_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link9, storeScope);
                model.Company9_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company9, storeScope);
                model.SortOrder9_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder9, storeScope);

                model.Picture10Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture10Id, storeScope);
                model.Link10_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link10, storeScope);
                model.Company10_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company10, storeScope);
                model.SortOrder10_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder10, storeScope);

                model.Picture11Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture11Id, storeScope);
                model.Link11_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link11, storeScope);
                model.Company11_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company11, storeScope);
                model.SortOrder11_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder11, storeScope);

                model.Picture12Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture12Id, storeScope);
                model.Link12_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link12, storeScope);
                model.Company12_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company12, storeScope);
                model.SortOrder12_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder12, storeScope);

                model.Picture13Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture13Id, storeScope);
                model.Link13_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link13, storeScope);
                model.Company13_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company13, storeScope);
                model.SortOrder13_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder13, storeScope);

                model.Picture14Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture14Id, storeScope);
                model.Link14_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link14, storeScope);
                model.Company14_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company14, storeScope);
                model.SortOrder14_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder14, storeScope);

                model.Picture15Id_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Picture15Id, storeScope);
                model.Link15_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Link15, storeScope);
                model.Company15_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.Company15, storeScope);
                model.SortOrder15_OverrideForStore = _settingService.SettingExists(brandSliderSettings, x => x.SortOrder15, storeScope);
            }

            return View("Nop.Plugin.VideotelDigital.BrandSlider.Views.VideotelDigitalBrandSlider.Configure", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var brandSliderSettings = _settingService.LoadSetting<VideotelDigitalBrandSliderSettings>(storeScope);

            brandSliderSettings.SectionHeader = model.SectionHeader;

            brandSliderSettings.Picture1Id = model.Picture1Id;
            brandSliderSettings.Link1 = model.Link1;
            brandSliderSettings.Company1 = model.Company1;
            brandSliderSettings.SortOrder1 = model.SortOrder1;

            brandSliderSettings.Picture2Id = model.Picture2Id;
            brandSliderSettings.Link2 = model.Link2;
            brandSliderSettings.Company2 = model.Company2;
            brandSliderSettings.SortOrder2 = model.SortOrder2;

            brandSliderSettings.Picture3Id = model.Picture3Id;
            brandSliderSettings.Link3 = model.Link3;
            brandSliderSettings.Company3 = model.Company3;
            brandSliderSettings.SortOrder3 = model.SortOrder3;

            brandSliderSettings.Picture4Id = model.Picture4Id;
            brandSliderSettings.Link4 = model.Link4;
            brandSliderSettings.Company4 = model.Company4;
            brandSliderSettings.SortOrder4 = model.SortOrder4;

            brandSliderSettings.Picture5Id = model.Picture5Id;
            brandSliderSettings.Link5 = model.Link5;
            brandSliderSettings.Company5 = model.Company5;
            brandSliderSettings.SortOrder5 = model.SortOrder5;

            brandSliderSettings.Picture6Id = model.Picture6Id;
            brandSliderSettings.Link6 = model.Link6;
            brandSliderSettings.Company6 = model.Company6;
            brandSliderSettings.SortOrder6 = model.SortOrder6;

            brandSliderSettings.Picture7Id = model.Picture7Id;
            brandSliderSettings.Link7 = model.Link7;
            brandSliderSettings.Company7 = model.Company7;
            brandSliderSettings.SortOrder7 = model.SortOrder7;

            brandSliderSettings.Picture8Id = model.Picture8Id;
            brandSliderSettings.Link8 = model.Link8;
            brandSliderSettings.Company8 = model.Company8;
            brandSliderSettings.SortOrder8 = model.SortOrder8;

            brandSliderSettings.Picture9Id = model.Picture9Id;
            brandSliderSettings.Link9 = model.Link9;
            brandSliderSettings.Company9 = model.Company9;
            brandSliderSettings.SortOrder9 = model.SortOrder9;

            brandSliderSettings.Picture10Id = model.Picture10Id;
            brandSliderSettings.Link10 = model.Link10;
            brandSliderSettings.Company10 = model.Company10;
            brandSliderSettings.SortOrder10 = model.SortOrder10;

            brandSliderSettings.Picture11Id = model.Picture11Id;
            brandSliderSettings.Link11 = model.Link11;
            brandSliderSettings.Company11 = model.Company11;
            brandSliderSettings.SortOrder11 = model.SortOrder11;

            brandSliderSettings.Picture12Id = model.Picture12Id;
            brandSliderSettings.Link12 = model.Link12;
            brandSliderSettings.Company12 = model.Company12;
            brandSliderSettings.SortOrder12 = model.SortOrder12;

            brandSliderSettings.Picture13Id = model.Picture13Id;
            brandSliderSettings.Link13 = model.Link13;
            brandSliderSettings.Company13 = model.Company13;
            brandSliderSettings.SortOrder13 = model.SortOrder13;

            brandSliderSettings.Picture14Id = model.Picture14Id;
            brandSliderSettings.Link14 = model.Link14;
            brandSliderSettings.Company14 = model.Company14;
            brandSliderSettings.SortOrder14 = model.SortOrder14;

            brandSliderSettings.Picture15Id = model.Picture15Id;
            brandSliderSettings.Link15 = model.Link15;
            brandSliderSettings.Company15 = model.Company15;
            brandSliderSettings.SortOrder15 = model.SortOrder15;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */

            if (model.SectionHeader_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SectionHeader, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SectionHeader, storeScope);


            if (model.Picture1Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture1Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture1Id, storeScope);
            
            if (model.Link1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link1, storeScope);

            if (model.Company1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company1, storeScope);

            if (model.SortOrder1_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder1, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder1, storeScope);
            
            if (model.Picture2Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture2Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture2Id, storeScope);
            
            if (model.Link2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link2, storeScope);

            if (model.Company2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company2, storeScope);

            if (model.SortOrder2_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder2, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder2, storeScope);


            if (model.Picture3Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture3Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture3Id, storeScope);
            
            if (model.Link3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link3, storeScope);

            if (model.Company3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company3, storeScope);

            if (model.SortOrder3_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder3, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder3, storeScope);



            if (model.Picture4Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture4Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture4Id, storeScope);
            
            if (model.Link4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link4, storeScope);

            if (model.Company4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company4, storeScope);

            if (model.SortOrder4_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder4, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder4, storeScope);


            if (model.Picture5Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture5Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture5Id, storeScope);

            if (model.Link5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link5, storeScope);

            if (model.Company5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company5, storeScope);

            if (model.SortOrder5_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder5, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder5, storeScope);




            if (model.Picture6Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture6Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture6Id, storeScope);

            if (model.Link6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link6, storeScope);

            if (model.Company6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company6, storeScope);

            if (model.SortOrder6_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder6, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder6, storeScope);




            if (model.Picture7Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture7Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture7Id, storeScope);

            if (model.Link7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link7, storeScope);

            if (model.Company7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company7, storeScope);

            if (model.SortOrder7_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder7, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder7, storeScope);



            if (model.Picture8Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture8Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture8Id, storeScope);

            if (model.Link8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link8, storeScope);

            if (model.Company8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company8, storeScope);

            if (model.SortOrder8_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder8, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder8, storeScope);




            if (model.Picture9Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture9Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture9Id, storeScope);

            if (model.Link9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link9, storeScope);

            if (model.Company9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company9, storeScope);

            if (model.SortOrder9_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder9, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder9, storeScope);



            if (model.Picture10Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture10Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture10Id, storeScope);

            if (model.Link10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link10, storeScope);

            if (model.Company10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company10, storeScope);

            if (model.SortOrder10_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder10, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder10, storeScope);




            if (model.Picture11Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture11Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture11Id, storeScope);

            if (model.Link11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link11, storeScope);

            if (model.Company11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company11, storeScope);

            if (model.SortOrder11_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder11, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder11, storeScope);



            if (model.Picture12Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture12Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture12Id, storeScope);

            if (model.Link12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link12, storeScope);

            if (model.Company12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company12, storeScope);

            if (model.SortOrder12_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder12, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder12, storeScope);



            if (model.Picture13Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture13Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture13Id, storeScope);

            if (model.Link13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link13, storeScope);

            if (model.Company13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company13, storeScope);

            if (model.SortOrder13_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder13, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder13, storeScope);



            if (model.Picture14Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture14Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture14Id, storeScope);

            if (model.Link14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link14, storeScope);

            if (model.Company14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company14, storeScope);

            if (model.SortOrder14_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder14, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder14, storeScope);



            if (model.Picture15Id_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Picture15Id, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Picture15Id, storeScope);

            if (model.Link15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Link15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Link15, storeScope);

            if (model.Company15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.Company15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.Company15, storeScope);

            if (model.SortOrder15_OverrideForStore || storeScope == 0)
                _settingService.SaveSetting(brandSliderSettings, x => x.SortOrder15, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(brandSliderSettings, x => x.SortOrder15, storeScope);

            //now clear settings cache
            _settingService.ClearCache();
            
            return Configure();
        }

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone)
        {
            var brandSliderSettings = _settingService.LoadSetting<VideotelDigitalBrandSliderSettings>(_storeContext.CurrentStore.Id);
            var brands = new List<BrandModel>();
            var brand = new BrandModel();

            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture1Id);
            brand.Link = brandSliderSettings.Link1;
            brand.Company = brandSliderSettings.Company1;
            brand.SortOrder = brandSliderSettings.SortOrder1;
            brands.Add(brand);


            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture2Id);
            brand.Link = brandSliderSettings.Link2;
            brand.Company = brandSliderSettings.Company2;
            brand.SortOrder = brandSliderSettings.SortOrder2;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture3Id);
            brand.Link = brandSliderSettings.Link3;
            brand.Company = brandSliderSettings.Company3;
            brand.SortOrder = brandSliderSettings.SortOrder3;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture4Id);
            brand.Link = brandSliderSettings.Link4;
            brand.Company = brandSliderSettings.Company4;
            brand.SortOrder = brandSliderSettings.SortOrder4;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture5Id);
            brand.Link = brandSliderSettings.Link5;
            brand.Company = brandSliderSettings.Company5;
            brand.SortOrder = brandSliderSettings.SortOrder5;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture6Id);
            brand.Link = brandSliderSettings.Link6;
            brand.Company = brandSliderSettings.Company6;
            brand.SortOrder = brandSliderSettings.SortOrder6;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture7Id);
            brand.Link = brandSliderSettings.Link7;
            brand.Company = brandSliderSettings.Company7;
            brand.SortOrder = brandSliderSettings.SortOrder7;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture8Id);
            brand.Link = brandSliderSettings.Link8;
            brand.Company = brandSliderSettings.Company8;
            brand.SortOrder = brandSliderSettings.SortOrder8;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture9Id);
            brand.Link = brandSliderSettings.Link9;
            brand.Company = brandSliderSettings.Company9;
            brand.SortOrder = brandSliderSettings.SortOrder9;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture10Id);
            brand.Link = brandSliderSettings.Link10;
            brand.Company = brandSliderSettings.Company10;
            brand.SortOrder = brandSliderSettings.SortOrder10;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture11Id);
            brand.Link = brandSliderSettings.Link11;
            brand.Company = brandSliderSettings.Company11;
            brand.SortOrder = brandSliderSettings.SortOrder11;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture12Id);
            brand.Link = brandSliderSettings.Link12;
            brand.Company = brandSliderSettings.Company12;
            brand.SortOrder = brandSliderSettings.SortOrder12;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture13Id);
            brand.Link = brandSliderSettings.Link13;
            brand.Company = brandSliderSettings.Company13;
            brand.SortOrder = brandSliderSettings.SortOrder13;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture14Id);
            brand.Link = brandSliderSettings.Link14;
            brand.Company = brandSliderSettings.Company14;
            brand.SortOrder = brandSliderSettings.SortOrder14;
            brands.Add(brand);

            brand = new BrandModel();
            brand.PictureUrl = GetPictureUrl(brandSliderSettings.Picture15Id);
            brand.Link = brandSliderSettings.Link15;
            brand.Company = brandSliderSettings.Company15;
            brand.SortOrder = brandSliderSettings.SortOrder15;
            brands.Add(brand);

            List<BrandModel> sortedbrandList = brands.OrderBy(o => o.SortOrder).ToList();

            BrandListModels model = new BrandListModels();
            model.Brands = sortedbrandList;
            model.SectionHeader = brandSliderSettings.SectionHeader;
            

            return View("Nop.Plugin.VideotelDigital.BrandSlider.Views.VideotelDigitalBrandSlider.PublicInfo", model);
        }
    }
}
