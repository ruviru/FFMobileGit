using System;

namespace ffmobile
{
	public class Contact
	{
		public string ContactName { get; set; }
		public Contact ()
		{
		}
		public static Contact[] GetDataList()
		{
			return new Contact[] {
				new Contact { ContactName = "test1" },
				new Contact { ContactName = "test2" }
			};
		}
	}
}

