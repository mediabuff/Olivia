﻿using BlogEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Dtos
{
    public class BlogAddOrUpdateResponseDto: BlogDto
    {
        public BlogAddOrUpdateResponseDto(Blog entity)
        :base(entity)
        {

        }
    }
}
