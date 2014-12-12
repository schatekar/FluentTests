namespace REST.EndToEnd
{
    public class ARequest {
        public static RequestBuilder<T> ToCreate<T>(T resource)
        {
            return new RequestBuilder<T>(resource);
        }
    }
}