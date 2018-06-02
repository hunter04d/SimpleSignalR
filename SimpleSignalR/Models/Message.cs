using System.ComponentModel.DataAnnotations;

namespace SimpleSignalR.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Content { get; set; }
    }
}