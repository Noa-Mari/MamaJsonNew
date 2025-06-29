using System.Text.Json;
using Newtonsoft.Json;
using MamaJson;

namespace MamaJson
{
    public  class MamaJson : IMamaJson
    {
        public MamaJson()
        {
            
        }
        public IDictionary<string, int> GetMamaCycles(string jsonPath)
        {

            string jsonText = File.ReadAllText(jsonPath);

            List<MamaCourse> courses = System.Text.Json.JsonSerializer.Deserialize<List<MamaCourse>>(jsonText);

            Dictionary<string, int> result = new Dictionary<string, int> ();

            foreach (var course in courses)
            {
                result[course.Name] = course.Cycle;
            }

            return result;
        }
    }
}