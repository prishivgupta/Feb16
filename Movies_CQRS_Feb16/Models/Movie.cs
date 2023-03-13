using System;
using System.Collections.Generic;

namespace Movies_CQRS_Feb16.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string? MovieName { get; set; }

    public int GenreId { get; set; }
}
