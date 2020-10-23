using System;
using System.Collections.Generic;

namespace Pleasure.Data.Models
{
    public class UserModels
    {
        public Guid _id { get; set; }
        public string UserName { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string ProfilePhoto { get; set; }
        public List<Guid> Subscribers { get; set; }
        public List<Guid> Subscribed { get; set; }
    }
}
