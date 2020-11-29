﻿using CodeClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CodeClinic.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet<IssueTicket> IssueTickets {get;set;}
        DbSet<Category> Categories { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Like> Likes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
