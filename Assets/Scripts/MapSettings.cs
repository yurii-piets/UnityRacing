using UnityEngine;

class MapSettings
{
    public static MapSettings[] mapSettings =
    {
        new MapSettings("race_track_lake", new Vector3(-3.304075f, 2.55f, 128.0396f), Quaternion.AngleAxis(55, new Vector3(0, 1, 0))),
        new MapSettings("scene1-night", new Vector3(-146.63f, 5.63f, 160.63f), Quaternion.AngleAxis(35, new Vector3(0, 1, 0))),
        new MapSettings("sprint_track", new Vector3(953.47f, 219.96f, 924.5f), Quaternion.AngleAxis(90, new Vector3(0, 1, 0)))
    };
    
    public string name { get; set; }
    public Vector3 start { get; set; }
    
    public Quaternion rotation { get; set; }

    public MapSettings(string name, Vector3 start, Quaternion rotation)
    {
        this.name = name;
        this.start = start;
        this.rotation = rotation;
    }
}