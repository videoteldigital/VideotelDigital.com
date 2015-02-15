using Nop.Web.Framework.Mvc;
using System.Collections.Generic;
namespace Nop.Plugin.VideotelDigital.BrandSlider.Models
{
    public class BrandListModels : BaseNopModel
    {

        public string SectionHeader { get; set; }
        public IList<BrandModel> Brands { get; set; }
    
        

     }
    public class BrandModel : BaseNopModel
    {
        public string PictureUrl { get; set; }
        public string Link { get; set; }
        public string Company { get; set; }
        public int SortOrder { get; set; }
    }

    public class PublicInfoModel : BaseNopModel
    {
        public string SectionHeader { get; set; }

        public string Picture1Url { get; set; }
        public string Link1 { get; set; }
        public string Company1 { get; set; }
        public int SortOrder1 { get; set; }

        public string Picture2Url { get; set; }
        public string Link2 { get; set; }
        public string Company2 { get; set; }
        public int SortOrder2 { get; set; }

        public string Picture3Url { get; set; }
        public string Link3 { get; set; }
        public string Company3 { get; set; }
        public int SortOrder3 { get; set; }
        public string Picture4Url { get; set; }
        public string Link4 { get; set; }
        public string Company4 { get; set; }
        public int SortOrder4 { get; set; }
        public string Picture5Url { get; set; }
        public string Link5 { get; set; }
        public string Company5 { get; set; }
        public int SortOrder5 { get; set; }
        public string Picture6Url { get; set; }
        public string Link6 { get; set; }
        public string Company6 { get; set; }
        public int SortOrder6 { get; set; }
        public string Picture7Url { get; set; }
        public string Link7 { get; set; }
        public string Company7 { get; set; }
        public int SortOrder7 { get; set; }
        public string Picture8Url { get; set; }
        public string Link8 { get; set; }
        public string Company8 { get; set; }
        public int SortOrder8 { get; set; }
        public string Picture9Url { get; set; }
        public string Link9 { get; set; }
        public string Company9 { get; set; }
        public int SortOrder9 { get; set; }
        public string Picture10Url { get; set; }
        public string Link10 { get; set; }
        public string Company10 { get; set; }
        public int SortOrder10 { get; set; }

        public string Picture11Url { get; set; }
        public string Link11 { get; set; }
        public string Company11 { get; set; }
        public int SortOrder11 { get; set; }

        public string Picture12Url { get; set; }
        public string Link12 { get; set; }
        public string Company12 { get; set; }
        public int SortOrder12 { get; set; }


        public string Picture13Url { get; set; }
        public string Link13 { get; set; }
        public string Company13 { get; set; }
        public int SortOrder13 { get; set; }


        public string Picture14Url { get; set; }
        public string Link14 { get; set; }
        public string Company14 { get; set; }

        public int SortOrder14 { get; set; }


        public string Picture15Url { get; set; }
        public string Link15 { get; set; }
        public string Company15 { get; set; }
        public int SortOrder15 { get; set; }
    }
}