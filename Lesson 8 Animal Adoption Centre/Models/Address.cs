namespace Lesson_8_Animal_Adoption_Centre.Models
{
    public class Address
    {
        public string streetNumber;
        public string streetName;
        public string city;
        public int postcode;

        public string GetAddress()
        {
            return $"{streetNumber} {streetName}, {city}";
        }
    }
}