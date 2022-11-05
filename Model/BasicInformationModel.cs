using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace appPrevencionRiesgos.Model
{
    public class BasicInformationModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

    }
}
