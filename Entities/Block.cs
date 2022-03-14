namespace rest_tilemap_3d_cs.Entities;

public class Block
{
    public Vector Position { get; init; }
    public DateTime Updated { get; init; }
    
    public int x { get => Position.x; }
    public int y { get => Position.y; }
    public int z { get => Position.z; }

    public static implicit operator bool(Block block)
    {
        return !object.ReferenceEquals(block, null);
    }
}