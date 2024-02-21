using System.ComponentModel;

namespace BlazorApp1.Pages
{
    public class MailListResponse
    {
        public int result { get; set; }
        public List<MailData> mailList { get; set; }
    }

    public class MailData
    {
        public MailInfo mailInfo { get; set; }
        public List<MailItem> mailItems { get; set; }
    }

    public class MailInfo
    {
        public int mail_seq { get; set; }
        public string mail_title { get; set; }
        public DateTime create_dt { get; set; }
        public DateTime expire_dt { get; set; }
        public DateTime receive_dt { get; set; }
        public bool receive_yn { get; set; }
    }

    public class MailItem
    {
        [DisplayName("보상 키")]
        public int reward_key { get; set; }
        [DisplayName("보상 수")]
        public int reward_qty { get; set; }
        [DisplayName("보상 종류")]
        public string reward_type { get; set; }
    }

    public class MailReceiveRequest
    {
        public int MailSeq { get; set; }
    }

    public class MailRecieveResponse
    {
        public int result { get; set; }
        public List<ReceivedReward> rewards { get; set; }
    }

    public class ReceivedReward
    {
        public int rewardKey { get; set; }
        public List<RewardData> rewardDatas { get; set; }
    }
}
