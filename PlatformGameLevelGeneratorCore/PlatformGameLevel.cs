namespace PlatformGameLevelGeneratorCore;

public class PlatformGameLevel
{
    public int Length { get;  }

    public LinkedList<Tile> Map { get; }
    
    public PlatformGameLevel()
    {
    }

    public PlatformGameLevel(int length)
    {
        Length = length;
        Map = new LinkedList<Tile>();
        for (int i = 0; i < length; i++)
        {
            Map.AddLast(new Tile());
        }

        Map.First.ValueRef.Texture = "S";
        Map.Last.ValueRef.Texture = "F";
    }

    public string MapGet()
    {
        string mapVisualized = "";
        foreach (var tile in Map)
        {
            mapVisualized += tile.Texture;
        }

        return mapVisualized;
    }
}