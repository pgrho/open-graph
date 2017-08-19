using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Title
        {
            get => GetLocalProperty("title");
            set => SetLocalProperty("title", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Type
        {
            get => GetLocalProperty("type");
            set => SetLocalProperty("type", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Url
        {
            get => GetLocalProperty("url");
            set => SetLocalProperty("url", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Description
        {
            get => GetLocalProperty("description");
            set => SetLocalProperty("description", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Determiner
        {
            get => GetLocalProperty("determiner");
            set => SetLocalProperty("determiner", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Locale
        {
            get => GetLocalProperty("locale");
            set => SetLocalProperty("locale", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string SiteName
        {
            get => GetLocalProperty("site_name");
            set => SetLocalProperty("site_name", value);
        }

#region AlternateLocale

        public string AlternateLocale
        {
            get => GetLocalProperty("locale:alternate");
            set => SetLocalProperty("locale:alternate", value);
        }

        public IList<string> AlternateLocales
        {
            get => new GraphObjectPropertyCollection(this, "locale:alternate");
        }

#endregion AlternateLocale

#region Image

        public GraphImage Image
        {
            get => Images?.FirstOrDefault();
        }

        public IList<GraphImage> Images
        {
            get => new GraphObjectChildCollection<GraphImage>(this, "image");
        }

#endregion Image

#region Video

        public GraphVideo Video
        {
            get => Videos?.FirstOrDefault();
        }

        public IList<GraphVideo> Videos
        {
            get => new GraphObjectChildCollection<GraphVideo>(this, "video");
        }

#endregion Video

#region Audio

        public GraphAudio Audio
        {
            get => Audios?.FirstOrDefault();
        }

        public IList<GraphAudio> Audios
        {
            get => new GraphObjectChildCollection<GraphAudio>(this, "audio");
        }

#endregion Audio

    }
    partial class MusicSong
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

#region Album

        public MusicSongAlbum Album
        {
            get => Albums?.FirstOrDefault();
        }

        public IList<MusicSongAlbum> Albums
        {
            get => new GraphObjectChildCollection<MusicSongAlbum>(this, "album");
        }

#endregion Album

#region Musician

        public Profile Musician
        {
            get => Musicians?.FirstOrDefault();
        }

        public IList<Profile> Musicians
        {
            get => new GraphObjectChildCollection<Profile>(this, "musician");
        }

#endregion Musician

    }
    partial class MusicAlbum
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

#region Song

        public MusicAlbumSong Song
        {
            get => Songs?.FirstOrDefault();
        }

        public IList<MusicAlbumSong> Songs
        {
            get => new GraphObjectChildCollection<MusicAlbumSong>(this, "song");
        }

#endregion Song

#region Musician

        public Profile Musician
        {
            get => Musicians?.FirstOrDefault();
        }

        public IList<Profile> Musicians
        {
            get => new GraphObjectChildCollection<Profile>(this, "musician");
        }

#endregion Musician

    }
    partial class MusicPlaylist
    {
#region Song

        public MusicAlbumSong Song
        {
            get => Songs?.FirstOrDefault();
        }

        public IList<MusicAlbumSong> Songs
        {
            get => new GraphObjectChildCollection<MusicAlbumSong>(this, "song");
        }

#endregion Song

#region Creator

        public Profile Creator
        {
            get => Creators?.FirstOrDefault();
        }

        public IList<Profile> Creators
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator");
        }

#endregion Creator

    }
    partial class MusicRadioStation
    {
#region Creator

        public Profile Creator
        {
            get => Creators?.FirstOrDefault();
        }

        public IList<Profile> Creators
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator");
        }

#endregion Creator

    }
    partial class VideoObject
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Duration
        {
            get => GetLocalPropertyAsInt32("duration");
            set => SetLocalProperty("duration", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

#region Actor

        public Actor Actor
        {
            get => Actors?.FirstOrDefault();
        }

        public IList<Actor> Actors
        {
            get => new GraphObjectChildCollection<Actor>(this, "actor");
        }

#endregion Actor

#region Director

        public Profile Director
        {
            get => Directors?.FirstOrDefault();
        }

        public IList<Profile> Directors
        {
            get => new GraphObjectChildCollection<Profile>(this, "director");
        }

#endregion Director

#region Writer

        public Profile Writer
        {
            get => Writers?.FirstOrDefault();
        }

        public IList<Profile> Writers
        {
            get => new GraphObjectChildCollection<Profile>(this, "writer");
        }

#endregion Writer

#region Tag

        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        public IList<string> Tags
        {
            get => new GraphObjectPropertyCollection(this, "tag");
        }

#endregion Tag

    }
    partial class VideoEpisode
    {
#region Series

        public VideoTVShow Series
        {
            get => AllSeries?.FirstOrDefault();
        }

        public IList<VideoTVShow> AllSeries
        {
            get => new GraphObjectChildCollection<VideoTVShow>(this, "series");
        }

#endregion Series

    }
    partial class Article
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? PublishedTime
        {
            get => GetLocalPropertyAsDateTime("published_time");
            set => SetLocalProperty("published_time", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? ModifiedTime
        {
            get => GetLocalPropertyAsDateTime("modified_time");
            set => SetLocalProperty("modified_time", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? ExpirationTime
        {
            get => GetLocalPropertyAsDateTime("expiration_time");
            set => SetLocalProperty("expiration_time", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Section
        {
            get => GetLocalProperty("section");
            set => SetLocalProperty("section", value);
        }

#region Author

        public Profile Author
        {
            get => Authors?.FirstOrDefault();
        }

        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
        }

#endregion Author

#region Tag

        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        public IList<string> Tags
        {
            get => new GraphObjectPropertyCollection(this, "tag");
        }

#endregion Tag

    }
    partial class Book
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string ISBN
        {
            get => GetLocalProperty("isbn");
            set => SetLocalProperty("isbn", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public DateTime? ReleaseDate
        {
            get => GetLocalPropertyAsDateTime("release_date");
            set => SetLocalProperty("release_date", value);
        }

#region Author

        public Profile Author
        {
            get => Authors?.FirstOrDefault();
        }

        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
        }

#endregion Author

#region Tag

        public string Tag
        {
            get => GetLocalProperty("tag");
            set => SetLocalProperty("tag", value);
        }

        public IList<string> Tags
        {
            get => new GraphObjectPropertyCollection(this, "tag");
        }

#endregion Tag

    }
    partial class GraphAudio
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

    }
    partial class GraphImage
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Width
        {
            get => GetLocalPropertyAsInt32("width");
            set => SetLocalProperty("width", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Height
        {
            get => GetLocalPropertyAsInt32("height");
            set => SetLocalProperty("height", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Alt
        {
            get => GetLocalProperty("alt");
            set => SetLocalProperty("alt", value);
        }

    }
    partial class GraphVideo
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string SecureUrl
        {
            get => GetLocalProperty("secure_url");
            set => SetLocalProperty("secure_url", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Width
        {
            get => GetLocalPropertyAsInt32("width");
            set => SetLocalProperty("width", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Height
        {
            get => GetLocalPropertyAsInt32("height");
            set => SetLocalProperty("height", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Alt
        {
            get => GetLocalProperty("alt");
            set => SetLocalProperty("alt", value);
        }

    }
    partial class MusicAlbumSong
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Disc
        {
            get => GetLocalPropertyAsInt32("disc");
            set => SetLocalProperty("disc", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Track
        {
            get => GetLocalPropertyAsInt32("track");
            set => SetLocalProperty("track", value);
        }

    }
    partial class MusicSongAlbum
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Disc
        {
            get => GetLocalPropertyAsInt32("disc");
            set => SetLocalProperty("disc", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public Int32? Track
        {
            get => GetLocalPropertyAsInt32("track");
            set => SetLocalProperty("track", value);
        }

    }
    partial class Actor
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Role
        {
            get => GetLocalProperty("role");
            set => SetLocalProperty("role", value);
        }

    }
    partial class Profile
    {
        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string FirstName
        {
            get => GetLocalProperty("first_name");
            set => SetLocalProperty("first_name", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string LastName
        {
            get => GetLocalProperty("last_name");
            set => SetLocalProperty("last_name", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string UserName
        {
            get => GetLocalProperty("username");
            set => SetLocalProperty("username", value);
        }

        [DefaultValue(null)]
#if !NETSTANDARD1_3
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
#endif
        public string Gender
        {
            get => GetLocalProperty("gender");
            set => SetLocalProperty("gender", value);
        }

    }
    partial class Graph
    {
        [DefaultValue(null)]
        public MusicSong MusicSong
        {
            get => _TypeObject as MusicSong;
            set => _TypeObject = value ?? (_TypeObject is MusicSong ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public MusicAlbum MusicAlbum
        {
            get => _TypeObject as MusicAlbum;
            set => _TypeObject = value ?? (_TypeObject is MusicAlbum ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public MusicPlaylist MusicPlaylist
        {
            get => _TypeObject as MusicPlaylist;
            set => _TypeObject = value ?? (_TypeObject is MusicPlaylist ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public MusicRadioStation MusicRadioStation
        {
            get => _TypeObject as MusicRadioStation;
            set => _TypeObject = value ?? (_TypeObject is MusicRadioStation ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public VideoMovie VideoMovie
        {
            get => _TypeObject as VideoMovie;
            set => _TypeObject = value ?? (_TypeObject is VideoMovie ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public VideoEpisode VideoEpisode
        {
            get => _TypeObject as VideoEpisode;
            set => _TypeObject = value ?? (_TypeObject is VideoEpisode ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public VideoTVShow VideoTVShow
        {
            get => _TypeObject as VideoTVShow;
            set => _TypeObject = value ?? (_TypeObject is VideoTVShow ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public VideoOther VideoOther
        {
            get => _TypeObject as VideoOther;
            set => _TypeObject = value ?? (_TypeObject is VideoOther ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public Article Article
        {
            get => _TypeObject as Article;
            set => _TypeObject = value ?? (_TypeObject is Article ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public Book Book
        {
            get => _TypeObject as Book;
            set => _TypeObject = value ?? (_TypeObject is Book ? null : _TypeObject);
        }

        [DefaultValue(null)]
        public Profile Profile
        {
            get => _TypeObject as Profile;
            set => _TypeObject = value ?? (_TypeObject is Profile ? null : _TypeObject);
        }

    }
}