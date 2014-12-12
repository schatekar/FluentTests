using NUnit.Framework.Constraints;

namespace REST.EndToEnd.NUnit
{
    public class ContainsHeader
    {
        public static LocationHeaderConstraint Location
        {
            get { throw new System.NotImplementedException(); }
        }
    }

    public class LocationHeaderConstraint : Constraint {
        private string location;

        public override bool Matches(object actual)
        {
            var response = actual as Response;

            if (response == null) return false;

            //Extract location header value from response and compare it with location field value
            return true;
        }

        public override void WriteDescriptionTo(MessageWriter writer)
        {
            throw new System.NotImplementedException();
        }

        public Constraint HavingValue(string value)
        {
            location = value;
            return this;
        }
    }
}