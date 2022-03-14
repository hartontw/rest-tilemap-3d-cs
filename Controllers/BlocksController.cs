using Microsoft.AspNetCore.Mvc;
using rest_tilemap_3d_cs.Repositories;
using rest_tilemap_3d_cs.Entities;

namespace rest_tilemap_3d_cs.Controllers;

[ApiController]
[Route("Blocks")]
public class BlocksController : ControllerBase
{
    private readonly IRepository repository;

    public BlocksController() 
    {
        repository = new MemoryRepository();
    }

    [HttpGet]
    public IEnumerable<Block> GetBlocks() => repository.GetBlocks();    
}