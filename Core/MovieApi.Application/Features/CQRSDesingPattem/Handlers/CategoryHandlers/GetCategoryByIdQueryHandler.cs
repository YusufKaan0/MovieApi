using MovieApi.Application.Features.CQRSDesingPattem.Queries.CategoryQueries;
using MovieApi.Application.Features.CQRSDesingPattem.Results.CategoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesingPattem.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCategoryByIdResult> Handle(GetCategoryByIdQuery query)
        {
            var value =await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
