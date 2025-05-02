using AutoMapper;
using Blog.Core.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Models.System
{
    public class RoleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile() 
            {
                CreateMap<AppRole, RoleDto>();
            }
        }
    }
}
