using System;
using System.Collections.Generic;

namespace src.card_framework.entity
{
    public class JSONObject
    {
        public Dictionary<string, Object> JsonObjects = new();

        public JSONObject GetJsonObject(string key)
        {
            return JsonObjects.ContainsKey(key) ? (JSONObject)JsonObjects[key] : null;
        }
        
        public string GetString(string key)
        {
            return JsonObjects.ContainsKey(key) ? (string)JsonObjects[key] : null;
        }
        
        public void put(string key, Object value)
        {
            if (!JsonObjects.ContainsKey(key))
            {
                JsonObjects.Add(key, value);   
            }
        }
    }
}