using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using src.card_framework.entity;
using UnityEngine;

namespace src.card_framework.util
{
    public class LocalResourceLoaderUtil
    {
        private static LocalResourceLoaderUtil resource = new LocalResourceLoaderUtil();

        public static Dictionary<String, Dictionary<String, String>> configMap = new();
        public static JSONObject jsonObject;

        public static LocalResourceLoaderUtil GetLoader()
        {
            return LocalResourceLoaderUtil.resource;
        }

        public static void LoadSystemResource()
        {
            jsonObject = ParseJson("Assets\\Assets\\Resources\\parse_position.json");
        }

        public static JSONObject ParseJson(string path)
        {
            String content = File.ReadAllText(path, Encoding.UTF8);
            Stack<JSONObject> stack = new Stack<JSONObject>();
            StringBuilder builder = new StringBuilder();
            JSONObject node = null;
            JSONObject child = null;
            string key = null;
            string value = null;

            for (var i = 0; i < content.Length; i++)
            {
                char c = content[i];

                if (c == '{')
                {
                    child = new JSONObject();
                    
                    if (node == null)
                    {
                        node = child;
                        stack.Push(node);
                    }
                    else
                    {
                        node.put(key, child);
                        stack.Push(node);
                        node = child;
                    }
                }
                else if (c == ':')
                {
                    builder.Remove(builder.Length - 1, 1);
                    builder.Remove(0, 1);
                    key = builder.ToString();
                    builder.Clear();
                }
                else if (c == ',')
                {
                    if (builder.Length != 0)
                    {
                        builder.Remove(builder.Length - 1, 1);
                        builder.Remove(0, 1);
                        value = builder.ToString();
                        builder.Clear();
                        node.put(key, value);
                    }
                }
                else if (c == '}')
                {
                    if (builder.Length != 0)
                    {
                        builder.Remove(builder.Length - 1, 1);
                        builder.Remove(0, 1);
                        value = builder.ToString();
                        builder.Clear();
                        node.put(key, value);
                    }

                    node = stack.Pop();
                }
                else if (c != ' ' || c != '\n' || c != '\r')
                {
                    builder.Append(c);
                }
            }

            return node;
        }

        public static Dictionary<string, string> GetConfig(String name)
        {
            if (configMap.ContainsKey(name))
            {
                return configMap[name];
            }
            else
            {
                JSONObject target = jsonObject.GetJsonObject(name);

                Dictionary<string, string> result = new Dictionary<string, string>(target.JsonObjects.Count);
            
                foreach (var (key, _) in target.JsonObjects)
                {
                    result.Add(key, target.GetString(key));
                }
                
                configMap.Add(name, result);
                return result;
            }
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