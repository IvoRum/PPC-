using Lab22Method;

public class MainApp
{
    public static void Main1()
    {
        DataAccessObject daoCategories = new Categories(); 
        daoCategories.Run();
        
        DataAccessObject daoProducts = new Products(); 
        daoProducts.Run(); 
        
    }
}


        

interface IPrimitives { 

    string Operation1(); 

    string Operation2(); 

} 

       

class Algorithm { 

    public void TemplateMethod(IPrimitives a) { 

        string s =  

            a.Operation1() + 

            a.Operation2(); 

        Console.WriteLine(s); 

    } 

} 

 

class ClassA : IPrimitives { 

    public string Operation1() { 

        return "ClassA:Op1 "; 

    } 

    public string Operation2() { 

        return "ClassA:Op2 "; 

    } 

} 

 

class ClassB : IPrimitives { 

    public string Operation1() { 

        return "ClassB:Op1 "; 

    } 

    public string Operation2() { 

        return "ClassB.Op2 "; 

    } 

} 

 

class TemplateMethodPattern { 

     

    static void Main() { 

        Algorithm m = new Algorithm(); 

            

        m.TemplateMethod(new ClassA()); 

        m.TemplateMethod(new ClassB()); 

    } 

} 