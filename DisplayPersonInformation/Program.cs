using DisplayPersonInformation.Concrete; 
using DisplayPersonInformation.Entity;
using DisplayPersonInformation.Factory;
using DisplayPersonInformation.Static; 



DateTime birthday = DateTime.ParseExact("14/09/1987", "dd/MM/yyyy", null); 
Person person = Factory.GetPersonInstance("Onur", "Derman", "123456", "Istanbul", birthday); 

Menu.DisplayMenu();
int validOption = Option.GetValidOption();

PersonInfoFormats infoType = Factory.GetPersonInfoFormatsInstance();
Console.WriteLine(person.ToString(infoType.GetSelectedPersonInfoFormat(validOption)));   



Console.ReadKey();