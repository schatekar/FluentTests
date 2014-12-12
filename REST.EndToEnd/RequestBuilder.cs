using System;

namespace REST.EndToEnd
{
    public class RequestBuilder<T>
    {
        public RequestBuilder(T resource)
        {
            throw new System.NotImplementedException();
        }

        public RequestBuilder<T> UsingHeaders(Action<HttpHeaders> action)
        {
            throw new NotImplementedException();
        }

        public Request Build()
        {
            throw new NotImplementedException();
        }
    }
}