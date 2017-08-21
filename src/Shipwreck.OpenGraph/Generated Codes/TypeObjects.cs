using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    partial class Graph : GraphObject
    {
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
}