using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;


namespace Nop.Plugin.VideotelDigital.TestimonialSlider.Models
{
    public class ConfigurationModel  : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

       [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SectionHeader")]
       public string SectionHeader { get; set; }
       public bool SectionHeader_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture1Id { get; set; }
        
        public bool Picture1Id_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text1 { get; set; }
        public bool Text1_OverrideForStore { get; set; }
        
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link1 { get; set; }
        public bool Link1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author1 { get; set; }
        public bool Author1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company1 { get; set; }
        public bool Company1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder1 { get; set; }
        public bool SortOrder1_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture2Id { get; set; }
        public bool Picture2Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text2 { get; set; }
        public bool Text2_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link2 { get; set; }
        public bool Link2_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author2 { get; set; }
        public bool Author2_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company2 { get; set; }
        public bool Company2_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder2 { get; set; }
        public bool SortOrder2_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture3Id { get; set; }
        public bool Picture3Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text3 { get; set; }
        public bool Text3_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link3 { get; set; }
        public bool Link3_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author3 { get; set; }
        public bool Author3_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company3 { get; set; }
        public bool Company3_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder3 { get; set; }
        public bool SortOrder3_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture4Id { get; set; }
        public bool Picture4Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text4 { get; set; }
        public bool Text4_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link4 { get; set; }
        public bool Link4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author4 { get; set; }
        public bool Author4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company4 { get; set; }
        public bool Company4_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder4 { get; set; }
        public bool SortOrder4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture5Id { get; set; }
        public bool Picture5Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text5 { get; set; }
        public bool Text5_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link5 { get; set; }
        public bool Link5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author5 { get; set; }
        public bool Author5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company5 { get; set; }
        public bool Company5_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder5 { get; set; }
        public bool SortOrder5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture6Id { get; set; }
        public bool Picture6Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text6 { get; set; }
        public bool Text6_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link6 { get; set; }
        public bool Link6_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author6 { get; set; }
        public bool Author6_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company6 { get; set; }
        public bool Company6_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder6 { get; set; }
        public bool SortOrder6_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture7Id { get; set; }
        public bool Picture7Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text7 { get; set; }
        public bool Text7_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link7 { get; set; }
        public bool Link7_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author7 { get; set; }
        public bool Author7_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company7 { get; set; }
        public bool Company7_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder7 { get; set; }
        public bool SortOrder7_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture8Id { get; set; }
        public bool Picture8Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text8 { get; set; }
        public bool Text8_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link8 { get; set; }
        public bool Link8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author8 { get; set; }
        public bool Author8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company8 { get; set; }
        public bool Company8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder8 { get; set; }
        public bool SortOrder8_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture9Id { get; set; }
        public bool Picture9Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text9 { get; set; }
        public bool Text9_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link9 { get; set; }
        public bool Link9_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author9 { get; set; }
        public bool Author9_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company9 { get; set; }
        public bool Company9_OverrideForStore { get; set; }



        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder9 { get; set; }
        public bool SortOrder9_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture10Id { get; set; }
        public bool Picture10Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text10 { get; set; }
        public bool Text10_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link10 { get; set; }
        public bool Link10_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author10 { get; set; }
        public bool Author10_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company10 { get; set; }
        public bool Company10_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder10 { get; set; }
        public bool SortOrder10_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture11Id { get; set; }
        public bool Picture11Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text11 { get; set; }
        public bool Text11_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link11 { get; set; }
        public bool Link11_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author11 { get; set; }
        public bool Author11_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company11 { get; set; }
        public bool Company11_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder11 { get; set; }
        public bool SortOrder11_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture12Id { get; set; }
        public bool Picture12Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text12 { get; set; }
        public bool Text12_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link12 { get; set; }
        public bool Link12_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author12 { get; set; }
        public bool Author12_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company12 { get; set; }
        public bool Company12_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder12 { get; set; }
        public bool SortOrder12_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture13Id { get; set; }
        public bool Picture13Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text13 { get; set; }
        public bool Text13_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link13 { get; set; }
        public bool Link13_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author13 { get; set; }
        public bool Author13_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company13 { get; set; }
        public bool Company13_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder13 { get; set; }
        public bool SortOrder13_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture14Id { get; set; }
        public bool Picture14Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text14 { get; set; }
        public bool Text14_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link14 { get; set; }
        public bool Link14_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author14 { get; set; }
        public bool Author14_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company14 { get; set; }
        public bool Company14_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder14 { get; set; }
        public bool SortOrder14_OverrideForStore { get; set; }




        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Picture")]
        [UIHint("Picture")]
        public int Picture15Id { get; set; }
        public bool Picture15Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Text")]
        [AllowHtml]
        public string Text15 { get; set; }
        public bool Text15_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Link")]
        [AllowHtml]
        public string Link15 { get; set; }
        public bool Link15_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Author")]
        [AllowHtml]
        public string Author15 { get; set; }
        public bool Author15_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.Company")]
        [AllowHtml]
        public string Company15 { get; set; }
        public bool Company15_OverrideForStore { get; set; }


        [NopResourceDisplayName("Plugins.VideotelDigital.TestimonialSlider.SortOrder")]
        [AllowHtml]
        public int SortOrder15 { get; set; }
        public bool SortOrder15_OverrideForStore { get; set; }

    }
}
