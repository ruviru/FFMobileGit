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
	[Table("tblAccounts")]
	public class tblAccounts : BaseModel
	{
		public tblAccounts()
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
		
		



		[Column("AccountName")]
		public string AccountName 
		{ 
			get { return AccountName_private; }
			set { SetProperty(AccountName_private, value, (val) => { AccountName_private = val; }, AccountName_PropertyName); }
		}
		public static string AccountName_PropertyName = "AccountName";
		private string AccountName_private;
		
		


		[NotNull]
		[Column("Active")]
		public bool Active 
		{ 
			get { return Active_private; }
			set { SetProperty(Active_private, value, (val) => { Active_private = val; }, Active_PropertyName); }
		}
		public static string Active_PropertyName = "Active";
		private bool Active_private;
		
		



		[Column("Address")]
		public string Address 
		{ 
			get { return Address_private; }
			set { SetProperty(Address_private, value, (val) => { Address_private = val; }, Address_PropertyName); }
		}
		public static string Address_PropertyName = "Address";
		private string Address_private;
		
		



		[Column("AnnualRevenue")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> AnnualRevenue_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _AnnualRevenue_scale = (long)Math.Pow(10, 4);

		public static string AnnualRevenue_PropertyName = "AnnualRevenue";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> AnnualRevenue { 
			get { return AnnualRevenue_raw.HasValue ? (Nullable<decimal>)((decimal)AnnualRevenue_raw / (decimal)_AnnualRevenue_scale) : null; }
			set { SetProperty(AnnualRevenue_raw, AnnualRevenue_ConvertToInt(value), (val) => { AnnualRevenue_raw = val; }, AnnualRevenue_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> AnnualRevenue_ConvertToInt(Nullable<decimal> arg_AnnualRevenue)
		{
			if (!arg_AnnualRevenue.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_AnnualRevenue.Value * (decimal)_AnnualRevenue_scale));
		}

		



		[Column("City")]
		public string City 
		{ 
			get { return City_private; }
			set { SetProperty(City_private, value, (val) => { City_private = val; }, City_PropertyName); }
		}
		public static string City_PropertyName = "City";
		private string City_private;
		
		



		[Column("Comments")]
		public string Comments 
		{ 
			get { return Comments_private; }
			set { SetProperty(Comments_private, value, (val) => { Comments_private = val; }, Comments_PropertyName); }
		}
		public static string Comments_PropertyName = "Comments";
		private string Comments_private;
		
		



		[Column("ControllingSalesRep")]
		public string ControllingSalesRep 
		{ 
			get { return ControllingSalesRep_private; }
			set { SetProperty(ControllingSalesRep_private, value, (val) => { ControllingSalesRep_private = val; }, ControllingSalesRep_PropertyName); }
		}
		public static string ControllingSalesRep_PropertyName = "ControllingSalesRep";
		private string ControllingSalesRep_private;
		
		



		[Column("ControllingRepCode")]
		public string ControllingRepCode 
		{ 
			get { return ControllingRepCode_private; }
			set { SetProperty(ControllingRepCode_private, value, (val) => { ControllingRepCode_private = val; }, ControllingRepCode_PropertyName); }
		}
		public static string ControllingRepCode_PropertyName = "ControllingRepCode";
		private string ControllingRepCode_private;
		
		



		[Column("CountryCode")]
		public string CountryCode 
		{ 
			get { return CountryCode_private; }
			set { SetProperty(CountryCode_private, value, (val) => { CountryCode_private = val; }, CountryCode_PropertyName); }
		}
		public static string CountryCode_PropertyName = "CountryCode";
		private string CountryCode_private;
		
		



		[Column("CountryName")]
		public string CountryName 
		{ 
			get { return CountryName_private; }
			set { SetProperty(CountryName_private, value, (val) => { CountryName_private = val; }, CountryName_PropertyName); }
		}
		public static string CountryName_PropertyName = "CountryName";
		private string CountryName_private;
		
		



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
		
		



		[Column("CreditLimit")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> CreditLimit_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _CreditLimit_scale = (long)Math.Pow(10, 4);

		public static string CreditLimit_PropertyName = "CreditLimit";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> CreditLimit { 
			get { return CreditLimit_raw.HasValue ? (Nullable<decimal>)((decimal)CreditLimit_raw / (decimal)_CreditLimit_scale) : null; }
			set { SetProperty(CreditLimit_raw, CreditLimit_ConvertToInt(value), (val) => { CreditLimit_raw = val; }, CreditLimit_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> CreditLimit_ConvertToInt(Nullable<decimal> arg_CreditLimit)
		{
			if (!arg_CreditLimit.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_CreditLimit.Value * (decimal)_CreditLimit_scale));
		}

		



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

		



		[Column("FirstShipmentDate")]

		// The actual column definition, as seen in SQLite
		public string FirstShipmentDate_raw { get; set; }

		public static string FirstShipmentDate_PropertyName = "FirstShipmentDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> FirstShipmentDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return FirstShipmentDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(FirstShipmentDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(FirstShipmentDate_raw, FirstShipmentDate_ConvertToString(value), (val) => { FirstShipmentDate_raw = val; }, FirstShipmentDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string FirstShipmentDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("IndustrySector")]
		public string IndustrySector 
		{ 
			get { return IndustrySector_private; }
			set { SetProperty(IndustrySector_private, value, (val) => { IndustrySector_private = val; }, IndustrySector_PropertyName); }
		}
		public static string IndustrySector_PropertyName = "IndustrySector";
		private string IndustrySector_private;
		
		


		[NotNull]
		[Column("IsCustomer")]
		public bool IsCustomer 
		{ 
			get { return IsCustomer_private; }
			set { SetProperty(IsCustomer_private, value, (val) => { IsCustomer_private = val; }, IsCustomer_PropertyName); }
		}
		public static string IsCustomer_PropertyName = "IsCustomer";
		private bool IsCustomer_private;
		
		



		[Column("LastCreditUpdate")]

		// The actual column definition, as seen in SQLite
		public string LastCreditUpdate_raw { get; set; }

		public static string LastCreditUpdate_PropertyName = "LastCreditUpdate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> LastCreditUpdate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return LastCreditUpdate_raw != null ? (Nullable<DateTime>)DateTime.Parse(LastCreditUpdate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(LastCreditUpdate_raw, LastCreditUpdate_ConvertToString(value), (val) => { LastCreditUpdate_raw = val; }, LastCreditUpdate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string LastCreditUpdate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("LastShipmentDate")]

		// The actual column definition, as seen in SQLite
		public string LastShipmentDate_raw { get; set; }

		public static string LastShipmentDate_PropertyName = "LastShipmentDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> LastShipmentDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return LastShipmentDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(LastShipmentDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(LastShipmentDate_raw, LastShipmentDate_ConvertToString(value), (val) => { LastShipmentDate_raw = val; }, LastShipmentDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string LastShipmentDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss");
		
		}

		



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

		



		[Column("MaintenanceSalesRep")]
		public string MaintenanceSalesRep 
		{ 
			get { return MaintenanceSalesRep_private; }
			set { SetProperty(MaintenanceSalesRep_private, value, (val) => { MaintenanceSalesRep_private = val; }, MaintenanceSalesRep_PropertyName); }
		}
		public static string MaintenanceSalesRep_PropertyName = "MaintenanceSalesRep";
		private string MaintenanceSalesRep_private;
		
		



		[Column("MaintenanceRepCode")]
		public string MaintenanceRepCode 
		{ 
			get { return MaintenanceRepCode_private; }
			set { SetProperty(MaintenanceRepCode_private, value, (val) => { MaintenanceRepCode_private = val; }, MaintenanceRepCode_PropertyName); }
		}
		public static string MaintenanceRepCode_PropertyName = "MaintenanceRepCode";
		private string MaintenanceRepCode_private;
		
		



		[Column("NewBusinessDays")]
		public Nullable<int> NewBusinessDays 
		{ 
			get { return NewBusinessDays_private; }
			set { SetProperty(NewBusinessDays_private, value, (val) => { NewBusinessDays_private = val; }, NewBusinessDays_PropertyName); }
		}
		public static string NewBusinessDays_PropertyName = "NewBusinessDays";
		private Nullable<int> NewBusinessDays_private;
		
		



		[Column("NewBusinessEndDate")]

		// The actual column definition, as seen in SQLite
		public string NewBusinessEndDate_raw { get; set; }

		public static string NewBusinessEndDate_PropertyName = "NewBusinessEndDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> NewBusinessEndDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return NewBusinessEndDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(NewBusinessEndDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(NewBusinessEndDate_raw, NewBusinessEndDate_ConvertToString(value), (val) => { NewBusinessEndDate_raw = val; }, NewBusinessEndDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string NewBusinessEndDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



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

		



		[Column("NumberOfEmployees")]
		public Nullable<int> NumberOfEmployees 
		{ 
			get { return NumberOfEmployees_private; }
			set { SetProperty(NumberOfEmployees_private, value, (val) => { NumberOfEmployees_private = val; }, NumberOfEmployees_PropertyName); }
		}
		public static string NumberOfEmployees_PropertyName = "NumberOfEmployees";
		private Nullable<int> NumberOfEmployees_private;
		
		



		[Column("OriginatingUserId")]
		public Nullable<int> OriginatingUserId 
		{ 
			get { return OriginatingUserId_private; }
			set { SetProperty(OriginatingUserId_private, value, (val) => { OriginatingUserId_private = val; }, OriginatingUserId_PropertyName); }
		}
		public static string OriginatingUserId_PropertyName = "OriginatingUserId";
		private Nullable<int> OriginatingUserId_private;
		
		



		[Column("OriginSystem")]
		public string OriginSystem 
		{ 
			get { return OriginSystem_private; }
			set { SetProperty(OriginSystem_private, value, (val) => { OriginSystem_private = val; }, OriginSystem_PropertyName); }
		}
		public static string OriginSystem_PropertyName = "OriginSystem";
		private string OriginSystem_private;
		
		



		[Column("OriginSystemSalesRepCode")]
		public string OriginSystemSalesRepCode 
		{ 
			get { return OriginSystemSalesRepCode_private; }
			set { SetProperty(OriginSystemSalesRepCode_private, value, (val) => { OriginSystemSalesRepCode_private = val; }, OriginSystemSalesRepCode_PropertyName); }
		}
		public static string OriginSystemSalesRepCode_PropertyName = "OriginSystemSalesRepCode";
		private string OriginSystemSalesRepCode_private;
		
		



		[Column("Phone")]
		public string Phone 
		{ 
			get { return Phone_private; }
			set { SetProperty(Phone_private, value, (val) => { Phone_private = val; }, Phone_PropertyName); }
		}
		public static string Phone_PropertyName = "Phone";
		private string Phone_private;
		
		



		[Column("Phone2")]
		public string Phone2 
		{ 
			get { return Phone2_private; }
			set { SetProperty(Phone2_private, value, (val) => { Phone2_private = val; }, Phone2_PropertyName); }
		}
		public static string Phone2_PropertyName = "Phone2";
		private string Phone2_private;
		
		



		[Column("PostalCode")]
		public string PostalCode 
		{ 
			get { return PostalCode_private; }
			set { SetProperty(PostalCode_private, value, (val) => { PostalCode_private = val; }, PostalCode_PropertyName); }
		}
		public static string PostalCode_PropertyName = "PostalCode";
		private string PostalCode_private;
		
		



		[Column("PrimaryAccount")]
		public Nullable<int> PrimaryAccount 
		{ 
			get { return PrimaryAccount_private; }
			set { SetProperty(PrimaryAccount_private, value, (val) => { PrimaryAccount_private = val; }, PrimaryAccount_PropertyName); }
		}
		public static string PrimaryAccount_PropertyName = "PrimaryAccount";
		private Nullable<int> PrimaryAccount_private;
		
		



		[Column("RelatedLeadID")]
		public Nullable<int> RelatedLeadID 
		{ 
			get { return RelatedLeadID_private; }
			set { SetProperty(RelatedLeadID_private, value, (val) => { RelatedLeadID_private = val; }, RelatedLeadID_PropertyName); }
		}
		public static string RelatedLeadID_PropertyName = "RelatedLeadID";
		private Nullable<int> RelatedLeadID_private;
		
		



		[Column("RevenueLastPeriod")]
		public Nullable<int> RevenueLastPeriod 
		{ 
			get { return RevenueLastPeriod_private; }
			set { SetProperty(RevenueLastPeriod_private, value, (val) => { RevenueLastPeriod_private = val; }, RevenueLastPeriod_PropertyName); }
		}
		public static string RevenueLastPeriod_PropertyName = "RevenueLastPeriod";
		private Nullable<int> RevenueLastPeriod_private;
		
		



		[Column("RevenueYtd")]
		public Nullable<int> RevenueYtd 
		{ 
			get { return RevenueYtd_private; }
			set { SetProperty(RevenueYtd_private, value, (val) => { RevenueYtd_private = val; }, RevenueYtd_PropertyName); }
		}
		public static string RevenueYtd_PropertyName = "RevenueYtd";
		private Nullable<int> RevenueYtd_private;
		
		



		[Column("SegmentCode")]
		public string SegmentCode 
		{ 
			get { return SegmentCode_private; }
			set { SetProperty(SegmentCode_private, value, (val) => { SegmentCode_private = val; }, SegmentCode_PropertyName); }
		}
		public static string SegmentCode_PropertyName = "SegmentCode";
		private string SegmentCode_private;
		
		



		[Column("ServiceRepCode")]
		public string ServiceRepCode 
		{ 
			get { return ServiceRepCode_private; }
			set { SetProperty(ServiceRepCode_private, value, (val) => { ServiceRepCode_private = val; }, ServiceRepCode_PropertyName); }
		}
		public static string ServiceRepCode_PropertyName = "ServiceRepCode";
		private string ServiceRepCode_private;
		
		



		[Column("Source")]
		public string Source 
		{ 
			get { return Source_private; }
			set { SetProperty(Source_private, value, (val) => { Source_private = val; }, Source_PropertyName); }
		}
		public static string Source_PropertyName = "Source";
		private string Source_private;
		
		



		[Column("StateProvince")]
		public string StateProvince 
		{ 
			get { return StateProvince_private; }
			set { SetProperty(StateProvince_private, value, (val) => { StateProvince_private = val; }, StateProvince_PropertyName); }
		}
		public static string StateProvince_PropertyName = "StateProvince";
		private string StateProvince_private;
		
		



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
		
		



		[Column("Address1")]
		public string Address1 
		{ 
			get { return Address1_private; }
			set { SetProperty(Address1_private, value, (val) => { Address1_private = val; }, Address1_PropertyName); }
		}
		public static string Address1_PropertyName = "Address1";
		private string Address1_private;
		
		



		[Column("Address2")]
		public string Address2 
		{ 
			get { return Address2_private; }
			set { SetProperty(Address2_private, value, (val) => { Address2_private = val; }, Address2_PropertyName); }
		}
		public static string Address2_PropertyName = "Address2";
		private string Address2_private;
		
		



		[Column("Address3")]
		public string Address3 
		{ 
			get { return Address3_private; }
			set { SetProperty(Address3_private, value, (val) => { Address3_private = val; }, Address3_PropertyName); }
		}
		public static string Address3_PropertyName = "Address3";
		private string Address3_private;
		
		


		[NotNull]
		[Column("BusinessInJeopardy")]
		public bool BusinessInJeopardy 
		{ 
			get { return BusinessInJeopardy_private; }
			set { SetProperty(BusinessInJeopardy_private, value, (val) => { BusinessInJeopardy_private = val; }, BusinessInJeopardy_PropertyName); }
		}
		public static string BusinessInJeopardy_PropertyName = "BusinessInJeopardy";
		private bool BusinessInJeopardy_private;
		
		



		[Column("BusinessJeopardyActionPlan")]
		public string BusinessJeopardyActionPlan 
		{ 
			get { return BusinessJeopardyActionPlan_private; }
			set { SetProperty(BusinessJeopardyActionPlan_private, value, (val) => { BusinessJeopardyActionPlan_private = val; }, BusinessJeopardyActionPlan_PropertyName); }
		}
		public static string BusinessJeopardyActionPlan_PropertyName = "BusinessJeopardyActionPlan";
		private string BusinessJeopardyActionPlan_private;
		
		



		[Column("BusinessInJeopardyDate")]

		// The actual column definition, as seen in SQLite
		public string BusinessInJeopardyDate_raw { get; set; }

		public static string BusinessInJeopardyDate_PropertyName = "BusinessInJeopardyDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> BusinessInJeopardyDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return BusinessInJeopardyDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(BusinessInJeopardyDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(BusinessInJeopardyDate_raw, BusinessInJeopardyDate_ConvertToString(value), (val) => { BusinessInJeopardyDate_raw = val; }, BusinessInJeopardyDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string BusinessInJeopardyDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("BusinessInJeopardyReason")]
		public string BusinessInJeopardyReason 
		{ 
			get { return BusinessInJeopardyReason_private; }
			set { SetProperty(BusinessInJeopardyReason_private, value, (val) => { BusinessInJeopardyReason_private = val; }, BusinessInJeopardyReason_PropertyName); }
		}
		public static string BusinessInJeopardyReason_PropertyName = "BusinessInJeopardyReason";
		private string BusinessInJeopardyReason_private;
		
		


		[NotNull]
		[Column("BusinessLost")]
		public bool BusinessLost 
		{ 
			get { return BusinessLost_private; }
			set { SetProperty(BusinessLost_private, value, (val) => { BusinessLost_private = val; }, BusinessLost_PropertyName); }
		}
		public static string BusinessLost_PropertyName = "BusinessLost";
		private bool BusinessLost_private;
		
		



		[Column("BusinessLostDate")]

		// The actual column definition, as seen in SQLite
		public string BusinessLostDate_raw { get; set; }

		public static string BusinessLostDate_PropertyName = "BusinessLostDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> BusinessLostDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return BusinessLostDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(BusinessLostDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(BusinessLostDate_raw, BusinessLostDate_ConvertToString(value), (val) => { BusinessLostDate_raw = val; }, BusinessLostDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string BusinessLostDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("BusinessLostReason")]
		public string BusinessLostReason 
		{ 
			get { return BusinessLostReason_private; }
			set { SetProperty(BusinessLostReason_private, value, (val) => { BusinessLostReason_private = val; }, BusinessLostReason_PropertyName); }
		}
		public static string BusinessLostReason_PropertyName = "BusinessLostReason";
		private string BusinessLostReason_private;
		
		


		[NotNull]
		[Column("BusinessReAcquired")]
		public bool BusinessReAcquired 
		{ 
			get { return BusinessReAcquired_private; }
			set { SetProperty(BusinessReAcquired_private, value, (val) => { BusinessReAcquired_private = val; }, BusinessReAcquired_PropertyName); }
		}
		public static string BusinessReAcquired_PropertyName = "BusinessReAcquired";
		private bool BusinessReAcquired_private;
		
		



		[Column("BusinessReAcquiredDate")]

		// The actual column definition, as seen in SQLite
		public string BusinessReAcquiredDate_raw { get; set; }

		public static string BusinessReAcquiredDate_PropertyName = "BusinessReAcquiredDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> BusinessReAcquiredDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return BusinessReAcquiredDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(BusinessReAcquiredDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(BusinessReAcquiredDate_raw, BusinessReAcquiredDate_ConvertToString(value), (val) => { BusinessReAcquiredDate_raw = val; }, BusinessReAcquiredDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string BusinessReAcquiredDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("BusinessReAcquiredReason")]
		public string BusinessReAcquiredReason 
		{ 
			get { return BusinessReAcquiredReason_private; }
			set { SetProperty(BusinessReAcquiredReason_private, value, (val) => { BusinessReAcquiredReason_private = val; }, BusinessReAcquiredReason_PropertyName); }
		}
		public static string BusinessReAcquiredReason_PropertyName = "BusinessReAcquiredReason";
		private string BusinessReAcquiredReason_private;
		
		



		[Column("CollectorID")]
		public Nullable<int> CollectorID 
		{ 
			get { return CollectorID_private; }
			set { SetProperty(CollectorID_private, value, (val) => { CollectorID_private = val; }, CollectorID_PropertyName); }
		}
		public static string CollectorID_PropertyName = "CollectorID";
		private Nullable<int> CollectorID_private;
		
		



		[Column("Country")]
		public string Country 
		{ 
			get { return Country_private; }
			set { SetProperty(Country_private, value, (val) => { Country_private = val; }, Country_PropertyName); }
		}
		public static string Country_PropertyName = "Country";
		private string Country_private;
		
		



		[Column("DUNSNumber")]
		public string DUNSNumber 
		{ 
			get { return DUNSNumber_private; }
			set { SetProperty(DUNSNumber_private, value, (val) => { DUNSNumber_private = val; }, DUNSNumber_PropertyName); }
		}
		public static string DUNSNumber_PropertyName = "DUNSNumber";
		private string DUNSNumber_private;
		
		



		[Column("DaysNoShipments")]
		public Nullable<int> DaysNoShipments 
		{ 
			get { return DaysNoShipments_private; }
			set { SetProperty(DaysNoShipments_private, value, (val) => { DaysNoShipments_private = val; }, DaysNoShipments_PropertyName); }
		}
		public static string DaysNoShipments_PropertyName = "DaysNoShipments";
		private Nullable<int> DaysNoShipments_private;
		
		



		[Column("HooversID")]
		public string HooversID 
		{ 
			get { return HooversID_private; }
			set { SetProperty(HooversID_private, value, (val) => { HooversID_private = val; }, HooversID_PropertyName); }
		}
		public static string HooversID_PropertyName = "HooversID";
		private string HooversID_private;
		
		



		[Column("PrimaryAddressID")]
		public Nullable<int> PrimaryAddressID 
		{ 
			get { return PrimaryAddressID_private; }
			set { SetProperty(PrimaryAddressID_private, value, (val) => { PrimaryAddressID_private = val; }, PrimaryAddressID_PropertyName); }
		}
		public static string PrimaryAddressID_PropertyName = "PrimaryAddressID";
		private Nullable<int> PrimaryAddressID_private;
		
		



		[Column("PrimaryContactID")]
		public Nullable<int> PrimaryContactID 
		{ 
			get { return PrimaryContactID_private; }
			set { SetProperty(PrimaryContactID_private, value, (val) => { PrimaryContactID_private = val; }, PrimaryContactID_PropertyName); }
		}
		public static string PrimaryContactID_PropertyName = "PrimaryContactID";
		private Nullable<int> PrimaryContactID_private;
		
		



		[Column("SalesGroups")]
		public string SalesGroups 
		{ 
			get { return SalesGroups_private; }
			set { SetProperty(SalesGroups_private, value, (val) => { SalesGroups_private = val; }, SalesGroups_PropertyName); }
		}
		public static string SalesGroups_PropertyName = "SalesGroups";
		private string SalesGroups_private;
		
		



		[Column("SICCode1")]
		public string SICCode1 
		{ 
			get { return SICCode1_private; }
			set { SetProperty(SICCode1_private, value, (val) => { SICCode1_private = val; }, SICCode1_PropertyName); }
		}
		public static string SICCode1_PropertyName = "SICCode1";
		private string SICCode1_private;
		
		



		[Column("SICCode2")]
		public string SICCode2 
		{ 
			get { return SICCode2_private; }
			set { SetProperty(SICCode2_private, value, (val) => { SICCode2_private = val; }, SICCode2_PropertyName); }
		}
		public static string SICCode2_PropertyName = "SICCode2";
		private string SICCode2_private;
		
		



		[Column("SRAssignedByID")]
		public Nullable<int> SRAssignedByID 
		{ 
			get { return SRAssignedByID_private; }
			set { SetProperty(SRAssignedByID_private, value, (val) => { SRAssignedByID_private = val; }, SRAssignedByID_PropertyName); }
		}
		public static string SRAssignedByID_PropertyName = "SRAssignedByID";
		private Nullable<int> SRAssignedByID_private;
		
		



		[Column("SRAssignedByName")]
		public string SRAssignedByName 
		{ 
			get { return SRAssignedByName_private; }
			set { SetProperty(SRAssignedByName_private, value, (val) => { SRAssignedByName_private = val; }, SRAssignedByName_PropertyName); }
		}
		public static string SRAssignedByName_PropertyName = "SRAssignedByName";
		private string SRAssignedByName_private;
		
		



		[Column("SRAssignedDate")]

		// The actual column definition, as seen in SQLite
		public string SRAssignedDate_raw { get; set; }

		public static string SRAssignedDate_PropertyName = "SRAssignedDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> SRAssignedDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return SRAssignedDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(SRAssignedDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(SRAssignedDate_raw, SRAssignedDate_ConvertToString(value), (val) => { SRAssignedDate_raw = val; }, SRAssignedDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string SRAssignedDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		


		[NotNull]
		[Column("SRViewedAssignment")]
		public bool SRViewedAssignment 
		{ 
			get { return SRViewedAssignment_private; }
			set { SetProperty(SRViewedAssignment_private, value, (val) => { SRViewedAssignment_private = val; }, SRViewedAssignment_PropertyName); }
		}
		public static string SRViewedAssignment_PropertyName = "SRViewedAssignment";
		private bool SRViewedAssignment_private;
		
		



		[Column("SRViewedAssignedDate")]

		// The actual column definition, as seen in SQLite
		public string SRViewedAssignedDate_raw { get; set; }

		public static string SRViewedAssignedDate_PropertyName = "SRViewedAssignedDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> SRViewedAssignedDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return SRViewedAssignedDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(SRViewedAssignedDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(SRViewedAssignedDate_raw, SRViewedAssignedDate_ConvertToString(value), (val) => { SRViewedAssignedDate_raw = val; }, SRViewedAssignedDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string SRViewedAssignedDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("State")]
		public string State 
		{ 
			get { return State_private; }
			set { SetProperty(State_private, value, (val) => { State_private = val; }, State_PropertyName); }
		}
		public static string State_PropertyName = "State";
		private string State_private;
		
		



		[Column("Tags")]
		public string Tags 
		{ 
			get { return Tags_private; }
			set { SetProperty(Tags_private, value, (val) => { Tags_private = val; }, Tags_PropertyName); }
		}
		public static string Tags_PropertyName = "Tags";
		private string Tags_private;
		
		



		[Column("ZipCode")]
		public string ZipCode 
		{ 
			get { return ZipCode_private; }
			set { SetProperty(ZipCode_private, value, (val) => { ZipCode_private = val; }, ZipCode_PropertyName); }
		}
		public static string ZipCode_PropertyName = "ZipCode";
		private string ZipCode_private;
		
		


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

			if (AccountName != null)
			{
				sb.Append(AccountName.ToString());
			}
			sb.Append("|");

			sb.Append(Active.ToString());

			sb.Append("|");

			if (Address != null)
			{
				sb.Append(Address.ToString());
			}
			sb.Append("|");

			if (AnnualRevenue.HasValue)
			{
				sb.Append(AnnualRevenue.ToString());
			}
			sb.Append("|");

			if (City != null)
			{
				sb.Append(City.ToString());
			}
			sb.Append("|");

			if (Comments != null)
			{
				sb.Append(Comments.ToString());
			}
			sb.Append("|");

			if (ControllingSalesRep != null)
			{
				sb.Append(ControllingSalesRep.ToString());
			}
			sb.Append("|");

			if (ControllingRepCode != null)
			{
				sb.Append(ControllingRepCode.ToString());
			}
			sb.Append("|");

			if (CountryCode != null)
			{
				sb.Append(CountryCode.ToString());
			}
			sb.Append("|");

			if (CountryName != null)
			{
				sb.Append(CountryName.ToString());
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

			if (CreditLimit.HasValue)
			{
				sb.Append(CreditLimit.ToString());
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

			if (FirstShipmentDate != null)
			{
				sb.Append(FirstShipmentDate_ConvertToString(FirstShipmentDate));
			}
			sb.Append("|");

			if (IndustrySector != null)
			{
				sb.Append(IndustrySector.ToString());
			}
			sb.Append("|");

			sb.Append(IsCustomer.ToString());

			sb.Append("|");

			if (LastCreditUpdate != null)
			{
				sb.Append(LastCreditUpdate_ConvertToString(LastCreditUpdate));
			}
			sb.Append("|");

			if (LastShipmentDate != null)
			{
				sb.Append(LastShipmentDate_ConvertToString(LastShipmentDate));
			}
			sb.Append("|");

			if (LastActivityDate != null)
			{
				sb.Append(LastActivityDate_ConvertToString(LastActivityDate));
			}
			sb.Append("|");

			if (LastUpdate != null)
			{
				sb.Append(LastUpdate_ConvertToString(LastUpdate));
			}
			sb.Append("|");

			if (MaintenanceSalesRep != null)
			{
				sb.Append(MaintenanceSalesRep.ToString());
			}
			sb.Append("|");

			if (MaintenanceRepCode != null)
			{
				sb.Append(MaintenanceRepCode.ToString());
			}
			sb.Append("|");

			if (NewBusinessDays.HasValue)
			{
				sb.Append(NewBusinessDays.ToString());
			}
			sb.Append("|");

			if (NewBusinessEndDate != null)
			{
				sb.Append(NewBusinessEndDate_ConvertToString(NewBusinessEndDate));
			}
			sb.Append("|");

			if (NextActivityDate != null)
			{
				sb.Append(NextActivityDate_ConvertToString(NextActivityDate));
			}
			sb.Append("|");

			if (NumberOfEmployees.HasValue)
			{
				sb.Append(NumberOfEmployees.ToString());
			}
			sb.Append("|");

			if (OriginatingUserId.HasValue)
			{
				sb.Append(OriginatingUserId.ToString());
			}
			sb.Append("|");

			if (OriginSystem != null)
			{
				sb.Append(OriginSystem.ToString());
			}
			sb.Append("|");

			if (OriginSystemSalesRepCode != null)
			{
				sb.Append(OriginSystemSalesRepCode.ToString());
			}
			sb.Append("|");

			if (Phone != null)
			{
				sb.Append(Phone.ToString());
			}
			sb.Append("|");

			if (Phone2 != null)
			{
				sb.Append(Phone2.ToString());
			}
			sb.Append("|");

			if (PostalCode != null)
			{
				sb.Append(PostalCode.ToString());
			}
			sb.Append("|");

			if (PrimaryAccount.HasValue)
			{
				sb.Append(PrimaryAccount.ToString());
			}
			sb.Append("|");

			if (RelatedLeadID.HasValue)
			{
				sb.Append(RelatedLeadID.ToString());
			}
			sb.Append("|");

			if (RevenueLastPeriod.HasValue)
			{
				sb.Append(RevenueLastPeriod.ToString());
			}
			sb.Append("|");

			if (RevenueYtd.HasValue)
			{
				sb.Append(RevenueYtd.ToString());
			}
			sb.Append("|");

			if (SegmentCode != null)
			{
				sb.Append(SegmentCode.ToString());
			}
			sb.Append("|");

			if (ServiceRepCode != null)
			{
				sb.Append(ServiceRepCode.ToString());
			}
			sb.Append("|");

			if (Source != null)
			{
				sb.Append(Source.ToString());
			}
			sb.Append("|");

			if (StateProvince != null)
			{
				sb.Append(StateProvince.ToString());
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

			if (Address1 != null)
			{
				sb.Append(Address1.ToString());
			}
			sb.Append("|");

			if (Address2 != null)
			{
				sb.Append(Address2.ToString());
			}
			sb.Append("|");

			if (Address3 != null)
			{
				sb.Append(Address3.ToString());
			}
			sb.Append("|");

			sb.Append(BusinessInJeopardy.ToString());

			sb.Append("|");

			if (BusinessJeopardyActionPlan != null)
			{
				sb.Append(BusinessJeopardyActionPlan.ToString());
			}
			sb.Append("|");

			if (BusinessInJeopardyDate != null)
			{
				sb.Append(BusinessInJeopardyDate_ConvertToString(BusinessInJeopardyDate));
			}
			sb.Append("|");

			if (BusinessInJeopardyReason != null)
			{
				sb.Append(BusinessInJeopardyReason.ToString());
			}
			sb.Append("|");

			sb.Append(BusinessLost.ToString());

			sb.Append("|");

			if (BusinessLostDate != null)
			{
				sb.Append(BusinessLostDate_ConvertToString(BusinessLostDate));
			}
			sb.Append("|");

			if (BusinessLostReason != null)
			{
				sb.Append(BusinessLostReason.ToString());
			}
			sb.Append("|");

			sb.Append(BusinessReAcquired.ToString());

			sb.Append("|");

			if (BusinessReAcquiredDate != null)
			{
				sb.Append(BusinessReAcquiredDate_ConvertToString(BusinessReAcquiredDate));
			}
			sb.Append("|");

			if (BusinessReAcquiredReason != null)
			{
				sb.Append(BusinessReAcquiredReason.ToString());
			}
			sb.Append("|");

			if (CollectorID.HasValue)
			{
				sb.Append(CollectorID.ToString());
			}
			sb.Append("|");

			if (Country != null)
			{
				sb.Append(Country.ToString());
			}
			sb.Append("|");

			if (DUNSNumber != null)
			{
				sb.Append(DUNSNumber.ToString());
			}
			sb.Append("|");

			if (DaysNoShipments.HasValue)
			{
				sb.Append(DaysNoShipments.ToString());
			}
			sb.Append("|");

			if (HooversID != null)
			{
				sb.Append(HooversID.ToString());
			}
			sb.Append("|");

			if (PrimaryAddressID.HasValue)
			{
				sb.Append(PrimaryAddressID.ToString());
			}
			sb.Append("|");

			if (PrimaryContactID.HasValue)
			{
				sb.Append(PrimaryContactID.ToString());
			}
			sb.Append("|");

			if (SalesGroups != null)
			{
				sb.Append(SalesGroups.ToString());
			}
			sb.Append("|");

			if (SICCode1 != null)
			{
				sb.Append(SICCode1.ToString());
			}
			sb.Append("|");

			if (SICCode2 != null)
			{
				sb.Append(SICCode2.ToString());
			}
			sb.Append("|");

			if (SRAssignedByID.HasValue)
			{
				sb.Append(SRAssignedByID.ToString());
			}
			sb.Append("|");

			if (SRAssignedByName != null)
			{
				sb.Append(SRAssignedByName.ToString());
			}
			sb.Append("|");

			if (SRAssignedDate != null)
			{
				sb.Append(SRAssignedDate_ConvertToString(SRAssignedDate));
			}
			sb.Append("|");

			sb.Append(SRViewedAssignment.ToString());

			sb.Append("|");

			if (SRViewedAssignedDate != null)
			{
				sb.Append(SRViewedAssignedDate_ConvertToString(SRViewedAssignedDate));
			}
			sb.Append("|");

			if (State != null)
			{
				sb.Append(State.ToString());
			}
			sb.Append("|");

			if (Tags != null)
			{
				sb.Append(Tags.ToString());
			}
			sb.Append("|");

			if (ZipCode != null)
			{
				sb.Append(ZipCode.ToString());
			}
			sb.Append("|");

			return sb.ToString();
		}
	}
}