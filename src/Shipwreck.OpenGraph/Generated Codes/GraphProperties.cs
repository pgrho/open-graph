using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    partial class Graph
    {
#region Title

        private Collection<System.String> _Titles;
        
        public System.String Title
        {
            get => _Titles?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Titles, value);
        }

        public Collection<System.String> Titles
        {
            get => CollectionHelper.GetCollection(ref _Titles);
            set => CollectionHelper.SetCollection(ref _Titles, value);
        }

        public bool ShouldSerializeTitle()
            => _Titles?.Count == 1;

        public bool ShouldSerializeTitles()
            => _Titles?.Count > 1;

        public void ResetTitle()
            => _Titles?.Clear();

        public void ResetTitles()
            => _Titles?.Clear();

#endregion Title

#region Type

        private Collection<System.String> _Types;
        
        public System.String Type
        {
            get => _Types?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Types, value);
        }

        public Collection<System.String> Types
        {
            get => CollectionHelper.GetCollection(ref _Types);
            set => CollectionHelper.SetCollection(ref _Types, value);
        }

        public bool ShouldSerializeType()
            => _Types?.Count == 1;

        public bool ShouldSerializeTypes()
            => _Types?.Count > 1;

        public void ResetType()
            => _Types?.Clear();

        public void ResetTypes()
            => _Types?.Clear();

#endregion Type

#region Url

        private Collection<System.String> _Urls;
        
        public System.String Url
        {
            get => _Urls?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Urls, value);
        }

        public Collection<System.String> Urls
        {
            get => CollectionHelper.GetCollection(ref _Urls);
            set => CollectionHelper.SetCollection(ref _Urls, value);
        }

        public bool ShouldSerializeUrl()
            => _Urls?.Count == 1;

        public bool ShouldSerializeUrls()
            => _Urls?.Count > 1;

        public void ResetUrl()
            => _Urls?.Clear();

        public void ResetUrls()
            => _Urls?.Clear();

#endregion Url

#region Description

        private Collection<System.String> _Descriptions;
        
        public System.String Description
        {
            get => _Descriptions?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Descriptions, value);
        }

        public Collection<System.String> Descriptions
        {
            get => CollectionHelper.GetCollection(ref _Descriptions);
            set => CollectionHelper.SetCollection(ref _Descriptions, value);
        }

        public bool ShouldSerializeDescription()
            => _Descriptions?.Count == 1;

        public bool ShouldSerializeDescriptions()
            => _Descriptions?.Count > 1;

        public void ResetDescription()
            => _Descriptions?.Clear();

        public void ResetDescriptions()
            => _Descriptions?.Clear();

#endregion Description

#region Determiner

        private Collection<System.String> _Determiners;
        
        public System.String Determiner
        {
            get => _Determiners?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Determiners, value);
        }

        public Collection<System.String> Determiners
        {
            get => CollectionHelper.GetCollection(ref _Determiners);
            set => CollectionHelper.SetCollection(ref _Determiners, value);
        }

        public bool ShouldSerializeDeterminer()
            => _Determiners?.Count == 1;

        public bool ShouldSerializeDeterminers()
            => _Determiners?.Count > 1;

        public void ResetDeterminer()
            => _Determiners?.Clear();

        public void ResetDeterminers()
            => _Determiners?.Clear();

#endregion Determiner

#region Locale

        private Collection<System.String> _Locales;
        
        public System.String Locale
        {
            get => _Locales?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Locales, value);
        }

        public Collection<System.String> Locales
        {
            get => CollectionHelper.GetCollection(ref _Locales);
            set => CollectionHelper.SetCollection(ref _Locales, value);
        }

        public bool ShouldSerializeLocale()
            => _Locales?.Count == 1;

        public bool ShouldSerializeLocales()
            => _Locales?.Count > 1;

        public void ResetLocale()
            => _Locales?.Clear();

        public void ResetLocales()
            => _Locales?.Clear();

#endregion Locale

#region AlternateLocale

        private Collection<System.String> _AlternateLocales;
        
        public System.String AlternateLocale
        {
            get => _AlternateLocales?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _AlternateLocales, value);
        }

        public Collection<System.String> AlternateLocales
        {
            get => CollectionHelper.GetCollection(ref _AlternateLocales);
            set => CollectionHelper.SetCollection(ref _AlternateLocales, value);
        }

        public bool ShouldSerializeAlternateLocale()
            => _AlternateLocales?.Count == 1;

        public bool ShouldSerializeAlternateLocales()
            => _AlternateLocales?.Count > 1;

        public void ResetAlternateLocale()
            => _AlternateLocales?.Clear();

        public void ResetAlternateLocales()
            => _AlternateLocales?.Clear();

#endregion AlternateLocale

#region SiteName

        private Collection<System.String> _SiteNames;
        
        public System.String SiteName
        {
            get => _SiteNames?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _SiteNames, value);
        }

        public Collection<System.String> SiteNames
        {
            get => CollectionHelper.GetCollection(ref _SiteNames);
            set => CollectionHelper.SetCollection(ref _SiteNames, value);
        }

        public bool ShouldSerializeSiteName()
            => _SiteNames?.Count == 1;

        public bool ShouldSerializeSiteNames()
            => _SiteNames?.Count > 1;

        public void ResetSiteName()
            => _SiteNames?.Clear();

        public void ResetSiteNames()
            => _SiteNames?.Clear();

#endregion SiteName

#region Image

        private Collection<GraphImage> _Images;
        
        public GraphImage Image
        {
            get => _Images?.FirstOrDefault() ?? default(GraphImage);
            set => CollectionHelper.SetCollection(ref _Images, value);
        }

        public Collection<GraphImage> Images
        {
            get => CollectionHelper.GetCollection(ref _Images);
            set => CollectionHelper.SetCollection(ref _Images, value);
        }

        public bool ShouldSerializeImage()
            => false;

        public bool ShouldSerializeImages()
            => _Images?.Count > 0;

        public void ResetImage()
            => _Images?.Clear();

        public void ResetImages()
            => _Images?.Clear();

#endregion Image

#region Video

        private Collection<GraphVideo> _Videos;
        
        public GraphVideo Video
        {
            get => _Videos?.FirstOrDefault() ?? default(GraphVideo);
            set => CollectionHelper.SetCollection(ref _Videos, value);
        }

        public Collection<GraphVideo> Videos
        {
            get => CollectionHelper.GetCollection(ref _Videos);
            set => CollectionHelper.SetCollection(ref _Videos, value);
        }

        public bool ShouldSerializeVideo()
            => false;

        public bool ShouldSerializeVideos()
            => _Videos?.Count > 0;

        public void ResetVideo()
            => _Videos?.Clear();

        public void ResetVideos()
            => _Videos?.Clear();

#endregion Video

    }
}