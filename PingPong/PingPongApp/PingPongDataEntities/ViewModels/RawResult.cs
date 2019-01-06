using System;
using System.Collections.Generic;
using System.Text;

namespace PingPongDataEntities.ViewModels
{
    public class RawResult<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
    public class RawResultList<T>
    {
        public List<T> Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }

    public enum StatusCode
    {
        Success = 0,
        Error = 1,
        NotFound = 3
    }

    public class PlayerViewModel
    {
        public long PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string EmailAddress { get; set; }
        public int SkillLevelId { get; set; }
        public string SkillLevelName { get; set; }
    }
}
