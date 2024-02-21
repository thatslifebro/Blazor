using System.ComponentModel;

namespace BlazorApp1.Pages
{
    public class UserDataLoadResponse
    {
        public int result { get; set; }
        public UserData userData { get; set; }
    }

    public class UserData
    {
        public UserInfoData userInfo { get; set; }
        public UserMoneyInfoData moneyInfo { get; set; }
    }

    public class UserInfoData
    {
        public int uid { get; set; }
        public string player_id { get; set; }
        public string nickname { get; set; }
        public int main_char_key { get; set; }
        public DateTime create_dt { get; set; }
        public DateTime recent_login_dt { get; set; }
        public int total_bestscore { get; set; }
        public int total_bestscore_cur_season { get; set; }
        public int total_bestscore_prev_season { get; set; }
        public int star_point { get; set; }
    }

    public class UserMoneyInfoData
    {
        public int jewelry { get; set; }
        public int gold_medal { get; set; }
        public int sunchip { get; set; }
        public int cash { get; set; }
    }

    public class GameDataLoadResponse
    {
        public int result { get; set; }
        public GameData GameData { get; set; }
    }

    public class GameData
    {
        public IEnumerable<GdbMiniGameInfo> GameList { get; set; }
        public IEnumerable<UserCharInfo> CharList { get; set; }
        public IEnumerable<GdbUserSkinInfo> SkinList { get; set; }
        public IEnumerable<GdbUserCostumeInfo> CostumeList { get; set; }
        public IEnumerable<GdbUserFoodInfo> FoodList { get; set; }
    }

    public class UserCharInfo
    {
        public GdbUserCharInfo CharInfo { get; set; }
        public IEnumerable<GdbUserCharRandomSkillInfo> RandomSkills { get; set; }
    }

    public class GdbMiniGameInfo
    {
        [DisplayName("게임키")]
        public int game_key { get; set; }
        [DisplayName("플레이 캐릭터 키")]
        public int play_char_key { get; set; }
        [DisplayName("최고점수")]
        public int bestscore { get; set; }
        public DateTime create_dt { get; set; }
        public DateTime new_record_dt { get; set; }
        [DisplayName("최근 플레이 일시")]
        public DateTime recent_play_dt { get; set; }
        public int bestscore_cur_season { get; set; }
        public int bestscore_prev_season { get; set; }
    }

    public class GdbUserSkinInfo
    {
        public int uid { get; set; }
        [DisplayName("스킨 키")]
        public int skin_key { get; set; }
        public DateTime create_dt { get; set; }
    }

    public class GdbUserCostumeInfo
    {
        public int uid { get; set; }
        [DisplayName("코스튬 키")]
        public int costume_key { get; set; }
        [DisplayName("코스튬 레벨")]
        public int costume_level { get; set; }
        [DisplayName("코스튬 카운트")]
        public int costume_cnt { get; set; }
        public DateTime create_dt { get; set; }
    }
    public class GdbUserFoodInfo
    {
        public int uid { get; set; }
        public int food_key { get; set; }
        public int food_qty { get; set; }
        public int food_level { get; set; }
        public int food_gear_qty { get; set; }
        public DateTime create_dt { get; set; }
    }

    public class GdbUserCharInfo
    {
        public int uid { get; set; }
        [DisplayName("캐릭터 키")]
        public int char_key { get; set; }
        [DisplayName("캐릭터 레벨")]
        public int char_level { get; set; }
        [DisplayName("캐릭터 카운트")]
        public int char_cnt { get; set; }
        public int skin_key { get; set; }
        public string costume_json { get; set; }
    }
    public class GdbUserCharRandomSkillInfo
    {
        public int uid { get; set; }
        public int char_key { get; set; }
        public int index_num { get; set; }
        public int skill_key { get; set; }
        public DateTime create_dt { get; set; }
    }
}
