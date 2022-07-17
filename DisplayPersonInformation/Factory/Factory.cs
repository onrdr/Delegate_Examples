using DisplayPersonInformation.Concrete;
using DisplayPersonInformation.Entity;

namespace DisplayPersonInformation.Factory
{
    public static class Factory
    {
        public static Person GetPersonInstance(string name, string lastName, string tckn, string placeOfBirth, DateTime birthday)
        {
            return new Person
            {
                Name = name,
                LastName = lastName,
                Tckn = tckn,
                PlaceOfBirth = placeOfBirth,
                Birthday = birthday
            };
        }
        public static PersonInfoFormats GetPersonInfoFormatsInstance()
        {
            return new PersonInfoFormats();
        }
    }
}
