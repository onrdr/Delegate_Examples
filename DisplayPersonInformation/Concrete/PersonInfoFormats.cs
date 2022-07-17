using DisplayPersonInformation.Entity;
using DisplayPersonInformation.Enum;
using static DisplayPersonInformation.Delegate.Delegates;

namespace DisplayPersonInformation.Concrete
{
    public class PersonInfoFormats
    {
        public PersonInfoFormatFunc GetSelectedPersonInfoFormat(int validOption)
        {

            switch (validOption - 1)
            {
                case (int)PersonInfoFormatsEnum.FullName:
                    return GetFullName;
                case (int)PersonInfoFormatsEnum.FullNameTckn:
                    return GetFullName_Tckn;
                case (int)PersonInfoFormatsEnum.FullNameBirthDay:
                    return GetFullName_BirthDay;
                case (int)PersonInfoFormatsEnum.FullNamePlaceOfBirth:
                    return GetFullName_PlaceOfBirth;
                default:
                    Console.WriteLine("Not a Valid Option => Displaying Basic Info");
                    return null;
            }
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
