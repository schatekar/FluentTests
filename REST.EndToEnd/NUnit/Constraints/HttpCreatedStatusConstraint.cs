using System.Net;
using NUnit.Framework.Constraints;

namespace REST.EndToEnd.NUnit.Constraints
{
    public class HttpCreatedStatusConstraint : Constraint {
        public override bool Matches(object matches)
        {
            var resposne = matches as Response;
            if (resposne == null) return false;

            return resposne.StatusCode == HttpStatusCode.Created;
        }

        public override void WriteDescriptionTo(MessageWriter writer)
        {
            writer.Write("Created");
        }
    }
}