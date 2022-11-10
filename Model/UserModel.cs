﻿using MongoDB.Bson;

namespace appPrevencionRiesgos.Model.Security
{
    public class UserModel
    {
        public ObjectId Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string TokenByGoogle { get; set; }
    }
}
