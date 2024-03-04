namespace Lab1
{
    public class Emp
    {
        private int No;
        private string Name;
        private int Sal;

        public Emp(int no, string name, int sal)
        {
            No = no;
            Name = name;
            Sal = sal;
        }

        public int No1
        {
            get => No;
            set => No = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public int Sal1
        {
            get => Sal;
            set => Sal = value;
        }
    }
}