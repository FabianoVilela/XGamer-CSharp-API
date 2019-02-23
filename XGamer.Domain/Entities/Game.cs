using System;
using System.Collections.Generic;
using System.Text;

namespace XGamer.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public string Publisher { get; set; }
        public string Type { get; set; }
        public string WebSite { get; set; }
    }
}
