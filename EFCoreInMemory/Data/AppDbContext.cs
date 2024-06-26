﻿using EFCoreInMemory.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInMemory.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CustomerDataModel> Customers { get; set; }
}