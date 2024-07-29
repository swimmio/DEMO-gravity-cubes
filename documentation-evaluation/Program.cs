using System;
using documentation_evaluation.person;

namespace documentation_evaluation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            Person person = new Person { Name = "John Doe", Age = 30 };
            PersonViewModel viewModel = new PersonViewModel(person);
            PersonView view = new PersonView(viewModel);

            view.Display();
            view.UpdateName();
            view.UpdateAge();
            view.Display();

            Console.ReadKey();
        }
    }
}