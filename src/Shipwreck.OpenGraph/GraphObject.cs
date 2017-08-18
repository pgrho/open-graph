using System.ComponentModel;

namespace Shipwreck.OpenGraph
{
    public abstract partial class GraphObject
    {
        internal GraphObject(string path)
        {
            Path = path;
        }

        internal string Path { get; }

        [DefaultValue(null)]
        public string Title { get; set; }

        [DefaultValue(null)]
        public string Url { get; set; }

        [DefaultValue(null)]
        public string Description { get; set; }

        [DefaultValue(null)]
        public string Determiner { get; set; }

        [DefaultValue(null)]
        public string Locale { get; set; }

        [DefaultValue(null)]
        public string SiteName { get; set; }

        internal virtual bool TryAddMetadata(string property, string content, out GraphObject child)
        {
            if (!property.MachesPath(Path))
            {
                child = null;
                return false;
            }

            if (property.StartsWithChildPath(Path, "image"))
            {
                var img = new GraphImage(Path + ":image");
                Images.Add(img);
                if (property.Length == Path.Length + 6)
                {
                    img.Url = content;
                    child = img;
                }
                else
                {
                    img.TryAddMetadata(property, content, out child);
                    child = child ?? img;
                }
                return true;
            }
            else if (property.StartsWithChildPath(Path, "audio"))
            {
                var audio = new GraphAudio(Path + ":audio");
                Audios.Add(audio);
                if (property.Length == Path.Length + 6)
                {
                    audio.Url = content;
                    child = audio;
                }
                else
                {
                    audio.TryAddMetadata(property, content, out child);
                                        child = child ?? audio;
                }
                return true;
            }
            else if (property.StartsWithChildPath(Path, "video"))
            {
                var video = new GraphVideo(Path + ":video");
                Videos.Add(video);
                if (property.Length == Path.Length + 6)
                {
                    video.Url = content;
                    child = video;
                }
                else
                {
                    video.TryAddMetadata(property, content, out child);
                    child = child ?? video;
                }
                return true;
            }

            child = null;
            if (property.MachesChildPath(Path, "title"))
            {
                if (Title == null)
                {
                    Title = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "description"))
            {
                if (Description == null)
                {
                    Description = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "determiner"))
            {
                if (Determiner == null)
                {
                    Determiner = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "url"))
            {
                if (Url == null)
                {
                    Url = content;
                    return true;
                }
                return false;
            }
            else if (property.MachesChildPath(Path, "locale"))
            {
                if (Locale == null)
                {
                    Locale = content;
                }

                return true;
            }
            else if (property.MachesChildPath(Path, "locale:alternate"))
            {
                AlternateLocales.Add(content);

                return true;
            }
            else if (property.MachesChildPath(Path, "site_name"))
            {
                if (SiteName == null)
                {
                    SiteName = content;
                }

                return true;
            }
            return false;
        }
    }
}