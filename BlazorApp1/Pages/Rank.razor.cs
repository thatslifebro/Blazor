namespace BlazorApp1.Pages
{
    public class RankResponse
    {
        public int result { get; set; }
        public List<RankInfo> rankingData { get; set; }
    }

    public class RankInfo
    {
        public int rank { get; set; }
        public int uid { get; set; }
        public int score { get; set; }
    }
}
