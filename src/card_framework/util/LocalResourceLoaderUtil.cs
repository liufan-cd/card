using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace src.card_framework.util
{
    public class LocalResourceLoaderUtil
    {
        private static LocalResourceLoaderUtil resource = new LocalResourceLoaderUtil();

        public static Dictionary<String, Dictionary<String, String>> configMap =
            new Dictionary<string, Dictionary<string, string>>();

        public static LocalResourceLoaderUtil GetLoader()
        {
            return LocalResourceLoaderUtil.resource;
        }

        public static void LoadSystemResource()
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_expanded");
            temp.Add("position_x", "3.025");
            temp.Add("position_y", "0.965");
            temp.Add("size_y", "7.11");
            temp.Add("size_x", "12.05");
            configMap.Add("map_expanded", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "building_place");
            temp.Add("position_x", "19.19");
            temp.Add("position_y", "8.99");
            temp.Add("size_x", "1.90");
            configMap.Add("building_place", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_number_text");
            temp.Add("position_x", "5.995");
            temp.Add("position_y", "-3.025");
            temp.Add("size_y", "0.69");
            temp.Add("size_x", "0.69");
            configMap.Add("discard_pile_number_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "character_icon_shadow");
            temp.Add("position_x", "-9.575");
            temp.Add("position_y", "-4.85");
            temp.Add("size_y", "9.64");
            temp.Add("size_x", "8.15");
            configMap.Add("character_icon_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_icon");
            temp.Add("position_x", "6.7");
            temp.Add("position_y", "-2.675");
            temp.Add("size_y", "0.77");
            temp.Add("size_x", "0.76");
            configMap.Add("discard_pile_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "character_icon");
            temp.Add("position_x", "-9.265");
            temp.Add("position_y", "-4.77");
            temp.Add("size_y", "9.64");
            temp.Add("size_x", "8.15");
            configMap.Add("character_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_container");
            temp.Add("position_x", "19.19");
            temp.Add("position_y", "8.99");
            temp.Add("size_x", "1.90");
            configMap.Add("card_container", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress_icon");
            temp.Add("position_x", "3.83");
            temp.Add("position_y", "4.75");
            temp.Add("size_y", "0.18");
            temp.Add("size_x", "0.18");
            configMap.Add("battle_progress_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "materials_storage_text");
            temp.Add("position_x", "-3.285");
            temp.Add("position_y", "-2.655");
            temp.Add("size_y", "0.49");
            temp.Add("size_x", "1.19");
            configMap.Add("materials_storage_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "building");
            temp.Add("position_x", "19.19");
            temp.Add("position_y", "8.99");
            temp.Add("size_x", "1.90");
            configMap.Add("building", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_close_button");
            temp.Add("position_x", "-3.09");
            temp.Add("position_y", "0.22");
            temp.Add("size_y", "0.96");
            temp.Add("size_x", "1.84");
            configMap.Add("map_close_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_icon");
            temp.Add("position_x", "-5.6");
            temp.Add("position_y", "-2.76");
            temp.Add("size_y", "0.34");
            temp.Add("size_x", "0.7");
            configMap.Add("drawing_pile_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_number_text");
            temp.Add("position_x", "-4.98");
            temp.Add("position_y", "-2.89");
            temp.Add("size_y", "0.58");
            temp.Add("size_x", "0.5");
            configMap.Add("drawing_pile_number_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border1");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "0.12");
            temp.Add("size_y", "9.92");
            temp.Add("size_x", "18.09");
            configMap.Add("main_border1", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_close_text");
            temp.Add("position_x", "-3.355");
            temp.Add("position_y", "0.255");
            temp.Add("size_y", "0.45");
            temp.Add("size_x", "0.79");
            configMap.Add("map_close_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_background");
            temp.Add("position_x", "-5.22");
            temp.Add("position_y", "-4.455");
            temp.Add("size_y", "1.89");
            temp.Add("size_x", "1.96");
            configMap.Add("remains_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value");
            temp.Add("position_x", "0.14");
            temp.Add("position_y", "4.815");
            temp.Add("size_y", "0.47");
            temp.Add("size_x", "1.6");
            configMap.Add("battle_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_place_arrows");
            temp.Add("position_x", "0.065");
            temp.Add("position_y", "0.36");
            temp.Add("size_y", "6.28");
            temp.Add("size_x", "7.19");
            configMap.Add("card_place_arrows", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_shadow");
            temp.Add("position_x", "9.685");
            temp.Add("position_y", "1.81");
            temp.Add("size_y", "7.34");
            temp.Add("size_x", "1.27");
            configMap.Add("map_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_background");
            temp.Add("position_x", "0.6");
            temp.Add("position_y", "-3.795");
            temp.Add("size_y", "3.07");
            temp.Add("size_x", "10.42");
            configMap.Add("hand_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_background_shadow");
            temp.Add("position_x", "-6.805");
            temp.Add("position_y", "-3.555");
            temp.Add("size_y", "3.69");
            temp.Add("size_x", "5.45");
            configMap.Add("remains_background_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_button_background");
            temp.Add("position_x", "-2.72");
            temp.Add("position_y", "4.75");
            temp.Add("size_y", "0.64");
            temp.Add("size_x", "4.66");
            configMap.Add("battle_button_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_accelerated_value");
            temp.Add("position_x", "0.075");
            temp.Add("position_y", "4.045");
            temp.Add("size_y", "0.35");
            temp.Add("size_x", "1.03");
            configMap.Add("battle_accelerated_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "fast_forward_button_15");
            temp.Add("position_x", "-4.11");
            temp.Add("position_y", "4.74");
            temp.Add("size_y", "0.26");
            temp.Add("size_x", "0.32");
            configMap.Add("fast_forward_button_15", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress");
            temp.Add("position_x", "2.385");
            temp.Add("position_y", "4.905");
            temp.Add("size_y", "0.21");
            temp.Add("size_x", "4.43");
            configMap.Add("battle_progress", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "setting_icon");
            temp.Add("position_x", "8.005");
            temp.Add("position_y", "4.9");
            temp.Add("size_y", "0.4");
            temp.Add("size_x", "0.43");
            configMap.Add("setting_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "fast_forward_button_20");
            temp.Add("position_x", "-3.74");
            temp.Add("position_y", "4.74");
            temp.Add("size_y", "0.26");
            temp.Add("size_x", "0.28");
            configMap.Add("fast_forward_button_20", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value_background");
            temp.Add("position_x", "0.135");
            temp.Add("position_y", "4.735");
            temp.Add("size_y", "1.15");
            temp.Add("size_x", "4.37");
            configMap.Add("battle_value_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_decreased_value");
            temp.Add("position_x", "4.08");
            temp.Add("position_y", "4.565");
            temp.Add("size_y", "0.21");
            temp.Add("size_x", "0.3");
            configMap.Add("battle_decreased_value", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_day_text");
            temp.Add("position_x", "-2.68");
            temp.Add("position_y", "4.72");
            temp.Add("size_y", "0.34");
            temp.Add("size_x", "1.06");
            configMap.Add("battle_day_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "remains_icon");
            temp.Add("position_x", "-5.3");
            temp.Add("position_y", "-4.33");
            temp.Add("size_y", "1.34");
            temp.Add("size_x", "1.4");
            configMap.Add("remains_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "drawing_pile_background");
            temp.Add("position_x", "-5.285");
            temp.Add("position_y", "-2.87");
            temp.Add("size_y", "1.04");
            temp.Add("size_x", "1.89");
            configMap.Add("drawing_pile_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "close_icon_border");
            temp.Add("position_x", "8.88");
            temp.Add("position_y", "4.9");
            temp.Add("size_y", "0.82");
            temp.Add("size_x", "0.84");
            configMap.Add("close_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_value_icon");
            temp.Add("position_x", "-1.21");
            temp.Add("position_y", "4.805");
            temp.Add("size_y", "0.65");
            temp.Add("size_x", "0.7");
            configMap.Add("battle_value_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_progress_background");
            temp.Add("position_x", "2.28");
            temp.Add("position_y", "4.795");
            temp.Add("size_y", "0.75");
            temp.Add("size_x", "5.36");
            configMap.Add("battle_progress_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "battle_pause_button");
            temp.Add("position_x", "-4.47");
            temp.Add("position_y", "4.74");
            temp.Add("size_y", "0.26");
            temp.Add("size_x", "0.3");
            configMap.Add("battle_pause_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_text");
            temp.Add("position_x", "7.825");
            temp.Add("position_y", "-4.18");
            temp.Add("size_y", "2.18");
            temp.Add("size_x", "3.51");
            configMap.Add("next_day_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background1");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "-0.025");
            temp.Add("size_y", "14.47");
            temp.Add("size_x", "19.21");
            configMap.Add("main_background1", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map");
            temp.Add("position_x", "9.13");
            temp.Add("position_y", "0.96");
            temp.Add("size_y", "6.92");
            temp.Add("size_x", "0.94");
            configMap.Add("map", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_shadow");
            temp.Add("position_x", "0.525");
            temp.Add("position_y", "-3.94");
            temp.Add("size_y", "3.04");
            temp.Add("size_x", "10.11");
            configMap.Add("hand_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background3");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "-0.025");
            temp.Add("size_y", "14.47");
            temp.Add("size_x", "19.21");
            configMap.Add("main_background3", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "hand_text");
            temp.Add("position_x", "-3.29");
            temp.Add("position_y", "-2.655");
            temp.Add("size_y", "0.47");
            temp.Add("size_x", "0.78");
            configMap.Add("hand_text", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_background2");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "-0.025");
            temp.Add("size_y", "14.47");
            temp.Add("size_x", "19.21");
            configMap.Add("main_background2", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border4");
            temp.Add("position_x", "0.045");
            temp.Add("position_y", "-0.015");
            temp.Add("size_y", "11.31");
            temp.Add("size_x", "19.49");
            configMap.Add("main_border4", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_border");
            temp.Add("position_x", "7.675");
            temp.Add("position_y", "-4.07");
            temp.Add("size_y", "1.78");
            temp.Add("size_x", "2.95");
            configMap.Add("next_day_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border3");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "0.14");
            temp.Add("size_y", "10.12");
            temp.Add("size_x", "18.45");
            configMap.Add("main_border3", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "main_border2");
            temp.Add("position_x", "-0.005");
            temp.Add("position_y", "0.135");
            temp.Add("size_y", "10.01");
            temp.Add("size_x", "18.21");
            configMap.Add("main_border2", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "map_bundling");
            temp.Add("position_x", "9.05");
            temp.Add("position_y", "0.82");
            temp.Add("size_y", "1.64");
            temp.Add("size_x", "0.68");
            configMap.Add("map_bundling", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "discard_pile_background");
            temp.Add("position_x", "6.27");
            temp.Add("position_y", "-2.915");
            temp.Add("size_y", "1.45");
            temp.Add("size_x", "2.08");
            configMap.Add("discard_pile_background", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "next_day_button");
            temp.Add("position_x", "7.63");
            temp.Add("position_y", "-4.075");
            temp.Add("size_y", "2.45");
            temp.Add("size_x", "3.8");
            configMap.Add("next_day_button", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "card_place_shadow");
            temp.Add("position_x", "2433");
            temp.Add("position_y", "1439");
            temp.Add("size_x", "190");
            configMap.Add("card_place_shadow", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "setting_icon_border");
            temp.Add("position_x", "7.97");
            temp.Add("position_y", "4.9");
            temp.Add("size_y", "0.72");
            temp.Add("size_x", "0.8");
            configMap.Add("setting_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "help_icon_border");
            temp.Add("position_x", "7.1");
            temp.Add("position_y", "4.87");
            temp.Add("size_y", "0.72");
            temp.Add("size_x", "0.8");
            configMap.Add("help_icon_border", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "help_icon");
            temp.Add("position_x", "7.11");
            temp.Add("position_y", "4.88");
            temp.Add("size_y", "0.4");
            temp.Add("size_x", "0.32");
            configMap.Add("help_icon", temp);
            temp = new Dictionary<string, string>();
            temp.Add("path", "close_icon");
            temp.Add("position_x", "8.865");
            temp.Add("position_y", "4.905");
            temp.Add("size_y", "0.45");
            temp.Add("size_x", "0.43");
            configMap.Add("close_icon", temp);
        }

        public static Dictionary<string, string> GetConfig(String name)
        {
            return configMap.GetValueOrDefault(name);
        }

        public Dictionary<string, String> LoadProperties(String path)
        {
            String content = File.ReadAllText(path, System.Text.Encoding.UTF8);
            String[] rows = content.Split('\n');
            String[] kv = null;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach (String str in rows)
            {
                if (str.Trim().Length == 0)
                {
                    continue;
                }

                kv = str.Split('=');
                dictionary.Add(kv[0], kv[1]);
            }

            return dictionary;
        }

        public Sprite LoadSprite(String path)
        {
            // todo absolute path
            return Resources.Load<Sprite>(path);
        }

        public Dictionary<string, Sprite> LoadSpriteAll(String path)
        {
            // todo absolute path
            Dictionary<string, Sprite> dictionary = new Dictionary<string, Sprite>();

            foreach (Sprite sprite in Resources.LoadAll<Sprite>(path))
            {
                dictionary.Add(sprite.name, sprite);
            }

            return dictionary;
        }

        public bool Save<T>(String path, T t)
        {
            // todo
            return false;
        }

        public bool SaveAll<T>(String path, T[] ts)
        {
            return false;
        }
    }
}