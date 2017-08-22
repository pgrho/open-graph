using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Shipwreck.OpenGraph.Internal;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
        #region AlternateLocale

        /// <summary>
        /// Gets or sets an alternate locale.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AlternateLocale
        {
            get => GetLocalProperty("locale:alternate");
            set => SetLocalProperty("locale:alternate", value);
        }

        /// <summary>
        /// Gets or sets a list of all alternate locales.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> AlternateLocales
        {
            get => new PropertyEntryPartialCollection(this, "locale:alternate");
            set => SetLocalProperty("locale:alternate", value);
        }

        #endregion AlternateLocale

        #region Image

        /// <summary>
        /// Gets or sets an image.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GraphImage Image
        {
            get => Images.FirstOrDefault();
            set => Images.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all images.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphImage> Images
        {
            get => new GraphObjectPartialCollection<GraphImage>(this, "image");
            set => Images.Set(value);
        }

        #endregion Image

        #region Video

        /// <summary>
        /// Gets or sets a video.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GraphVideo Video
        {
            get => Videos.FirstOrDefault();
            set => Videos.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all videos.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphVideo> Videos
        {
            get => new GraphObjectPartialCollection<GraphVideo>(this, "video");
            set => Videos.Set(value);
        }

        #endregion Video

        #region Audio

        /// <summary>
        /// Gets or sets an audio.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GraphAudio Audio
        {
            get => Audios.FirstOrDefault();
            set => Audios.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all audios.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphAudio> Audios
        {
            get => new GraphObjectPartialCollection<GraphAudio>(this, "audio");
            set => Audios.Set(value);
        }

        #endregion Audio

        #region Restriction

        /// <summary>
        /// Gets or sets a restriction.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GraphRestriction Restriction
        {
            get => Restrictions.FirstOrDefault();
            set => Restrictions.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all restrictions.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphRestriction> Restrictions
        {
            get => new GraphObjectPartialCollection<GraphRestriction>(this, "restrictions");
            set => Restrictions.Set(value);
        }

        #endregion Restriction

        #region SeeAlso

        /// <summary>
        /// Gets or sets a see also.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SeeAlso
        {
            get => GetLocalProperty("see_also");
            set => SetLocalProperty("see_also", value);
        }

        /// <summary>
        /// Gets or sets a list of all see alsos.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> SeeAlsos
        {
            get => new PropertyEntryPartialCollection(this, "see_also");
            set => SetLocalProperty("see_also", value);
        }

        #endregion SeeAlso

        #region Title

        /// <summary>
        /// Gets or sets a title.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => GetLocalProperty("title");
            set => SetLocalProperty("title", value);
        }

        #endregion Title

        #region Type

        /// <summary>
        /// Gets or sets a type.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Type
        {
            get => GetLocalProperty("type");
            set => SetLocalProperty("type", value);
        }

        #endregion Type

        #region Url

        /// <summary>
        /// Gets or sets an url.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Url
        {
            get => GetLocalProperty("url");
            set => SetLocalProperty("url", value);
        }

        #endregion Url

        #region Description

        /// <summary>
        /// Gets or sets a description.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Description
        {
            get => GetLocalProperty("description");
            set => SetLocalProperty("description", value);
        }

        #endregion Description

        #region Determiner

        /// <summary>
        /// Gets or sets a determiner.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Determiner
        {
            get => GetLocalProperty("determiner");
            set => SetLocalProperty("determiner", value);
        }

        #endregion Determiner

        #region Locale

        /// <summary>
        /// Gets or sets a locale.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Locale
        {
            get => GetLocalProperty("locale");
            set => SetLocalProperty("locale", value);
        }

        #endregion Locale

        #region RichAttachment

        /// <summary>
        /// Gets or sets a rich attachment.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? RichAttachment
        {
            get => GetLocalPropertyAsBoolean("rich_attachment");
            set => SetLocalProperty("rich_attachment", value);
        }

        #endregion RichAttachment

        #region SiteName

        /// <summary>
        /// Gets or sets a site name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SiteName
        {
            get => GetLocalProperty("site_name");
            set => SetLocalProperty("site_name", value);
        }

        #endregion SiteName

        #region TimeToLive

        /// <summary>
        /// Gets or sets a time to live.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? TimeToLive
        {
            get => GetLocalPropertyAsInt32("ttl");
            set => SetLocalProperty("ttl", value);
        }

        #endregion TimeToLive

        #region UpdatedTime

        /// <summary>
        /// Gets or sets an updated time.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? UpdatedTime
        {
            get => GetLocalPropertyAsDateTime("updated_time");
            set => SetLocalProperty("updated_time", value);
        }

        #endregion UpdatedTime

        /// <inheritdoc />
        internal virtual GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "image", out matched, skipCompareProperty: true))
            {
                return new GraphImage(Path + "image");
            }
            if (property.StartsWith(Path, "video", out matched, skipCompareProperty: true))
            {
                return new GraphVideo(Path + "video");
            }
            if (property.StartsWith(Path, "audio", out matched, skipCompareProperty: true))
            {
                return new GraphAudio(Path + "audio");
            }
            if (property.StartsWith(Path, "restrictions", out matched, skipCompareProperty: true))
            {
                return new GraphRestriction(Path + "restrictions");
            }
            return null;
        }
    }
    partial class Graph
    {
        #region AndroidApp

        /// <summary>
        /// Gets or sets an android app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AndroidApplink AndroidApp
        {
            get => AndroidApps.FirstOrDefault();
            set => AndroidApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all android apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<AndroidApplink> AndroidApps
        {
            get => new GraphObjectPartialCollection<AndroidApplink>(this, new PropertyPath(NamespaceCollection.Applink, "android"));
            set => AndroidApps.Set(value);
        }

        #endregion AndroidApp

        #region IosApp

        /// <summary>
        /// Gets or sets an ios app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IosApplink IosApp
        {
            get => IosApps.FirstOrDefault();
            set => IosApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all ios apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<IosApplink> IosApps
        {
            get => new GraphObjectPartialCollection<IosApplink>(this, new PropertyPath(NamespaceCollection.Applink, "ios"));
            set => IosApps.Set(value);
        }

        #endregion IosApp

        #region IPadApp

        /// <summary>
        /// Gets or sets an i pad app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IosApplink IPadApp
        {
            get => IPadApps.FirstOrDefault();
            set => IPadApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all i pad apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<IosApplink> IPadApps
        {
            get => new GraphObjectPartialCollection<IosApplink>(this, new PropertyPath(NamespaceCollection.Applink, "ipad"));
            set => IPadApps.Set(value);
        }

        #endregion IPadApp

        #region IPhoneApp

        /// <summary>
        /// Gets or sets an i phone app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IosApplink IPhoneApp
        {
            get => IPhoneApps.FirstOrDefault();
            set => IPhoneApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all i phone apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<IosApplink> IPhoneApps
        {
            get => new GraphObjectPartialCollection<IosApplink>(this, new PropertyPath(NamespaceCollection.Applink, "iphone"));
            set => IPhoneApps.Set(value);
        }

        #endregion IPhoneApp

        #region WebApp

        /// <summary>
        /// Gets or sets a web app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Weblink WebApp
        {
            get => WebApps.FirstOrDefault();
            set => WebApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all web apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Weblink> WebApps
        {
            get => new GraphObjectPartialCollection<Weblink>(this, new PropertyPath(NamespaceCollection.Applink, "web"));
            set => WebApps.Set(value);
        }

        #endregion WebApp

        #region WindowsApp

        /// <summary>
        /// Gets or sets a windows app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WindowsApplink WindowsApp
        {
            get => WindowsApps.FirstOrDefault();
            set => WindowsApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all windows apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<WindowsApplink> WindowsApps
        {
            get => new GraphObjectPartialCollection<WindowsApplink>(this, new PropertyPath(NamespaceCollection.Applink, "windows"));
            set => WindowsApps.Set(value);
        }

        #endregion WindowsApp

        #region WindowsPhoneApp

        /// <summary>
        /// Gets or sets a windows phone app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WindowsApplink WindowsPhoneApp
        {
            get => WindowsPhoneApps.FirstOrDefault();
            set => WindowsPhoneApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all windows phone apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<WindowsApplink> WindowsPhoneApps
        {
            get => new GraphObjectPartialCollection<WindowsApplink>(this, new PropertyPath(NamespaceCollection.Applink, "windows_phone"));
            set => WindowsPhoneApps.Set(value);
        }

        #endregion WindowsPhoneApp

        #region WindowsUniversalApp

        /// <summary>
        /// Gets or sets a windows universal app.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WindowsApplink WindowsUniversalApp
        {
            get => WindowsUniversalApps.FirstOrDefault();
            set => WindowsUniversalApps.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all windows universal apps.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<WindowsApplink> WindowsUniversalApps
        {
            get => new GraphObjectPartialCollection<WindowsApplink>(this, new PropertyPath(NamespaceCollection.Applink, "windows_universal"));
            set => WindowsUniversalApps.Set(value);
        }

        #endregion WindowsUniversalApp

        #region FacebookAdmin

        /// <summary>
        /// Gets or sets a facebook admin.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FacebookAdmin
        {
            get => GetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "admins"));
            set => SetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "admins"), value);
        }

        /// <summary>
        /// Gets or sets a list of all facebook admins.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> FacebookAdmins
        {
            get => new PropertyEntryPartialCollection(this, new PropertyPath(NamespaceCollection.Facebook, "admins"));
            set => SetLocalProperty("fb:admins", value);
        }

        #endregion FacebookAdmin

        #region FacebookAppId

        /// <summary>
        /// Gets or sets a facebook app id.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int64? FacebookAppId
        {
            get => GetLocalPropertyAsInt64(new PropertyPath(NamespaceCollection.Facebook, "app_id"));
            set => SetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "app_id"), value);
        }

        #endregion FacebookAppId

        #region FacebookPage

        /// <summary>
        /// Gets or sets a facebook page.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FacebookPage
        {
            get => GetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "pages"));
            set => SetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "pages"), value);
        }

        /// <summary>
        /// Gets or sets a list of all facebook pages.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> FacebookPages
        {
            get => new PropertyEntryPartialCollection(this, new PropertyPath(NamespaceCollection.Facebook, "pages"));
            set => SetLocalProperty("fb:pages", value);
        }

        #endregion FacebookPage

        #region FacebookProfileId

        /// <summary>
        /// Gets or sets a facebook profile id.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int64? FacebookProfileId
        {
            get => GetLocalPropertyAsInt64(new PropertyPath(NamespaceCollection.Facebook, "profile_id"));
            set => SetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "profile_id"), value);
        }

        #endregion FacebookProfileId

        #region Location

        /// <summary>
        /// Gets or sets a location.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GeoPoint Location
        {
            get => Locations.FirstOrDefault();
            set => Locations.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all locations.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GeoPoint> Locations
        {
            get => new GraphObjectPartialCollection<GeoPoint>(this, new PropertyPath(NamespaceCollection.Place, "location"));
            set => Locations.Set(value);
        }

        #endregion Location

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "android");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new AndroidApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "ios");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new IosApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "ipad");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new IosApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "iphone");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new IosApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "web");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new Weblink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "windows");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new WindowsApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "windows_phone");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new WindowsApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Applink, "windows_universal");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new WindowsApplink(p);
                }
            }
            {
                var p = new PropertyPath(NamespaceCollection.Place, "location");
                matched = property == p;
                if (matched || property.StartsWith(p))
                {
                    return new GeoPoint(p);
                }
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class GraphAudio
    {
        #region SecureUrl

        /// <summary>
        /// Gets or sets a secure url.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        #endregion SecureUrl

    }
    partial class GraphImage
    {
        #region SecureUrl

        /// <summary>
        /// Gets or sets a secure url.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        #endregion SecureUrl

        #region Width

        /// <summary>
        /// Gets or sets a width.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Width
        {
            get => GetLocalPropertyAsInt32("width");
            set => SetLocalProperty("width", value);
        }

        #endregion Width

        #region Height

        /// <summary>
        /// Gets or sets a height.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Height
        {
            get => GetLocalPropertyAsInt32("height");
            set => SetLocalProperty("height", value);
        }

        #endregion Height

        #region Alt

        /// <summary>
        /// Gets or sets an alt.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Alt
        {
            get => GetLocalProperty("alt");
            set => SetLocalProperty("alt", value);
        }

        #endregion Alt

        #region UserGenerated

        /// <summary>
        /// Gets or sets an user generated.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? UserGenerated
        {
            get => GetLocalPropertyAsBoolean("user_generated");
            set => SetLocalProperty("user_generated", value);
        }

        #endregion UserGenerated

    }
    partial class GraphVideo
    {
        #region SecureUrl

        /// <summary>
        /// Gets or sets a secure url.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        #endregion SecureUrl

        #region Width

        /// <summary>
        /// Gets or sets a width.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Width
        {
            get => GetLocalPropertyAsInt32("width");
            set => SetLocalProperty("width", value);
        }

        #endregion Width

        #region Height

        /// <summary>
        /// Gets or sets a height.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Height
        {
            get => GetLocalPropertyAsInt32("height");
            set => SetLocalProperty("height", value);
        }

        #endregion Height

        #region Alt

        /// <summary>
        /// Gets or sets an alt.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Alt
        {
            get => GetLocalProperty("alt");
            set => SetLocalProperty("alt", value);
        }

        #endregion Alt

    }
    partial class GraphRestriction
    {
        #region AllowedContry

        /// <summary>
        /// Gets or sets an allowed contry.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AllowedContry
        {
            get => GetLocalProperty("country:allowed");
            set => SetLocalProperty("country:allowed", value);
        }

        /// <summary>
        /// Gets or sets a list of all allowed countries.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> AllowedCountries
        {
            get => new PropertyEntryPartialCollection(this, "country:allowed");
            set => SetLocalProperty("country:allowed", value);
        }

        #endregion AllowedContry

        #region DisallowedContry

        /// <summary>
        /// Gets or sets a disallowed contry.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DisallowedContry
        {
            get => GetLocalProperty("country:disallowed");
            set => SetLocalProperty("country:disallowed", value);
        }

        /// <summary>
        /// Gets or sets a list of all disallowed countries.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> DisallowedCountries
        {
            get => new PropertyEntryPartialCollection(this, "country:disallowed");
            set => SetLocalProperty("country:disallowed", value);
        }

        #endregion DisallowedContry

        #region Age

        /// <summary>
        /// Gets or sets an age.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Age
        {
            get => GetLocalProperty("age");
            set => SetLocalProperty("age", value);
        }

        #endregion Age

        #region Content

        /// <summary>
        /// Gets or sets a content.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Content
        {
            get => GetLocalProperty("content");
            set => SetLocalProperty("content", value);
        }

        /// <summary>
        /// Gets or sets a list of all contents.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Contents
        {
            get => new PropertyEntryPartialCollection(this, "content");
            set => SetLocalProperty("content", value);
        }

        #endregion Content

    }
    partial class ContactData
    {
        #region StreetAddress

        /// <summary>
        /// Gets or sets a street address.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string StreetAddress
        {
            get => GetLocalProperty("street_address");
            set => SetLocalProperty("street_address", value);
        }

        #endregion StreetAddress

        #region Locality

        /// <summary>
        /// Gets or sets a locality.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Locality
        {
            get => GetLocalProperty("locality");
            set => SetLocalProperty("locality", value);
        }

        #endregion Locality

        #region PostalCode

        /// <summary>
        /// Gets or sets a postal code.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PostalCode
        {
            get => GetLocalProperty("postal_code");
            set => SetLocalProperty("postal_code", value);
        }

        #endregion PostalCode

        #region Region

        /// <summary>
        /// Gets or sets a region.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Region
        {
            get => GetLocalProperty("region");
            set => SetLocalProperty("region", value);
        }

        #endregion Region

        #region CountryName

        /// <summary>
        /// Gets or sets a country name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CountryName
        {
            get => GetLocalProperty("country_name");
            set => SetLocalProperty("country_name", value);
        }

        #endregion CountryName

        #region Email

        /// <summary>
        /// Gets or sets an email.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email
        {
            get => GetLocalProperty("email");
            set => SetLocalProperty("email", value);
        }

        #endregion Email

        #region PhoneNumber

        /// <summary>
        /// Gets or sets a phone number.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PhoneNumber
        {
            get => GetLocalProperty("phone_number");
            set => SetLocalProperty("phone_number", value);
        }

        #endregion PhoneNumber

        #region FaxNumber

        /// <summary>
        /// Gets or sets a fax number.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FaxNumber
        {
            get => GetLocalProperty("fax_number");
            set => SetLocalProperty("fax_number", value);
        }

        #endregion FaxNumber

        #region Website

        /// <summary>
        /// Gets or sets a website.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Website
        {
            get => GetLocalProperty("website");
            set => SetLocalProperty("website", value);
        }

        #endregion Website

    }
    partial class GeoPoint
    {
        #region Latitude

        /// <summary>
        /// Gets or sets a latitude.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? Latitude
        {
            get => GetLocalPropertyAsSingle("latitude");
            set => SetLocalProperty("latitude", value);
        }

        #endregion Latitude

        #region Longitude

        /// <summary>
        /// Gets or sets a longitude.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? Longitude
        {
            get => GetLocalPropertyAsSingle("longitude");
            set => SetLocalProperty("longitude", value);
        }

        #endregion Longitude

        #region Altitude

        /// <summary>
        /// Gets or sets an altitude.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? Altitude
        {
            get => GetLocalPropertyAsSingle("altitude");
            set => SetLocalProperty("altitude", value);
        }

        #endregion Altitude

    }
    partial class Quantity
    {
        #region Value

        /// <summary>
        /// Gets or sets a value.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? Value
        {
            get => GetLocalPropertyAsSingle("value");
            set => SetLocalProperty("value", value);
        }

        #endregion Value

        #region Units

        /// <summary>
        /// Gets or sets an units.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Units
        {
            get => GetLocalProperty("units");
            set => SetLocalProperty("units", value);
        }

        #endregion Units

    }
    partial class Currency
    {
        #region Amount

        /// <summary>
        /// Gets or sets an amount.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? Amount
        {
            get => GetLocalPropertyAsSingle("amount");
            set => SetLocalProperty("amount", value);
        }

        #endregion Amount

        #region Units

        /// <summary>
        /// Gets or sets an units.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Units
        {
            get => GetLocalProperty("currency");
            set => SetLocalProperty("currency", value);
        }

        #endregion Units

    }
    partial class DateTimeRange
    {
        #region Start

        /// <summary>
        /// Gets or sets a start.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? Start
        {
            get => GetLocalPropertyAsDateTime("start");
            set => SetLocalProperty("start", value);
        }

        #endregion Start

        #region End

        /// <summary>
        /// Gets or sets an end.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? End
        {
            get => GetLocalPropertyAsDateTime("end");
            set => SetLocalProperty("end", value);
        }

        #endregion End

    }
    partial class MusicSong
    {
        #region Album

        /// <summary>
        /// Gets or sets an album.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicAlbum Album
        {
            get => Albums.FirstOrDefault();
            set => Albums.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all albums.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicAlbum> Albums
        {
            get => new GraphObjectPartialCollection<MusicAlbum>(this, "album");
            set => Albums.Set(value);
        }

        #endregion Album

        #region Musician

        /// <summary>
        /// Gets or sets a musician.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Musician
        {
            get => Musicians.FirstOrDefault();
            set => Musicians.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all musicians.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Musicians
        {
            get => new GraphObjectPartialCollection<Profile>(this, "musician");
            set => Musicians.Set(value);
        }

        #endregion Musician

        #region Preview

        /// <summary>
        /// Gets or sets a preview.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GraphAudio Preview
        {
            get => Previews.FirstOrDefault();
            set => Previews.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all previews.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphAudio> Previews
        {
            get => new GraphObjectPartialCollection<GraphAudio>(this, "preview_url");
            set => Previews.Set(value);
        }

        #endregion Preview

        #region Duration

        /// <summary>
        /// Gets or sets a duration.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        #endregion Duration

        #region ISRC

        /// <summary>
        /// Gets or sets ISRC.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ISRC
        {
            get => GetLocalProperty("isrc");
            set => SetLocalProperty("isrc", value);
        }

        #endregion ISRC

        #region ReleaseDate

        /// <summary>
        /// Gets or sets a release date.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        #endregion ReleaseDate

        #region ReleaseType

        /// <summary>
        /// Gets or sets a release type.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ReleaseType
        {
            get => GetLocalProperty("release_type");
            set => SetLocalProperty("release_type", value);
        }

        #endregion ReleaseType

        #region Disc

        /// <summary>
        /// Gets or sets a disc.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Disc
        {
            get => GetLocalPropertyAsInt32("disc");
            set => SetLocalProperty("disc", value);
        }

        #endregion Disc

        #region Track

        /// <summary>
        /// Gets or sets a track.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Track
        {
            get => GetLocalPropertyAsInt32("track");
            set => SetLocalProperty("track", value);
        }

        #endregion Track

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "album", out matched, skipCompareProperty: true))
            {
                return new MusicAlbum(Path + "album");
            }
            if (property.StartsWith(Path, "musician", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "musician");
            }
            if (property.StartsWith(Path, "preview_url", out matched, skipCompareProperty: true))
            {
                return new GraphAudio(Path + "preview_url");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class MusicAlbum
    {
        #region Song

        /// <summary>
        /// Gets or sets a song.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong Song
        {
            get => Songs.FirstOrDefault();
            set => Songs.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all songs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicSong> Songs
        {
            get => new GraphObjectPartialCollection<MusicSong>(this, "song");
            set => Songs.Set(value);
        }

        #endregion Song

        #region Musician

        /// <summary>
        /// Gets or sets a musician.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Musician
        {
            get => Musicians.FirstOrDefault();
            set => Musicians.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all musicians.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Musicians
        {
            get => new GraphObjectPartialCollection<Profile>(this, "musician");
            set => Musicians.Set(value);
        }

        #endregion Musician

        #region ReleaseDate

        /// <summary>
        /// Gets or sets a release date.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        #endregion ReleaseDate

        #region ReleaseType

        /// <summary>
        /// Gets or sets a release type.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ReleaseType
        {
            get => GetLocalProperty("release_type");
            set => SetLocalProperty("release_type", value);
        }

        #endregion ReleaseType

        #region Disc

        /// <summary>
        /// Gets or sets a disc.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Disc
        {
            get => GetLocalPropertyAsInt32("disc");
            set => SetLocalProperty("disc", value);
        }

        #endregion Disc

        #region Track

        /// <summary>
        /// Gets or sets a track.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Track
        {
            get => GetLocalPropertyAsInt32("track");
            set => SetLocalProperty("track", value);
        }

        #endregion Track

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "song", out matched, skipCompareProperty: true))
            {
                return new MusicSong(Path + "song");
            }
            if (property.StartsWith(Path, "musician", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "musician");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class MusicPlaylist
    {
        #region Creator

        /// <summary>
        /// Gets or sets a creator.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Creator
        {
            get => Creators.FirstOrDefault();
            set => Creators.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all creators.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Creators
        {
            get => new GraphObjectPartialCollection<Profile>(this, "creator");
            set => Creators.Set(value);
        }

        #endregion Creator

        #region Song

        /// <summary>
        /// Gets or sets a song.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong Song
        {
            get => Songs.FirstOrDefault();
            set => Songs.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all songs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicSong> Songs
        {
            get => new GraphObjectPartialCollection<MusicSong>(this, "song");
            set => Songs.Set(value);
        }

        #endregion Song

        #region SongCount

        /// <summary>
        /// Gets or sets a song count.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? SongCount
        {
            get => GetLocalPropertyAsInt32("song_count");
            set => SetLocalProperty("song_count", value);
        }

        #endregion SongCount

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "creator", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "creator");
            }
            if (property.StartsWith(Path, "song", out matched, skipCompareProperty: true))
            {
                return new MusicSong(Path + "song");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class MusicRadioStation
    {
        #region Creator

        /// <summary>
        /// Gets or sets a creator.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Creator
        {
            get => Creators.FirstOrDefault();
            set => Creators.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all creators.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Creators
        {
            get => new GraphObjectPartialCollection<Profile>(this, "creator");
            set => Creators.Set(value);
        }

        #endregion Creator

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "creator", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "creator");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class VideoObject
    {
        #region Actor

        /// <summary>
        /// Gets or sets an actor.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Actor
        {
            get => Actors.FirstOrDefault();
            set => Actors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all actors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Actors
        {
            get => new GraphObjectPartialCollection<Profile>(this, "actor");
            set => Actors.Set(value);
        }

        #endregion Actor

        #region Director

        /// <summary>
        /// Gets or sets a director.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Director
        {
            get => Directors.FirstOrDefault();
            set => Directors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all directors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Directors
        {
            get => new GraphObjectPartialCollection<Profile>(this, "director");
            set => Directors.Set(value);
        }

        #endregion Director

        #region Writer

        /// <summary>
        /// Gets or sets a writer.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Writer
        {
            get => Writers.FirstOrDefault();
            set => Writers.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all writers.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Writers
        {
            get => new GraphObjectPartialCollection<Profile>(this, "writer");
            set => Writers.Set(value);
        }

        #endregion Writer

        #region Tag

        /// <summary>
        /// Gets or sets a tag.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        /// <summary>
        /// Gets or sets a list of all tags.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Tags
        {
            get => new PropertyEntryPartialCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        #region Duration

        /// <summary>
        /// Gets or sets a duration.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        #endregion Duration

        #region ReleaseDate

        /// <summary>
        /// Gets or sets a release date.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        #endregion ReleaseDate

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "actor", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "actor");
            }
            if (property.StartsWith(Path, "director", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "director");
            }
            if (property.StartsWith(Path, "writer", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "writer");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class VideoEpisode
    {
        #region Series

        /// <summary>
        /// Gets or sets a series.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoTVShow Series
        {
            get => AllSeries.FirstOrDefault();
            set => AllSeries.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all series.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<VideoTVShow> AllSeries
        {
            get => new GraphObjectPartialCollection<VideoTVShow>(this, "series");
            set => AllSeries.Set(value);
        }

        #endregion Series

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "series", out matched, skipCompareProperty: true))
            {
                return new VideoTVShow(Path + "series");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Article
    {
        #region Author

        /// <summary>
        /// Gets or sets an author.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Author
        {
            get => Authors.FirstOrDefault();
            set => Authors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectPartialCollection<Profile>(this, "author");
            set => Authors.Set(value);
        }

        #endregion Author

        #region Publisher

        /// <summary>
        /// Gets or sets a publisher.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Publisher
        {
            get => Publishers.FirstOrDefault();
            set => Publishers.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all publishers.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Publishers
        {
            get => new GraphObjectPartialCollection<Profile>(this, "publisher");
            set => Publishers.Set(value);
        }

        #endregion Publisher

        #region Tag

        /// <summary>
        /// Gets or sets a tag.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        /// <summary>
        /// Gets or sets a list of all tags.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Tags
        {
            get => new PropertyEntryPartialCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        #region PublishedTime

        /// <summary>
        /// Gets or sets a published time.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? PublishedTime
        {
            get => GetLocalPropertyAsDateTime("published_time");
            set => SetLocalProperty("published_time", value);
        }

        #endregion PublishedTime

        #region ModifiedTime

        /// <summary>
        /// Gets or sets a modified time.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ModifiedTime
        {
            get => GetLocalPropertyAsDateTime("modified_time");
            set => SetLocalProperty("modified_time", value);
        }

        #endregion ModifiedTime

        #region ExpirationTime

        /// <summary>
        /// Gets or sets an expiration time.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ExpirationTime
        {
            get => GetLocalPropertyAsDateTime("expiration_time");
            set => SetLocalProperty("expiration_time", value);
        }

        #endregion ExpirationTime

        #region Section

        /// <summary>
        /// Gets or sets a section.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Section
        {
            get => GetLocalProperty("section");
            set => SetLocalProperty("section", value);
        }

        #endregion Section

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "author", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "author");
            }
            if (property.StartsWith(Path, "publisher", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "publisher");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Profile
    {
        #region ContentTier

        /// <summary>
        /// Gets or sets a content tier.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ContentTier
        {
            get => GetLocalProperty("content_tier");
            set => SetLocalProperty("content_tier", value);
        }

        #endregion ContentTier

        #region Book

        /// <summary>
        /// Gets or sets a book.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Book Book
        {
            get => Books.FirstOrDefault();
            set => Books.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all books.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Book> Books
        {
            get => new GraphObjectPartialCollection<Book>(this, "book");
            set => Books.Set(value);
        }

        #endregion Book

        #region Genre

        /// <summary>
        /// Gets or sets a genre.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Genre
        {
            get => GetLocalProperty("genre");
            set => SetLocalProperty("genre", value);
        }

        /// <summary>
        /// Gets or sets a list of all genres.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Genres
        {
            get => new PropertyEntryPartialCollection(this, "genre");
            set => SetLocalProperty("genre", value);
        }

        #endregion Genre

        #region FirstName

        /// <summary>
        /// Gets or sets a first name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName
        {
            get => GetLocalProperty("first_name");
            set => SetLocalProperty("first_name", value);
        }

        #endregion FirstName

        #region LastName

        /// <summary>
        /// Gets or sets a last name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName
        {
            get => GetLocalProperty("last_name");
            set => SetLocalProperty("last_name", value);
        }

        #endregion LastName

        #region UserName

        /// <summary>
        /// Gets or sets an user name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName
        {
            get => GetLocalProperty("username");
            set => SetLocalProperty("username", value);
        }

        #endregion UserName

        #region Gender

        /// <summary>
        /// Gets or sets a gender.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Gender
        {
            get => GetLocalProperty("gender");
            set => SetLocalProperty("gender", value);
        }

        #endregion Gender

        #region OfficialSite

        /// <summary>
        /// Gets or sets an official site.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OfficialSite
        {
            get => GetLocalProperty("official_site");
            set => SetLocalProperty("official_site", value);
        }

        #endregion OfficialSite

        #region Role

        /// <summary>
        /// Gets or sets a role.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Role
        {
            get => GetLocalProperty("role");
            set => SetLocalProperty("role", value);
        }

        #endregion Role

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "book", out matched, skipCompareProperty: true))
            {
                return new Book(Path + "book");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Book
    {
        #region Author

        /// <summary>
        /// Gets or sets an author.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Author
        {
            get => Authors.FirstOrDefault();
            set => Authors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectPartialCollection<Profile>(this, "author");
            set => Authors.Set(value);
        }

        #endregion Author

        #region Genre

        /// <summary>
        /// Gets or sets a genre.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookGenre Genre
        {
            get => Genres.FirstOrDefault();
            set => Genres.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all genres.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<BookGenre> Genres
        {
            get => new GraphObjectPartialCollection<BookGenre>(this, "genre");
            set => Genres.Set(value);
        }

        #endregion Genre

        #region AlternateLanguage

        /// <summary>
        /// Gets or sets an alternate language.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AlternateLanguage
        {
            get => GetLocalProperty("language:alternate");
            set => SetLocalProperty("language:alternate", value);
        }

        /// <summary>
        /// Gets or sets a list of all alternate languages.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> AlternateLanguages
        {
            get => new PropertyEntryPartialCollection(this, "language:alternate");
            set => SetLocalProperty("language:alternate", value);
        }

        #endregion AlternateLanguage

        #region Tag

        /// <summary>
        /// Gets or sets a tag.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        /// <summary>
        /// Gets or sets a list of all tags.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> Tags
        {
            get => new PropertyEntryPartialCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        #region InitialReleaseDate

        /// <summary>
        /// Gets or sets an initial release date.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? InitialReleaseDate
        {
            get => GetLocalPropertyAsDateTime("initial_release_date");
            set => SetLocalProperty("initial_release_date", value);
        }

        #endregion InitialReleaseDate

        #region ISBN

        /// <summary>
        /// Gets or sets ISBN.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ISBN
        {
            get => GetLocalProperty("isbn");
            set => SetLocalProperty("isbn", value);
        }

        #endregion ISBN

        #region Language

        /// <summary>
        /// Gets or sets a language.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Language
        {
            get => GetLocalProperty("language");
            set => SetLocalProperty("language", value);
        }

        #endregion Language

        #region PageCount

        /// <summary>
        /// Gets or sets a page count.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? PageCount
        {
            get => GetLocalPropertyAsInt32("page_count");
            set => SetLocalProperty("page_count", value);
        }

        #endregion PageCount

        #region RatingValue

        /// <summary>
        /// Gets or sets a rating value.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Single? RatingValue
        {
            get => GetLocalPropertyAsSingle("rating:value");
            set => SetLocalProperty("rating:value", value);
        }

        #endregion RatingValue

        #region RatingScale

        /// <summary>
        /// Gets or sets a rating scale.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? RatingScale
        {
            get => GetLocalPropertyAsInt32("rating:scale");
            set => SetLocalProperty("rating:scale", value);
        }

        #endregion RatingScale

        #region ReleaseDate

        /// <summary>
        /// Gets or sets a release date.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

        #endregion ReleaseDate

        #region Sample

        /// <summary>
        /// Gets or sets a sample.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Sample
        {
            get => GetLocalProperty("sample");
            set => SetLocalProperty("sample", value);
        }

        #endregion Sample

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "author", out matched, skipCompareProperty: true))
            {
                return new Profile(Path + "author");
            }
            if (property.StartsWith(Path, "genre", out matched, skipCompareProperty: true))
            {
                return new BookGenre(Path + "genre");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class BookGenre
    {
        #region CanonicalName

        /// <summary>
        /// Gets or sets a canonical name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CanonicalName
        {
            get => GetLocalProperty("canonical_name");
            set => SetLocalProperty("canonical_name", value);
        }

        #endregion CanonicalName

    }
    partial class AndroidApplink
    {
        #region Package

        /// <summary>
        /// Gets or sets a package.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Package
        {
            get => GetLocalProperty("package");
            set => SetLocalProperty("package", value);
        }

        #endregion Package

        #region AppName

        /// <summary>
        /// Gets or sets an app name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AppName
        {
            get => GetLocalProperty("app_name");
            set => SetLocalProperty("app_name", value);
        }

        #endregion AppName

        #region Class

        /// <summary>
        /// Gets or sets a class.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Class
        {
            get => GetLocalProperty("class");
            set => SetLocalProperty("class", value);
        }

        #endregion Class

    }
    partial class IosApplink
    {
        #region AppStoreId

        /// <summary>
        /// Gets or sets an app store id.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? AppStoreId
        {
            get => GetLocalPropertyAsInt32("app_store_id");
            set => SetLocalProperty("app_store_id", value);
        }

        #endregion AppStoreId

        #region AppName

        /// <summary>
        /// Gets or sets an app name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AppName
        {
            get => GetLocalProperty("app_name");
            set => SetLocalProperty("app_name", value);
        }

        #endregion AppName

    }
    partial class Weblink
    {
        #region ShouldFallback

        /// <summary>
        /// Gets or sets a should fallback.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? ShouldFallback
        {
            get => GetLocalPropertyAsBoolean("should_fallback");
            set => SetLocalProperty("should_fallback", value);
        }

        #endregion ShouldFallback

    }
    partial class WindowsApplink
    {
        #region PackageFamilyName

        /// <summary>
        /// Gets or sets a package family name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PackageFamilyName
        {
            get => GetLocalProperty("package_family_name");
            set => SetLocalProperty("package_family_name", value);
        }

        #endregion PackageFamilyName

        #region AppId

        /// <summary>
        /// Gets or sets an app id.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AppId
        {
            get => GetLocalProperty("app_id");
            set => SetLocalProperty("app_id", value);
        }

        #endregion AppId

        #region AppName

        /// <summary>
        /// Gets or sets an app name.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AppName
        {
            get => GetLocalProperty("app_name");
            set => SetLocalProperty("app_name", value);
        }

        #endregion AppName

    }
    partial class Business
    {
        #region ContactData

        /// <summary>
        /// Gets or sets a contact data.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ContactData ContactData
        {
            get => ContactDatas.FirstOrDefault();
            set => ContactDatas.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all contact datas.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<ContactData> ContactDatas
        {
            get => new GraphObjectPartialCollection<ContactData>(this, "contact_data");
            set => ContactDatas.Set(value);
        }

        #endregion ContactData

        #region Hour

        /// <summary>
        /// Gets or sets a hour.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BusinessHour Hour
        {
            get => Hours.FirstOrDefault();
            set => Hours.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all hours.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<BusinessHour> Hours
        {
            get => new GraphObjectPartialCollection<BusinessHour>(this, "hour");
            set => Hours.Set(value);
        }

        #endregion Hour

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "contact_data", out matched, skipCompareProperty: true))
            {
                return new ContactData(Path + "contact_data");
            }
            if (property.StartsWith(Path, "hour", out matched, skipCompareProperty: true))
            {
                return new BusinessHour(Path + "hour");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class BusinessHour
    {
        #region Day

        /// <summary>
        /// Gets or sets a day.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Day
        {
            get => GetLocalProperty("day");
            set => SetLocalProperty("day", value);
        }

        #endregion Day

        #region Start

        /// <summary>
        /// Gets or sets a start.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Start
        {
            get => GetLocalProperty("start");
            set => SetLocalProperty("start", value);
        }

        #endregion Start

        #region End

        /// <summary>
        /// Gets or sets an end.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string End
        {
            get => GetLocalProperty("end");
            set => SetLocalProperty("end", value);
        }

        #endregion End

    }
    partial class FitnessCourse
    {
        #region Calories

        /// <summary>
        /// Gets or sets a calories.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Calories
        {
            get => GetLocalPropertyAsInt32("calories");
            set => SetLocalProperty("calories", value);
        }

        #endregion Calories

        #region CustomUnitEnergy

        /// <summary>
        /// Gets or sets a custom unit energy.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity CustomUnitEnergy
        {
            get => CustomUnitEnergys.FirstOrDefault();
            set => CustomUnitEnergys.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all custom unit energys.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> CustomUnitEnergys
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "custom_unit_energy");
            set => CustomUnitEnergys.Set(value);
        }

        #endregion CustomUnitEnergy

        #region Distance

        /// <summary>
        /// Gets or sets a distance.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Distance
        {
            get => Distances.FirstOrDefault();
            set => Distances.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all distances.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Distances
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "distance");
            set => Distances.Set(value);
        }

        #endregion Distance

        #region Duration

        /// <summary>
        /// Gets or sets a duration.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Duration
        {
            get => Durations.FirstOrDefault();
            set => Durations.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all durations.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Durations
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "duration");
            set => Durations.Set(value);
        }

        #endregion Duration

        #region LiveText

        /// <summary>
        /// Gets or sets a live text.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LiveText
        {
            get => GetLocalProperty("live_text");
            set => SetLocalProperty("live_text", value);
        }

        #endregion LiveText

        #region Metric

        /// <summary>
        /// Gets or sets a metric.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FitnessActivityDataPoint Metric
        {
            get => Metrics.FirstOrDefault();
            set => Metrics.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all metrics.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<FitnessActivityDataPoint> Metrics
        {
            get => new GraphObjectPartialCollection<FitnessActivityDataPoint>(this, "metric");
            set => Metrics.Set(value);
        }

        #endregion Metric

        #region Pace

        /// <summary>
        /// Gets or sets a pace.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Pace
        {
            get => Paces.FirstOrDefault();
            set => Paces.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all paces.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Paces
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "pace");
            set => Paces.Set(value);
        }

        #endregion Pace

        #region Speed

        /// <summary>
        /// Gets or sets a speed.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Speed
        {
            get => Speeds.FirstOrDefault();
            set => Speeds.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all speeds.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Speeds
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "speed");
            set => Speeds.Set(value);
        }

        #endregion Speed

        #region Split

        /// <summary>
        /// Gets or sets a split.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FitnessSplits Split
        {
            get => Splits.FirstOrDefault();
            set => Splits.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all splits.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<FitnessSplits> Splits
        {
            get => new GraphObjectPartialCollection<FitnessSplits>(this, "split");
            set => Splits.Set(value);
        }

        #endregion Split

        #region Steps

        /// <summary>
        /// Gets or sets a steps.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete("Deprecated in Open Graph Protocol")]
        public Int32? Steps
        {
            get => GetLocalPropertyAsInt32("steps");
            set => SetLocalProperty("steps", value);
        }

        #endregion Steps

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "metric", out matched, skipCompareProperty: true))
            {
                return new FitnessActivityDataPoint(Path + "metric");
            }
            if (property.StartsWith(Path, "split", out matched, skipCompareProperty: true))
            {
                return new FitnessSplits(Path + "split");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class FitnessActivityDataPoint
    {
        #region Calories

        /// <summary>
        /// Gets or sets a calories.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Calories
        {
            get => GetLocalPropertyAsInt32("calories");
            set => SetLocalProperty("calories", value);
        }

        #endregion Calories

        #region CustomUnitEnergy

        /// <summary>
        /// Gets or sets a custom unit energy.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity CustomUnitEnergy
        {
            get => CustomUnitEnergys.FirstOrDefault();
            set => CustomUnitEnergys.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all custom unit energys.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> CustomUnitEnergys
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "custom_unit_energy");
            set => CustomUnitEnergys.Set(value);
        }

        #endregion CustomUnitEnergy

        #region Distance

        /// <summary>
        /// Gets or sets a distance.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Distance
        {
            get => Distances.FirstOrDefault();
            set => Distances.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all distances.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Distances
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "distance");
            set => Distances.Set(value);
        }

        #endregion Distance

        #region Location

        /// <summary>
        /// Gets or sets a location.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GeoPoint Location
        {
            get => Locations.FirstOrDefault();
            set => Locations.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all locations.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GeoPoint> Locations
        {
            get => new GraphObjectPartialCollection<GeoPoint>(this, "location");
            set => Locations.Set(value);
        }

        #endregion Location

        #region Steps

        /// <summary>
        /// Gets or sets a steps.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Steps
        {
            get => GetLocalPropertyAsInt32("steps");
            set => SetLocalProperty("steps", value);
        }

        #endregion Steps

        #region Speed

        /// <summary>
        /// Gets or sets a speed.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Speed
        {
            get => Speeds.FirstOrDefault();
            set => Speeds.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all speeds.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Speeds
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "speed");
            set => Speeds.Set(value);
        }

        #endregion Speed

        #region Timestamp

        /// <summary>
        /// Gets or sets a timestamp.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? Timestamp
        {
            get => GetLocalPropertyAsDateTime("timestamp");
            set => SetLocalProperty("timestamp", value);
        }

        #endregion Timestamp

        #region Pace

        /// <summary>
        /// Gets or sets a pace.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Pace
        {
            get => Paces.FirstOrDefault();
            set => Paces.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all paces.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Paces
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "pace");
            set => Paces.Set(value);
        }

        #endregion Pace

    }
    partial class FitnessSplits
    {
        #region Unit

        /// <summary>
        /// Gets or sets an unit.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Unit
        {
            get => GetLocalProperty("unit");
            set => SetLocalProperty("unit", value);
        }

        #endregion Unit

        #region Value

        /// <summary>
        /// Gets or sets a value.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Value
        {
            get => Values.FirstOrDefault();
            set => Values.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all values.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Values
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "value");
            set => Values.Set(value);
        }

        #endregion Value

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "value", out matched, skipCompareProperty: true))
            {
                return new Quantity(Path + "value");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class GameAchievement
    {
        #region Points

        /// <summary>
        /// Gets or sets a points.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int32? Points
        {
            get => GetLocalPropertyAsInt32("points");
            set => SetLocalProperty("points", value);
        }

        #endregion Points

        #region Secret

        /// <summary>
        /// Gets or sets a secret.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? Secret
        {
            get => GetLocalPropertyAsBoolean("secret");
            set => SetLocalProperty("secret", value);
        }

        #endregion Secret

    }
    partial class Product
    {
        #region AgeGroup

        /// <summary>
        /// Gets or sets an age group.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AgeGroup
        {
            get => GetLocalProperty("age_group");
            set => SetLocalProperty("age_group", value);
        }

        #endregion AgeGroup

        #region Availability

        /// <summary>
        /// Gets or sets an availability.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Availability
        {
            get => GetLocalProperty("availability");
            set => SetLocalProperty("availability", value);
        }

        #endregion Availability

        #region Brand

        /// <summary>
        /// Gets or sets a brand.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Brand
        {
            get => GetLocalProperty("brand");
            set => SetLocalProperty("brand", value);
        }

        #endregion Brand

        #region Category

        /// <summary>
        /// Gets or sets a category.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Category
        {
            get => GetLocalProperty("category");
            set => SetLocalProperty("category", value);
        }

        #endregion Category

        #region Color

        /// <summary>
        /// Gets or sets a color.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Color
        {
            get => GetLocalProperty("color");
            set => SetLocalProperty("color", value);
        }

        #endregion Color

        #region Condition

        /// <summary>
        /// Gets or sets a condition.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Condition
        {
            get => GetLocalProperty("condition");
            set => SetLocalProperty("condition", value);
        }

        #endregion Condition

        #region EAN

        /// <summary>
        /// Gets or sets an e a n.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EAN
        {
            get => GetLocalProperty("ean");
            set => SetLocalProperty("ean", value);
        }

        #endregion EAN

        #region ExpirationTime

        /// <summary>
        /// Gets or sets an expiration time.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime? ExpirationTime
        {
            get => GetLocalPropertyAsDateTime("expiration_time");
            set => SetLocalProperty("expiration_time", value);
        }

        #endregion ExpirationTime

        #region IsProductShareable

        /// <summary>
        /// Gets or sets an is product shareable.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? IsProductShareable
        {
            get => GetLocalPropertyAsBoolean("is_product_shareable");
            set => SetLocalProperty("is_product_shareable", value);
        }

        #endregion IsProductShareable

        #region ISBN

        /// <summary>
        /// Gets or sets an i s b n.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ISBN
        {
            get => GetLocalProperty("isbn");
            set => SetLocalProperty("isbn", value);
        }

        #endregion ISBN

        #region Material

        /// <summary>
        /// Gets or sets a material.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Material
        {
            get => GetLocalProperty("material");
            set => SetLocalProperty("material", value);
        }

        #endregion Material

        #region ManufacturerPartNo

        /// <summary>
        /// Gets or sets a manufacturer part no.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManufacturerPartNo
        {
            get => GetLocalProperty("mfr_part_no");
            set => SetLocalProperty("mfr_part_no", value);
        }

        #endregion ManufacturerPartNo

        #region OriginalPrice

        /// <summary>
        /// Gets or sets an original price.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency OriginalPrice
        {
            get => OriginalPrices.FirstOrDefault();
            set => OriginalPrices.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all original prices.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> OriginalPrices
        {
            get => new GraphObjectPartialCollection<Currency>(this, "original_price");
            set => OriginalPrices.Set(value);
        }

        #endregion OriginalPrice

        #region Pattern

        /// <summary>
        /// Gets or sets a pattern.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Pattern
        {
            get => GetLocalProperty("pattern");
            set => SetLocalProperty("pattern", value);
        }

        #endregion Pattern

        #region PluralTitle

        /// <summary>
        /// Gets or sets a plural title.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PluralTitle
        {
            get => GetLocalProperty("plural_title");
            set => SetLocalProperty("plural_title", value);
        }

        #endregion PluralTitle

        #region PretaxPrice

        /// <summary>
        /// Gets or sets a pretax price.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency PretaxPrice
        {
            get => PretaxPrices.FirstOrDefault();
            set => PretaxPrices.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all pretax prices.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> PretaxPrices
        {
            get => new GraphObjectPartialCollection<Currency>(this, "pretax_price");
            set => PretaxPrices.Set(value);
        }

        #endregion PretaxPrice

        #region Price

        /// <summary>
        /// Gets or sets a price.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency Price
        {
            get => Prices.FirstOrDefault();
            set => Prices.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all prices.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> Prices
        {
            get => new GraphObjectPartialCollection<Currency>(this, "price");
            set => Prices.Set(value);
        }

        #endregion Price

        #region ProductLink

        /// <summary>
        /// Gets or sets a product link.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProductLink
        {
            get => GetLocalProperty("product_link");
            set => SetLocalProperty("product_link", value);
        }

        #endregion ProductLink

        #region PurchaseLimit

        /// <summary>
        /// Gets or sets a purchase limit.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Int64? PurchaseLimit
        {
            get => GetLocalPropertyAsInt64("purchase_limit");
            set => SetLocalProperty("purchase_limit", value);
        }

        #endregion PurchaseLimit

        #region Retailer

        /// <summary>
        /// Gets or sets a retailer.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Retailer
        {
            get => Retailers.FirstOrDefault();
            set => Retailers.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all retailers.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Retailers
        {
            get => new GraphObjectPartialCollection<Profile>(this, "retailer");
            set => Retailers.Set(value);
        }

        #endregion Retailer

        #region RetailerCategory

        /// <summary>
        /// Gets or sets a retailer category.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RetailerCategory
        {
            get => GetLocalProperty("retailer_category");
            set => SetLocalProperty("retailer_category", value);
        }

        #endregion RetailerCategory

        #region RetailerPartNo

        /// <summary>
        /// Gets or sets a retailer part no.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RetailerPartNo
        {
            get => GetLocalProperty("retailer_part_no");
            set => SetLocalProperty("retailer_part_no", value);
        }

        #endregion RetailerPartNo

        #region RetailerTitle

        /// <summary>
        /// Gets or sets a retailer title.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RetailerTitle
        {
            get => GetLocalProperty("retailer_title");
            set => SetLocalProperty("retailer_title", value);
        }

        #endregion RetailerTitle

        #region SalePrice

        /// <summary>
        /// Gets or sets a sale price.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency SalePrice
        {
            get => SalePrices.FirstOrDefault();
            set => SalePrices.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all sale prices.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> SalePrices
        {
            get => new GraphObjectPartialCollection<Currency>(this, "sale_price");
            set => SalePrices.Set(value);
        }

        #endregion SalePrice

        #region SalePriceDates

        /// <summary>
        /// Gets or sets a sale price dates.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency SalePriceDates
        {
            get => AllSalePriceDates.FirstOrDefault();
            set => AllSalePriceDates.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all all sale price dates.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> AllSalePriceDates
        {
            get => new GraphObjectPartialCollection<Currency>(this, "sale_price_dates");
            set => AllSalePriceDates.Set(value);
        }

        #endregion SalePriceDates

        #region ShippingCost

        /// <summary>
        /// Gets or sets a shipping cost.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Currency ShippingCost
        {
            get => ShippingCosts.FirstOrDefault();
            set => ShippingCosts.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all shipping costs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Currency> ShippingCosts
        {
            get => new GraphObjectPartialCollection<Currency>(this, "shipping_cost");
            set => ShippingCosts.Set(value);
        }

        #endregion ShippingCost

        #region ShippingWeight

        /// <summary>
        /// Gets or sets a shipping weight.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity ShippingWeight
        {
            get => ShippingWeights.FirstOrDefault();
            set => ShippingWeights.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all shipping weights.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> ShippingWeights
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "shipping_weight");
            set => ShippingWeights.Set(value);
        }

        #endregion ShippingWeight

        #region Size

        /// <summary>
        /// Gets or sets a size.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Size
        {
            get => GetLocalProperty("size");
            set => SetLocalProperty("size", value);
        }

        #endregion Size

        #region TargetGender

        /// <summary>
        /// Gets or sets a target gender.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TargetGender
        {
            get => GetLocalProperty("target_gender");
            set => SetLocalProperty("target_gender", value);
        }

        #endregion TargetGender

        #region UniversalProductCode

        /// <summary>
        /// Gets or sets an universal product code.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UniversalProductCode
        {
            get => GetLocalProperty("upc");
            set => SetLocalProperty("upc", value);
        }

        #endregion UniversalProductCode

        #region Weight

        /// <summary>
        /// Gets or sets a weight.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Quantity Weight
        {
            get => Weights.FirstOrDefault();
            set => Weights.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all weights.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Quantity> Weights
        {
            get => new GraphObjectPartialCollection<Quantity>(this, "weight");
            set => Weights.Set(value);
        }

        #endregion Weight

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(PropertyPath property, out bool matched)
        {
            if (property.StartsWith(Path, "original_price", out matched, skipCompareProperty: true))
            {
                return new Currency(Path + "original_price");
            }
            if (property.StartsWith(Path, "pretax_price", out matched, skipCompareProperty: true))
            {
                return new Currency(Path + "pretax_price");
            }
            if (property.StartsWith(Path, "price", out matched, skipCompareProperty: true))
            {
                return new Currency(Path + "price");
            }
            if (property.StartsWith(Path, "shipping_cost", out matched, skipCompareProperty: true))
            {
                return new Currency(Path + "shipping_cost");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class ProductGroup
    {
        #region RetailerGroupId

        /// <summary>
        /// Gets or sets a retailer group id.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RetailerGroupId
        {
            get => GetLocalProperty("retailer_group_id");
            set => SetLocalProperty("retailer_group_id", value);
        }

        #endregion RetailerGroupId

    }
}