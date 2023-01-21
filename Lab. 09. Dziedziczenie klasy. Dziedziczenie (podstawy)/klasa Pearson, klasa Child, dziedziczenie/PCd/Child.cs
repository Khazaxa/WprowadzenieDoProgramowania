using System;


namespace PCd
{
    public class Child : Person
    {
        private readonly Person mother;
        private readonly Person father;

        public Child(string firstName, string familyName, int age, Person mother = null, Person father = null) : base(firstName, familyName, age)
        {
            if (age > 15)
                throw new ArgumentException("Child’s age must be less than 15!");
            this.mother = mother;
            this.father = father;
        }

        public override void modifyAge(int age)
        {
            if (age < 0 || age > 15)
                throw new ArgumentException("Child’s age must be less than 15!");
            Age = age;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "mother: " + (mother != null ? mother.ToString() : "No data") + "\n" +
                "father: " + (father != null ? father.ToString() : "No data");
        }
    }


}
