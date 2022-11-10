using MongoDB.Bson;

namespace appPrevencionRiesgos.Model
{
    public class BasicInformationModel
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

    }
}
