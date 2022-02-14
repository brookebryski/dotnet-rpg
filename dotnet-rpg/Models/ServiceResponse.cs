namespace dotnet_rpg.Models

// Questions for Lord Charles:
// I still do not really get the point
// Why are we setting the message to null? How do we get a message then?

{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = null;
    }
}
