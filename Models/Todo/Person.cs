using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TodoWebAPI.Models.Todo
{
    public class Person
    {

        public uint PersonId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<TodoItem> ThingsTodo { get; set; }

    }
}