﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Model
{
    public static class EEWConverter
    {
        private static Dictionary<int, string> code2Hypocenter = new()
        {
            { 721, "北海道道央" },
            { 722, "北海道道南" },
            { 723, "北海道道北" },
            { 724, "北海道道東" },
            { 725, "北海道南西沖" },
            { 726, "北海道西方沖" },
            { 727, "石狩湾" },
            { 728, "北海道北西沖" },
            { 729, "宗谷海峡" },
            { 730, "国後島付近" },
            { 731, "択捉島付近" },
            { 732, "北海道東方沖" },
            { 733, "根室半島沖" },
            { 734, "釧路沖" },
            { 735, "十勝沖" },
            { 736, "浦河沖" },
            { 737, "苫小牧沖" },
            { 738, "内浦湾" },
            { 739, "宗谷東方沖" },
            { 740, "網走沖" },
            { 741, "択捉島南東沖" },
            { 742, "青森県" },
            { 743, "岩手県" },
            { 744, "宮城県" },
            { 745, "秋田県" },
            { 746, "山形県" },
            { 747, "福島県" },
            { 748, "津軽海峡" },
            { 749, "山形沖" },
            { 750, "秋田沖" },
            { 751, "青森西方沖" },
            { 752, "陸奥湾" },
            { 753, "青森東方沖" },
            { 754, "岩手沖" },
            { 755, "宮城沖" },
            { 756, "三陸沖" },
            { 757, "福島沖" },
            { 758, "茨城県" },
            { 759, "千葉南東沖" },
            { 760, "栃木県" },
            { 761, "群馬県" },
            { 762, "埼玉県" },
            { 763, "千葉県" },
            { 764, "千葉南方沖" },
            { 765, "東京" },
            { 766, "神奈川県" },
            { 767, "新潟県" },
            { 768, "新潟沖" },
            { 769, "富山県" },
            { 770, "石川県" },
            { 771, "福井県" },
            { 772, "山梨県" },
            { 773, "長野県" },
            { 774, "岐阜県" },
            { 775, "静岡県" },
            { 776, "愛知県" },
            { 777, "三重県" },
            { 778, "三重南東沖" },
            { 779, "茨城沖" },
            { 780, "関東東方沖" },
            { 781, "千葉東方沖" },
            { 782, "関東南方沖" },
            { 783, "伊豆諸島近海" },
            { 784, "東京湾" },
            { 785, "相模湾" },
            { 786, "伊豆東方沖" },
            { 787, "静岡沖" },
            { 788, "三河湾" },
            { 789, "伊勢湾" },
            { 790, "若狭湾" },
            { 791, "福井沖" },
            { 792, "石川西方沖" },
            { 793, "能登半島沖" },
            { 794, "富山湾" },
            { 795, "佐渡付近" },
            { 796, "東海道沖" },
            { 797, "滋賀県" },
            { 798, "京都府" },
            { 799, "大阪府" },
            { 800, "兵庫県" },
            { 801, "奈良県" },
            { 802, "和歌山県" },
            { 803, "鳥取県" },
            { 804, "島根県" },
            { 805, "岡山県" },
            { 806, "広島県" },
            { 807, "徳島県" },
            { 808, "香川県" },
            { 809, "愛媛県" },
            { 810, "高知県" },
            { 811, "土佐湾" },
            { 812, "紀伊水道" },
            { 813, "大阪湾" },
            { 814, "播磨灘" },
            { 815, "瀬戸内海" },
            { 816, "安芸灘" },
            { 817, "周防灘" },
            { 818, "伊予灘" },
            { 819, "豊後水道" },
            { 820, "山口北西沖" },
            { 821, "島根沖" },
            { 822, "鳥取沖" },
            { 823, "隠岐島近海" },
            { 824, "兵庫北方沖" },
            { 825, "京都沖" },
            { 826, "淡路島付近" },
            { 827, "和歌山沖" },
            { 828, "山口県" },
            { 829, "福岡県" },
            { 830, "佐賀県" },
            { 831, "長崎県" },
            { 832, "熊本県" },
            { 833, "大分県" },
            { 834, "宮崎県" },
            { 835, "鹿児島県" },
            { 836, "五島列島近海" },
            { 837, "天草灘" },
            { 838, "有明海" },
            { 839, "橘湾" },
            { 840, "鹿児島湾" },
            { 841, "種子島近海" },
            { 842, "日向灘" },
            { 843, "奄美大島近海" },
            { 844, "対馬近海" },
            { 845, "福岡北西沖" },
            { 846, "鹿児島西方沖" },
            { 847, "薩南諸島近海" },
            { 848, "鹿児島東方沖" },
            { 849, "九州南東沖" },
            { 850, "沖縄本島近海" },
            { 851, "南大東島近海" },
            { 852, "沖縄南方沖" },
            { 853, "宮古島近海" },
            { 854, "石垣島近海" },
            { 855, "石垣島南方沖" },
            { 856, "西表島付近" },
            { 857, "与那国島近海" },
            { 858, "宮古島北西沖" },
            { 859, "石垣島北西沖" },
            { 860, "台湾付近" },
            { 861, "東シナ海" },
            { 862, "四国沖" },
            { 863, "鳥島近海" },
            { 864, "鳥島東方沖" },
            { 865, "オホーツク海" },
            { 866, "サハリン付近" },
            { 867, "日本海北部" },
            { 868, "日本海中部" },
            { 869, "日本海西部" },
            { 870, "父島近海" },
            { 871, "南海道南方沖" },
            { 872, "サハリン南部" },
            { 873, "朝鮮半島南部" },
            { 874, "千島列島" },
            { 875, "千島海溝付近" },
            { 876, "北海道南東沖" },
            { 877, "硫黄島近海" },
            { 878, "本州南方沖" },
            { 879, "北西太平洋" },
            { 880, "マリアナ諸島" },
            { 881, "黄海" },
            { 882, "朝鮮半島北部" },
            { 883, "中国東北部" },
            { 884, "シベリア南部" },
            { 885, "フィリピン北" },
            { 886, "中国東部" },
        };

        private static Dictionary<int, string> code2AreaName = new()
        {
            { 160, "北海道道央" },
            { 161, "北海道道南" },
            { 162, "北海道道北" },
            { 163, "北海道道東" },
            { 164, "青森" },
            { 165, "岩手" },
            { 166, "宮城" },
            { 167, "秋田" },
            { 168, "山形" },
            { 169, "福島" },
            { 170, "茨城" },
            { 171, "栃木" },
            { 172, "群馬" },
            { 173, "埼玉" },
            { 174, "千葉" },
            { 175, "東京" },
            { 176, "伊豆諸島" },
            { 177, "小笠原" },
            { 178, "神奈川" },
            { 179, "新潟" },
            { 180, "富山" },
            { 181, "石川" },
            { 182, "福井" },
            { 183, "山梨" },
            { 184, "長野" },
            { 185, "岐阜" },
            { 186, "静岡" },
            { 187, "愛知" },
            { 188, "三重" },
            { 189, "滋賀" },
            { 190, "京都" },
            { 191, "大阪" },
            { 192, "兵庫" },
            { 193, "奈良" },
            { 194, "和歌山" },
            { 195, "鳥取" },
            { 196, "島根" },
            { 197, "岡山" },
            { 198, "広島" },
            { 199, "徳島" },
            { 360, "香川" },
            { 361, "愛媛" },
            { 362, "高知" },
            { 363, "山口" },
            { 364, "福岡" },
            { 365, "佐賀" },
            { 366, "長崎" },
            { 367, "熊本" },
            { 368, "大分" },
            { 369, "宮崎" },
            { 370, "鹿児島" },
            { 371, "奄美(群島)" },
            { 372, "沖縄本島" },
            { 373, "大東島" },
            { 374, "宮古島" },
            { 375, "八重山" },
        };

        public static string GetHypocenter(int code)
        {
            if (code2Hypocenter.ContainsKey(code))
            {
                return code2Hypocenter[code];
            }

            return null;
        }

        public static int GetHypocenterCode(string name)
        {
            return code2Hypocenter.FirstOrDefault(e => e.Value == name, new KeyValuePair<int, string>(-1, "")).Key;
        }

        public static string GetArea(int code)
        {
            if (code2AreaName.ContainsKey(code))
            {
                return code2AreaName[code];
            }

            return null;
        }

        public static int GetAreaCode(string name)
        {
            return code2AreaName.FirstOrDefault(e => e.Value == name, new KeyValuePair<int, string>(-1, "")).Key;
        }
    }
}
