using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using AutoMapper.Configuration.Annotations;

namespace FreeCourse.Services.Catalog.Dto
{
    public class CategoryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
