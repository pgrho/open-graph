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
        /// Gets or sets a rich attachment.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Boolean? RichAttachment
        {
            get => GetLocalPropertyAsBoolean("rich_attachment");
            set => SetLocalProperty("rich_attachment", value);
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
            get => Images.FirstOrDefault();
            set => Images.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all images.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<GraphImage> Images
        {
            get => new GraphObjectChildCollection<GraphImage>(this, "image");
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
            get => new GraphObjectChildCollection<GraphVideo>(this, "video");
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
            get => new GraphObjectChildCollection<GraphAudio>(this, "audio");
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
            get => new GraphObjectChildCollection<GraphRestriction>(this, "restrictions");
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
            get => new GraphObjectPropertyCollection(this, "see_also");
            set => SetLocalProperty("see_also", value);
        }

        #endregion SeeAlso

        /// <inheritdoc />
        internal virtual GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "image", out matched))
            {
                return new GraphImage(Path + ":image");
            }
            if (property.StartsWithChildPath(Path, "video", out matched))
            {
                return new GraphVideo(Path + ":video");
            }
            if (property.StartsWithChildPath(Path, "audio", out matched))
            {
                return new GraphAudio(Path + ":audio");
            }
            if (property.StartsWithChildPath(Path, "restrictions", out matched))
            {
                return new GraphRestriction(Path + ":restrictions");
            }
            return null;
        }
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
    partial class GraphRestriction
    {
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
            get => new GraphObjectPropertyCollection(this, "country:allowed");
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
            get => new GraphObjectPropertyCollection(this, "country:disallowed");
            set => SetLocalProperty("country:disallowed", value);
        }

        #endregion DisallowedContry

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
            get => new GraphObjectPropertyCollection(this, "content");
            set => SetLocalProperty("content", value);
        }

        #endregion Content

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
        /// Gets or sets ISRC.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ISRC
        {
            get => GetLocalProperty("isrc");
            set => SetLocalProperty("isrc", value);
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
            get => Albums.FirstOrDefault();
            set => Albums.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all albums.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicAlbum> Albums
        {
            get => new GraphObjectChildCollection<MusicAlbum>(this, "album");
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
            get => new GraphObjectChildCollection<Profile>(this, "musician");
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
            get => new GraphObjectChildCollection<GraphAudio>(this, "preview_url");
            set => Previews.Set(value);
        }

        #endregion Preview

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
            if (property.StartsWithChildPath(Path, "preview_url", out matched))
            {
                return new GraphAudio(Path + ":preview_url");
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
        /// Gets or sets a release type.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ReleaseType
        {
            get => GetLocalProperty("release_type");
            set => SetLocalProperty("release_type", value);
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
            get => Songs.FirstOrDefault();
            set => Songs.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all songs.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<MusicSong> Songs
        {
            get => new GraphObjectChildCollection<MusicSong>(this, "song");
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
            get => new GraphObjectChildCollection<Profile>(this, "musician");
            set => Musicians.Set(value);
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
            get => new GraphObjectChildCollection<Profile>(this, "creator");
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
            get => new GraphObjectChildCollection<MusicSong>(this, "song");
            set => Songs.Set(value);
        }

        #endregion Song

        /// <inheritdoc />
        internal override GraphObject CreateNewChild(string property, out bool matched)
        {
            if (property.StartsWithChildPath(Path, "creator", out matched))
            {
                return new Profile(Path + ":creator");
            }
            if (property.StartsWithChildPath(Path, "song", out matched))
            {
                return new MusicSong(Path + ":song");
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
            get => new GraphObjectChildCollection<Profile>(this, "creator");
            set => Creators.Set(value);
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
            get => Actors.FirstOrDefault();
            set => Actors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all actors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Actors
        {
            get => new GraphObjectChildCollection<Profile>(this, "actor");
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
            get => new GraphObjectChildCollection<Profile>(this, "director");
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
            get => new GraphObjectChildCollection<Profile>(this, "writer");
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
            get => AllSeries.FirstOrDefault();
            set => AllSeries.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all series.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<VideoTVShow> AllSeries
        {
            get => new GraphObjectChildCollection<VideoTVShow>(this, "series");
            set => AllSeries.Set(value);
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
            get => Authors.FirstOrDefault();
            set => Authors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
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
            get => new GraphObjectChildCollection<Profile>(this, "publisher");
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
            get => Authors.FirstOrDefault();
            set => Authors.Set(value);
        }

        /// <summary>
        /// Gets or sets a list of all authors.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<Profile> Authors
        {
            get => new GraphObjectChildCollection<Profile>(this, "author");
            set => Authors.Set(value);
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
    partial class AndroidApplink
    {
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

    }
    partial class IosApplink
    {
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

    }
    partial class Weblink
    {
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

    }
    partial class WindowsApplink
    {
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