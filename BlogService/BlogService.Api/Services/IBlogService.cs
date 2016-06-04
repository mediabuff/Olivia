﻿using BlogService.Api.Dtos;
using System.Collections.Generic;

namespace BlogService.Api.Services
{
    public interface IBlogService
    {
        BlogAddOrUpdateResponseDto AddOrUpdate(BlogAddOrUpdateRequestDto request);
        ICollection<BlogDto> Get();
        BlogDto GetById(int id);
        dynamic Remove(int id);
    }
}
