﻿namespace appPrevencionRiesgos.Model.Security
{
    public class UserModel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string tokenByGoogle { get; set; }
    }
}
