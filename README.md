Do you like writing code using [fluent interface stype](http://martinfowler.com/bliki/FluentInterface.html)? 
This repository contains code samples that use fluent interface style of coding for writing different types of tests. 

###Example

```csharp
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
```

This is a work in progress and contains just very few useful things at the moment. The plan is to expand this to include guidelines for different types of tests e.g. unit tests for ASP.NET MVC, Web API etc. 

These code samples use `NUnit` as unit tests tools so the fluent interfaces around assertions are build by extending NUnit `Constraint` class. I have not looked into other test unit frameworks to find out if similar extensibility is available or not. 
