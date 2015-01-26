using System;

namespace ffmobile
{
	public class Contact
	{
		public string ContactName { get; set; }
		public string ContactType { get; set; }

		public static Contact[] GetDataList()
		{
			return new Contact[] {
				new Contact { ContactName = "test1", ContactType = "type1" },
				new Contact { ContactName = "test2", ContactType = "type2" }
			};
		}
	}
}

