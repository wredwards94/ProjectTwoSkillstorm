using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Sample data for User entity
            builder.HasData(
                new User { Id = new string("25f87c58-9061-4bb7-aa3a-4a05177481d2"), FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", UserName = "johndoe", PasswordHash = "password1", Address = "123 Main St" },
                new User { Id = new string("538091ec-802c-460d-a56e-8ce2414782b2"), FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", UserName = "janesmith", PasswordHash = "password2", Address = "456 Elm St" },
                new User { Id = new string("3f86cc51-c688-42de-aa44-d35c5db73bc4"), FirstName = "Elmer", LastName = "Fudd", Email = "elmer.fudd@example.com", UserName = "elmerfudd", PasswordHash = "password3", Address = "789 Loon St" },
                new User { Id = new string("838cb215-63f4-4880-bc9e-f0367316183a"), FirstName = "Wesley", LastName = "Edwards", Email = "sample@sample.com", UserName = "wredwards", PasswordHash = "Govols94!@", Address = "1270 Main St" }
            );
        }
    }
}
