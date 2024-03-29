﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.StoreApp.Entities.Models;

namespace YGN.StoreApp.Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.CategoryId);
            builder.Property(p => p.CategoryName).IsRequired();

            builder.HasData(
                    new Category() { CategoryId = 1, CategoryName = "Book" },
                    new Category() { CategoryId = 2, CategoryName = "Electronic" }
                );
        }
    }
}
