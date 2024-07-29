namespace documentation_evaluation.person
{
    public class PersonViewModel
    {
        private Person _person;

        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public string Name
        {
            get { return _person.Name; }
            set { _person.Name = value; }
        }

        public int Age
        {
            get { return _person.Age; }
            set { _person.Age = value; }
        }
    }
}