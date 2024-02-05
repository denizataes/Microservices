using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AutoMapper.Configuration.Annotations;

namespace FreeCourse.Services.Catalog.Dto
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
    }
}
