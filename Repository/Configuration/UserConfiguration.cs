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
                new User { Id = new Guid("25f87c58-9061-4bb7-aa3a-4a05177481d2"), FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Username = "johndoe", Password = "password1", Address = "123 Main St" },
                new User { Id = new Guid("538091ec-802c-460d-a56e-8ce2414782b2"), FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Username = "janesmith", Password = "password2", Address = "456 Elm St" },
                new User { Id = new Guid("3f86cc51-c688-42de-aa44-d35c5db73bc4"), FirstName = "Elmer", LastName = "Fudd", Email = "elmer.fudd@example.com", Username = "elmerfudd", Password = "password3", Address = "789 Loon St" }
            );
        }
    }
}
