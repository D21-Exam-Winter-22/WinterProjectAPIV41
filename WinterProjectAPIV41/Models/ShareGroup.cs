using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WinterProjectAPIV41.Models;

public partial class ShareGroup
{
    public int GroupId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? HasConcluded { get; set; }

    public bool? IsPublic { get; set; }

    [JsonIgnore]
    public virtual ICollection<UserGroup> UserGroups { get; } = new List<UserGroup>();
}
