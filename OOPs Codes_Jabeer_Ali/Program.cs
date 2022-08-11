// See https://aka.ms/new-console-template for more information

                                    //----------OOPS CODES----------//

            //1)Single Level Inheritence Code:
	
class Kalpita
{
    public int Company_Code = 9008;
    public string name = "Kalpita_Technologies";
    public void CompanyDetails()
    {
        Console.WriteLine("Here you get all the details of Employee Details");
    }
}

class Employee : Kalpita
{
    public string Employee_Name = "Jabeer";
    public string Employee_ID = "06T019";
    double salary = 22500.78;
    public void EmployeeDetails()
    {
        Console.WriteLine("The Employee Company is " + name + "  and Id is " + Company_Code);
        Console.WriteLine("The Employee name and Id is " + Employee_Name + " & " + Employee_ID + " and his salary is " + salary);
    }
}


class HR
{
    static void Main(string[] args)
    {
        Employee E = new Employee();
        E.CompanyDetails();
        E.EmployeeDetails();
    }

}


//---------------------------------------------------2)Hierarchical Inheritence-------------------------------------------------


class Vehicles
{
    public string Engine_size = "Big";
    public void ShowDetails()
    {
        Console.WriteLine("The Details of Vehicle is given below");
    }
}

class Bike : Vehicles
{
    public string Engine_size = "small";
    public string Bike_Color = "Blue";
    public void BikeDetails()
    {
        Console.WriteLine("Bike engine size is " + Engine_size + " and color is  " + Bike_Color);
    }
}

class Car : Vehicles
{

    public string Engine_size = "Big";
    public string Car_Color = "Red";
    public void CarDetails()
    {
        Console.WriteLine("Car engine size is " + Engine_size + " and color is  " + Car_Color);
    }
}

class Customer
{
    public static void Main()
    {
        Bike b = new Bike();
        b.ShowDetails();
        b.BikeDetails();
        Car c = new Car();
        c.CarDetails();
    }
}

//---------------------------------------------Multilevel Inheritence------------------------------------------//

class Whatsapp
{
    public double version = 6.61;
    public void OldFeatures()
    {
        Console.WriteLine("The verison is " + version);
    }
}

class OGWhatsapp : Whatsapp
{

    public void Features(string color, string Icon_Shape)
    {
        Console.WriteLine("Whatsapp color is " + color + " and icon shape is " + Icon_Shape);
    }
}

class GbWhatsapp : OGWhatsapp
{
    public string storage = "2GB";
    public void NewFeatues()
    {
        Console.WriteLine("Double Tick");
    }
}
class Developer
{
    public static void Main()
    {
        GbWhatsapp g = new GbWhatsapp();
        g.OldFeatures();
        g.Features("blue", "Circle");
        g.NewFeatues();
        Console.WriteLine("The storage of Whatsapp is " + g.storage);

    }
}
//------------------------------------------------------Multiple Inheritence-------------------------------//
class A
{
    string name = "Apple";
    public void fruit()
    {
        Console.WriteLine("I will eat apple" + name);
    }
}
class B
{
    string name = "mango";
    public void fruits()
    {
        Console.WriteLine("I will eat Mango" + name);
    }
}

class Eat : A, B    //Multiple inheritence Not supported in C-sharp
{
    static void Main()
    {
        A a = new A();
        a.fruit();
        B b = new B();
        b.fruits();

    }
}






//---------------------------------------------------Polymorphism---------------------------------------------------//


                     //   1)Run Time Polymorphism(Inheritence, method overriding and Upcasting)
class Electronics
{
    public virtual void AllElectronics()
    {
        Console.WriteLine("Made for various purpose");
    }
}

class Mobile : Electronics //Inherited class
{
    public string brand = "Iphone";
    public override void AllElectronics()
    {
        Console.WriteLine("Supports android Applications");
    }
}

class Tabs : Mobile
{
    public string brand = "Samsung";
    public override void AllElectronics()
    {
        Console.WriteLine("Supports android apllications and size is large " + brand);
    }

}

class customer
{
    public static void Main()
    {
        Electronics e = new Tabs(); //Upcasting
        e.AllElectronics();

    }
}


//--------------------------------------------2) CompileTime Ploymorphism(Method Overloading)----------------------------
class CreateContact
{
    public void createContact(string name, long mobile_number)
    {
        Console.WriteLine("The name is " + name + "and mobile number is " + mobile_number);
    }
    public void createContact(string name, long mobile_number, long mobile_number2)
    {
        Console.WriteLine("The name is " + name + "and mobile number is " + mobile_number + " alternate number is " + mobile_number2);
    }
    public void createContact(string name, string Email)
    {
        Console.WriteLine("The name is " + name + "and Email  is " + Email);
    }
    public void createContact(string name, string Email, long mobile_number)
    {
        Console.WriteLine("Name " + name + " Email " + Email + " mobile  number " + mobile_number);
    }
}
class Mobile
{
    public static void Main(string[] args)
    {
        CreateContact c = new CreateContact();
        c.createContact("Jabeer", 9353159008);
        c.createContact("Jabeer", 8970258238, 9353159008);
        c.createContact("Jabeer", "ali@gmail.com");
        c.createContact("Jabeer", "alli@gmail.com", 9353159008);
    }
}



//--------------------------------------------------Abstraction-----------------------------------------------------------
interface Flipcart
{
    public void orderLaptops();

}

interface Amazon
{

    public void orderLaptops();

    public void makePayments();
}

class Customer : Amazon, Flipcart
{
    public void orderLaptops()
    {
        Console.WriteLine("Ordering hp");
    }
    public void makePayments()
    {
        Console.WriteLine("Payment done succesfulyy");
    }
}
class Tester
{
    public static void Main()
    {
        Customer c = new Customer();
        c.orderLaptops();
        c.makePayments();

    }
}


---------------------------------------------------------------------Encapsulation-------------------------------------------------- -

class User
{
    private string username;
    private string password;
    private string email;
    private long mobile_Number;
    public void setDetails(string username, string password, string email, long mobile_Number)
    {
        this.username = username;
        this.password = password;
        this.email = email;
        this.mobile_Number = mobile_Number;
    }

    public void getDetails()
    {
        Console.WriteLine("The username and password is " + username + " and " + password);
        Console.WriteLine("The Email and Mobile Number is " + email + " and " + mobile_Number);
    }
}

class Developer
{
    public static void Main()
    {
        User user = new User();
        user.setDetails("JabeerAli", "JB@234", "ali786@gmail.com", 9353159008);
        user.getDetails();
    }
}






