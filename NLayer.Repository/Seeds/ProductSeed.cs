﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "Kalem 1",
                Price = 100,
                Stock = 20,
                CreatedAt = DateTime.Now


            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Kalem 2",
                Price = 200,
                Stock = 30,
                CreatedAt = DateTime.Now


            },
             new Product
             {
                 Id = 3,
                 CategoryId = 1,
                 ProductName = "Kalem 3",
                 Price = 600,
                 Stock = 60,
                 CreatedAt = DateTime.Now


             },
               new Product
               {
                   Id = 4,
                   CategoryId = 2,
                   ProductName = "Kitap 1",
                   Price = 600,
                   Stock = 60,
                   CreatedAt = DateTime.Now


               },
               new Product
               {
                   Id = 5,
                   CategoryId = 2,
                   ProductName = "Kitap 2",
                   Price = 6600,
                   Stock = 320,
                   CreatedAt = DateTime.Now


               });
        }
    }
}
