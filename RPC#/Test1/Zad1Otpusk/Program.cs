using Zad1Otpusk;

class Program
{
    static void Main(string[] args)
    {
        Vocation vocation = new PaidVocation();
        Rector rector = new Rector(vocation);
        Dekan decan = new Dekan(rector);
        Rukovoditel rucovoditel = new Rukovoditel(decan);
        WorkerDecorator teacher = new Teacher(rucovoditel);
        teacher.requestVecation(45);
    }
}