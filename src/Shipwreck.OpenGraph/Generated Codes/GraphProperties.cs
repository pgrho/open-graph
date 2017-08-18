using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
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

#region Audio

        private Collection<GraphAudio> _Audios;
        
        public GraphAudio Audio
        {
            get => _Audios?.FirstOrDefault() ?? default(GraphAudio);
            set => CollectionHelper.SetCollection(ref _Audios, value);
        }

        public Collection<GraphAudio> Audios
        {
            get => CollectionHelper.GetCollection(ref _Audios);
            set => CollectionHelper.SetCollection(ref _Audios, value);
        }

        public bool ShouldSerializeAudio()
            => false;

        public bool ShouldSerializeAudios()
            => _Audios?.Count > 0;

        public void ResetAudio()
            => _Audios?.Clear();

        public void ResetAudios()
            => _Audios?.Clear();

#endregion Audio

    }
    partial class MusicSong
    {
#region Album

        private Collection<MusicSongAlbum> _Albums;
        
        public MusicSongAlbum Album
        {
            get => _Albums?.FirstOrDefault() ?? default(MusicSongAlbum);
            set => CollectionHelper.SetCollection(ref _Albums, value);
        }

        public Collection<MusicSongAlbum> Albums
        {
            get => CollectionHelper.GetCollection(ref _Albums);
            set => CollectionHelper.SetCollection(ref _Albums, value);
        }

        public bool ShouldSerializeAlbum()
            => false;

        public bool ShouldSerializeAlbums()
            => _Albums?.Count > 0;

        public void ResetAlbum()
            => _Albums?.Clear();

        public void ResetAlbums()
            => _Albums?.Clear();

#endregion Album

#region Musician

        private Collection<Profile> _Musicians;
        
        public Profile Musician
        {
            get => _Musicians?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Musicians, value);
        }

        public Collection<Profile> Musicians
        {
            get => CollectionHelper.GetCollection(ref _Musicians);
            set => CollectionHelper.SetCollection(ref _Musicians, value);
        }

        public bool ShouldSerializeMusician()
            => false;

        public bool ShouldSerializeMusicians()
            => _Musicians?.Count > 0;

        public void ResetMusician()
            => _Musicians?.Clear();

        public void ResetMusicians()
            => _Musicians?.Clear();

#endregion Musician

    }
    partial class MusicAlbum
    {
#region Song

        private Collection<MusicAlbumSong> _Songs;
        
        public MusicAlbumSong Song
        {
            get => _Songs?.FirstOrDefault() ?? default(MusicAlbumSong);
            set => CollectionHelper.SetCollection(ref _Songs, value);
        }

        public Collection<MusicAlbumSong> Songs
        {
            get => CollectionHelper.GetCollection(ref _Songs);
            set => CollectionHelper.SetCollection(ref _Songs, value);
        }

        public bool ShouldSerializeSong()
            => false;

        public bool ShouldSerializeSongs()
            => _Songs?.Count > 0;

        public void ResetSong()
            => _Songs?.Clear();

        public void ResetSongs()
            => _Songs?.Clear();

#endregion Song

#region Musician

        private Collection<Profile> _Musicians;
        
        public Profile Musician
        {
            get => _Musicians?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Musicians, value);
        }

        public Collection<Profile> Musicians
        {
            get => CollectionHelper.GetCollection(ref _Musicians);
            set => CollectionHelper.SetCollection(ref _Musicians, value);
        }

        public bool ShouldSerializeMusician()
            => false;

        public bool ShouldSerializeMusicians()
            => _Musicians?.Count > 0;

        public void ResetMusician()
            => _Musicians?.Clear();

        public void ResetMusicians()
            => _Musicians?.Clear();

#endregion Musician

    }
    partial class MusicPlaylist
    {
#region Song

        private Collection<MusicAlbumSong> _Songs;
        
        public MusicAlbumSong Song
        {
            get => _Songs?.FirstOrDefault() ?? default(MusicAlbumSong);
            set => CollectionHelper.SetCollection(ref _Songs, value);
        }

        public Collection<MusicAlbumSong> Songs
        {
            get => CollectionHelper.GetCollection(ref _Songs);
            set => CollectionHelper.SetCollection(ref _Songs, value);
        }

        public bool ShouldSerializeSong()
            => false;

        public bool ShouldSerializeSongs()
            => _Songs?.Count > 0;

        public void ResetSong()
            => _Songs?.Clear();

        public void ResetSongs()
            => _Songs?.Clear();

#endregion Song

    }
    partial class VideoObject
    {
#region Actor

        private Collection<Actor> _Actors;
        
        public Actor Actor
        {
            get => _Actors?.FirstOrDefault() ?? default(Actor);
            set => CollectionHelper.SetCollection(ref _Actors, value);
        }

        public Collection<Actor> Actors
        {
            get => CollectionHelper.GetCollection(ref _Actors);
            set => CollectionHelper.SetCollection(ref _Actors, value);
        }

        public bool ShouldSerializeActor()
            => false;

        public bool ShouldSerializeActors()
            => _Actors?.Count > 0;

        public void ResetActor()
            => _Actors?.Clear();

        public void ResetActors()
            => _Actors?.Clear();

#endregion Actor

#region Director

        private Collection<Profile> _Directors;
        
        public Profile Director
        {
            get => _Directors?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Directors, value);
        }

        public Collection<Profile> Directors
        {
            get => CollectionHelper.GetCollection(ref _Directors);
            set => CollectionHelper.SetCollection(ref _Directors, value);
        }

        public bool ShouldSerializeDirector()
            => false;

        public bool ShouldSerializeDirectors()
            => _Directors?.Count > 0;

        public void ResetDirector()
            => _Directors?.Clear();

        public void ResetDirectors()
            => _Directors?.Clear();

#endregion Director

#region Writer

        private Collection<Profile> _Writers;
        
        public Profile Writer
        {
            get => _Writers?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Writers, value);
        }

        public Collection<Profile> Writers
        {
            get => CollectionHelper.GetCollection(ref _Writers);
            set => CollectionHelper.SetCollection(ref _Writers, value);
        }

        public bool ShouldSerializeWriter()
            => false;

        public bool ShouldSerializeWriters()
            => _Writers?.Count > 0;

        public void ResetWriter()
            => _Writers?.Clear();

        public void ResetWriters()
            => _Writers?.Clear();

#endregion Writer

#region Tag

        private Collection<System.String> _Tags;
        
        public System.String Tag
        {
            get => _Tags?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public Collection<System.String> Tags
        {
            get => CollectionHelper.GetCollection(ref _Tags);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public bool ShouldSerializeTag()
            => _Tags?.Count == 1;

        public bool ShouldSerializeTags()
            => _Tags?.Count > 1;

        public void ResetTag()
            => _Tags?.Clear();

        public void ResetTags()
            => _Tags?.Clear();

#endregion Tag

    }
    partial class Article
    {
#region Author

        private Collection<Profile> _Authors;
        
        public Profile Author
        {
            get => _Authors?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Authors, value);
        }

        public Collection<Profile> Authors
        {
            get => CollectionHelper.GetCollection(ref _Authors);
            set => CollectionHelper.SetCollection(ref _Authors, value);
        }

        public bool ShouldSerializeAuthor()
            => false;

        public bool ShouldSerializeAuthors()
            => _Authors?.Count > 0;

        public void ResetAuthor()
            => _Authors?.Clear();

        public void ResetAuthors()
            => _Authors?.Clear();

#endregion Author

#region Tag

        private Collection<System.String> _Tags;
        
        public System.String Tag
        {
            get => _Tags?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public Collection<System.String> Tags
        {
            get => CollectionHelper.GetCollection(ref _Tags);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public bool ShouldSerializeTag()
            => _Tags?.Count == 1;

        public bool ShouldSerializeTags()
            => _Tags?.Count > 1;

        public void ResetTag()
            => _Tags?.Clear();

        public void ResetTags()
            => _Tags?.Clear();

#endregion Tag

    }
    partial class Book
    {
#region Author

        private Collection<Profile> _Authors;
        
        public Profile Author
        {
            get => _Authors?.FirstOrDefault() ?? default(Profile);
            set => CollectionHelper.SetCollection(ref _Authors, value);
        }

        public Collection<Profile> Authors
        {
            get => CollectionHelper.GetCollection(ref _Authors);
            set => CollectionHelper.SetCollection(ref _Authors, value);
        }

        public bool ShouldSerializeAuthor()
            => false;

        public bool ShouldSerializeAuthors()
            => _Authors?.Count > 0;

        public void ResetAuthor()
            => _Authors?.Clear();

        public void ResetAuthors()
            => _Authors?.Clear();

#endregion Author

#region Tag

        private Collection<System.String> _Tags;
        
        public System.String Tag
        {
            get => _Tags?.FirstOrDefault() ?? default(System.String);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public Collection<System.String> Tags
        {
            get => CollectionHelper.GetCollection(ref _Tags);
            set => CollectionHelper.SetCollection(ref _Tags, value);
        }

        public bool ShouldSerializeTag()
            => _Tags?.Count == 1;

        public bool ShouldSerializeTags()
            => _Tags?.Count > 1;

        public void ResetTag()
            => _Tags?.Clear();

        public void ResetTags()
            => _Tags?.Clear();

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