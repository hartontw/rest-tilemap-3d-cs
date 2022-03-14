using rest_tilemap_3d_cs.Entities;

namespace rest_tilemap_3d_cs.Repositories;

public class MongoRepository : IRepository
{
    public IEnumerable<Block> GetBlocks() => throw new NotImplementedException();

    public Block GetBlock(int x, int y, int z) => throw new NotImplementedException();
    public Block GetBlock(Vector position) => GetBlock(position.x, position.y, position.z);
}