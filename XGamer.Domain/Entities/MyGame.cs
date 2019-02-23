using System;
using System.Collections.Generic;
using System.Text;

namespace XGamer.Domain.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }
        public GamePlatform GamePlatform { get; set; }
        public bool IsWish { get; set; }
        public bool IsExchange { get; set; }
        public bool IsSell { get; set; }
        public DateTime WishDate { get; set; }
    }
}
