using System;
struct Book{
    string name;
    string avtor;
    string year;

    public Book(string name, string avtor, string year){
        this.name=name;
        this.avtor=avtor;
        this.year=year;
    }
    public void info() //метод
    { Console.WriteLine("Book name: {0}; Avtor: {1}; Year: {2}", name,avtor,year); }
}
class Zad3_8{
    static void Main(){
        Book[] books=new Book[3];
        books[0]=new Book("Pod Igoto","Ivan Vazov","1894");
        books[1]=new Book("Nemili-nedragi","Ivan Vazov","1883");
        books[2]=new Book("pO JICATA","Yordan Yovkov","1927");

        foreach (Book book in books)
        {
            book.info();
        }
        Console.ReadLine();
    }
}