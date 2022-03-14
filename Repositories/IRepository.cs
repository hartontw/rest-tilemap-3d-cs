using rest_tilemap_3d_cs.Entities;

namespace rest_tilemap_3d_cs.Repositories;

interface IRepository
{    
    public IEnumerable<Block> GetBlocks();
    public Block GetBlock(int x, int y, int z);
    public Block GetBlock(Vector position);
}