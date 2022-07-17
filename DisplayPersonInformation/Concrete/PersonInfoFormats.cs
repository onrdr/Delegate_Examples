using DisplayPersonInformation.Entity;
using DisplayPersonInformation.Enum;
using static DisplayPersonInformation.Delegate.Delegates;

namespace DisplayPersonInformation.Concrete
{
    public class PersonInfoFormats
    {
        public PersonInfoFormatFunc GetSelectedPersonInfoFormat(int validOption)
        {

            return (validOption - 1) switch
            {
                (int)PersonInfoFormatsEnum.FullName => GetFullName,
                (int)PersonInfoFormatsEnum.FullNameTckn => GetFullName_Tckn,
                (int)PersonInfoFormatsEnum.FullNameBirthDay => GetFullName_BirthDay,
                (int)PersonInfoFormatsEnum.FullNamePlaceOfBirth => GetFullName_PlaceOfBirth,
                _ => null,
            };
        }

        string GetFullName(Person person)
        {
            return $"{person.Name} {person.LastName}";
        }

        string GetFullName_Tckn(Person person)
        {
            return $"{person.Name} {person.LastName} {person.Tckn}";
        }

        string GetFullName_BirthDay(Person person)
        {
            return $"{person.Name} {person.LastName} {person.Birthday}";
        }

        string GetFullName_PlaceOfBirth(Person person)
        {
            return $"{person.Name} {person.LastName} {person.PlaceOfBirth}";
        }
    }
}
