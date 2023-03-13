using Moq;
using Movies_CQRS_Feb16.Controllers;
using Movies_CQRS_Feb16.Data_Access.Interfaces;
using Movies_CQRS_Feb16.Models;
using Movies_CQRS_Feb16.Repositories;
using MediatR;
using Movies_CQRS_Feb16.Queries.MovieQueries;
using Movies_CQRS_Feb16.Handlers.MovieHandlers;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.AspNetCore.Mvc;
using Movies_CQRS_Feb16.Commands.MovieCommands;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MockFramework_Feb16
{
    public class MovieTest
    {
        private readonly Mock<IMovie> service;

        public MovieTest()
        {
            service = new Mock<IMovie>();
        }
        //private List<Movie> GetSampleMovie()
        //{
        //    List<Movie> output = new List<Movie>
        //{
        //    new Movie
        //    {
        //        MovieId = 1,
        //        MovieName = "Doe",
        //        GenreId = 1
        //    },
        //    new Movie
        //    {
        //        MovieId = 2,
        //        MovieName = "kgf",
        //        GenreId = 2
        //    },
        //    new Movie
        //    {
        //        MovieId = 3,
        //        MovieName = "pathaan",
        //        GenreId = 1
        //    }
        //};
        //    return output;
        //}
        //[Fact]
        //public void getMovieNameById()
        //{
        //    //arrange
        //    var movie = GetSampleMovie();
        //    var firstMovie = movie[0];
        //    service.Setup(x => x.GetMovieById((int)1))
        //        .Returns(firstMovie);
        //    var controller = new MovieRepository(service.Object);

        //    //act
        //    var actionResult = controller.GetMovieById((int)1);
        //    var result = actionResult as OkObjectResult;

        //    //Assert
        //    Assert.IsType<OkObjectResult>(result);

        //    result.Value.Should().BeEquivalentTo(firstMovie);
        //}


        //[Fact]

        //public void getMovieById()
        //{
        //    // arrange
        //    //mock.Setup(p => p.GetMovieById(1));

        //    //MovieController movie = new MovieController(mock.Object);

        //    // act


        //    // assert

        //}
    }
}