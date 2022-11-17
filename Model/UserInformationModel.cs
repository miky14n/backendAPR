using MongoDB.Bson;

namespace appPrevencionRiesgos.Model.Security
{
    public class UserInformationModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string Phone { get; set; }
    }
}
