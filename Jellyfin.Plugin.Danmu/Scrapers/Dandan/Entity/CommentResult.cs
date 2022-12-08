using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Jellyfin.Plugin.Danmu.Scrapers.Dandan.Entity
{
    public class CommentResult
    {
        [JsonPropertyName("comments")]
        public List<Comment> Comments { get; set; }
    }
}
