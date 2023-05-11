public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

public class Address
{
	public string Street { get; set; }
	public string City { get; set; }
	public string ZipCode { get; set; }
}

public class Company
{
	public string Name { get; set; }
	public Address Address { get; set; }
}

public class Employee : Person
{
	public decimal Salary { get; set; }
	public Company Company { get; set; }
}
public class Person1
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

public class Address1
{
	public string Street { get; set; }
	public string City { get; set; }
	public string ZipCode { get; set; }
}

public class Company1
{
	public string Name { get; set; }
	public Address Address { get; set; }
}

public class Employee1 : Person
{
	public decimal Salary { get; set; }
	public Company Company { get; set; }
}