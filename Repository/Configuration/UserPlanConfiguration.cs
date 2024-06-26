﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class UserPlanConfiguration : IEntityTypeConfiguration<UserPlan>
    {
        public void Configure(EntityTypeBuilder<UserPlan> builder)
        {
            // Sample data for UserPlan entity
            builder.HasData(
                new UserPlan { Id = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"), UserId = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"), PlanId = new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc") },
                new UserPlan { Id = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"), UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"), PlanId = new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f") },
                new UserPlan { Id = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"), UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"), PlanId = new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839") },
                new UserPlan {Id = new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"), UserId = new string("838cb215-63f4-4880-bc9e-f0367316183a"), PlanId = new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc")}
            );
        }
    }
}
