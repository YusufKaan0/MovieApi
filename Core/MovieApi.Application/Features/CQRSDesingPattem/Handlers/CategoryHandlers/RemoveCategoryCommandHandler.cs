using MovieApi.Application.Features.CQRSDesingPattem.Command.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieApi.Application.Features.CQRSDesingPattem.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handlers(RemoveCategoryCommand command)
        {
            var value = await _context.Movies.FindAsync(command.CategoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
