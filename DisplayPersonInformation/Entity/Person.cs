using static DisplayPersonInformation.Delegate.Delegates;

namespace DisplayPersonInformation.Entity
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tckn { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }

        public string ToString(PersonInfoFormatFunc formatFunc)
        {
            return formatFunc is null ? ToString() : formatFunc(this);
        }
    }
}
