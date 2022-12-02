using ClassMetotDemo;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1= new Customer();
        customer1.Id = 1;
        customer1.FirstName = "Emre";
        customer1.LastName = "Yıldız";

        CustomerManager customerManager= new CustomerManager();
        customerManager.Add(customer1);
        customerManager.Delete(customer1);
        customerManager.Update(customer1);
    }
}
