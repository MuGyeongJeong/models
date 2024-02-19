using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class Response<T>
    {
        public string? code { get; set; }
        public string? message { get; set; }
        public T? data { get; set; }
    }
}
