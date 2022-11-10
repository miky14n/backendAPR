using MongoDB.Bson;

namespace appPrevencionRiesgos.Data.Entities
{
    public class UserEntity
    {
        public ObjectId Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string TokenByGoogle { get; set; }
    }
}
