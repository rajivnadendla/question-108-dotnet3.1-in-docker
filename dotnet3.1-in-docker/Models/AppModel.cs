using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet3._1_in_docker.Models
{
    public class AppErrorResponse
    {
        public string Status { get; set; }
        public string Reason { get; set; }
    }
    public class AppSuccessResponse
    {
        public string Status { get; set; }
    }
    public class PendingRequest
    {
        public List<string> Friend_Requests { get; set; }
    }
    public class AllFriends
    {
        public AllFriends()
        {
            this.Friends = new List<string>();
        }
        public List<string> Friends { get; set; }
    }
    public class FriendSuggestion
    {
        public List<string> Suggestions { get; set; }
    }
    public class CreateUser
    {
        public string UserName { get; set; }
    }
}
