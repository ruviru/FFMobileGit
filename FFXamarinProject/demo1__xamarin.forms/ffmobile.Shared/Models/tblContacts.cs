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
	[Table("tblContacts")]
	public class tblContacts : BaseModel
	{
		public tblContacts()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
		[NotNull]
		[AutoIncrement, Column("ID")]
		public int ID 
		{ 
			get { return ID_private; }
			set { SetProperty(ID_private, value, (val) => { ID_private = val; }, ID_PropertyName); }
		}
		public static string ID_PropertyName = "ID";
		private int ID_private;
		
		



		[Column("SubscriberId")]
		public Nullable<int> SubscriberId 
		{ 
			get { return SubscriberId_private; }
			set { SetProperty(SubscriberId_private, value, (val) => { SubscriberId_private = val; }, SubscriberId_PropertyName); }
		}
		public static string SubscriberId_PropertyName = "SubscriberId";
		private Nullable<int> SubscriberId_private;
		
		



		[Column("AccountCode")]
		public string AccountCode 
		{ 
			get { return AccountCode_private; }
			set { SetProperty(AccountCode_private, value, (val) => { AccountCode_private = val; }, AccountCode_PropertyName); }
		}
		public static string AccountCode_PropertyName = "AccountCode";
		private string AccountCode_private;
		
		



		[Column("BirthdayDay")]
		public Nullable<int> BirthdayDay 
		{ 
			get { return BirthdayDay_private; }
			set { SetProperty(BirthdayDay_private, value, (val) => { BirthdayDay_private = val; }, BirthdayDay_PropertyName); }
		}
		public static string BirthdayDay_PropertyName = "BirthdayDay";
		private Nullable<int> BirthdayDay_private;
		
		



		[Column("BirthdayMonth")]
		public string BirthdayMonth 
		{ 
			get { return BirthdayMonth_private; }
			set { SetProperty(BirthdayMonth_private, value, (val) => { BirthdayMonth_private = val; }, BirthdayMonth_PropertyName); }
		}
		public static string BirthdayMonth_PropertyName = "BirthdayMonth";
		private string BirthdayMonth_private;
		
		



		[Column("BusinessAddress")]
		public string BusinessAddress 
		{ 
			get { return BusinessAddress_private; }
			set { SetProperty(BusinessAddress_private, value, (val) => { BusinessAddress_private = val; }, BusinessAddress_PropertyName); }
		}
		public static string BusinessAddress_PropertyName = "BusinessAddress";
		private string BusinessAddress_private;
		
		



		[Column("BusinessCity")]
		public string BusinessCity 
		{ 
			get { return BusinessCity_private; }
			set { SetProperty(BusinessCity_private, value, (val) => { BusinessCity_private = val; }, BusinessCity_PropertyName); }
		}
		public static string BusinessCity_PropertyName = "BusinessCity";
		private string BusinessCity_private;
		
		



		[Column("BusinessCountry")]
		public string BusinessCountry 
		{ 
			get { return BusinessCountry_private; }
			set { SetProperty(BusinessCountry_private, value, (val) => { BusinessCountry_private = val; }, BusinessCountry_PropertyName); }
		}
		public static string BusinessCountry_PropertyName = "BusinessCountry";
		private string BusinessCountry_private;
		
		



		[Column("BusinessPhone")]
		public string BusinessPhone 
		{ 
			get { return BusinessPhone_private; }
			set { SetProperty(BusinessPhone_private, value, (val) => { BusinessPhone_private = val; }, BusinessPhone_PropertyName); }
		}
		public static string BusinessPhone_PropertyName = "BusinessPhone";
		private string BusinessPhone_private;
		
		



		[Column("BusinessPhone2")]
		public string BusinessPhone2 
		{ 
			get { return BusinessPhone2_private; }
			set { SetProperty(BusinessPhone2_private, value, (val) => { BusinessPhone2_private = val; }, BusinessPhone2_PropertyName); }
		}
		public static string BusinessPhone2_PropertyName = "BusinessPhone2";
		private string BusinessPhone2_private;
		
		



		[Column("BusinessState")]
		public string BusinessState 
		{ 
			get { return BusinessState_private; }
			set { SetProperty(BusinessState_private, value, (val) => { BusinessState_private = val; }, BusinessState_PropertyName); }
		}
		public static string BusinessState_PropertyName = "BusinessState";
		private string BusinessState_private;
		
		



		[Column("BusinessZipCode")]
		public string BusinessZipCode 
		{ 
			get { return BusinessZipCode_private; }
			set { SetProperty(BusinessZipCode_private, value, (val) => { BusinessZipCode_private = val; }, BusinessZipCode_PropertyName); }
		}
		public static string BusinessZipCode_PropertyName = "BusinessZipCode";
		private string BusinessZipCode_private;
		
		



		[Column("ChildrenNames")]
		public string ChildrenNames 
		{ 
			get { return ChildrenNames_private; }
			set { SetProperty(ChildrenNames_private, value, (val) => { ChildrenNames_private = val; }, ChildrenNames_PropertyName); }
		}
		public static string ChildrenNames_PropertyName = "ChildrenNames";
		private string ChildrenNames_private;
		
		



		[Column("Comments")]
		public string Comments 
		{ 
			get { return Comments_private; }
			set { SetProperty(Comments_private, value, (val) => { Comments_private = val; }, Comments_PropertyName); }
		}
		public static string Comments_PropertyName = "Comments";
		private string Comments_private;
		
		



		[Column("CompanyName")]
		public string CompanyName 
		{ 
			get { return CompanyName_private; }
			set { SetProperty(CompanyName_private, value, (val) => { CompanyName_private = val; }, CompanyName_PropertyName); }
		}
		public static string CompanyName_PropertyName = "CompanyName";
		private string CompanyName_private;
		
		



		[Column("ContactName")]
		public string ContactName 
		{ 
			get { return ContactName_private; }
			set { SetProperty(ContactName_private, value, (val) => { ContactName_private = val; }, ContactName_PropertyName); }
		}
		public static string ContactName_PropertyName = "ContactName";
		private string ContactName_private;
		
		



		[Column("ContactNameSource")]
		public string ContactNameSource 
		{ 
			get { return ContactNameSource_private; }
			set { SetProperty(ContactNameSource_private, value, (val) => { ContactNameSource_private = val; }, ContactNameSource_PropertyName); }
		}
		public static string ContactNameSource_PropertyName = "ContactNameSource";
		private string ContactNameSource_private;
		
		



		[Column("ContactOwnerId")]
		public Nullable<int> ContactOwnerId 
		{ 
			get { return ContactOwnerId_private; }
			set { SetProperty(ContactOwnerId_private, value, (val) => { ContactOwnerId_private = val; }, ContactOwnerId_PropertyName); }
		}
		public static string ContactOwnerId_PropertyName = "ContactOwnerId";
		private Nullable<int> ContactOwnerId_private;
		
		



		[Column("ContactType")]
		public string ContactType 
		{ 
			get { return ContactType_private; }
			set { SetProperty(ContactType_private, value, (val) => { ContactType_private = val; }, ContactType_PropertyName); }
		}
		public static string ContactType_PropertyName = "ContactType";
		private string ContactType_private;
		
		



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
		
		



		[Column("CustomerType")]
		public string CustomerType 
		{ 
			get { return CustomerType_private; }
			set { SetProperty(CustomerType_private, value, (val) => { CustomerType_private = val; }, CustomerType_PropertyName); }
		}
		public static string CustomerType_PropertyName = "CustomerType";
		private string CustomerType_private;
		
		



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
		
		



		[Column("Email")]
		public string Email 
		{ 
			get { return Email_private; }
			set { SetProperty(Email_private, value, (val) => { Email_private = val; }, Email_PropertyName); }
		}
		public static string Email_PropertyName = "Email";
		private string Email_private;
		
		



		[Column("EntityId")]
		public Nullable<int> EntityId 
		{ 
			get { return EntityId_private; }
			set { SetProperty(EntityId_private, value, (val) => { EntityId_private = val; }, EntityId_PropertyName); }
		}
		public static string EntityId_PropertyName = "EntityId";
		private Nullable<int> EntityId_private;
		
		



		[Column("EntityType")]
		public string EntityType 
		{ 
			get { return EntityType_private; }
			set { SetProperty(EntityType_private, value, (val) => { EntityType_private = val; }, EntityType_PropertyName); }
		}
		public static string EntityType_PropertyName = "EntityType";
		private string EntityType_private;
		
		



		[Column("EntityTypeId")]
		public Nullable<int> EntityTypeId 
		{ 
			get { return EntityTypeId_private; }
			set { SetProperty(EntityTypeId_private, value, (val) => { EntityTypeId_private = val; }, EntityTypeId_PropertyName); }
		}
		public static string EntityTypeId_PropertyName = "EntityTypeId";
		private Nullable<int> EntityTypeId_private;
		
		



		[Column("Fax")]
		public string Fax 
		{ 
			get { return Fax_private; }
			set { SetProperty(Fax_private, value, (val) => { Fax_private = val; }, Fax_PropertyName); }
		}
		public static string Fax_PropertyName = "Fax";
		private string Fax_private;
		
		



		[Column("FileUploadId")]
		public Nullable<int> FileUploadId 
		{ 
			get { return FileUploadId_private; }
			set { SetProperty(FileUploadId_private, value, (val) => { FileUploadId_private = val; }, FileUploadId_PropertyName); }
		}
		public static string FileUploadId_PropertyName = "FileUploadId";
		private Nullable<int> FileUploadId_private;
		
		



		[Column("FileUploadDate")]

		// The actual column definition, as seen in SQLite
		public string FileUploadDate_raw { get; set; }

		public static string FileUploadDate_PropertyName = "FileUploadDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> FileUploadDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return FileUploadDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(FileUploadDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(FileUploadDate_raw, FileUploadDate_ConvertToString(value), (val) => { FileUploadDate_raw = val; }, FileUploadDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string FileUploadDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("FirstName")]
		public string FirstName 
		{ 
			get { return FirstName_private; }
			set { SetProperty(FirstName_private, value, (val) => { FirstName_private = val; }, FirstName_PropertyName); }
		}
		public static string FirstName_PropertyName = "FirstName";
		private string FirstName_private;
		
		



		[Column("Hobbies")]
		public string Hobbies 
		{ 
			get { return Hobbies_private; }
			set { SetProperty(Hobbies_private, value, (val) => { Hobbies_private = val; }, Hobbies_PropertyName); }
		}
		public static string Hobbies_PropertyName = "Hobbies";
		private string Hobbies_private;
		
		


		[NotNull]
		[Column("HolidayCards")]
		public bool HolidayCards 
		{ 
			get { return HolidayCards_private; }
			set { SetProperty(HolidayCards_private, value, (val) => { HolidayCards_private = val; }, HolidayCards_PropertyName); }
		}
		public static string HolidayCards_PropertyName = "HolidayCards";
		private bool HolidayCards_private;
		
		



		[Column("HomeAddress")]
		public string HomeAddress 
		{ 
			get { return HomeAddress_private; }
			set { SetProperty(HomeAddress_private, value, (val) => { HomeAddress_private = val; }, HomeAddress_PropertyName); }
		}
		public static string HomeAddress_PropertyName = "HomeAddress";
		private string HomeAddress_private;
		
		



		[Column("HomeCity")]
		public string HomeCity 
		{ 
			get { return HomeCity_private; }
			set { SetProperty(HomeCity_private, value, (val) => { HomeCity_private = val; }, HomeCity_PropertyName); }
		}
		public static string HomeCity_PropertyName = "HomeCity";
		private string HomeCity_private;
		
		



		[Column("HomeCountry")]
		public string HomeCountry 
		{ 
			get { return HomeCountry_private; }
			set { SetProperty(HomeCountry_private, value, (val) => { HomeCountry_private = val; }, HomeCountry_PropertyName); }
		}
		public static string HomeCountry_PropertyName = "HomeCountry";
		private string HomeCountry_private;
		
		



		[Column("HomePhone")]
		public string HomePhone 
		{ 
			get { return HomePhone_private; }
			set { SetProperty(HomePhone_private, value, (val) => { HomePhone_private = val; }, HomePhone_PropertyName); }
		}
		public static string HomePhone_PropertyName = "HomePhone";
		private string HomePhone_private;
		
		



		[Column("HomeState")]
		public string HomeState 
		{ 
			get { return HomeState_private; }
			set { SetProperty(HomeState_private, value, (val) => { HomeState_private = val; }, HomeState_PropertyName); }
		}
		public static string HomeState_PropertyName = "HomeState";
		private string HomeState_private;
		
		



		[Column("HomeZipCode")]
		public string HomeZipCode 
		{ 
			get { return HomeZipCode_private; }
			set { SetProperty(HomeZipCode_private, value, (val) => { HomeZipCode_private = val; }, HomeZipCode_PropertyName); }
		}
		public static string HomeZipCode_PropertyName = "HomeZipCode";
		private string HomeZipCode_private;
		
		



		[Column("LastActivityDate")]

		// The actual column definition, as seen in SQLite
		public string LastActivityDate_raw { get; set; }

		public static string LastActivityDate_PropertyName = "LastActivityDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> LastActivityDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return LastActivityDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(LastActivityDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(LastActivityDate_raw, LastActivityDate_ConvertToString(value), (val) => { LastActivityDate_raw = val; }, LastActivityDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string LastActivityDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("LastName")]
		public string LastName 
		{ 
			get { return LastName_private; }
			set { SetProperty(LastName_private, value, (val) => { LastName_private = val; }, LastName_PropertyName); }
		}
		public static string LastName_PropertyName = "LastName";
		private string LastName_private;
		
		



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

		



		[Column("MailChimpStatus")]
		public string MailChimpStatus 
		{ 
			get { return MailChimpStatus_private; }
			set { SetProperty(MailChimpStatus_private, value, (val) => { MailChimpStatus_private = val; }, MailChimpStatus_PropertyName); }
		}
		public static string MailChimpStatus_PropertyName = "MailChimpStatus";
		private string MailChimpStatus_private;
		
		



		[Column("MiddleName")]
		public string MiddleName 
		{ 
			get { return MiddleName_private; }
			set { SetProperty(MiddleName_private, value, (val) => { MiddleName_private = val; }, MiddleName_PropertyName); }
		}
		public static string MiddleName_PropertyName = "MiddleName";
		private string MiddleName_private;
		
		



		[Column("MobilePhone")]
		public string MobilePhone 
		{ 
			get { return MobilePhone_private; }
			set { SetProperty(MobilePhone_private, value, (val) => { MobilePhone_private = val; }, MobilePhone_PropertyName); }
		}
		public static string MobilePhone_PropertyName = "MobilePhone";
		private string MobilePhone_private;
		
		


		[NotNull]
		[Column("NewsLetter")]
		public bool NewsLetter 
		{ 
			get { return NewsLetter_private; }
			set { SetProperty(NewsLetter_private, value, (val) => { NewsLetter_private = val; }, NewsLetter_PropertyName); }
		}
		public static string NewsLetter_PropertyName = "NewsLetter";
		private bool NewsLetter_private;
		
		



		[Column("NextActivityDate")]

		// The actual column definition, as seen in SQLite
		public string NextActivityDate_raw { get; set; }

		public static string NextActivityDate_PropertyName = "NextActivityDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> NextActivityDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return NextActivityDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(NextActivityDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(NextActivityDate_raw, NextActivityDate_ConvertToString(value), (val) => { NextActivityDate_raw = val; }, NextActivityDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string NextActivityDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("OriginSystem")]
		public string OriginSystem 
		{ 
			get { return OriginSystem_private; }
			set { SetProperty(OriginSystem_private, value, (val) => { OriginSystem_private = val; }, OriginSystem_PropertyName); }
		}
		public static string OriginSystem_PropertyName = "OriginSystem";
		private string OriginSystem_private;
		
		


		[NotNull]
		[Column("PrivateContact")]
		public bool PrivateContact 
		{ 
			get { return PrivateContact_private; }
			set { SetProperty(PrivateContact_private, value, (val) => { PrivateContact_private = val; }, PrivateContact_PropertyName); }
		}
		public static string PrivateContact_PropertyName = "PrivateContact";
		private bool PrivateContact_private;
		
		


		[NotNull]
		[Column("ReceiveEmail")]
		public bool ReceiveEmail 
		{ 
			get { return ReceiveEmail_private; }
			set { SetProperty(ReceiveEmail_private, value, (val) => { ReceiveEmail_private = val; }, ReceiveEmail_PropertyName); }
		}
		public static string ReceiveEmail_PropertyName = "ReceiveEmail";
		private bool ReceiveEmail_private;
		
		



		[Column("RelatedContacts")]
		public string RelatedContacts 
		{ 
			get { return RelatedContacts_private; }
			set { SetProperty(RelatedContacts_private, value, (val) => { RelatedContacts_private = val; }, RelatedContacts_PropertyName); }
		}
		public static string RelatedContacts_PropertyName = "RelatedContacts";
		private string RelatedContacts_private;
		
		



		[Column("Salutation")]
		public string Salutation 
		{ 
			get { return Salutation_private; }
			set { SetProperty(Salutation_private, value, (val) => { Salutation_private = val; }, Salutation_PropertyName); }
		}
		public static string Salutation_PropertyName = "Salutation";
		private string Salutation_private;
		
		



		[Column("Source")]
		public string Source 
		{ 
			get { return Source_private; }
			set { SetProperty(Source_private, value, (val) => { Source_private = val; }, Source_PropertyName); }
		}
		public static string Source_PropertyName = "Source";
		private string Source_private;
		
		



		[Column("SpouseName")]
		public string SpouseName 
		{ 
			get { return SpouseName_private; }
			set { SetProperty(SpouseName_private, value, (val) => { SpouseName_private = val; }, SpouseName_PropertyName); }
		}
		public static string SpouseName_PropertyName = "SpouseName";
		private string SpouseName_private;
		
		



		[Column("SyncAssignedToCrmDate")]

		// The actual column definition, as seen in SQLite
		public string SyncAssignedToCrmDate_raw { get; set; }

		public static string SyncAssignedToCrmDate_PropertyName = "SyncAssignedToCrmDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> SyncAssignedToCrmDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return SyncAssignedToCrmDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(SyncAssignedToCrmDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(SyncAssignedToCrmDate_raw, SyncAssignedToCrmDate_ConvertToString(value), (val) => { SyncAssignedToCrmDate_raw = val; }, SyncAssignedToCrmDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string SyncAssignedToCrmDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("SyncAssignedUserId")]
		public Nullable<int> SyncAssignedUserId 
		{ 
			get { return SyncAssignedUserId_private; }
			set { SetProperty(SyncAssignedUserId_private, value, (val) => { SyncAssignedUserId_private = val; }, SyncAssignedUserId_PropertyName); }
		}
		public static string SyncAssignedUserId_PropertyName = "SyncAssignedUserId";
		private Nullable<int> SyncAssignedUserId_private;
		
		



		[Column("SyncAssignedUserName")]
		public string SyncAssignedUserName 
		{ 
			get { return SyncAssignedUserName_private; }
			set { SetProperty(SyncAssignedUserName_private, value, (val) => { SyncAssignedUserName_private = val; }, SyncAssignedUserName_PropertyName); }
		}
		public static string SyncAssignedUserName_PropertyName = "SyncAssignedUserName";
		private string SyncAssignedUserName_private;
		
		



		[Column("SyncContactId")]
		public string SyncContactId 
		{ 
			get { return SyncContactId_private; }
			set { SetProperty(SyncContactId_private, value, (val) => { SyncContactId_private = val; }, SyncContactId_PropertyName); }
		}
		public static string SyncContactId_PropertyName = "SyncContactId";
		private string SyncContactId_private;
		
		



		[Column("SyncLastModified")]

		// The actual column definition, as seen in SQLite
		public string SyncLastModified_raw { get; set; }

		public static string SyncLastModified_PropertyName = "SyncLastModified";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> SyncLastModified { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return SyncLastModified_raw != null ? (Nullable<DateTime>)DateTime.Parse(SyncLastModified_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(SyncLastModified_raw, SyncLastModified_ConvertToString(value), (val) => { SyncLastModified_raw = val; }, SyncLastModified_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string SyncLastModified_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("Tags")]
		public string Tags 
		{ 
			get { return Tags_private; }
			set { SetProperty(Tags_private, value, (val) => { Tags_private = val; }, Tags_PropertyName); }
		}
		public static string Tags_PropertyName = "Tags";
		private string Tags_private;
		
		



		[Column("Title")]
		public string Title 
		{ 
			get { return Title_private; }
			set { SetProperty(Title_private, value, (val) => { Title_private = val; }, Title_PropertyName); }
		}
		public static string Title_PropertyName = "Title";
		private string Title_private;
		
		



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
		
		



		[Column("Website")]
		public string Website 
		{ 
			get { return Website_private; }
			set { SetProperty(Website_private, value, (val) => { Website_private = val; }, Website_PropertyName); }
		}
		public static string Website_PropertyName = "Website";
		private string Website_private;
		
		


		[NotNull]
		[Column("Active")]
		public bool Active 
		{ 
			get { return Active_private; }
			set { SetProperty(Active_private, value, (val) => { Active_private = val; }, Active_PropertyName); }
		}
		public static string Active_PropertyName = "Active";
		private bool Active_private;
		
		



		[Column("Birthday")]
		public string Birthday 
		{ 
			get { return Birthday_private; }
			set { SetProperty(Birthday_private, value, (val) => { Birthday_private = val; }, Birthday_PropertyName); }
		}
		public static string Birthday_PropertyName = "Birthday";
		private string Birthday_private;
		
		



		[Column("BirthdayYear")]
		public Nullable<int> BirthdayYear 
		{ 
			get { return BirthdayYear_private; }
			set { SetProperty(BirthdayYear_private, value, (val) => { BirthdayYear_private = val; }, BirthdayYear_PropertyName); }
		}
		public static string BirthdayYear_PropertyName = "BirthdayYear";
		private Nullable<int> BirthdayYear_private;
		
		



		[Column("BusinessAddress1")]
		public string BusinessAddress1 
		{ 
			get { return BusinessAddress1_private; }
			set { SetProperty(BusinessAddress1_private, value, (val) => { BusinessAddress1_private = val; }, BusinessAddress1_PropertyName); }
		}
		public static string BusinessAddress1_PropertyName = "BusinessAddress1";
		private string BusinessAddress1_private;
		
		



		[Column("BusinessAddress2")]
		public string BusinessAddress2 
		{ 
			get { return BusinessAddress2_private; }
			set { SetProperty(BusinessAddress2_private, value, (val) => { BusinessAddress2_private = val; }, BusinessAddress2_PropertyName); }
		}
		public static string BusinessAddress2_PropertyName = "BusinessAddress2";
		private string BusinessAddress2_private;
		
		



		[Column("HomeAddress1")]
		public string HomeAddress1 
		{ 
			get { return HomeAddress1_private; }
			set { SetProperty(HomeAddress1_private, value, (val) => { HomeAddress1_private = val; }, HomeAddress1_PropertyName); }
		}
		public static string HomeAddress1_PropertyName = "HomeAddress1";
		private string HomeAddress1_private;
		
		



		[Column("HomeAddress2")]
		public string HomeAddress2 
		{ 
			get { return HomeAddress2_private; }
			set { SetProperty(HomeAddress2_private, value, (val) => { HomeAddress2_private = val; }, HomeAddress2_PropertyName); }
		}
		public static string HomeAddress2_PropertyName = "HomeAddress2";
		private string HomeAddress2_private;
		
		



		[Column("MaritalStatus")]
		public string MaritalStatus 
		{ 
			get { return MaritalStatus_private; }
			set { SetProperty(MaritalStatus_private, value, (val) => { MaritalStatus_private = val; }, MaritalStatus_PropertyName); }
		}
		public static string MaritalStatus_PropertyName = "MaritalStatus";
		private string MaritalStatus_private;
		
		


		[NotNull]
		[Column("PrimaryContact")]
		public bool PrimaryContact 
		{ 
			get { return PrimaryContact_private; }
			set { SetProperty(PrimaryContact_private, value, (val) => { PrimaryContact_private = val; }, PrimaryContact_PropertyName); }
		}
		public static string PrimaryContact_PropertyName = "PrimaryContact";
		private bool PrimaryContact_private;
		
		



		[Column("GoogleContactId")]
		public string GoogleContactId 
		{ 
			get { return GoogleContactId_private; }
			set { SetProperty(GoogleContactId_private, value, (val) => { GoogleContactId_private = val; }, GoogleContactId_PropertyName); }
		}
		public static string GoogleContactId_PropertyName = "GoogleContactId";
		private string GoogleContactId_private;
		
		



		[Column("ExchangeContactId")]
		public string ExchangeContactId 
		{ 
			get { return ExchangeContactId_private; }
			set { SetProperty(ExchangeContactId_private, value, (val) => { ExchangeContactId_private = val; }, ExchangeContactId_PropertyName); }
		}
		public static string ExchangeContactId_PropertyName = "ExchangeContactId";
		private string ExchangeContactId_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(ID.ToString());

			sb.Append("|");

			if (SubscriberId.HasValue)
			{
				sb.Append(SubscriberId.ToString());
			}
			sb.Append("|");

			if (AccountCode != null)
			{
				sb.Append(AccountCode.ToString());
			}
			sb.Append("|");

			if (BirthdayDay.HasValue)
			{
				sb.Append(BirthdayDay.ToString());
			}
			sb.Append("|");

			if (BirthdayMonth != null)
			{
				sb.Append(BirthdayMonth.ToString());
			}
			sb.Append("|");

			if (BusinessAddress != null)
			{
				sb.Append(BusinessAddress.ToString());
			}
			sb.Append("|");

			if (BusinessCity != null)
			{
				sb.Append(BusinessCity.ToString());
			}
			sb.Append("|");

			if (BusinessCountry != null)
			{
				sb.Append(BusinessCountry.ToString());
			}
			sb.Append("|");

			if (BusinessPhone != null)
			{
				sb.Append(BusinessPhone.ToString());
			}
			sb.Append("|");

			if (BusinessPhone2 != null)
			{
				sb.Append(BusinessPhone2.ToString());
			}
			sb.Append("|");

			if (BusinessState != null)
			{
				sb.Append(BusinessState.ToString());
			}
			sb.Append("|");

			if (BusinessZipCode != null)
			{
				sb.Append(BusinessZipCode.ToString());
			}
			sb.Append("|");

			if (ChildrenNames != null)
			{
				sb.Append(ChildrenNames.ToString());
			}
			sb.Append("|");

			if (Comments != null)
			{
				sb.Append(Comments.ToString());
			}
			sb.Append("|");

			if (CompanyName != null)
			{
				sb.Append(CompanyName.ToString());
			}
			sb.Append("|");

			if (ContactName != null)
			{
				sb.Append(ContactName.ToString());
			}
			sb.Append("|");

			if (ContactNameSource != null)
			{
				sb.Append(ContactNameSource.ToString());
			}
			sb.Append("|");

			if (ContactOwnerId.HasValue)
			{
				sb.Append(ContactOwnerId.ToString());
			}
			sb.Append("|");

			if (ContactType != null)
			{
				sb.Append(ContactType.ToString());
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

			if (CustomerType != null)
			{
				sb.Append(CustomerType.ToString());
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

			if (Email != null)
			{
				sb.Append(Email.ToString());
			}
			sb.Append("|");

			if (EntityId.HasValue)
			{
				sb.Append(EntityId.ToString());
			}
			sb.Append("|");

			if (EntityType != null)
			{
				sb.Append(EntityType.ToString());
			}
			sb.Append("|");

			if (EntityTypeId.HasValue)
			{
				sb.Append(EntityTypeId.ToString());
			}
			sb.Append("|");

			if (Fax != null)
			{
				sb.Append(Fax.ToString());
			}
			sb.Append("|");

			if (FileUploadId.HasValue)
			{
				sb.Append(FileUploadId.ToString());
			}
			sb.Append("|");

			if (FileUploadDate != null)
			{
				sb.Append(FileUploadDate_ConvertToString(FileUploadDate));
			}
			sb.Append("|");

			if (FirstName != null)
			{
				sb.Append(FirstName.ToString());
			}
			sb.Append("|");

			if (Hobbies != null)
			{
				sb.Append(Hobbies.ToString());
			}
			sb.Append("|");

			sb.Append(HolidayCards.ToString());

			sb.Append("|");

			if (HomeAddress != null)
			{
				sb.Append(HomeAddress.ToString());
			}
			sb.Append("|");

			if (HomeCity != null)
			{
				sb.Append(HomeCity.ToString());
			}
			sb.Append("|");

			if (HomeCountry != null)
			{
				sb.Append(HomeCountry.ToString());
			}
			sb.Append("|");

			if (HomePhone != null)
			{
				sb.Append(HomePhone.ToString());
			}
			sb.Append("|");

			if (HomeState != null)
			{
				sb.Append(HomeState.ToString());
			}
			sb.Append("|");

			if (HomeZipCode != null)
			{
				sb.Append(HomeZipCode.ToString());
			}
			sb.Append("|");

			if (LastActivityDate != null)
			{
				sb.Append(LastActivityDate_ConvertToString(LastActivityDate));
			}
			sb.Append("|");

			if (LastName != null)
			{
				sb.Append(LastName.ToString());
			}
			sb.Append("|");

			if (LastUpdate != null)
			{
				sb.Append(LastUpdate_ConvertToString(LastUpdate));
			}
			sb.Append("|");

			if (MailChimpStatus != null)
			{
				sb.Append(MailChimpStatus.ToString());
			}
			sb.Append("|");

			if (MiddleName != null)
			{
				sb.Append(MiddleName.ToString());
			}
			sb.Append("|");

			if (MobilePhone != null)
			{
				sb.Append(MobilePhone.ToString());
			}
			sb.Append("|");

			sb.Append(NewsLetter.ToString());

			sb.Append("|");

			if (NextActivityDate != null)
			{
				sb.Append(NextActivityDate_ConvertToString(NextActivityDate));
			}
			sb.Append("|");

			if (OriginSystem != null)
			{
				sb.Append(OriginSystem.ToString());
			}
			sb.Append("|");

			sb.Append(PrivateContact.ToString());

			sb.Append("|");

			sb.Append(ReceiveEmail.ToString());

			sb.Append("|");

			if (RelatedContacts != null)
			{
				sb.Append(RelatedContacts.ToString());
			}
			sb.Append("|");

			if (Salutation != null)
			{
				sb.Append(Salutation.ToString());
			}
			sb.Append("|");

			if (Source != null)
			{
				sb.Append(Source.ToString());
			}
			sb.Append("|");

			if (SpouseName != null)
			{
				sb.Append(SpouseName.ToString());
			}
			sb.Append("|");

			if (SyncAssignedToCrmDate != null)
			{
				sb.Append(SyncAssignedToCrmDate_ConvertToString(SyncAssignedToCrmDate));
			}
			sb.Append("|");

			if (SyncAssignedUserId.HasValue)
			{
				sb.Append(SyncAssignedUserId.ToString());
			}
			sb.Append("|");

			if (SyncAssignedUserName != null)
			{
				sb.Append(SyncAssignedUserName.ToString());
			}
			sb.Append("|");

			if (SyncContactId != null)
			{
				sb.Append(SyncContactId.ToString());
			}
			sb.Append("|");

			if (SyncLastModified != null)
			{
				sb.Append(SyncLastModified_ConvertToString(SyncLastModified));
			}
			sb.Append("|");

			if (Tags != null)
			{
				sb.Append(Tags.ToString());
			}
			sb.Append("|");

			if (Title != null)
			{
				sb.Append(Title.ToString());
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

			if (Website != null)
			{
				sb.Append(Website.ToString());
			}
			sb.Append("|");

			sb.Append(Active.ToString());

			sb.Append("|");

			if (Birthday != null)
			{
				sb.Append(Birthday.ToString());
			}
			sb.Append("|");

			if (BirthdayYear.HasValue)
			{
				sb.Append(BirthdayYear.ToString());
			}
			sb.Append("|");

			if (BusinessAddress1 != null)
			{
				sb.Append(BusinessAddress1.ToString());
			}
			sb.Append("|");

			if (BusinessAddress2 != null)
			{
				sb.Append(BusinessAddress2.ToString());
			}
			sb.Append("|");

			if (HomeAddress1 != null)
			{
				sb.Append(HomeAddress1.ToString());
			}
			sb.Append("|");

			if (HomeAddress2 != null)
			{
				sb.Append(HomeAddress2.ToString());
			}
			sb.Append("|");

			if (MaritalStatus != null)
			{
				sb.Append(MaritalStatus.ToString());
			}
			sb.Append("|");

			sb.Append(PrimaryContact.ToString());

			sb.Append("|");

			if (GoogleContactId != null)
			{
				sb.Append(GoogleContactId.ToString());
			}
			sb.Append("|");

			if (ExchangeContactId != null)
			{
				sb.Append(ExchangeContactId.ToString());
			}
			sb.Append("|");

			return sb.ToString();
		}
	}
}