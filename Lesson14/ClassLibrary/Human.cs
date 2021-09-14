using System;

namespace ClassLibrary
{
    public class Human
    {
        string age;
        string firstName;
        string lastName;

        [RegexMatch(@"[0-9]{0,3}")]
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        [RegexMatch(@"\A[а-яА-Я]{2,8}\Z")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        [RegexMatch(@"\A[а-яА-Я]{2,8}\Z")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
