using UnityEngine;

class MapSettings
{
    public static MapSettings[] mapSettings =
    {
        new MapSettings("race_track_lake", new Vector3(-3.304075f, 2.051f, 128.0396f)),
        new MapSettings("scene1-night", new Vector3(0, 0.76f, -3.54f)),
        new MapSettings("sprint_track", new Vector3(953.47f, 219.96f, 924.5f))
    };
    
    public string name { get; set; }
    public Vector3 start { get; set; }

    public MapSettings(string name, Vector3 start)
    {
        this.name = name;
        this.start = start;
    }
}