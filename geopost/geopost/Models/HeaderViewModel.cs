using System.Collections.Generic;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Models
{
    public class HeaderViewModel
    {
        public DataSiteSettings SiteSettings { get; set; }
        public List<IGeneralNavigation> Breadcrumbs { get; set; }
    }
}