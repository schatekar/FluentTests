using System;
using NUnit.Framework;
using REST.EndToEnd.NUnit;
using REST.EndToEnd.Resources;

namespace REST.EndToEnd
{
    [TestFixture]
    public class PostTests
    {
        [Test]
        public void PostIsCreated()
        {
            var request = ARequest
                            .ToCreate(new Post())
                            .UsingHeaders(headers =>
                            {
                                headers.Authorization = "Digest XXXX";
                                headers.RequestId = Guid.NewGuid().ToString();
                                headers.CultureCode = "en-GB";
                            })
                            .Build();

            var response = request.Execute();

            Assert.That(response, HasStatus.Created);
            Assert.That(response, ContainsHeader.Location.HavingValue("some value"));
        }
    }
}
