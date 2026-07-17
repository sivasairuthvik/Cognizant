public class CustomerService
{
    private readonly ICustomerRepository repository;

    // Constructor Injection
    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        Console.WriteLine(repository.FindCustomerById(id));
    }
}