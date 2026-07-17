public class CustomerRepository : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return $"Customer ID: {id}, Name: Siva Sai Ruthvik";
    }
}