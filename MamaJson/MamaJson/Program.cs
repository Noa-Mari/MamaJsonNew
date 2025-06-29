using MamaJson;

MamaJson.MamaJson mama = new MamaJson.MamaJson();

IDictionary<string, int> result = mama.GetMamaCycles("/Users/noamari/Desktop/mamas2/MamaJson/MamaJson/MamaJson/courses.json");

foreach (var kv in result)
        {
            Console.WriteLine($"Course: {kv.Key}, Cycle: {kv.Value}");
        }