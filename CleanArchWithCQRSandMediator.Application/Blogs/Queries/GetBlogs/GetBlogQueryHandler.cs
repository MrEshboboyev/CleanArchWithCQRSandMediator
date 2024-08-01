using CleanArchWithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediator.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAllBlogsAsync();
            
            // convert blog to blogVm
            var blogList = blogs.Select(bg => new BlogVm { Id = bg.Id, Author = bg.Author, 
                Description = bg.Description, Name = bg.Name }).ToList();

            return blogList;
        }
    }
}
