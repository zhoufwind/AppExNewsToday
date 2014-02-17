using System;

namespace ConsoleApplication8
{
    public class Today
    {
        public Adsdata adsData { get; set; }
        public Cluster[] clusters { get; set; }
        public Lastmodified lastModified { get; set; }
        public int version { get; set; }
    }

    public class Adsdata
    {
        public Articlereaderad[] articleReaderAds { get; set; }
        public Clusterad[] clusterAds { get; set; }
        public Videoad[] videoAds { get; set; }
    }

    public class Articlereaderad
    {
        public object[] adTags { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Clusterad
    {
        public int adClusterPosition { get; set; }
        public Adunit adUnit { get; set; }
        public string clusterLevel { get; set; }
        public string EntityClusterId { get; set; }
    }

    public class Adunit
    {
        public object[] adTags { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Videoad
    {
        public string adProvider { get; set; }
        public int adRepeatFrequency { get; set; }
        public string adServer { get; set; }
        public int adStartFrequency { get; set; }
        public Adunit1 adUnit { get; set; }
    }

    public class Adunit1
    {
        public object[] adTags { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Lastmodified
    {
        public long utctime { get; set; }
    }

    public class Cluster
    {
        public Hero hero { get; set; }
        public Lastmodified1 lastModified { get; set; }
        public string type { get; set; }
        public Entitylist entityList { get; set; }
    }

    public class Hero
    {
        public Content content { get; set; }
        public string destination { get; set; }
        public Heroimage heroImage { get; set; }
    }

    public class Content
    {
        public string _abstract { get; set; }
        public string byline { get; set; }
        public string headline { get; set; }
        public Source source { get; set; }
    }

    public class Source
    {
        public string favicon { get; set; }
        public string name { get; set; }
    }

    public class Heroimage
    {
        public string anchorPoint { get; set; }
        public string headerFont { get; set; }
        public Image image { get; set; }
    }

    public class Image
    {
        public string altText { get; set; }
        public string attribution { get; set; }
        public string caption { get; set; }
        public Image1[] images { get; set; }
    }

    public class Image1
    {
        public int height { get; set; }
        public Herofocalpoint heroFocalPoint { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Herofocalpoint
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Lastmodified1
    {
        public long utctime { get; set; }
    }

    public class Entitylist
    {
        public string collectionId { get; set; }
        public Entity[] entities { get; set; }
        public string categoryName { get; set; }
        public string template { get; set; }
    }

    public class Entity
    {
        public Content1 content { get; set; }
        public string destination { get; set; }
        public Image2 image { get; set; }
        public string paywallState { get; set; }
        public string templateClass { get; set; }
    }

    public class Content1
    {
        public string _abstract { get; set; }
        public string byline { get; set; }
        public string headline { get; set; }
        public Publicationdate publicationDate { get; set; }
        public Source1 source { get; set; }
    }

    public class Publicationdate
    {
        public Published published { get; set; }
        public Updated updated { get; set; }
    }

    public class Published
    {
        public long utctime { get; set; }
    }

    public class Updated
    {
        public long utctime { get; set; }
    }

    public class Source1
    {
        public string favicon { get; set; }
        public string name { get; set; }
    }

    public class Image2
    {
        public string caption { get; set; }
        public Image3[] images { get; set; }
        public string altText { get; set; }
        public string attribution { get; set; }
    }

    public class Image3
    {
        public int height { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public Herofocalpoint1 heroFocalPoint { get; set; }
    }

    public class Herofocalpoint1
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
