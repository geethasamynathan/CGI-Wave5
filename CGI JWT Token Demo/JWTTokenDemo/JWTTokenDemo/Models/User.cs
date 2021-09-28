using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JWTTokenDemo.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
       [JsonProperty(propertyName:"userid")]
        public string UserId { get; set; }
        [JsonProperty(propertyName: "password")]
        public string Password { get; set; }
        [JsonProperty(propertyName: "firstname")]
        public string Firstname { get; set; }
        [JsonProperty(propertyName: "lastname")]
        public string Lastname { get; set; }
    }
}
