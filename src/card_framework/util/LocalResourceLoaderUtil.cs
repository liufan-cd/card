using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace src.card_framework.util
{
    public class LocalResourceLoaderUtil
    {
        private static LocalResourceLoaderUtil resource = new LocalResourceLoaderUtil();

        public static Dictionary<String, Dictionary<String, String>> configMap = new Dictionary<string, Dictionary<string, string>>();

        public static LocalResourceLoaderUtil GetLoader(){
            return LocalResourceLoaderUtil.resource;
        }

        public static void LoadSystemResource() {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            temp.Add("path", "close_icon");
            temp.Add("position_x", "3745");
            temp.Add("position_y", "1107");
            temp.Add("size_x", "43");
            temp.Add("size_y", "45");
            configMap.Add("close_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "setting_icon");
            temp.Add("position_x", "3659");
            temp.Add("position_y", "1110");
            temp.Add("size_x", "43");
            temp.Add("size_y", "40");
            configMap.Add("setting_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "help_icon");
            temp.Add("position_x", "3575");
            temp.Add("position_y", "1112");
            temp.Add("size_x", "32");
            temp.Add("size_y", "40");
            configMap.Add("help_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "setting_icon_border");
            temp.Add("position_x", "3637");
            temp.Add("position_y", "1094");
            temp.Add("size_x", "80");
            temp.Add("size_y", "72");
            configMap.Add("setting_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "close_icon_border");
            temp.Add("position_x", "3726");
            temp.Add("position_y", "1089");
            temp.Add("size_x", "84");
            temp.Add("size_y", "82");
            configMap.Add("close_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "help_icon_border");
            temp.Add("position_x", "3550");
            temp.Add("position_y", "1097");
            temp.Add("size_x", "80");
            temp.Add("size_y", "72");
            configMap.Add("help_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_close_text");
            temp.Add("position_x", "2505");
            temp.Add("position_y", "1572");
            temp.Add("size_x", "79");
            temp.Add("size_y", "45");
            configMap.Add("map_close_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_close_button");
            temp.Add("position_x", "2479");
            temp.Add("position_y", "1550");
            temp.Add("size_x", "184");
            temp.Add("size_y", "96");
            configMap.Add("map_close_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_bundling");
            temp.Add("position_x", "3751");
            temp.Add("position_y", "1456");
            temp.Add("size_x", "68");
            temp.Add("size_y", "164");
            configMap.Add("map_bundling", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map");
            temp.Add("position_x", "3746");
            temp.Add("position_y", "1178");
            temp.Add("size_x", "94");
            temp.Add("size_y", "692");
            configMap.Add("map", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_shadow");
            temp.Add("position_x", "3785");
            temp.Add("position_y", "1072");
            temp.Add("size_x", "127");
            temp.Add("size_y", "734");
            configMap.Add("map_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_expanded");
            temp.Add("position_x", "2580");
            temp.Add("position_y", "1168");
            temp.Add("size_x", "1205");
            temp.Add("size_y", "711");
            configMap.Add("map_expanded", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_text");
            temp.Add("position_x", "3487");
            temp.Add("position_y", "1929");
            temp.Add("size_x", "351");
            temp.Add("size_y", "218");
            configMap.Add("next_day_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_border");
            temp.Add("position_x", "3500");
            temp.Add("position_y", "1938");
            temp.Add("size_x", "295");
            temp.Add("size_y", "178");
            configMap.Add("next_day_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_button");
            temp.Add("position_x", "3453");
            temp.Add("position_y", "1905");
            temp.Add("size_x", "380");
            temp.Add("size_y", "245");
            configMap.Add("next_day_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_accelerated_value");
            temp.Add("position_x", "2836");
            temp.Add("position_y", "1198");
            temp.Add("size_x", "103");
            temp.Add("size_y", "35");
            configMap.Add("battle_accelerated_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value");
            temp.Add("position_x", "2814");
            temp.Add("position_y", "1115");
            temp.Add("size_x", "160");
            temp.Add("size_y", "47");
            configMap.Add("battle_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value_icon");
            temp.Add("position_x", "2724");
            temp.Add("position_y", "1107");
            temp.Add("size_x", "70");
            temp.Add("size_y", "65");
            configMap.Add("battle_value_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value_background");
            temp.Add("position_x", "2675");
            temp.Add("position_y", "1089");
            temp.Add("size_x", "437");
            temp.Add("size_y", "115");
            configMap.Add("battle_value_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "fast_forward_button_15");
            temp.Add("position_x", "2453");
            temp.Add("position_y", "1133");
            temp.Add("size_x", "32");
            temp.Add("size_y", "26");
            configMap.Add("fast_forward_button_15", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "fast_forward_button_20");
            temp.Add("position_x", "2492");
            temp.Add("position_y", "1133");
            temp.Add("size_x", "28");
            temp.Add("size_y", "26");
            configMap.Add("fast_forward_button_20", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_pause_button");
            temp.Add("position_x", "2418");
            temp.Add("position_y", "1133");
            temp.Add("size_x", "30");
            temp.Add("size_y", "26");
            configMap.Add("battle_pause_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_day_text");
            temp.Add("position_x", "2559");
            temp.Add("position_y", "1131");
            temp.Add("size_x", "106");
            temp.Add("size_y", "34");
            configMap.Add("battle_day_text", temp);
            temp = new Dictionary<string, string>();
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_button_background");
            temp.Add("position_x", "2375");
            temp.Add("position_y", "1113");
            temp.Add("size_x", "466");
            temp.Add("size_y", "64");
            configMap.Add("battle_button_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_decreased_value");
            temp.Add("position_x", "3273");
            temp.Add("position_y", "1153");
            temp.Add("size_x", "30");
            temp.Add("size_y", "21");
            configMap.Add("battle_decreased_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress_icon");
            temp.Add("position_x", "3254");
            temp.Add("position_y", "1136");
            temp.Add("size_x", "18");
            temp.Add("size_y", "18");
            configMap.Add("battle_progress_icon", temp);
            temp = new Dictionary<string, string>();
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress");
            temp.Add("position_x", "2897");
            temp.Add("position_y", "1119");
            temp.Add("size_x", "443");
            temp.Add("size_y", "21");
            configMap.Add("battle_progress", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress_background");
            temp.Add("position_x", "2840");
            temp.Add("position_y", "1103");
            temp.Add("size_x", "536");
            temp.Add("size_y", "75");
            configMap.Add("battle_progress_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_place_arrows");
            temp.Add("position_x", "2527");
            temp.Add("position_y", "1270");
            temp.Add("size_x", "719");
            temp.Add("size_y", "628");
            configMap.Add("card_place_arrows", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_place_shadow");
            temp.Add("position_x", "2433");
            temp.Add("position_y", "1439");
            temp.Add("size_x", "190");
            configMap.Add("card_place_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_shadow");
            temp.Add("position_x", "2427");
            temp.Add("position_y", "1862");
            temp.Add("size_x", "1011");
            temp.Add("size_y", "304");
            configMap.Add("hand_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_number_text");
            temp.Add("position_x", "2357");
            temp.Add("position_y", "1880");
            temp.Add("size_x", "50");
            temp.Add("size_y", "58");
            configMap.Add("drawing_pile_number_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_icon");
            temp.Add("position_x", "2285");
            temp.Add("position_y", "1879");
            temp.Add("size_x", "70");
            temp.Add("size_y", "34");
            configMap.Add("drawing_pile_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_background");
            temp.Add("position_x", "2257");
            temp.Add("position_y", "1855");
            temp.Add("size_x", "189");
            temp.Add("size_y", "104");
            configMap.Add("drawing_pile_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_number_text");
            temp.Add("position_x", "3445");
            temp.Add("position_y", "1888");
            temp.Add("size_x", "69");
            temp.Add("size_y", "69");
            configMap.Add("discard_pile_number_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_icon");
            temp.Add("position_x", "3512");
            temp.Add("position_y", "1849");
            temp.Add("size_x", "76");
            temp.Add("size_y", "77");
            configMap.Add("discard_pile_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_background");
            temp.Add("position_x", "3403");
            temp.Add("position_y", "1839");
            temp.Add("size_x", "208");
            temp.Add("size_y", "145");
            configMap.Add("discard_pile_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_text");
            temp.Add("position_x", "2512");
            temp.Add("position_y", "1862");
            temp.Add("size_x", "78");
            temp.Add("size_y", "47");
            configMap.Add("hand_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "materials_storage_text");
            temp.Add("position_x", "2492");
            temp.Add("position_y", "1861");
            temp.Add("size_x", "119");
            temp.Add("size_y", "49");
            configMap.Add("materials_storage_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_background");
            temp.Add("position_x", "2419");
            temp.Add("position_y", "1846");
            temp.Add("size_x", "1042");
            temp.Add("size_y", "307");
            configMap.Add("hand_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "character_icon");
            temp.Add("position_x", "1546");
            temp.Add("position_y", "1615");
            temp.Add("size_x", "815");
            temp.Add("size_y", "964");
            configMap.Add("character_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "character_icon_shadow");
            temp.Add("position_x", "1515");
            temp.Add("position_y", "1623");
            temp.Add("size_x", "815");
            temp.Add("size_y", "964");
            configMap.Add("character_icon_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_icon");
            temp.Add("position_x", "2280");
            temp.Add("position_y", "1986");
            temp.Add("size_x", "140");
            temp.Add("size_y", "134");
            configMap.Add("remains_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_background");
            temp.Add("position_x", "2260");
            temp.Add("position_y", "1971");
            temp.Add("size_x", "196");
            temp.Add("size_y", "189");
            configMap.Add("remains_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_background_shadow");
            temp.Add("position_x", "1927");
            temp.Add("position_y", "1791");
            temp.Add("size_x", "545");
            temp.Add("size_y", "369");
            configMap.Add("remains_background_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border1");
            temp.Add("position_x", "1975");
            temp.Add("position_y", "1112");
            temp.Add("size_x", "1809");
            temp.Add("size_y", "992");
            configMap.Add("main_border1", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border2");
            temp.Add("position_x", "1969");
            temp.Add("position_y", "1106");
            temp.Add("size_x", "1821");
            temp.Add("size_y", "1001");
            configMap.Add("main_border2", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border3");
            temp.Add("position_x", "1957");
            temp.Add("position_y", "1100");
            temp.Add("size_x", "1845");
            temp.Add("size_y", "1012");
            configMap.Add("main_border3", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border4");
            temp.Add("position_x", "1910");
            temp.Add("position_y", "1056");
            temp.Add("size_x", "1949");
            temp.Add("size_y", "1131");
            configMap.Add("main_border4", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background1");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "1921");
            temp.Add("size_y", "1447");
            configMap.Add("main_background1", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background2");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "1921");
            temp.Add("size_y", "1447");
            configMap.Add("main_background2", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background3");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "1921");
            temp.Add("size_y", "1447");
            configMap.Add("main_background3", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_container");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "190");
            configMap.Add("card_container", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "building_place");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "190");
            configMap.Add("building_place", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "building");
            temp.Add("position_x", "1919");
            temp.Add("position_y", "899");
            temp.Add("size_x", "190");
            configMap.Add("building", temp);
        }

        public static Dictionary<string, string> GetConfig(String name) {
            return configMap.GetValueOrDefault(name);
        }

        public Dictionary<string, String> LoadProperties(String path){
            String content = File.ReadAllText(path, System.Text.Encoding.UTF8);
            String[] rows = content.Split('\n');
            String[] kv = null;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
            foreach (String str in rows){
                if (str.Trim().Length == 0){
                    continue;
                }

                kv = str.Split('=');
                dictionary.Add(kv[0], kv[1]);
            }

            return dictionary;
        }

        public Sprite LoadSprite(String path){
            // todo absolute path
            return Resources.Load<Sprite>(path);
        }

        public Dictionary<string, Sprite> LoadSpriteAll(String path){
            // todo absolute path
            Dictionary<string, Sprite> dictionary = new Dictionary<string, Sprite>();

            foreach (Sprite sprite in Resources.LoadAll<Sprite>(path)){
                dictionary.Add(sprite.name, sprite);
            }

            return dictionary;
        }

        public bool Save<T>(String path, T t){
            // todo
            return false;
        }

        public bool SaveAll<T>(String path, T[] ts){
            return false;
        }
    }
}
