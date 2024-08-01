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
        public Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
