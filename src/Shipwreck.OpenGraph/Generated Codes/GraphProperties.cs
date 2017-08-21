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
        public string FacebookAppId
        {
            get => GetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "app_id"));
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
        public string FacebookProfileId
        {
            get => GetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "profile_id"));
            set => SetLocalProperty(new PropertyPath(NamespaceCollection.Facebook, "profile_id"), value);
        }

        #endregion FacebookProfileId

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
            return base.CreateNewChild(property, out matched);
        }

        #region TypeObject

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicSong" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong MusicSong
        {
            get => _TypeObject as MusicSong;
            set => TypeObject = value ?? (_TypeObject is MusicSong ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicAlbum" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicAlbum MusicAlbum
        {
            get => _TypeObject as MusicAlbum;
            set => TypeObject = value ?? (_TypeObject is MusicAlbum ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicPlaylist" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicPlaylist MusicPlaylist
        {
            get => _TypeObject as MusicPlaylist;
            set => TypeObject = value ?? (_TypeObject is MusicPlaylist ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicRadioStation" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicRadioStation MusicRadioStation
        {
            get => _TypeObject as MusicRadioStation;
            set => TypeObject = value ?? (_TypeObject is MusicRadioStation ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoMovie" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoMovie VideoMovie
        {
            get => _TypeObject as VideoMovie;
            set => TypeObject = value ?? (_TypeObject is VideoMovie ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoEpisode" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoEpisode VideoEpisode
        {
            get => _TypeObject as VideoEpisode;
            set => TypeObject = value ?? (_TypeObject is VideoEpisode ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoTVShow" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoTVShow VideoTVShow
        {
            get => _TypeObject as VideoTVShow;
            set => TypeObject = value ?? (_TypeObject is VideoTVShow ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoOther" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoOther VideoOther
        {
            get => _TypeObject as VideoOther;
            set => TypeObject = value ?? (_TypeObject is VideoOther ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Article" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Article Article
        {
            get => _TypeObject as Article;
            set => TypeObject = value ?? (_TypeObject is Article ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Book" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Book Book
        {
            get => _TypeObject as Book;
            set => TypeObject = value ?? (_TypeObject is Book ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.BookGenre" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookGenre BookGenre
        {
            get => _TypeObject as BookGenre;
            set => TypeObject = value ?? (_TypeObject is BookGenre ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Profile" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Profile
        {
            get => _TypeObject as Profile;
            set => TypeObject = value ?? (_TypeObject is Profile ? null : _TypeObject);
        }


        #endregion TypeObject
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
}