using Microsoft.AspNetCore.Mvc;
using rest_tilemap_3d_cs.Repositories;
using rest_tilemap_3d_cs.Entities;

namespace rest_tilemap_3d_cs.Controllers;

[ApiController]
[Route("Block")]
public class BlockController : ControllerBase
{
    private readonly IRepository repository;

    public BlockController() 
    {
        repository = new MemoryRepository();
    }

    [HttpGet]
    public ActionResult<Block> GetBlock(int x, int y, int z) 
    {
        Block block = repository.GetBlock(x, y, z);
        if (block) return Ok(block);
        return NotFound();
    }

    //[HttpGet]
    //public Block GetBlock(Vector position) => repository.GetBlock(position);    
}
