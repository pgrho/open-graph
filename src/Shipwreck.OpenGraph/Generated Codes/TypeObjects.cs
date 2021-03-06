using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    partial class Graph : GraphObject
    {
        #region TypeObject

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
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Profile" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Profile Profile
        {
            get => _TypeObject as Profile;
            set => TypeObject = value ?? (_TypeObject is Profile ? null : _TypeObject);
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
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Product" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Product Product
        {
            get => _TypeObject as Product;
            set => TypeObject = value ?? (_TypeObject is Product ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.ProductGroup" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProductGroup ProductGroup
        {
            get => _TypeObject as ProductGroup;
            set => TypeObject = value ?? (_TypeObject is ProductGroup ? null : _TypeObject);
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
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.Business" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Business Business
        {
            get => _TypeObject as Business;
            set => TypeObject = value ?? (_TypeObject is Business ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.FitnessCourse" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FitnessCourse FitnessCourse
        {
            get => _TypeObject as FitnessCourse;
            set => TypeObject = value ?? (_TypeObject is FitnessCourse ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.GameAchievement" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GameAchievement GameAchievement
        {
            get => _TypeObject as GameAchievement;
            set => TypeObject = value ?? (_TypeObject is GameAchievement ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.RestaurantMenu" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RestaurantMenu RestaurantMenu
        {
            get => _TypeObject as RestaurantMenu;
            set => TypeObject = value ?? (_TypeObject is RestaurantMenu ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.RestaurantMenuItem" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RestaurantMenuItem RestaurantMenuItem
        {
            get => _TypeObject as RestaurantMenuItem;
            set => TypeObject = value ?? (_TypeObject is RestaurantMenuItem ? null : _TypeObject);
        }

        /// <summary>
        /// Gets or sets a value of <see cref="TypeObject" /> as <see cref="OpenGraph.RestaurantMenuSection" />.
        /// </summary>
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RestaurantMenuSection RestaurantMenuSection
        {
            get => _TypeObject as RestaurantMenuSection;
            set => TypeObject = value ?? (_TypeObject is RestaurantMenuSection ? null : _TypeObject);
        }

        private GraphObject CreateTypeObject()
        {
            switch (Type)
            {
                case "article":
                    return new Article(new PropertyPath(NamespaceCollection.Article));

                case "book":
                    return new Book(new PropertyPath(NamespaceCollection.Book));

                case "books.author":
                    return new Profile(new PropertyPath(NamespaceCollection.Books));

                case "books.book":
                    return new Book(new PropertyPath(NamespaceCollection.Books));

                case "books.genre":
                    return new BookGenre(new PropertyPath(NamespaceCollection.Books));

                case "music.song":
                    return new MusicSong(new PropertyPath(NamespaceCollection.Music));

                case "music.album":
                    return new MusicAlbum(new PropertyPath(NamespaceCollection.Music));

                case "music.playlist":
                    return new MusicPlaylist(new PropertyPath(NamespaceCollection.Music));

                case "music.radio_station":
                    return new MusicRadioStation(new PropertyPath(NamespaceCollection.Music));

                case "profile":
                    return new Profile(new PropertyPath(NamespaceCollection.Profile));

                case "product":
                    return new Product(new PropertyPath(NamespaceCollection.Product));

                case "product.group":
                    return new ProductGroup(new PropertyPath(NamespaceCollection.Product));

                case "product.item":
                    return new Product(new PropertyPath(NamespaceCollection.Product));

                case "video.movie":
                    return new VideoMovie(new PropertyPath(NamespaceCollection.Video));

                case "video.episode":
                    return new VideoEpisode(new PropertyPath(NamespaceCollection.Video));

                case "video.tv_show":
                    return new VideoTVShow(new PropertyPath(NamespaceCollection.Video));

                case "video.other":
                    return new VideoOther(new PropertyPath(NamespaceCollection.Video));

                case "business.business":
                    return new Business(new PropertyPath(NamespaceCollection.Business));

                case "fitness.course":
                    return new FitnessCourse(new PropertyPath(NamespaceCollection.Fitness));

                case "game.achievement":
                    return new GameAchievement(new PropertyPath(NamespaceCollection.Game));

                case "restaurant.menu":
                    return new RestaurantMenu(new PropertyPath(NamespaceCollection.Restaurant));

                case "restaurant.menu_item":
                    return new RestaurantMenuItem(new PropertyPath(NamespaceCollection.Restaurant));

                case "restaurant.menu_section":
                    return new RestaurantMenuSection(new PropertyPath(NamespaceCollection.Restaurant));

            }

            return null;
        }

        #endregion TypeObject
    }
}