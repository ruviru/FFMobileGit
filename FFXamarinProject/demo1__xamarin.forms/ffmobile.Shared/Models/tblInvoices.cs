using System;
using System.Text;
using SQLite;

namespace ffmobile.Models
{

	/**
	 * This class presents a simple ORM over the Zumero-synced SQLite 
	 * table.  Some properties may require conversion from C# objects
	 * to the representation that Zumero requires in SQLite.  For more
	 * information on why some data types are converted when stored in 
	 * a Zumero-synced SQLite database, see: 
	 * http://zumero.com/docs/zumero_for_sql_server_manager.html#data_type_conversion_and_limitations
	 */
	[Table("tblInvoices")]
	public class tblInvoices : BaseModel
	{
		public tblInvoices()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
		[NotNull]
		[AutoIncrement, Column("InvoiceId")]
		public int InvoiceId 
		{ 
			get { return InvoiceId_private; }
			set { SetProperty(InvoiceId_private, value, (val) => { InvoiceId_private = val; }, InvoiceId_PropertyName); }
		}
		public static string InvoiceId_PropertyName = "InvoiceId";
		private int InvoiceId_private;
		
		



		[Column("SubscriberId")]
		public Nullable<int> SubscriberId 
		{ 
			get { return SubscriberId_private; }
			set { SetProperty(SubscriberId_private, value, (val) => { SubscriberId_private = val; }, SubscriberId_PropertyName); }
		}
		public static string SubscriberId_PropertyName = "SubscriberId";
		private Nullable<int> SubscriberId_private;
		
		



		[Column("AddressBlock")]
		public string AddressBlock 
		{ 
			get { return AddressBlock_private; }
			set { SetProperty(AddressBlock_private, value, (val) => { AddressBlock_private = val; }, AddressBlock_PropertyName); }
		}
		public static string AddressBlock_PropertyName = "AddressBlock";
		private string AddressBlock_private;
		
		



		[Column("ContactName")]
		public string ContactName 
		{ 
			get { return ContactName_private; }
			set { SetProperty(ContactName_private, value, (val) => { ContactName_private = val; }, ContactName_PropertyName); }
		}
		public static string ContactName_PropertyName = "ContactName";
		private string ContactName_private;
		
		



		[Column("CreatedById")]
		public Nullable<int> CreatedById 
		{ 
			get { return CreatedById_private; }
			set { SetProperty(CreatedById_private, value, (val) => { CreatedById_private = val; }, CreatedById_PropertyName); }
		}
		public static string CreatedById_PropertyName = "CreatedById";
		private Nullable<int> CreatedById_private;
		
		



		[Column("CreatedDate")]

		// The actual column definition, as seen in SQLite
		public string CreatedDate_raw { get; set; }

		public static string CreatedDate_PropertyName = "CreatedDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> CreatedDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return CreatedDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(CreatedDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(CreatedDate_raw, CreatedDate_ConvertToString(value), (val) => { CreatedDate_raw = val; }, CreatedDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string CreatedDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("CreatedUserName")]
		public string CreatedUserName 
		{ 
			get { return CreatedUserName_private; }
			set { SetProperty(CreatedUserName_private, value, (val) => { CreatedUserName_private = val; }, CreatedUserName_PropertyName); }
		}
		public static string CreatedUserName_PropertyName = "CreatedUserName";
		private string CreatedUserName_private;
		
		



		[Column("CurrencyCode")]
		public string CurrencyCode 
		{ 
			get { return CurrencyCode_private; }
			set { SetProperty(CurrencyCode_private, value, (val) => { CurrencyCode_private = val; }, CurrencyCode_PropertyName); }
		}
		public static string CurrencyCode_PropertyName = "CurrencyCode";
		private string CurrencyCode_private;
		
		



		[Column("CurrencySymbol")]
		public string CurrencySymbol 
		{ 
			get { return CurrencySymbol_private; }
			set { SetProperty(CurrencySymbol_private, value, (val) => { CurrencySymbol_private = val; }, CurrencySymbol_PropertyName); }
		}
		public static string CurrencySymbol_PropertyName = "CurrencySymbol";
		private string CurrencySymbol_private;
		
		



		[Column("DateDeleted")]

		// The actual column definition, as seen in SQLite
		public string DateDeleted_raw { get; set; }

		public static string DateDeleted_PropertyName = "DateDeleted";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> DateDeleted { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return DateDeleted_raw != null ? (Nullable<DateTime>)DateTime.Parse(DateDeleted_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(DateDeleted_raw, DateDeleted_ConvertToString(value), (val) => { DateDeleted_raw = val; }, DateDeleted_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string DateDeleted_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		


		[NotNull]
		[Column("Deleted")]
		public bool Deleted 
		{ 
			get { return Deleted_private; }
			set { SetProperty(Deleted_private, value, (val) => { Deleted_private = val; }, Deleted_PropertyName); }
		}
		public static string Deleted_PropertyName = "Deleted";
		private bool Deleted_private;
		
		



		[Column("DeletedById")]
		public Nullable<int> DeletedById 
		{ 
			get { return DeletedById_private; }
			set { SetProperty(DeletedById_private, value, (val) => { DeletedById_private = val; }, DeletedById_PropertyName); }
		}
		public static string DeletedById_PropertyName = "DeletedById";
		private Nullable<int> DeletedById_private;
		
		



		[Column("InvoiceAmount")]
		public Nullable<double> InvoiceAmount 
		{ 
			get { return InvoiceAmount_private; }
			set { SetProperty(InvoiceAmount_private, value, (val) => { InvoiceAmount_private = val; }, InvoiceAmount_PropertyName); }
		}
		public static string InvoiceAmount_PropertyName = "InvoiceAmount";
		private Nullable<double> InvoiceAmount_private;
		
		



		[Column("InvoiceDate")]

		// The actual column definition, as seen in SQLite
		public string InvoiceDate_raw { get; set; }

		public static string InvoiceDate_PropertyName = "InvoiceDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> InvoiceDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return InvoiceDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(InvoiceDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(InvoiceDate_raw, InvoiceDate_ConvertToString(value), (val) => { InvoiceDate_raw = val; }, InvoiceDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string InvoiceDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("InvoiceNumber")]
		public string InvoiceNumber 
		{ 
			get { return InvoiceNumber_private; }
			set { SetProperty(InvoiceNumber_private, value, (val) => { InvoiceNumber_private = val; }, InvoiceNumber_PropertyName); }
		}
		public static string InvoiceNumber_PropertyName = "InvoiceNumber";
		private string InvoiceNumber_private;
		
		



		[Column("InvoiceText")]
		public string InvoiceText 
		{ 
			get { return InvoiceText_private; }
			set { SetProperty(InvoiceText_private, value, (val) => { InvoiceText_private = val; }, InvoiceText_PropertyName); }
		}
		public static string InvoiceText_PropertyName = "InvoiceText";
		private string InvoiceText_private;
		
		



		[Column("LastUpdate")]

		// The actual column definition, as seen in SQLite
		public string LastUpdate_raw { get; set; }

		public static string LastUpdate_PropertyName = "LastUpdate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> LastUpdate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return LastUpdate_raw != null ? (Nullable<DateTime>)DateTime.Parse(LastUpdate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(LastUpdate_raw, LastUpdate_ConvertToString(value), (val) => { LastUpdate_raw = val; }, LastUpdate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string LastUpdate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("MonthlyUserFee")]
		public Nullable<double> MonthlyUserFee 
		{ 
			get { return MonthlyUserFee_private; }
			set { SetProperty(MonthlyUserFee_private, value, (val) => { MonthlyUserFee_private = val; }, MonthlyUserFee_PropertyName); }
		}
		public static string MonthlyUserFee_PropertyName = "MonthlyUserFee";
		private Nullable<double> MonthlyUserFee_private;
		
		


		[NotNull]
		[Column("Paid")]
		public bool Paid 
		{ 
			get { return Paid_private; }
			set { SetProperty(Paid_private, value, (val) => { Paid_private = val; }, Paid_PropertyName); }
		}
		public static string Paid_PropertyName = "Paid";
		private bool Paid_private;
		
		



		[Column("PaidDate")]

		// The actual column definition, as seen in SQLite
		public string PaidDate_raw { get; set; }

		public static string PaidDate_PropertyName = "PaidDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> PaidDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return PaidDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(PaidDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(PaidDate_raw, PaidDate_ConvertToString(value), (val) => { PaidDate_raw = val; }, PaidDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string PaidDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("Phone")]
		public string Phone 
		{ 
			get { return Phone_private; }
			set { SetProperty(Phone_private, value, (val) => { Phone_private = val; }, Phone_PropertyName); }
		}
		public static string Phone_PropertyName = "Phone";
		private string Phone_private;
		
		



		[Column("UpdateUserId")]
		public Nullable<int> UpdateUserId 
		{ 
			get { return UpdateUserId_private; }
			set { SetProperty(UpdateUserId_private, value, (val) => { UpdateUserId_private = val; }, UpdateUserId_PropertyName); }
		}
		public static string UpdateUserId_PropertyName = "UpdateUserId";
		private Nullable<int> UpdateUserId_private;
		
		



		[Column("UpdateUserName")]
		public string UpdateUserName 
		{ 
			get { return UpdateUserName_private; }
			set { SetProperty(UpdateUserName_private, value, (val) => { UpdateUserName_private = val; }, UpdateUserName_PropertyName); }
		}
		public static string UpdateUserName_PropertyName = "UpdateUserName";
		private string UpdateUserName_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(InvoiceId.ToString());

			sb.Append("|");

			if (SubscriberId.HasValue)
			{
				sb.Append(SubscriberId.ToString());
			}
			sb.Append("|");

			if (AddressBlock != null)
			{
				sb.Append(AddressBlock.ToString());
			}
			sb.Append("|");

			if (ContactName != null)
			{
				sb.Append(ContactName.ToString());
			}
			sb.Append("|");

			if (CreatedById.HasValue)
			{
				sb.Append(CreatedById.ToString());
			}
			sb.Append("|");

			if (CreatedDate != null)
			{
				sb.Append(CreatedDate_ConvertToString(CreatedDate));
			}
			sb.Append("|");

			if (CreatedUserName != null)
			{
				sb.Append(CreatedUserName.ToString());
			}
			sb.Append("|");

			if (CurrencyCode != null)
			{
				sb.Append(CurrencyCode.ToString());
			}
			sb.Append("|");

			if (CurrencySymbol != null)
			{
				sb.Append(CurrencySymbol.ToString());
			}
			sb.Append("|");

			if (DateDeleted != null)
			{
				sb.Append(DateDeleted_ConvertToString(DateDeleted));
			}
			sb.Append("|");

			sb.Append(Deleted.ToString());

			sb.Append("|");

			if (DeletedById.HasValue)
			{
				sb.Append(DeletedById.ToString());
			}
			sb.Append("|");

			if (InvoiceAmount.HasValue)
			{
				sb.Append(InvoiceAmount.ToString());
			}
			sb.Append("|");

			if (InvoiceDate != null)
			{
				sb.Append(InvoiceDate_ConvertToString(InvoiceDate));
			}
			sb.Append("|");

			if (InvoiceNumber != null)
			{
				sb.Append(InvoiceNumber.ToString());
			}
			sb.Append("|");

			if (InvoiceText != null)
			{
				sb.Append(InvoiceText.ToString());
			}
			sb.Append("|");

			if (LastUpdate != null)
			{
				sb.Append(LastUpdate_ConvertToString(LastUpdate));
			}
			sb.Append("|");

			if (MonthlyUserFee.HasValue)
			{
				sb.Append(MonthlyUserFee.ToString());
			}
			sb.Append("|");

			sb.Append(Paid.ToString());

			sb.Append("|");

			if (PaidDate != null)
			{
				sb.Append(PaidDate_ConvertToString(PaidDate));
			}
			sb.Append("|");

			if (Phone != null)
			{
				sb.Append(Phone.ToString());
			}
			sb.Append("|");

			if (UpdateUserId.HasValue)
			{
				sb.Append(UpdateUserId.ToString());
			}
			sb.Append("|");

			if (UpdateUserName != null)
			{
				sb.Append(UpdateUserName.ToString());
			}
			sb.Append("|");

			return sb.ToString();
		}
	}
}