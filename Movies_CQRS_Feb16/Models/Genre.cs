using System;
using System.Collections.Generic;

namespace Movies_CQRS_Feb16.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? GenreName { get; set; }
}
