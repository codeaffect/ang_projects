using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mydb.DTO;

namespace mydb.Services
{
    public static class ItemService
    {
        public static Task<IEnumerable<ItemDto>> GetItems()
        {
            var list = new List<ItemDto>() {
                 new ItemDto(){ Name="Pencils", Quantity=5, TaskId=1 },
                 new ItemDto(){ Name="Tomatoes", Quantity=12, TaskId=2 }
            };

            return Task.FromResult(list.AsEnumerable());
        }
    }
}
