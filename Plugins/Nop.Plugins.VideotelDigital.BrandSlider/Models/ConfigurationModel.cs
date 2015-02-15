using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;


namespace Nop.Plugin.VideotelDigital.BrandSlider.Models
{
    public class ConfigurationModel  : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

       [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SectionHeader")]
       public string SectionHeader { get; set; }
       public bool SectionHeader_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture1Id { get; set; }
        
        public bool Picture1Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link1 { get; set; }
        public bool Link1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company1 { get; set; }
        public bool Company1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder1 { get; set; }
        public bool SortOrder1_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture2Id { get; set; }
        public bool Picture2Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link2 { get; set; }
        public bool Link2_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company2 { get; set; }
        public bool Company2_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder2 { get; set; }
        public bool SortOrder2_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture3Id { get; set; }
        public bool Picture3Id_OverrideForStore { get; set; }
        
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link3 { get; set; }
        public bool Link3_OverrideForStore { get; set; }

        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company3 { get; set; }
        public bool Company3_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder3 { get; set; }
        public bool SortOrder3_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture4Id { get; set; }
        public bool Picture4Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link4 { get; set; }
        public bool Link4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company4 { get; set; }
        public bool Company4_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder4 { get; set; }
        public bool SortOrder4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture5Id { get; set; }
        public bool Picture5Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link5 { get; set; }
        public bool Link5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company5 { get; set; }
        public bool Company5_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder5 { get; set; }
        public bool SortOrder5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture6Id { get; set; }
        public bool Picture6Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link6 { get; set; }
        public bool Link6_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company6 { get; set; }
        public bool Company6_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder6 { get; set; }
        public bool SortOrder6_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture7Id { get; set; }
        public bool Picture7Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link7 { get; set; }
        public bool Link7_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company7 { get; set; }
        public bool Company7_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder7 { get; set; }
        public bool SortOrder7_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture8Id { get; set; }
        public bool Picture8Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link8 { get; set; }
        public bool Link8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company8 { get; set; }
        public bool Company8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder8 { get; set; }
        public bool SortOrder8_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture9Id { get; set; }
        public bool Picture9Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link9 { get; set; }
        public bool Link9_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company9 { get; set; }
        public bool Company9_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder9 { get; set; }
        public bool SortOrder9_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture10Id { get; set; }
        public bool Picture10Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link10 { get; set; }
        public bool Link10_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company10 { get; set; }
        public bool Company10_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder10 { get; set; }
        public bool SortOrder10_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture11Id { get; set; }
        public bool Picture11Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link11 { get; set; }
        public bool Link11_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company11 { get; set; }
        public bool Company11_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder11 { get; set; }
        public bool SortOrder11_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture12Id { get; set; }
        public bool Picture12Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link12 { get; set; }
        public bool Link12_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company12 { get; set; }
        public bool Company12_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder12 { get; set; }
        public bool SortOrder12_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture13Id { get; set; }
        public bool Picture13Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link13 { get; set; }
        public bool Link13_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company13 { get; set; }
        public bool Company13_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder13 { get; set; }
        public bool SortOrder13_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture14Id { get; set; }
        public bool Picture14Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link14 { get; set; }
        public bool Link14_OverrideForStore { get; set; }

        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company14 { get; set; }
        public bool Company14_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder14 { get; set; }
        public bool SortOrder14_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Picture")]
        [UIHint("Picture")]
        public int Picture15Id { get; set; }
        public bool Picture15Id_OverrideForStore { get; set; }
        
        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Link")]
        [AllowHtml]
        public string Link15 { get; set; }
        public bool Link15_OverrideForStore { get; set; }

        
        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.Company")]
        [AllowHtml]
        public string Company15 { get; set; }
        public bool Company15_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.BrandSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder15 { get; set; }
        public bool SortOrder15_OverrideForStore { get; set; }

    }
}
