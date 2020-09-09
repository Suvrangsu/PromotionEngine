using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class JSONParser
    {
        public dynamic ParseJSON()
        {
            dynamic promotionEngineModel;
            using (StreamReader r = new StreamReader("ItemConfiguration.json"))
            {
                string json = r.ReadToEnd();
                promotionEngineModel = JsonConvert.DeserializeObject<dynamic>(json); 
            }

            return promotionEngineModel;


        }
    }
}
