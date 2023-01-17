// See https://aka.ms/new-console-template for more information

//TimeMap timeMap = new TimeMap();
//timeMap.Set("foo", "bar", 1);                   // store the key "foo" and value "bar" along with timestamp = 1.
//Console.WriteLine(timeMap.Get("foo", 1));       // return "bar"
//Console.WriteLine(timeMap.Get("foo", 3));       // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
//timeMap.Set("foo", "bar2", 4);                  // store the key "foo" and value "bar2" along with timestamp = 4.
//Console.WriteLine(timeMap.Get("foo", 4));       // return "bar2"
//Console.WriteLine(timeMap.Get("foo", 5));       // return "bar2"


TimeMap timeMap = new TimeMap();
timeMap.Set("love", "high", 10);
timeMap.Set("love", "low", 20);
Console.WriteLine(timeMap.Get("love", 5));       // return ""
Console.WriteLine(timeMap.Get("love", 10));      // return "high"
Console.WriteLine(timeMap.Get("love", 15));      // return "high"
Console.WriteLine(timeMap.Get("love", 20));      // return "low"
Console.WriteLine(timeMap.Get("love", 25));      // return "low"

public class TimeMap
{
    private Dictionary<string, IList<string>> values = new Dictionary<string, IList<string>>();
    private Dictionary<string, IList<int>> timestamps = new Dictionary<string, IList<int>>();

    public TimeMap()
    {

    }

    public void Set(string key, string value, int timestamp)
    {
        if (values.ContainsKey(key))
        {
            values[key].Add(value);
            timestamps[key].Add(timestamp);
        }
        else
        {
            values.Add(key, new List<string> { value });
            timestamps.Add(key, new List<int> { timestamp });
        }
    }

    public string Get(string key, int timestamp)
    {
        if (values.ContainsKey(key))
        {
            var times = timestamps[key];
            var l = 0;
            var r = times.Count - 1;

            if (timestamp < times[0])
            {
                return string.Empty;
            }

            while (l < r)
            {
                var m = l + (r - l) / 2 + 1;

                if (times[m] == timestamp)
                    return values[key][m];

                else if (times[m] <= timestamp)
                    l = m;
                else
                    r = m - 1;
            }


            return values[key][l];
        }

        return string.Empty;
    }
}