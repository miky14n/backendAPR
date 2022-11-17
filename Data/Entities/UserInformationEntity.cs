using MongoDB.Bson;

namespace appPrevencionRiesgos.Data.Entities
{
    public class UserInformationEntity
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string Phone { get; set; }
    }
}
