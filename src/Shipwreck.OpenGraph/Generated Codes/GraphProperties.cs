using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
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

    }
    partial class VideoObject
    {
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
    partial class Article
    {
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