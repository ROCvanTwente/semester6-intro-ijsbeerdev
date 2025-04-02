namespace CSHARP_02.Models
{
    // Gemaakt door Jesper
    public interface IAnimal
    {
        string Name { get; set; }
        double Weight { get; set; }
        int Age { get; set; }

        void UpdateName(string name);
        void UpdateWeight(double weight);
        void UpdateAge(int age);
        string GetInfo();
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public void UpdateName(string name) => Name = name;
        public void UpdateWeight(double weight) => Weight = weight;
        public void UpdateAge(int age) => Age = age;
        public string GetInfo() => $"Dog: {Name}, {Age} years, {Weight} kg";
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public void UpdateName(string name) => Name = name;
        public void UpdateWeight(double weight) => Weight = weight;
        public void UpdateAge(int age) => Age = age;
        public string GetInfo() => $"Cat: {Name}, {Age} years, {Weight} kg";
    }

}
