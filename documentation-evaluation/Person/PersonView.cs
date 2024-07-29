using System;

namespace documentation_evaluation.person
{
    public class PersonView
    {
        private PersonViewModel _viewModel;

        public PersonView(PersonViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {_viewModel.Name}, Age: {_viewModel.Age}");
        }

        public void UpdateName()
        {
            Console.Write("Enter a new name: ");
            _viewModel.Name = Console.ReadLine();
        }

        public void UpdateAge()
        {
            Console.Write("Enter a new age: ");
            _viewModel.Age = int.Parse(Console.ReadLine());
        }
    }
}