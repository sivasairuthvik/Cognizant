ICustomerRepository repository = new CustomerRepository();

CustomerService service = new CustomerService(repository);

service.GetCustomer(101);