using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7_dars;

public class User
{
	private Guid userId;

	public Guid UserId
	{
		get { return userId; }
		set { userId = value; }
	}
	private string userName;

	public string UserName
	{
		get { return userName; }
		set { userName = value; }
	}

	private string pasword;

	public string Pasword
	{
		get { return pasword; }
		set { pasword = value; }
	}

	private string lastName;

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}


}
