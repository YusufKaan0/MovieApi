using MovieApi.Application.Features.CQRSDesingPattem.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattem.Handlers.MovieHandkers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handlers(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Rating = command.Rating;
            value.Status = command.Status;  
            value.Duration = command.Duration;
            value.CoverImageUrl = command.CoverImageUrl;
            value.CreatedYears = command.CreatedYears;
            value.Description = command.Description;
            value.ReleaseDate = command.ReleaseDate;
            value.Title = command.Title;
            await _context.SaveChangesAsync();
        }
    }
}
