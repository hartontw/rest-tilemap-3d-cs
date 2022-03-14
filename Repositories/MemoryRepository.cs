using rest_tilemap_3d_cs.Entities;

namespace rest_tilemap_3d_cs.Repositories;

public class MemoryRepository : IRepository
{
    private readonly List<Block> blocks = new List<Block>();

    public MemoryRepository()
    {
        blocks.Add(new Block{ Position = new Vector(0,0,0), Updated = DateTime.Now });
        blocks.Add(new Block{ Position = new Vector(0,0,1), Updated = DateTime.Now });
        blocks.Add(new Block{ Position = new Vector(0,0,2), Updated = DateTime.Now });
    }

    public IEnumerable<Block> GetBlocks() => blocks;

    public Block GetBlock(int x, int y, int z) => blocks.FirstOrDefault(b => b.x == x && b.y == y && b.z == z);
    public Block GetBlock(Vector position) => GetBlock(position.x, position.y, position.z);
}