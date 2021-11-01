using System;


namespace Array_Classes
{
	class User
	{
		string userName;
		string emailid;
		string passwrd;
		long mobileNo;

		public void GetDetails()
		{
			object[] arr = new object[4];
			Console.WriteLine("Please Enter your User Name");
			userName = Console.ReadLine();
			arr[0] = userName;
			Console.WriteLine("Please Enter your User emailid");
			emailid = Console.ReadLine();
			 arr[1] = emailid;
			Console.WriteLine("Please Enter your User Password");
			passwrd = Console.ReadLine();
			arr[2] = passwrd;
			Console.WriteLine("Please Enter your User MobileNo");
			mobileNo =Convert.ToInt64( Console.ReadLine());
			arr[3] = mobileNo;
			foreach(object obj in arr)
			{
				Console.WriteLine(obj);
			}

		}

	}
}
