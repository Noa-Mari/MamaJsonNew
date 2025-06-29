using Newtonsoft.Json;

namespace MamaJson
{
    public  class MamaJson : IMamaJson
    {
        public MamaJson()
        {
            
        }
        public IDictionary<string, int> GetMamaCycles(string jsonPath)
        {

            string text = File.ReadAllText(jsonPath);
            Dictionary<string, int> values = JsonConvert.DeserializeObject<Dictionary<string, int>>(text);

            return values;
        }
    }
}