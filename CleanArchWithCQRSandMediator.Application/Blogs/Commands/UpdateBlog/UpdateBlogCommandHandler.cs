using AutoMapper;
using CleanArchWithCQRSandMediator.Domain.Entity;
using CleanArchWithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediator.Application.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public UpdateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var updateBlogEntity = new Blog() { Id = request.Id, Name = request.Name, 
                Author = request.Author, Description = request.Description};

            return await _blogRepository.UpdateAsync(request.Id, updateBlogEntity);
        }
    }
}
