using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
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
            get => new GraphObjectPropertyCollection(this, "locale:alternate");
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
            get => GetChild<GraphImage>("image");
            set => SetChild("image", value);
        }

        /// <summary>
        /// Gets or sets a list of all images.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphImage> Images
        {
            get => new GraphObjectChildCollection<GraphImage>(this, "image");
            set => SetChild<GraphImage>("image", value);
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
            get => GetChild<GraphVideo>("video");
            set => SetChild("video", value);
        }

        /// <summary>
        /// Gets or sets a list of all videos.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphVideo> Videos
        {
            get => new GraphObjectChildCollection<GraphVideo>(this, "video");
            set => SetChild<GraphVideo>("video", value);
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
            get => GetChild<GraphAudio>("audio");
            set => SetChild("audio", value);
        }

        /// <summary>
        /// Gets or sets a list of all audios.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphAudio> Audios
        {
            get => new GraphObjectChildCollection<GraphAudio>(this, "audio");
            set => SetChild<GraphAudio>("audio", value);
        }

        #endregion Audio

    }
    partial class GraphAudio
    {
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

    }
    partial class GraphImage
    {
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

    }
    partial class GraphVideo
    {
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

    }
    partial class MusicSong
    {
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

        #region Album

        /// <summary>
        /// Gets or sets an album.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicAlbum Album
        {
            get => GetChild<MusicAlbum>("album");
            set => SetChild("album", value);
        }

        /// <summary>
        /// Gets or sets a list of all albums.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicAlbum> Albums
        {
            get => new GraphObjectChildCollection<MusicAlbum>(this, "album");
            set => SetChild<MusicAlbum>("album", value);
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
            get => GetChild<Profile>("musician");
            set => SetChild("musician", value);
        }

        /// <summary>
        /// Gets or sets a list of all musicians.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Musicians
        {
            get => new GraphObjectChildCollection<Profile>(this, "musician");
            set => SetChild<Profile>("musician", value);
        }

        #endregion Musician

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "album", out matched))
            {
                return new MusicAlbum(Path + ":album");
            }
            if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                return new Profile(Path + ":musician");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class MusicAlbum
    {
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

        #region Song

        /// <summary>
        /// Gets or sets a song.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong Song
        {
            get => GetChild<MusicSong>("song");
            set => SetChild("song", value);
        }

        /// <summary>
        /// Gets or sets a list of all songs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicSong> Songs
        {
            get => new GraphObjectChildCollection<MusicSong>(this, "song");
            set => SetChild<MusicSong>("song", value);
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
            get => GetChild<Profile>("musician");
            set => SetChild("musician", value);
        }

        /// <summary>
        /// Gets or sets a list of all musicians.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Musicians
        {
            get => new GraphObjectChildCollection<Profile>(this, "musician");
            set => SetChild<Profile>("musician", value);
        }

        #endregion Musician

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                return new MusicSong(Path + ":song");
            }
            if (property.StartsWithChildPath(Path, "musician", out matched))
            {
                return new Profile(Path + ":musician");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class MusicPlaylist
    {
        #region Song

        /// <summary>
        /// Gets or sets a song.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong Song
        {
            get => GetChild<MusicSong>("song");
            set => SetChild("song", value);
        }

        /// <summary>
        /// Gets or sets a list of all songs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicSong> Songs
        {
            get => new GraphObjectChildCollection<MusicSong>(this, "song");
            set => SetChild<MusicSong>("song", value);
        }

        #endregion Song

        #region Creator

        /// <summary>
        /// Gets or sets a creator.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Creator
        {
            get => GetChild<Profile>("creator");
            set => SetChild("creator", value);
        }

        /// <summary>
        /// Gets or sets a list of all creators.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Creators
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator");
            set => SetChild<Profile>("creator", value);
        }

        #endregion Creator

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                return new MusicSong(Path + ":song");
            }
            if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                return new Profile(Path + ":creator");
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
            get => GetChild<Profile>("creator");
            set => SetChild("creator", value);
        }

        /// <summary>
        /// Gets or sets a list of all creators.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Creators
        {
            get => new GraphObjectChildCollection<Profile>(this, "creator");
            set => SetChild<Profile>("creator", value);
        }

        #endregion Creator

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                return new Profile(Path + ":creator");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class VideoObject
    {
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

        #region Actor

        /// <summary>
        /// Gets or sets an actor.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Actor
        {
            get => GetChild<Profile>("actor");
            set => SetChild("actor", value);
        }

        /// <summary>
        /// Gets or sets a list of all actors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Actors
        {
            get => new GraphObjectChildCollection<Profile>(this, "actor");
            set => SetChild<Profile>("actor", value);
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
            get => GetChild<Profile>("director");
            set => SetChild("director", value);
        }

        /// <summary>
        /// Gets or sets a list of all directors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Directors
        {
            get => new GraphObjectChildCollection<Profile>(this, "director");
            set => SetChild<Profile>("director", value);
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
            get => GetChild<Profile>("writer");
            set => SetChild("writer", value);
        }

        /// <summary>
        /// Gets or sets a list of all writers.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Writers
        {
            get => new GraphObjectChildCollection<Profile>(this, "writer");
            set => SetChild<Profile>("writer", value);
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
            get => new GraphObjectPropertyCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "actor", out matched))
            {
                return new Profile(Path + ":actor");
            }
            if (property.StartsWithChildPath(Path, "director", out matched))
            {
                return new Profile(Path + ":director");
            }
            if (property.StartsWithChildPath(Path, "writer", out matched))
            {
                return new Profile(Path + ":writer");
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
            get => GetChild<VideoTVShow>("series");
            set => SetChild("series", value);
        }

        /// <summary>
        /// Gets or sets a list of all series.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<VideoTVShow> AllSeries
        {
            get => new GraphObjectChildCollection<VideoTVShow>(this, "series");
            set => SetChild<VideoTVShow>("series", value);
        }

        #endregion Series

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "series", out matched))
            {
                return new VideoTVShow(Path + ":series");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Article
    {
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

        #region Author

        /// <summary>
        /// Gets or sets an author.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Author
        {
            get => GetChild<Profile>("author");
            set => SetChild("author", value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
            set => SetChild<Profile>("author", value);
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
            get => GetChild<Profile>("publisher");
            set => SetChild("publisher", value);
        }

        /// <summary>
        /// Gets or sets a list of all publishers.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Publishers
        {
            get => new GraphObjectChildCollection<Profile>(this, "publisher");
            set => SetChild<Profile>("publisher", value);
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
            get => new GraphObjectPropertyCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "author", out matched))
            {
                return new Profile(Path + ":author");
            }
            if (property.StartsWithChildPath(Path, "publisher", out matched))
            {
                return new Profile(Path + ":publisher");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Profile
    {
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

    }
    partial class Book
    {
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

        #region Author

        /// <summary>
        /// Gets or sets an author.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Author
        {
            get => GetChild<Profile>("author");
            set => SetChild("author", value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
            set => SetChild<Profile>("author", value);
        }

        #endregion Author

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
            get => new GraphObjectPropertyCollection(this, "tag");
            set => SetLocalProperty("tag", value);
        }

        #endregion Tag

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "author", out matched))
            {
                return new Profile(Path + ":author");
            }
            return base.CreateNewChild(property, out matched);
        }
    }
    partial class Graph
    {
        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicSong" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicSong MusicSong
        {
            get => _TypeObject as MusicSong;
            set => _TypeObject = value ?? (_TypeObject is MusicSong ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicAlbum" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicAlbum MusicAlbum
        {
            get => _TypeObject as MusicAlbum;
            set => _TypeObject = value ?? (_TypeObject is MusicAlbum ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicPlaylist" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicPlaylist MusicPlaylist
        {
            get => _TypeObject as MusicPlaylist;
            set => _TypeObject = value ?? (_TypeObject is MusicPlaylist ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.MusicRadioStation" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MusicRadioStation MusicRadioStation
        {
            get => _TypeObject as MusicRadioStation;
            set => _TypeObject = value ?? (_TypeObject is MusicRadioStation ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoMovie" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoMovie VideoMovie
        {
            get => _TypeObject as VideoMovie;
            set => _TypeObject = value ?? (_TypeObject is VideoMovie ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoEpisode" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoEpisode VideoEpisode
        {
            get => _TypeObject as VideoEpisode;
            set => _TypeObject = value ?? (_TypeObject is VideoEpisode ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoTVShow" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoTVShow VideoTVShow
        {
            get => _TypeObject as VideoTVShow;
            set => _TypeObject = value ?? (_TypeObject is VideoTVShow ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.VideoOther" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public VideoOther VideoOther
        {
            get => _TypeObject as VideoOther;
            set => _TypeObject = value ?? (_TypeObject is VideoOther ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Article" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Article Article
        {
            get => _TypeObject as Article;
            set => _TypeObject = value ?? (_TypeObject is Article ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Book" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Book Book
        {
            get => _TypeObject as Book;
            set => _TypeObject = value ?? (_TypeObject is Book ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Profile" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Profile
        {
            get => _TypeObject as Profile;
            set => _TypeObject = value ?? (_TypeObject is Profile ? null : _TypeObject);
        }

    }
}