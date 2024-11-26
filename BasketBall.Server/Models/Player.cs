using System;
using System.Collections.Generic;

namespace BasketBall.Server.Models;

public partial class Player
{
    public int Id { get; set; }

    public int ShirtNo { get; set; }

    public string Name { get; set; } = null!;

    public int PositionId { get; set; }

    public int Appearances { get; set; }

    public int Goals { get; set; }
    public Position? Position { get; internal set; }
}
