using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Shipwreck.OpenGraph
{
    public class GraphTest : GraphObjectTestBase
    {
        public GraphTest(ITestOutputHelper output)
            : base(output)
        {
        }

        #region Reference HTML

        [Fact]
        public void ReferenceSampleTest_Place()
            => TestXml(@"<html> <head prefix='og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# place: http://ogp.me/ns/place#'>
  <meta property='fb:app_id'                content='302184056577324' />
  <meta property='og:type'                  content='place' />
  <meta property='og:url'                   content='Put your own URL to the object here' />
  <meta property='og:title'                 content='Sample Place' />
  <meta property='og:image'                 content='https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png' />
  <meta property='place:location:latitude'  content='123.45' />
  <meta property='place:location:longitude' content='67.89' /> </head></html>",
                new Graph()
                {
                    FacebookAppId = 302184056577324L,
                    Type = "place",
                    Url = "Put your own URL to the object here",
                    Title = "Sample Place",
                    Image = new GraphImage()
                    {
                        Url = "https://s-static.ak.fbcdn.net/images/devsite/attachment_blank.png"
                    },
                    Location = new GeoPoint()
                    {
                        Latitude = 123.45f,
                        Longitude = 67.89f
                    }
                });

        #endregion Reference HTML

        #region Title

        [Fact]
        public void TitleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Title);
        }

        [Fact]
        public void TitlesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:title' content='The Rock' />
<meta property='og:title' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Title);
        }

        #endregion Title

        #region Type

        [Fact]
        public void TypeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Type);
        }

        [Fact]
        public void TypesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='The Rock' />
<meta property='og:type' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Type);
        }

        #endregion Type

        #region Url

        [Fact]
        public void UrlTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:url' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Url);
        }

        [Fact]
        public void UrlsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:url' content='The Rock' />
<meta property='og:url' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Url);
        }

        #endregion Url

        #region Description

        [Fact]
        public void DescriptionTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:description' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Description);
        }

        [Fact]
        public void DescriptionsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:description' content='The Rock' />
<meta property='og:description' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Description);
        }

        #endregion Description

        #region Determiner

        [Fact]
        public void DeterminerTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:determiner' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Determiner);
        }

        [Fact]
        public void DeterminersTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:determiner' content='The Rock' />
<meta property='og:determiner' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Determiner);
        }

        #endregion Determiner

        #region Locale

        [Fact]
        public void LocaleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Locale);
        }

        [Fact]
        public void LocalesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale' content='The Rock' />
<meta property='og:locale' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Locale);
        }

        #endregion Locale

        #region AlternateLocale

        [Fact]
        public void AlternateLocaleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale:alternate' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.AlternateLocale);
        }

        [Fact]
        public void AlternateLocalesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:locale:alternate' content='The Rock' />
<meta property='og:locale:alternate' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.AlternateLocale);
            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.AlternateLocales);
        }

        #endregion AlternateLocale

        #region SiteName

        [Fact]
        public void SiteNameTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:site_name' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.SiteName);
        }

        [Fact]
        public void SiteNamesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:site_name' content='The Rock' />
<meta property='og:site_name' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.SiteName);
        }

        #endregion SiteName

        #region Image

        [Fact]
        public void ImageTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock" }, target.Images?.Select(i => i.Url));
        }

        [Fact]
        public void ImagesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:image' content='The Rock' />
<meta property='og:image' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.Images?.Select(i => i.Url));
        }

        #endregion Image

        #region _TypeObject

        [Fact]
        public void ArticleTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='article' />
<meta property='article:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Article);
            Assert.Equal("The Rock", target.Article.Title);
        }

        #region books.*

        [Fact]
        public void BookTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='book' />
<meta property='book:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal("The Rock", target.Book.Title);
        }

        [Fact]
        public void BooksAuthorTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='books.author' />
<meta property='books:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.Profile.Title);
        }

        [Fact]
        public void BooksBookTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='books.book' />
<meta property='books:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Book);
            Assert.Equal("The Rock", target.Book.Title);
        }

        [Fact]
        public void BooksGenreTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='books.genre' />
<meta property='books:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.BookGenre.Title);
        }

        #endregion books.*

        #region music.*

        [Fact]
        public void MusicSongTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.song' />
<meta property='music:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal("The Rock", target.MusicSong.Title);
        }

        [Fact]
        public void MusicAlbumTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.album' />
<meta property='music:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicAlbum);
            Assert.Equal("The Rock", target.MusicAlbum.Title);
        }

        [Fact]
        public void MusicPlaylistTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.playlist' />
<meta property='music:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicPlaylist);
            Assert.Equal("The Rock", target.MusicPlaylist.Title);
        }

        [Fact]
        public void MusicRadioStationTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='music.radio_station' />
<meta property='music:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicRadioStation);
            Assert.Equal("The Rock", target.MusicRadioStation.Title);
        }

        #endregion music.*

        [Fact]
        public void ProfileTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='profile' />
<meta property='profile:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.Profile);
            Assert.Equal("The Rock", target.Profile.Title);
        }

        #region video.*

        [Fact]
        public void VideoMovieTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.movie' />
<meta property='video:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoMovie);
            Assert.Equal("The Rock", target.VideoMovie.Title);
        }

        [Fact]
        public void VideoEpisodeTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.episode' />
<meta property='video:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoEpisode);
            Assert.Equal("The Rock", target.VideoEpisode.Title);
        }

        [Fact]
        public void VideoTVShowTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.tv_show' />
<meta property='video:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoTVShow);
            Assert.Equal("The Rock", target.VideoTVShow.Title);
        }

        [Fact]
        public void VideoOtherTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='og:type' content='video.other' />
<meta property='video:title' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.VideoOther);
            Assert.Equal("The Rock", target.VideoOther.Title);
        }

        #endregion video.*

        [Fact]
        public void DelayedMusicSongTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='video:title' content='The piyo' />
<meta property='music:title' content='The Rock' />
<meta property='og:type' content='music.song' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.NotNull(target.MusicSong);
            Assert.Equal("The Rock", target.MusicSong.Title);
            Assert.Equal(2, target.LocalProperties.Count);
            Assert.Equal("The piyo", target.LocalProperties[0].Content);
        }

        #endregion _TypeObject

        #region Applink

        #region AndroidApp

        [Fact]
        public void AndroidAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:android' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.AndroidApp.Url);
        }

        [Fact]
        public void AndroidAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:android' content='The Rock' />
<meta property='al:android' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.AndroidApps.Select(a => a.Url));
        }

        #endregion AndroidApp

        #region IosApp

        [Fact]
        public void IosAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:ios' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.IosApp.Url);
        }

        [Fact]
        public void IosAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:ios' content='The Rock' />
<meta property='al:ios' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.IosApps.Select(a => a.Url));
        }

        #endregion IosApp

        #region IPadApp

        [Fact]
        public void IPadAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:ipad' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.IPadApp.Url);
        }

        [Fact]
        public void IPadAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:ipad' content='The Rock' />
<meta property='al:ipad' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.IPadApps.Select(a => a.Url));
        }

        #endregion IPadApp

        #region IPhoneApp

        [Fact]
        public void IPhoneAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:iphone' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.IPhoneApp.Url);
        }

        [Fact]
        public void IPhoneAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:iphone' content='The Rock' />
<meta property='al:iphone' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.IPhoneApps.Select(a => a.Url));
        }

        #endregion IPhoneApp

        #region WebApp

        [Fact]
        public void WebAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:web' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.WebApp.Url);
        }

        [Fact]
        public void WebAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:web' content='The Rock' />
<meta property='al:web' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.WebApps.Select(a => a.Url));
        }

        #endregion WebApp

        #region WindowsApp

        [Fact]
        public void WindowsAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.WindowsApp.Url);
        }

        [Fact]
        public void WindowsAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows' content='The Rock' />
<meta property='al:windows' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.WindowsApps.Select(a => a.Url));
        }

        #endregion WindowsApp

        #region WindowsPhoneApp

        [Fact]
        public void WindowsPhoneAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows_phone' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.WindowsPhoneApp.Url);
        }

        [Fact]
        public void WindowsPhoneAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows_phone' content='The Rock' />
<meta property='al:windows_phone' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.WindowsPhoneApps.Select(a => a.Url));
        }

        #endregion WindowsPhoneApp

        #region WindowsUniversalApp

        [Fact]
        public void WindowsUniversalAppTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows_universal' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.WindowsUniversalApp.Url);
        }

        [Fact]
        public void WindowsUniversalAppsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='al:windows_universal' content='The Rock' />
<meta property='al:windows_universal' content='The Rock 2' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(new[] { "The Rock", "The Rock 2" }, target.WindowsUniversalApps.Select(a => a.Url));
        }

        #endregion WindowsUniversalApp

        #endregion Applink

        #region fb:*

        #region FacebookAdmin

        [Fact]
        public void FacebookAdminTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:admins' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.FacebookAdmin);
        }

        [Fact]
        public void FacebookAdminsTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:admins' content='The Rock' />
<meta property='fb:admins' content='puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.FacebookAdmin);
            Assert.Equal(new[] { "The Rock", "puri" }, target.FacebookAdmins);
        }

        #endregion FacebookAdmin

        #region FacebookAppId

        [Fact]
        public void FacebookAppIdTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:app_id' content='1234567890' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(1234567890L, target.FacebookAppId);
        }

        #endregion FacebookAppId

        #region FacebookPage

        [Fact]
        public void FacebookPageTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:pages' content='The Rock' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.FacebookPage);
        }

        [Fact]
        public void FacebookPagesTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:pages' content='The Rock' />
<meta property='fb:pages' content='puri' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal("The Rock", target.FacebookPage);
            Assert.Equal(new[] { "The Rock", "puri" }, target.FacebookPages);
        }

        #endregion FacebookPage

        #region FacebookProfileId

        [Fact]
        public void FacebookProfileIdTest()
        {
            var html = @"<html prefix='og: http://ogp.me/ns#'>
<head>
<meta property='fb:profile_id' content='1234567890' />
</head>
</html>";

            var target = Graph.FromXml(html);

            Assert.Equal(1234567890L, target.FacebookProfileId);
        }

        #endregion FacebookProfileId

        #endregion fb:*

        #region GetPrefixAttribute

        [Fact]
        public void GetPrefixAttributeTest()
        {
            var g = new Graph();
            g.Type = "video.movie";
            g.Title = "hoge";

            g.IosApp = new IosApplink()
            {
                Url = "a"
            };

            g.VideoMovie = new VideoMovie()
            {
                Url = "aaa"
            };

            Assert.Equal($"og:{NamespaceCollection.OpenGraph} al:{NamespaceCollection.Applink} video:{NamespaceCollection.Video}", g.GetPrefixAttribute());
        }

        #endregion GetPrefixAttribute

        #region WriteTo

        [Fact]
        public void WriteToTest()
        {
            var g = new Graph();
            g.Type = "video.movie";
            g.Title = "hoge";

            g.IosApp = new IosApplink()
            {
                Url = "a"
            };

            g.Videos = new[]
            {
                new GraphVideo
                {
                    Url = "http://ani.tv",
                    Image = new GraphImage
                    {
                        Url = "kashikoma"
                    }
                }
            };

            g.VideoMovie = new VideoMovie()
            {
                Url = "aaa"
            };

            using (var sw = new StringWriter())
            {
                g.WriteTo(sw);

                var actual = sw.ToString();

                Assert.Equal("<meta property=\"og:type\" content=\"video.movie\" />"
                    + "<meta property=\"og:title\" content=\"hoge\" />"
                    + "<meta property=\"al:ios:url\" content=\"a\" />"
                    + "<meta property=\"og:video:url\" content=\"http://ani.tv\" />"
                    + "<meta property=\"og:video:image:url\" content=\"kashikoma\" />"
                    + "<meta property=\"video:url\" content=\"aaa\" />", actual);
            }
        }

        #endregion WriteTo
    }
}