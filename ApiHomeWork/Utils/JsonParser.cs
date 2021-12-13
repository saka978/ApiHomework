using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace ApiHomeWork.Utils
{
    public class JsonParser
    {
        public String getValueByKey(string json, string key)
        {
            string value = null;
            Random rnd = new Random();
            try{
                dynamic data = JsonConvert.DeserializeObject(json);
                if (data is JArray)
                {
                    data = data[rnd.Next(0, data.Count)];
                }
                value = data[key];
            }catch(Exception ex)
            {
                value = json;
            }
            return value;
        }
    }
}
