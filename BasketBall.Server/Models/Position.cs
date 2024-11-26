using System;
using System.Collections.Generic;

namespace BasketBall.Server.Models;

public partial class Position
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
