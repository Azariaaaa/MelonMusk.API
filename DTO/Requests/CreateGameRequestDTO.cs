using clickelon.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickelon.api.DTO.Requests
{
    public class CreateGameRequestDTO
    {
        public int Score { get; set; }
        public int PlayerId { get; set; }
    }
}
