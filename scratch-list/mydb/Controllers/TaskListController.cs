using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mydb.DTO;
using mydb.Services;

namespace mydb.Controllers
{
    [Route("Tasks")]
    [ApiController]
    public class TaskListController : ControllerBase
    {
        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<ItemDto>> Get()
        {
            return await ItemService.GetItems();
        }
    }
}
