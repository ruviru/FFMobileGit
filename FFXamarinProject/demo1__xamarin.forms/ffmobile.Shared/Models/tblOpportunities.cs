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
	[Table("tblOpportunities")]
	public class tblOpportunities : BaseModel
	{
		public tblOpportunities()
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
		
		



		[Column("AccountId")]
		public Nullable<int> AccountId 
		{ 
			get { return AccountId_private; }
			set { SetProperty(AccountId_private, value, (val) => { AccountId_private = val; }, AccountId_PropertyName); }
		}
		public static string AccountId_PropertyName = "AccountId";
		private Nullable<int> AccountId_private;
		
		



		[Column("Commodity")]
		public string Commodity 
		{ 
			get { return Commodity_private; }
			set { SetProperty(Commodity_private, value, (val) => { Commodity_private = val; }, Commodity_PropertyName); }
		}
		public static string Commodity_PropertyName = "Commodity";
		private string Commodity_private;
		
		



		[Column("Competitor")]
		public string Competitor 
		{ 
			get { return Competitor_private; }
			set { SetProperty(Competitor_private, value, (val) => { Competitor_private = val; }, Competitor_PropertyName); }
		}
		public static string Competitor_PropertyName = "Competitor";
		private string Competitor_private;
		
		



		[Column("ContractEndDate")]

		// The actual column definition, as seen in SQLite
		public string ContractEndDate_raw { get; set; }

		public static string ContractEndDate_PropertyName = "ContractEndDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ContractEndDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ContractEndDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ContractEndDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ContractEndDate_raw, ContractEndDate_ConvertToString(value), (val) => { ContractEndDate_raw = val; }, ContractEndDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ContractEndDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



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

		



		[Column("DateLost")]

		// The actual column definition, as seen in SQLite
		public string DateLost_raw { get; set; }

		public static string DateLost_PropertyName = "DateLost";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> DateLost { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return DateLost_raw != null ? (Nullable<DateTime>)DateTime.Parse(DateLost_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(DateLost_raw, DateLost_ConvertToString(value), (val) => { DateLost_raw = val; }, DateLost_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string DateLost_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("DateWon")]

		// The actual column definition, as seen in SQLite
		public string DateWon_raw { get; set; }

		public static string DateWon_PropertyName = "DateWon";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> DateWon { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return DateWon_raw != null ? (Nullable<DateTime>)DateTime.Parse(DateWon_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(DateWon_raw, DateWon_ConvertToString(value), (val) => { DateWon_raw = val; }, DateWon_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string DateWon_ConvertToString(Nullable<DateTime> date)
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
		
		



		[Column("DeletedUserName")]
		public string DeletedUserName 
		{ 
			get { return DeletedUserName_private; }
			set { SetProperty(DeletedUserName_private, value, (val) => { DeletedUserName_private = val; }, DeletedUserName_PropertyName); }
		}
		public static string DeletedUserName_PropertyName = "DeletedUserName";
		private string DeletedUserName_private;
		
		



		[Column("DistrictCode")]
		public string DistrictCode 
		{ 
			get { return DistrictCode_private; }
			set { SetProperty(DistrictCode_private, value, (val) => { DistrictCode_private = val; }, DistrictCode_PropertyName); }
		}
		public static string DistrictCode_PropertyName = "DistrictCode";
		private string DistrictCode_private;
		
		



		[Column("DistrictName")]
		public string DistrictName 
		{ 
			get { return DistrictName_private; }
			set { SetProperty(DistrictName_private, value, (val) => { DistrictName_private = val; }, DistrictName_PropertyName); }
		}
		public static string DistrictName_PropertyName = "DistrictName";
		private string DistrictName_private;
		
		



		[Column("DueDate")]

		// The actual column definition, as seen in SQLite
		public string DueDate_raw { get; set; }

		public static string DueDate_PropertyName = "DueDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> DueDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return DueDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(DueDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(DueDate_raw, DueDate_ConvertToString(value), (val) => { DueDate_raw = val; }, DueDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string DueDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("EntityId")]
		public Nullable<int> EntityId 
		{ 
			get { return EntityId_private; }
			set { SetProperty(EntityId_private, value, (val) => { EntityId_private = val; }, EntityId_PropertyName); }
		}
		public static string EntityId_PropertyName = "EntityId";
		private Nullable<int> EntityId_private;
		
		



		[Column("EntityName")]
		public string EntityName 
		{ 
			get { return EntityName_private; }
			set { SetProperty(EntityName_private, value, (val) => { EntityName_private = val; }, EntityName_PropertyName); }
		}
		public static string EntityName_PropertyName = "EntityName";
		private string EntityName_private;
		
		



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
		
		



		[Column("EstimatedStartDate")]

		// The actual column definition, as seen in SQLite
		public string EstimatedStartDate_raw { get; set; }

		public static string EstimatedStartDate_PropertyName = "EstimatedStartDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> EstimatedStartDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return EstimatedStartDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(EstimatedStartDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(EstimatedStartDate_raw, EstimatedStartDate_ConvertToString(value), (val) => { EstimatedStartDate_raw = val; }, EstimatedStartDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string EstimatedStartDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("ExpectedDecisionDate")]

		// The actual column definition, as seen in SQLite
		public string ExpectedDecisionDate_raw { get; set; }

		public static string ExpectedDecisionDate_PropertyName = "ExpectedDecisionDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ExpectedDecisionDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ExpectedDecisionDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ExpectedDecisionDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ExpectedDecisionDate_raw, ExpectedDecisionDate_ConvertToString(value), (val) => { ExpectedDecisionDate_raw = val; }, ExpectedDecisionDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ExpectedDecisionDate_ConvertToString(Nullable<DateTime> date)
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

		



		[Column("LeadId")]
		public Nullable<int> LeadId 
		{ 
			get { return LeadId_private; }
			set { SetProperty(LeadId_private, value, (val) => { LeadId_private = val; }, LeadId_PropertyName); }
		}
		public static string LeadId_PropertyName = "LeadId";
		private Nullable<int> LeadId_private;
		
		


		[NotNull]
		[Column("Lost")]
		public bool Lost 
		{ 
			get { return Lost_private; }
			set { SetProperty(Lost_private, value, (val) => { Lost_private = val; }, Lost_PropertyName); }
		}
		public static string Lost_PropertyName = "Lost";
		private bool Lost_private;
		
		



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

		



		[Column("OpportunityDescription")]
		public string OpportunityDescription 
		{ 
			get { return OpportunityDescription_private; }
			set { SetProperty(OpportunityDescription_private, value, (val) => { OpportunityDescription_private = val; }, OpportunityDescription_PropertyName); }
		}
		public static string OpportunityDescription_PropertyName = "OpportunityDescription";
		private string OpportunityDescription_private;
		
		



		[Column("OpportunityName")]
		public string OpportunityName 
		{ 
			get { return OpportunityName_private; }
			set { SetProperty(OpportunityName_private, value, (val) => { OpportunityName_private = val; }, OpportunityName_PropertyName); }
		}
		public static string OpportunityName_PropertyName = "OpportunityName";
		private string OpportunityName_private;
		
		



		[Column("OpportunityNumber")]
		public string OpportunityNumber 
		{ 
			get { return OpportunityNumber_private; }
			set { SetProperty(OpportunityNumber_private, value, (val) => { OpportunityNumber_private = val; }, OpportunityNumber_PropertyName); }
		}
		public static string OpportunityNumber_PropertyName = "OpportunityNumber";
		private string OpportunityNumber_private;
		
		



		[Column("OpportunityOwnerId")]
		public Nullable<int> OpportunityOwnerId 
		{ 
			get { return OpportunityOwnerId_private; }
			set { SetProperty(OpportunityOwnerId_private, value, (val) => { OpportunityOwnerId_private = val; }, OpportunityOwnerId_PropertyName); }
		}
		public static string OpportunityOwnerId_PropertyName = "OpportunityOwnerId";
		private Nullable<int> OpportunityOwnerId_private;
		
		



		[Column("OpportunityType")]
		public string OpportunityType 
		{ 
			get { return OpportunityType_private; }
			set { SetProperty(OpportunityType_private, value, (val) => { OpportunityType_private = val; }, OpportunityType_PropertyName); }
		}
		public static string OpportunityType_PropertyName = "OpportunityType";
		private string OpportunityType_private;
		
		



		[Column("PrimaryContactId")]
		public Nullable<int> PrimaryContactId 
		{ 
			get { return PrimaryContactId_private; }
			set { SetProperty(PrimaryContactId_private, value, (val) => { PrimaryContactId_private = val; }, PrimaryContactId_PropertyName); }
		}
		public static string PrimaryContactId_PropertyName = "PrimaryContactId";
		private Nullable<int> PrimaryContactId_private;
		
		



		[Column("PrimaryContactName")]
		public string PrimaryContactName 
		{ 
			get { return PrimaryContactName_private; }
			set { SetProperty(PrimaryContactName_private, value, (val) => { PrimaryContactName_private = val; }, PrimaryContactName_PropertyName); }
		}
		public static string PrimaryContactName_PropertyName = "PrimaryContactName";
		private string PrimaryContactName_private;
		
		



		[Column("ReasonWonLost")]
		public string ReasonWonLost 
		{ 
			get { return ReasonWonLost_private; }
			set { SetProperty(ReasonWonLost_private, value, (val) => { ReasonWonLost_private = val; }, ReasonWonLost_PropertyName); }
		}
		public static string ReasonWonLost_PropertyName = "ReasonWonLost";
		private string ReasonWonLost_private;
		
		



		[Column("RegionCode")]
		public string RegionCode 
		{ 
			get { return RegionCode_private; }
			set { SetProperty(RegionCode_private, value, (val) => { RegionCode_private = val; }, RegionCode_PropertyName); }
		}
		public static string RegionCode_PropertyName = "RegionCode";
		private string RegionCode_private;
		
		



		[Column("RegionName")]
		public string RegionName 
		{ 
			get { return RegionName_private; }
			set { SetProperty(RegionName_private, value, (val) => { RegionName_private = val; }, RegionName_PropertyName); }
		}
		public static string RegionName_PropertyName = "RegionName";
		private string RegionName_private;
		
		



		[Column("SalesRepCode")]
		public string SalesRepCode 
		{ 
			get { return SalesRepCode_private; }
			set { SetProperty(SalesRepCode_private, value, (val) => { SalesRepCode_private = val; }, SalesRepCode_PropertyName); }
		}
		public static string SalesRepCode_PropertyName = "SalesRepCode";
		private string SalesRepCode_private;
		
		



		[Column("SalesRepName")]
		public string SalesRepName 
		{ 
			get { return SalesRepName_private; }
			set { SetProperty(SalesRepName_private, value, (val) => { SalesRepName_private = val; }, SalesRepName_PropertyName); }
		}
		public static string SalesRepName_PropertyName = "SalesRepName";
		private string SalesRepName_private;
		
		



		[Column("SalesStage")]
		public string SalesStage 
		{ 
			get { return SalesStage_private; }
			set { SetProperty(SalesStage_private, value, (val) => { SalesStage_private = val; }, SalesStage_PropertyName); }
		}
		public static string SalesStage_PropertyName = "SalesStage";
		private string SalesStage_private;
		
		



		[Column("StationCode")]
		public string StationCode 
		{ 
			get { return StationCode_private; }
			set { SetProperty(StationCode_private, value, (val) => { StationCode_private = val; }, StationCode_PropertyName); }
		}
		public static string StationCode_PropertyName = "StationCode";
		private string StationCode_private;
		
		



		[Column("StationName")]
		public string StationName 
		{ 
			get { return StationName_private; }
			set { SetProperty(StationName_private, value, (val) => { StationName_private = val; }, StationName_PropertyName); }
		}
		public static string StationName_PropertyName = "StationName";
		private string StationName_private;
		
		



		[Column("UpdateUserName")]
		public string UpdateUserName 
		{ 
			get { return UpdateUserName_private; }
			set { SetProperty(UpdateUserName_private, value, (val) => { UpdateUserName_private = val; }, UpdateUserName_PropertyName); }
		}
		public static string UpdateUserName_PropertyName = "UpdateUserName";
		private string UpdateUserName_private;
		
		



		[Column("UpdateUserId")]
		public Nullable<int> UpdateUserId 
		{ 
			get { return UpdateUserId_private; }
			set { SetProperty(UpdateUserId_private, value, (val) => { UpdateUserId_private = val; }, UpdateUserId_PropertyName); }
		}
		public static string UpdateUserId_PropertyName = "UpdateUserId";
		private Nullable<int> UpdateUserId_private;
		
		


		[NotNull]
		[Column("Won")]
		public bool Won 
		{ 
			get { return Won_private; }
			set { SetProperty(Won_private, value, (val) => { Won_private = val; }, Won_PropertyName); }
		}
		public static string Won_PropertyName = "Won";
		private bool Won_private;
		
		



		[Column("WonExchangeRate")]
		public Nullable<double> WonExchangeRate 
		{ 
			get { return WonExchangeRate_private; }
			set { SetProperty(WonExchangeRate_private, value, (val) => { WonExchangeRate_private = val; }, WonExchangeRate_PropertyName); }
		}
		public static string WonExchangeRate_PropertyName = "WonExchangeRate";
		private Nullable<double> WonExchangeRate_private;
		
		



		[Column("FIELDS_BELOW_TO_BE_REMOVED")]
		public string FIELDS_BELOW_TO_BE_REMOVED 
		{ 
			get { return FIELDS_BELOW_TO_BE_REMOVED_private; }
			set { SetProperty(FIELDS_BELOW_TO_BE_REMOVED_private, value, (val) => { FIELDS_BELOW_TO_BE_REMOVED_private = val; }, FIELDS_BELOW_TO_BE_REMOVED_PropertyName); }
		}
		public static string FIELDS_BELOW_TO_BE_REMOVED_PropertyName = "FIELDS_BELOW_TO_BE_REMOVED";
		private string FIELDS_BELOW_TO_BE_REMOVED_private;
		
		


		[NotNull]
		[Column("Active")]
		public bool Active 
		{ 
			get { return Active_private; }
			set { SetProperty(Active_private, value, (val) => { Active_private = val; }, Active_PropertyName); }
		}
		public static string Active_PropertyName = "Active";
		private bool Active_private;
		
		



		[Column("AnnualShipments")]
		public Nullable<int> AnnualShipments 
		{ 
			get { return AnnualShipments_private; }
			set { SetProperty(AnnualShipments_private, value, (val) => { AnnualShipments_private = val; }, AnnualShipments_PropertyName); }
		}
		public static string AnnualShipments_PropertyName = "AnnualShipments";
		private Nullable<int> AnnualShipments_private;
		
		



		[Column("CBMs")]
		public Nullable<double> CBMs 
		{ 
			get { return CBMs_private; }
			set { SetProperty(CBMs_private, value, (val) => { CBMs_private = val; }, CBMs_PropertyName); }
		}
		public static string CBMs_PropertyName = "CBMs";
		private Nullable<double> CBMs_private;
		
		



		[Column("ContactId")]
		public Nullable<int> ContactId 
		{ 
			get { return ContactId_private; }
			set { SetProperty(ContactId_private, value, (val) => { ContactId_private = val; }, ContactId_PropertyName); }
		}
		public static string ContactId_PropertyName = "ContactId";
		private Nullable<int> ContactId_private;
		
		



		[Column("ContractLength")]
		public string ContractLength 
		{ 
			get { return ContractLength_private; }
			set { SetProperty(ContractLength_private, value, (val) => { ContractLength_private = val; }, ContractLength_PropertyName); }
		}
		public static string ContractLength_PropertyName = "ContractLength";
		private string ContractLength_private;
		
		



		[Column("ControlledBy")]
		public string ControlledBy 
		{ 
			get { return ControlledBy_private; }
			set { SetProperty(ControlledBy_private, value, (val) => { ControlledBy_private = val; }, ControlledBy_PropertyName); }
		}
		public static string ControlledBy_PropertyName = "ControlledBy";
		private string ControlledBy_private;
		
		



		[Column("CurrencyCode")]
		public string CurrencyCode 
		{ 
			get { return CurrencyCode_private; }
			set { SetProperty(CurrencyCode_private, value, (val) => { CurrencyCode_private = val; }, CurrencyCode_PropertyName); }
		}
		public static string CurrencyCode_PropertyName = "CurrencyCode";
		private string CurrencyCode_private;
		
		



		[Column("CurrencyExchangeRate")]
		public Nullable<double> CurrencyExchangeRate 
		{ 
			get { return CurrencyExchangeRate_private; }
			set { SetProperty(CurrencyExchangeRate_private, value, (val) => { CurrencyExchangeRate_private = val; }, CurrencyExchangeRate_PropertyName); }
		}
		public static string CurrencyExchangeRate_PropertyName = "CurrencyExchangeRate";
		private Nullable<double> CurrencyExchangeRate_private;
		
		



		[Column("CurrentRevenue")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> CurrentRevenue_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _CurrentRevenue_scale = (long)Math.Pow(10, 4);

		public static string CurrentRevenue_PropertyName = "CurrentRevenue";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> CurrentRevenue { 
			get { return CurrentRevenue_raw.HasValue ? (Nullable<decimal>)((decimal)CurrentRevenue_raw / (decimal)_CurrentRevenue_scale) : null; }
			set { SetProperty(CurrentRevenue_raw, CurrentRevenue_ConvertToInt(value), (val) => { CurrentRevenue_raw = val; }, CurrentRevenue_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> CurrentRevenue_ConvertToInt(Nullable<decimal> arg_CurrentRevenue)
		{
			if (!arg_CurrentRevenue.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_CurrentRevenue.Value * (decimal)_CurrentRevenue_scale));
		}

		



		[Column("CustomerReferenceNumber")]
		public string CustomerReferenceNumber 
		{ 
			get { return CustomerReferenceNumber_private; }
			set { SetProperty(CustomerReferenceNumber_private, value, (val) => { CustomerReferenceNumber_private = val; }, CustomerReferenceNumber_PropertyName); }
		}
		public static string CustomerReferenceNumber_PropertyName = "CustomerReferenceNumber";
		private string CustomerReferenceNumber_private;
		
		



		[Column("DateReceived")]

		// The actual column definition, as seen in SQLite
		public string DateReceived_raw { get; set; }

		public static string DateReceived_PropertyName = "DateReceived";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> DateReceived { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return DateReceived_raw != null ? (Nullable<DateTime>)DateTime.Parse(DateReceived_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(DateReceived_raw, DateReceived_ConvertToString(value), (val) => { DateReceived_raw = val; }, DateReceived_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string DateReceived_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("DecisionMaking")]
		public string DecisionMaking 
		{ 
			get { return DecisionMaking_private; }
			set { SetProperty(DecisionMaking_private, value, (val) => { DecisionMaking_private = val; }, DecisionMaking_PropertyName); }
		}
		public static string DecisionMaking_PropertyName = "DecisionMaking";
		private string DecisionMaking_private;
		
		



		[Column("DestinationPortCodes")]
		public string DestinationPortCodes 
		{ 
			get { return DestinationPortCodes_private; }
			set { SetProperty(DestinationPortCodes_private, value, (val) => { DestinationPortCodes_private = val; }, DestinationPortCodes_PropertyName); }
		}
		public static string DestinationPortCodes_PropertyName = "DestinationPortCodes";
		private string DestinationPortCodes_private;
		
		



		[Column("Direction")]
		public string Direction 
		{ 
			get { return Direction_private; }
			set { SetProperty(Direction_private, value, (val) => { Direction_private = val; }, Direction_PropertyName); }
		}
		public static string Direction_PropertyName = "Direction";
		private string Direction_private;
		
		



		[Column("EstimatedProfit")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> EstimatedProfit_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _EstimatedProfit_scale = (long)Math.Pow(10, 4);

		public static string EstimatedProfit_PropertyName = "EstimatedProfit";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> EstimatedProfit { 
			get { return EstimatedProfit_raw.HasValue ? (Nullable<decimal>)((decimal)EstimatedProfit_raw / (decimal)_EstimatedProfit_scale) : null; }
			set { SetProperty(EstimatedProfit_raw, EstimatedProfit_ConvertToInt(value), (val) => { EstimatedProfit_raw = val; }, EstimatedProfit_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> EstimatedProfit_ConvertToInt(Nullable<decimal> arg_EstimatedProfit)
		{
			if (!arg_EstimatedProfit.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_EstimatedProfit.Value * (decimal)_EstimatedProfit_scale));
		}

		



		[Column("FEUs")]
		public Nullable<double> FEUs 
		{ 
			get { return FEUs_private; }
			set { SetProperty(FEUs_private, value, (val) => { FEUs_private = val; }, FEUs_PropertyName); }
		}
		public static string FEUs_PropertyName = "FEUs";
		private Nullable<double> FEUs_private;
		
		



		[Column("ForecastPercentage")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> ForecastPercentage_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _ForecastPercentage_scale = (long)Math.Pow(10, 2);

		public static string ForecastPercentage_PropertyName = "ForecastPercentage";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> ForecastPercentage { 
			get { return ForecastPercentage_raw.HasValue ? (Nullable<decimal>)((decimal)ForecastPercentage_raw / (decimal)_ForecastPercentage_scale) : null; }
			set { SetProperty(ForecastPercentage_raw, ForecastPercentage_ConvertToInt(value), (val) => { ForecastPercentage_raw = val; }, ForecastPercentage_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> ForecastPercentage_ConvertToInt(Nullable<decimal> arg_ForecastPercentage)
		{
			if (!arg_ForecastPercentage.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_ForecastPercentage.Value * (decimal)_ForecastPercentage_scale));
		}

		



		[Column("GrossProfitPercent")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> GrossProfitPercent_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _GrossProfitPercent_scale = (long)Math.Pow(10, 2);

		public static string GrossProfitPercent_PropertyName = "GrossProfitPercent";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> GrossProfitPercent { 
			get { return GrossProfitPercent_raw.HasValue ? (Nullable<decimal>)((decimal)GrossProfitPercent_raw / (decimal)_GrossProfitPercent_scale) : null; }
			set { SetProperty(GrossProfitPercent_raw, GrossProfitPercent_ConvertToInt(value), (val) => { GrossProfitPercent_raw = val; }, GrossProfitPercent_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> GrossProfitPercent_ConvertToInt(Nullable<decimal> arg_GrossProfitPercent)
		{
			if (!arg_GrossProfitPercent.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_GrossProfitPercent.Value * (decimal)_GrossProfitPercent_scale));
		}

		


		[NotNull]
		[Column("InterOffice")]
		public bool InterOffice 
		{ 
			get { return InterOffice_private; }
			set { SetProperty(InterOffice_private, value, (val) => { InterOffice_private = val; }, InterOffice_PropertyName); }
		}
		public static string InterOffice_PropertyName = "InterOffice";
		private bool InterOffice_private;
		
		



		[Column("InterOfficeSalesRepCode")]
		public string InterOfficeSalesRepCode 
		{ 
			get { return InterOfficeSalesRepCode_private; }
			set { SetProperty(InterOfficeSalesRepCode_private, value, (val) => { InterOfficeSalesRepCode_private = val; }, InterOfficeSalesRepCode_PropertyName); }
		}
		public static string InterOfficeSalesRepCode_PropertyName = "InterOfficeSalesRepCode";
		private string InterOfficeSalesRepCode_private;
		
		



		[Column("InterOfficeStationCode")]
		public string InterOfficeStationCode 
		{ 
			get { return InterOfficeStationCode_private; }
			set { SetProperty(InterOfficeStationCode_private, value, (val) => { InterOfficeStationCode_private = val; }, InterOfficeStationCode_PropertyName); }
		}
		public static string InterOfficeStationCode_PropertyName = "InterOfficeStationCode";
		private string InterOfficeStationCode_private;
		
		



		[Column("KGs")]
		public Nullable<double> KGs 
		{ 
			get { return KGs_private; }
			set { SetProperty(KGs_private, value, (val) => { KGs_private = val; }, KGs_PropertyName); }
		}
		public static string KGs_PropertyName = "KGs";
		private Nullable<double> KGs_private;
		
		



		[Column("OriginPortCodes")]
		public string OriginPortCodes 
		{ 
			get { return OriginPortCodes_private; }
			set { SetProperty(OriginPortCodes_private, value, (val) => { OriginPortCodes_private = val; }, OriginPortCodes_PropertyName); }
		}
		public static string OriginPortCodes_PropertyName = "OriginPortCodes";
		private string OriginPortCodes_private;
		
		



		[Column("Ranking")]
		public string Ranking 
		{ 
			get { return Ranking_private; }
			set { SetProperty(Ranking_private, value, (val) => { Ranking_private = val; }, Ranking_PropertyName); }
		}
		public static string Ranking_PropertyName = "Ranking";
		private string Ranking_private;
		
		



		[Column("Region")]
		public string Region 
		{ 
			get { return Region_private; }
			set { SetProperty(Region_private, value, (val) => { Region_private = val; }, Region_PropertyName); }
		}
		public static string Region_PropertyName = "Region";
		private string Region_private;
		
		



		[Column("Revenue")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> Revenue_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _Revenue_scale = (long)Math.Pow(10, 4);

		public static string Revenue_PropertyName = "Revenue";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> Revenue { 
			get { return Revenue_raw.HasValue ? (Nullable<decimal>)((decimal)Revenue_raw / (decimal)_Revenue_scale) : null; }
			set { SetProperty(Revenue_raw, Revenue_ConvertToInt(value), (val) => { Revenue_raw = val; }, Revenue_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> Revenue_ConvertToInt(Nullable<decimal> arg_Revenue)
		{
			if (!arg_Revenue.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_Revenue.Value * (decimal)_Revenue_scale));
		}

		



		[Column("RevenueRange")]
		public string RevenueRange 
		{ 
			get { return RevenueRange_private; }
			set { SetProperty(RevenueRange_private, value, (val) => { RevenueRange_private = val; }, RevenueRange_PropertyName); }
		}
		public static string RevenueRange_PropertyName = "RevenueRange";
		private string RevenueRange_private;
		
		



		[Column("RequestType")]
		public string RequestType 
		{ 
			get { return RequestType_private; }
			set { SetProperty(RequestType_private, value, (val) => { RequestType_private = val; }, RequestType_PropertyName); }
		}
		public static string RequestType_PropertyName = "RequestType";
		private string RequestType_private;
		
		



		[Column("Services")]
		public string Services 
		{ 
			get { return Services_private; }
			set { SetProperty(Services_private, value, (val) => { Services_private = val; }, Services_PropertyName); }
		}
		public static string Services_PropertyName = "Services";
		private string Services_private;
		
		



		[Column("ShippingFrequency")]
		public string ShippingFrequency 
		{ 
			get { return ShippingFrequency_private; }
			set { SetProperty(ShippingFrequency_private, value, (val) => { ShippingFrequency_private = val; }, ShippingFrequency_PropertyName); }
		}
		public static string ShippingFrequency_PropertyName = "ShippingFrequency";
		private string ShippingFrequency_private;
		
		



		[Column("StationCodeFrom")]
		public string StationCodeFrom 
		{ 
			get { return StationCodeFrom_private; }
			set { SetProperty(StationCodeFrom_private, value, (val) => { StationCodeFrom_private = val; }, StationCodeFrom_PropertyName); }
		}
		public static string StationCodeFrom_PropertyName = "StationCodeFrom";
		private string StationCodeFrom_private;
		
		



		[Column("TradeLanes")]
		public string TradeLanes 
		{ 
			get { return TradeLanes_private; }
			set { SetProperty(TradeLanes_private, value, (val) => { TradeLanes_private = val; }, TradeLanes_PropertyName); }
		}
		public static string TradeLanes_PropertyName = "TradeLanes";
		private string TradeLanes_private;
		
		



		[Column("TEUs")]
		public Nullable<double> TEUs 
		{ 
			get { return TEUs_private; }
			set { SetProperty(TEUs_private, value, (val) => { TEUs_private = val; }, TEUs_PropertyName); }
		}
		public static string TEUs_PropertyName = "TEUs";
		private Nullable<double> TEUs_private;
		
		


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

			if (AccountId.HasValue)
			{
				sb.Append(AccountId.ToString());
			}
			sb.Append("|");

			if (Commodity != null)
			{
				sb.Append(Commodity.ToString());
			}
			sb.Append("|");

			if (Competitor != null)
			{
				sb.Append(Competitor.ToString());
			}
			sb.Append("|");

			if (ContractEndDate != null)
			{
				sb.Append(ContractEndDate_ConvertToString(ContractEndDate));
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

			if (DateDeleted != null)
			{
				sb.Append(DateDeleted_ConvertToString(DateDeleted));
			}
			sb.Append("|");

			if (DateLost != null)
			{
				sb.Append(DateLost_ConvertToString(DateLost));
			}
			sb.Append("|");

			if (DateWon != null)
			{
				sb.Append(DateWon_ConvertToString(DateWon));
			}
			sb.Append("|");

			sb.Append(Deleted.ToString());

			sb.Append("|");

			if (DeletedById.HasValue)
			{
				sb.Append(DeletedById.ToString());
			}
			sb.Append("|");

			if (DeletedUserName != null)
			{
				sb.Append(DeletedUserName.ToString());
			}
			sb.Append("|");

			if (DistrictCode != null)
			{
				sb.Append(DistrictCode.ToString());
			}
			sb.Append("|");

			if (DistrictName != null)
			{
				sb.Append(DistrictName.ToString());
			}
			sb.Append("|");

			if (DueDate != null)
			{
				sb.Append(DueDate_ConvertToString(DueDate));
			}
			sb.Append("|");

			if (EntityId.HasValue)
			{
				sb.Append(EntityId.ToString());
			}
			sb.Append("|");

			if (EntityName != null)
			{
				sb.Append(EntityName.ToString());
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

			if (EstimatedStartDate != null)
			{
				sb.Append(EstimatedStartDate_ConvertToString(EstimatedStartDate));
			}
			sb.Append("|");

			if (ExpectedDecisionDate != null)
			{
				sb.Append(ExpectedDecisionDate_ConvertToString(ExpectedDecisionDate));
			}
			sb.Append("|");

			if (IndustrySector != null)
			{
				sb.Append(IndustrySector.ToString());
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

			if (LeadId.HasValue)
			{
				sb.Append(LeadId.ToString());
			}
			sb.Append("|");

			sb.Append(Lost.ToString());

			sb.Append("|");

			if (NextActivityDate != null)
			{
				sb.Append(NextActivityDate_ConvertToString(NextActivityDate));
			}
			sb.Append("|");

			if (OpportunityDescription != null)
			{
				sb.Append(OpportunityDescription.ToString());
			}
			sb.Append("|");

			if (OpportunityName != null)
			{
				sb.Append(OpportunityName.ToString());
			}
			sb.Append("|");

			if (OpportunityNumber != null)
			{
				sb.Append(OpportunityNumber.ToString());
			}
			sb.Append("|");

			if (OpportunityOwnerId.HasValue)
			{
				sb.Append(OpportunityOwnerId.ToString());
			}
			sb.Append("|");

			if (OpportunityType != null)
			{
				sb.Append(OpportunityType.ToString());
			}
			sb.Append("|");

			if (PrimaryContactId.HasValue)
			{
				sb.Append(PrimaryContactId.ToString());
			}
			sb.Append("|");

			if (PrimaryContactName != null)
			{
				sb.Append(PrimaryContactName.ToString());
			}
			sb.Append("|");

			if (ReasonWonLost != null)
			{
				sb.Append(ReasonWonLost.ToString());
			}
			sb.Append("|");

			if (RegionCode != null)
			{
				sb.Append(RegionCode.ToString());
			}
			sb.Append("|");

			if (RegionName != null)
			{
				sb.Append(RegionName.ToString());
			}
			sb.Append("|");

			if (SalesRepCode != null)
			{
				sb.Append(SalesRepCode.ToString());
			}
			sb.Append("|");

			if (SalesRepName != null)
			{
				sb.Append(SalesRepName.ToString());
			}
			sb.Append("|");

			if (SalesStage != null)
			{
				sb.Append(SalesStage.ToString());
			}
			sb.Append("|");

			if (StationCode != null)
			{
				sb.Append(StationCode.ToString());
			}
			sb.Append("|");

			if (StationName != null)
			{
				sb.Append(StationName.ToString());
			}
			sb.Append("|");

			if (UpdateUserName != null)
			{
				sb.Append(UpdateUserName.ToString());
			}
			sb.Append("|");

			if (UpdateUserId.HasValue)
			{
				sb.Append(UpdateUserId.ToString());
			}
			sb.Append("|");

			sb.Append(Won.ToString());

			sb.Append("|");

			if (WonExchangeRate.HasValue)
			{
				sb.Append(WonExchangeRate.ToString());
			}
			sb.Append("|");

			if (FIELDS_BELOW_TO_BE_REMOVED != null)
			{
				sb.Append(FIELDS_BELOW_TO_BE_REMOVED.ToString());
			}
			sb.Append("|");

			sb.Append(Active.ToString());

			sb.Append("|");

			if (AnnualShipments.HasValue)
			{
				sb.Append(AnnualShipments.ToString());
			}
			sb.Append("|");

			if (CBMs.HasValue)
			{
				sb.Append(CBMs.ToString());
			}
			sb.Append("|");

			if (ContactId.HasValue)
			{
				sb.Append(ContactId.ToString());
			}
			sb.Append("|");

			if (ContractLength != null)
			{
				sb.Append(ContractLength.ToString());
			}
			sb.Append("|");

			if (ControlledBy != null)
			{
				sb.Append(ControlledBy.ToString());
			}
			sb.Append("|");

			if (CurrencyCode != null)
			{
				sb.Append(CurrencyCode.ToString());
			}
			sb.Append("|");

			if (CurrencyExchangeRate.HasValue)
			{
				sb.Append(CurrencyExchangeRate.ToString());
			}
			sb.Append("|");

			if (CurrentRevenue.HasValue)
			{
				sb.Append(CurrentRevenue.ToString());
			}
			sb.Append("|");

			if (CustomerReferenceNumber != null)
			{
				sb.Append(CustomerReferenceNumber.ToString());
			}
			sb.Append("|");

			if (DateReceived != null)
			{
				sb.Append(DateReceived_ConvertToString(DateReceived));
			}
			sb.Append("|");

			if (DecisionMaking != null)
			{
				sb.Append(DecisionMaking.ToString());
			}
			sb.Append("|");

			if (DestinationPortCodes != null)
			{
				sb.Append(DestinationPortCodes.ToString());
			}
			sb.Append("|");

			if (Direction != null)
			{
				sb.Append(Direction.ToString());
			}
			sb.Append("|");

			if (EstimatedProfit.HasValue)
			{
				sb.Append(EstimatedProfit.ToString());
			}
			sb.Append("|");

			if (FEUs.HasValue)
			{
				sb.Append(FEUs.ToString());
			}
			sb.Append("|");

			if (ForecastPercentage.HasValue)
			{
				sb.Append(ForecastPercentage.ToString());
			}
			sb.Append("|");

			if (GrossProfitPercent.HasValue)
			{
				sb.Append(GrossProfitPercent.ToString());
			}
			sb.Append("|");

			sb.Append(InterOffice.ToString());

			sb.Append("|");

			if (InterOfficeSalesRepCode != null)
			{
				sb.Append(InterOfficeSalesRepCode.ToString());
			}
			sb.Append("|");

			if (InterOfficeStationCode != null)
			{
				sb.Append(InterOfficeStationCode.ToString());
			}
			sb.Append("|");

			if (KGs.HasValue)
			{
				sb.Append(KGs.ToString());
			}
			sb.Append("|");

			if (OriginPortCodes != null)
			{
				sb.Append(OriginPortCodes.ToString());
			}
			sb.Append("|");

			if (Ranking != null)
			{
				sb.Append(Ranking.ToString());
			}
			sb.Append("|");

			if (Region != null)
			{
				sb.Append(Region.ToString());
			}
			sb.Append("|");

			if (Revenue.HasValue)
			{
				sb.Append(Revenue.ToString());
			}
			sb.Append("|");

			if (RevenueRange != null)
			{
				sb.Append(RevenueRange.ToString());
			}
			sb.Append("|");

			if (RequestType != null)
			{
				sb.Append(RequestType.ToString());
			}
			sb.Append("|");

			if (Services != null)
			{
				sb.Append(Services.ToString());
			}
			sb.Append("|");

			if (ShippingFrequency != null)
			{
				sb.Append(ShippingFrequency.ToString());
			}
			sb.Append("|");

			if (StationCodeFrom != null)
			{
				sb.Append(StationCodeFrom.ToString());
			}
			sb.Append("|");

			if (TradeLanes != null)
			{
				sb.Append(TradeLanes.ToString());
			}
			sb.Append("|");

			if (TEUs.HasValue)
			{
				sb.Append(TEUs.ToString());
			}
			sb.Append("|");

			return sb.ToString();
		}
	}
}