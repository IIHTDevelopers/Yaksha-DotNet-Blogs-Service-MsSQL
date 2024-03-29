﻿using BlogsApplication.BusinessLayer.ViewModels;
using BlogsApplication.DataLayer;
using BlogsApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsApplication.BusinessLayer.Services.Repository
{
    public class BlogRepository:IBlogRepository
    {
        private readonly BlogDbContext _blogDbContext;
        public BlogRepository(BlogDbContext blogsDbContext)
        {
            _blogDbContext = blogsDbContext;
        }

        public async Task<Blog> AddBlog(Blog blog)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Blog> DeleteBlog(int blogId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Blog>> GetAllBlogs()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Blog> GetBlogById(int blogId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Blog> UpdateBlog(BlogViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
