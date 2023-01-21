using System;

namespace PCd
{
    public class Person
    {
        protected string FirstName { get; set; }
        protected string FamilyName { get; set; }
        protected int Age { get; set; }

        public Person(string firstName, string familyName, int age)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(familyName))
                throw new ArgumentException("Wrong name!");

            if (age < 0)
                throw new ArgumentException("Age must be positive!");

            // remove spaces and correct format of first letter
            firstName = firstName.Trim();
            familyName = familyName.Trim();
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
            familyName = char.ToUpper(familyName[0]) + familyName.Substring(1).ToLower();
            familyName = familyName.Replace(" ", string.Empty);

            bool isFirstNameValid = true;
            bool isFamilyNameValid = true;

            for (int i = 0; i < firstName.Length; i++)
            {
                if (!char.IsLetter(firstName[i]))
                {
                    isFirstNameValid = false;
                    break;
                }
            }

            for (int i = 0; i < familyName.Length; i++)
            {
                if (!char.IsLetter(familyName[i]))
                {
                    isFamilyNameValid = false;
                    break;
                }
            }
           
            if (!isFirstNameValid || !isFamilyNameValid)
               throw new ArgumentException("Wrong name!");

            FirstName = firstName;
            FamilyName = familyName;
            Age = age;
        }

        public void modifyFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Wrong name!");

            firstName = firstName.Trim();
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();

            bool isFirstNameValid = true;
            firstName = firstName.Replace(" ", string.Empty);
            for (int i = 0; i < firstName.Length; i++)
            {
                if (!char.IsLetter(firstName[i]))
                {
                    isFirstNameValid = false;
                    break;
                }
            }

            if (!isFirstNameValid)
                throw new ArgumentException("Wrong name!");

            FirstName = firstName;
        }

        public void modifyFamilyName(string familyName)
        {
            if (string.IsNullOrWhiteSpace(familyName))
                throw new ArgumentException("Wrong name!");

            familyName = familyName.Trim();
            familyName = char.ToUpper(familyName[0]) + familyName.Substring(1).ToLower();

            bool isFamilyNameValid = true;
            familyName = familyName.Replace(" ", string.Empty);
            for (int i = 0; i < familyName.Length; i++)
            {
                if (!char.IsLetter(familyName[i]))
                {
                    isFamilyNameValid = false;
                    break;
                }
            }

            if (!isFamilyNameValid)
                throw new ArgumentException("Wrong name!");

            FamilyName = familyName;
        }
        public virtual void modifyAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age must be positive!");
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Age})";
        }
    }
}