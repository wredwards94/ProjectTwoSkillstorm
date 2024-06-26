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
    public class UserDeviceConfiguration : IEntityTypeConfiguration<UserDevice>
    {
        public void Configure(EntityTypeBuilder<UserDevice> builder)
        {
            // Sample data for UserDevice entity
            builder.HasData(

                new UserDevice
                {
                    Id = new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                    DeviceId = new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                    PhoneNumber = "2629423847",
                    UserId = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"),
                    UserPlanId = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"),
                    ActivationDate = DateTime.Parse("2024-01-01")
                },

                new UserDevice
                {
                    Id = new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                    DeviceId = new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                    PhoneNumber = "7187624769",
                    UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"),
                    UserPlanId = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                    ActivationDate = DateTime.Parse("2024-02-01")
                },

                new UserDevice
                {
                    Id = new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                    DeviceId = new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                    PhoneNumber = "3036313605",
                    UserId = new string("538091ec-802c-460d-a56e-8ce2414782b2"),
                    UserPlanId = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                    ActivationDate = DateTime.Parse("2024-03-15")
                },

                new UserDevice
                {
                    Id = new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                    DeviceId = new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                    PhoneNumber = "8472898809",
                    UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                    UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                    ActivationDate = DateTime.Parse("2023-08-21")
                },

                new UserDevice
                {
                    Id = new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                    DeviceId = new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                    PhoneNumber = "2085544516",
                    UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                    UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                    ActivationDate = DateTime.Parse("2024-03-08")
                },

                new UserDevice
                {
                    Id = new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                    DeviceId = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                    PhoneNumber = "7712780071",
                    UserId = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"),
                    UserPlanId = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                    ActivationDate = DateTime.Parse("2024-02-14")
                },
                new UserDevice
                {
                    Id = Guid.NewGuid(),
                    DeviceId = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                    PhoneNumber = "5556869009",
                    UserId = new string("838cb215-63f4-4880-bc9e-f0367316183a"),
                    UserPlanId = new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                    ActivationDate = DateTime.Parse("2024-02-22")
                }
            );
        }
    }
}
