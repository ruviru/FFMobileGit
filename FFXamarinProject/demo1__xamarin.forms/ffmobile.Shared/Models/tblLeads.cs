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
	[Table("tblLeads")]
	public class tblLeads : BaseModel
	{
		public tblLeads()
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
		
		



		[Column("AnnualShipments")]
		public string AnnualShipments 
		{ 
			get { return AnnualShipments_private; }
			set { SetProperty(AnnualShipments_private, value, (val) => { AnnualShipments_private = val; }, AnnualShipments_PropertyName); }
		}
		public static string AnnualShipments_PropertyName = "AnnualShipments";
		private string AnnualShipments_private;
		
		



		[Column("AnnualVolumes")]
		public string AnnualVolumes 
		{ 
			get { return AnnualVolumes_private; }
			set { SetProperty(AnnualVolumes_private, value, (val) => { AnnualVolumes_private = val; }, AnnualVolumes_PropertyName); }
		}
		public static string AnnualVolumes_PropertyName = "AnnualVolumes";
		private string AnnualVolumes_private;
		
		



		[Column("AssignedDate")]

		// The actual column definition, as seen in SQLite
		public string AssignedDate_raw { get; set; }

		public static string AssignedDate_PropertyName = "AssignedDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> AssignedDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return AssignedDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(AssignedDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(AssignedDate_raw, AssignedDate_ConvertToString(value), (val) => { AssignedDate_raw = val; }, AssignedDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string AssignedDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("AssignedSalesRepCode")]
		public string AssignedSalesRepCode 
		{ 
			get { return AssignedSalesRepCode_private; }
			set { SetProperty(AssignedSalesRepCode_private, value, (val) => { AssignedSalesRepCode_private = val; }, AssignedSalesRepCode_PropertyName); }
		}
		public static string AssignedSalesRepCode_PropertyName = "AssignedSalesRepCode";
		private string AssignedSalesRepCode_private;
		
		



		[Column("CampaignName")]
		public string CampaignName 
		{ 
			get { return CampaignName_private; }
			set { SetProperty(CampaignName_private, value, (val) => { CampaignName_private = val; }, CampaignName_PropertyName); }
		}
		public static string CampaignName_PropertyName = "CampaignName";
		private string CampaignName_private;
		
		



		[Column("Comments")]
		public string Comments 
		{ 
			get { return Comments_private; }
			set { SetProperty(Comments_private, value, (val) => { Comments_private = val; }, Comments_PropertyName); }
		}
		public static string Comments_PropertyName = "Comments";
		private string Comments_private;
		
		



		[Column("Commodities")]
		public string Commodities 
		{ 
			get { return Commodities_private; }
			set { SetProperty(Commodities_private, value, (val) => { Commodities_private = val; }, Commodities_PropertyName); }
		}
		public static string Commodities_PropertyName = "Commodities";
		private string Commodities_private;
		
		



		[Column("Competitors")]
		public string Competitors 
		{ 
			get { return Competitors_private; }
			set { SetProperty(Competitors_private, value, (val) => { Competitors_private = val; }, Competitors_PropertyName); }
		}
		public static string Competitors_PropertyName = "Competitors";
		private string Competitors_private;
		
		



		[Column("ConsigneeAddress")]
		public string ConsigneeAddress 
		{ 
			get { return ConsigneeAddress_private; }
			set { SetProperty(ConsigneeAddress_private, value, (val) => { ConsigneeAddress_private = val; }, ConsigneeAddress_PropertyName); }
		}
		public static string ConsigneeAddress_PropertyName = "ConsigneeAddress";
		private string ConsigneeAddress_private;
		
		



		[Column("ConsigneeCity")]
		public string ConsigneeCity 
		{ 
			get { return ConsigneeCity_private; }
			set { SetProperty(ConsigneeCity_private, value, (val) => { ConsigneeCity_private = val; }, ConsigneeCity_PropertyName); }
		}
		public static string ConsigneeCity_PropertyName = "ConsigneeCity";
		private string ConsigneeCity_private;
		
		



		[Column("ConsigneeCompany")]
		public string ConsigneeCompany 
		{ 
			get { return ConsigneeCompany_private; }
			set { SetProperty(ConsigneeCompany_private, value, (val) => { ConsigneeCompany_private = val; }, ConsigneeCompany_PropertyName); }
		}
		public static string ConsigneeCompany_PropertyName = "ConsigneeCompany";
		private string ConsigneeCompany_private;
		
		



		[Column("ConsigneeContact")]
		public string ConsigneeContact 
		{ 
			get { return ConsigneeContact_private; }
			set { SetProperty(ConsigneeContact_private, value, (val) => { ConsigneeContact_private = val; }, ConsigneeContact_PropertyName); }
		}
		public static string ConsigneeContact_PropertyName = "ConsigneeContact";
		private string ConsigneeContact_private;
		
		



		[Column("ConsigneeContactSalutation")]
		public string ConsigneeContactSalutation 
		{ 
			get { return ConsigneeContactSalutation_private; }
			set { SetProperty(ConsigneeContactSalutation_private, value, (val) => { ConsigneeContactSalutation_private = val; }, ConsigneeContactSalutation_PropertyName); }
		}
		public static string ConsigneeContactSalutation_PropertyName = "ConsigneeContactSalutation";
		private string ConsigneeContactSalutation_private;
		
		



		[Column("ConsigneeContactTitle")]
		public string ConsigneeContactTitle 
		{ 
			get { return ConsigneeContactTitle_private; }
			set { SetProperty(ConsigneeContactTitle_private, value, (val) => { ConsigneeContactTitle_private = val; }, ConsigneeContactTitle_PropertyName); }
		}
		public static string ConsigneeContactTitle_PropertyName = "ConsigneeContactTitle";
		private string ConsigneeContactTitle_private;
		
		



		[Column("ConsigneeCountryCode")]
		public string ConsigneeCountryCode 
		{ 
			get { return ConsigneeCountryCode_private; }
			set { SetProperty(ConsigneeCountryCode_private, value, (val) => { ConsigneeCountryCode_private = val; }, ConsigneeCountryCode_PropertyName); }
		}
		public static string ConsigneeCountryCode_PropertyName = "ConsigneeCountryCode";
		private string ConsigneeCountryCode_private;
		
		



		[Column("ConsigneeCountryName")]
		public string ConsigneeCountryName 
		{ 
			get { return ConsigneeCountryName_private; }
			set { SetProperty(ConsigneeCountryName_private, value, (val) => { ConsigneeCountryName_private = val; }, ConsigneeCountryName_PropertyName); }
		}
		public static string ConsigneeCountryName_PropertyName = "ConsigneeCountryName";
		private string ConsigneeCountryName_private;
		
		



		[Column("ConsigneeEmail")]
		public string ConsigneeEmail 
		{ 
			get { return ConsigneeEmail_private; }
			set { SetProperty(ConsigneeEmail_private, value, (val) => { ConsigneeEmail_private = val; }, ConsigneeEmail_PropertyName); }
		}
		public static string ConsigneeEmail_PropertyName = "ConsigneeEmail";
		private string ConsigneeEmail_private;
		
		



		[Column("ConsigneeFax")]
		public string ConsigneeFax 
		{ 
			get { return ConsigneeFax_private; }
			set { SetProperty(ConsigneeFax_private, value, (val) => { ConsigneeFax_private = val; }, ConsigneeFax_PropertyName); }
		}
		public static string ConsigneeFax_PropertyName = "ConsigneeFax";
		private string ConsigneeFax_private;
		
		



		[Column("ConsigneeMobile")]
		public string ConsigneeMobile 
		{ 
			get { return ConsigneeMobile_private; }
			set { SetProperty(ConsigneeMobile_private, value, (val) => { ConsigneeMobile_private = val; }, ConsigneeMobile_PropertyName); }
		}
		public static string ConsigneeMobile_PropertyName = "ConsigneeMobile";
		private string ConsigneeMobile_private;
		
		



		[Column("ConsigneePhone")]
		public string ConsigneePhone 
		{ 
			get { return ConsigneePhone_private; }
			set { SetProperty(ConsigneePhone_private, value, (val) => { ConsigneePhone_private = val; }, ConsigneePhone_PropertyName); }
		}
		public static string ConsigneePhone_PropertyName = "ConsigneePhone";
		private string ConsigneePhone_private;
		
		



		[Column("ConsigneePostalCode")]
		public string ConsigneePostalCode 
		{ 
			get { return ConsigneePostalCode_private; }
			set { SetProperty(ConsigneePostalCode_private, value, (val) => { ConsigneePostalCode_private = val; }, ConsigneePostalCode_PropertyName); }
		}
		public static string ConsigneePostalCode_PropertyName = "ConsigneePostalCode";
		private string ConsigneePostalCode_private;
		
		



		[Column("ConsigneeStateProvince")]
		public string ConsigneeStateProvince 
		{ 
			get { return ConsigneeStateProvince_private; }
			set { SetProperty(ConsigneeStateProvince_private, value, (val) => { ConsigneeStateProvince_private = val; }, ConsigneeStateProvince_PropertyName); }
		}
		public static string ConsigneeStateProvince_PropertyName = "ConsigneeStateProvince";
		private string ConsigneeStateProvince_private;
		
		



		[Column("ConsigneeWebsite")]
		public string ConsigneeWebsite 
		{ 
			get { return ConsigneeWebsite_private; }
			set { SetProperty(ConsigneeWebsite_private, value, (val) => { ConsigneeWebsite_private = val; }, ConsigneeWebsite_PropertyName); }
		}
		public static string ConsigneeWebsite_PropertyName = "ConsigneeWebsite";
		private string ConsigneeWebsite_private;
		
		



		[Column("ConvertedDate")]

		// The actual column definition, as seen in SQLite
		public string ConvertedDate_raw { get; set; }

		public static string ConvertedDate_PropertyName = "ConvertedDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ConvertedDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ConvertedDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ConvertedDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ConvertedDate_raw, ConvertedDate_ConvertToString(value), (val) => { ConvertedDate_raw = val; }, ConvertedDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ConvertedDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("ConvertedById")]
		public Nullable<int> ConvertedById 
		{ 
			get { return ConvertedById_private; }
			set { SetProperty(ConvertedById_private, value, (val) => { ConvertedById_private = val; }, ConvertedById_PropertyName); }
		}
		public static string ConvertedById_PropertyName = "ConvertedById";
		private Nullable<int> ConvertedById_private;
		
		



		[Column("ConvertedByName")]
		public string ConvertedByName 
		{ 
			get { return ConvertedByName_private; }
			set { SetProperty(ConvertedByName_private, value, (val) => { ConvertedByName_private = val; }, ConvertedByName_PropertyName); }
		}
		public static string ConvertedByName_PropertyName = "ConvertedByName";
		private string ConvertedByName_private;
		
		



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
		
		



		[Column("Destinations")]
		public string Destinations 
		{ 
			get { return Destinations_private; }
			set { SetProperty(Destinations_private, value, (val) => { Destinations_private = val; }, Destinations_PropertyName); }
		}
		public static string Destinations_PropertyName = "Destinations";
		private string Destinations_private;
		
		



		[Column("Direction")]
		public string Direction 
		{ 
			get { return Direction_private; }
			set { SetProperty(Direction_private, value, (val) => { Direction_private = val; }, Direction_PropertyName); }
		}
		public static string Direction_PropertyName = "Direction";
		private string Direction_private;
		
		



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

		



		[Column("FreightServices")]
		public string FreightServices 
		{ 
			get { return FreightServices_private; }
			set { SetProperty(FreightServices_private, value, (val) => { FreightServices_private = val; }, FreightServices_PropertyName); }
		}
		public static string FreightServices_PropertyName = "FreightServices";
		private string FreightServices_private;
		
		



		[Column("Incoterms")]
		public string Incoterms 
		{ 
			get { return Incoterms_private; }
			set { SetProperty(Incoterms_private, value, (val) => { Incoterms_private = val; }, Incoterms_PropertyName); }
		}
		public static string Incoterms_PropertyName = "Incoterms";
		private string Incoterms_private;
		
		



		[Column("IndustrySector")]
		public string IndustrySector 
		{ 
			get { return IndustrySector_private; }
			set { SetProperty(IndustrySector_private, value, (val) => { IndustrySector_private = val; }, IndustrySector_PropertyName); }
		}
		public static string IndustrySector_PropertyName = "IndustrySector";
		private string IndustrySector_private;
		
		


		[NotNull]
		[Column("InterOffice")]
		public bool InterOffice 
		{ 
			get { return InterOffice_private; }
			set { SetProperty(InterOffice_private, value, (val) => { InterOffice_private = val; }, InterOffice_PropertyName); }
		}
		public static string InterOffice_PropertyName = "InterOffice";
		private bool InterOffice_private;
		
		



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

		



		[Column("LeadAddress")]
		public string LeadAddress 
		{ 
			get { return LeadAddress_private; }
			set { SetProperty(LeadAddress_private, value, (val) => { LeadAddress_private = val; }, LeadAddress_PropertyName); }
		}
		public static string LeadAddress_PropertyName = "LeadAddress";
		private string LeadAddress_private;
		
		



		[Column("LeadCity")]
		public string LeadCity 
		{ 
			get { return LeadCity_private; }
			set { SetProperty(LeadCity_private, value, (val) => { LeadCity_private = val; }, LeadCity_PropertyName); }
		}
		public static string LeadCity_PropertyName = "LeadCity";
		private string LeadCity_private;
		
		



		[Column("LeadContact")]
		public string LeadContact 
		{ 
			get { return LeadContact_private; }
			set { SetProperty(LeadContact_private, value, (val) => { LeadContact_private = val; }, LeadContact_PropertyName); }
		}
		public static string LeadContact_PropertyName = "LeadContact";
		private string LeadContact_private;
		
		



		[Column("LeadContactSalutation")]
		public string LeadContactSalutation 
		{ 
			get { return LeadContactSalutation_private; }
			set { SetProperty(LeadContactSalutation_private, value, (val) => { LeadContactSalutation_private = val; }, LeadContactSalutation_PropertyName); }
		}
		public static string LeadContactSalutation_PropertyName = "LeadContactSalutation";
		private string LeadContactSalutation_private;
		
		



		[Column("LeadContactTitle")]
		public string LeadContactTitle 
		{ 
			get { return LeadContactTitle_private; }
			set { SetProperty(LeadContactTitle_private, value, (val) => { LeadContactTitle_private = val; }, LeadContactTitle_PropertyName); }
		}
		public static string LeadContactTitle_PropertyName = "LeadContactTitle";
		private string LeadContactTitle_private;
		
		



		[Column("LeadCountryCode")]
		public string LeadCountryCode 
		{ 
			get { return LeadCountryCode_private; }
			set { SetProperty(LeadCountryCode_private, value, (val) => { LeadCountryCode_private = val; }, LeadCountryCode_PropertyName); }
		}
		public static string LeadCountryCode_PropertyName = "LeadCountryCode";
		private string LeadCountryCode_private;
		
		



		[Column("LeadCountryName")]
		public string LeadCountryName 
		{ 
			get { return LeadCountryName_private; }
			set { SetProperty(LeadCountryName_private, value, (val) => { LeadCountryName_private = val; }, LeadCountryName_PropertyName); }
		}
		public static string LeadCountryName_PropertyName = "LeadCountryName";
		private string LeadCountryName_private;
		
		



		[Column("LeadDateReceived")]
		public string LeadDateReceived 
		{ 
			get { return LeadDateReceived_private; }
			set { SetProperty(LeadDateReceived_private, value, (val) => { LeadDateReceived_private = val; }, LeadDateReceived_PropertyName); }
		}
		public static string LeadDateReceived_PropertyName = "LeadDateReceived";
		private string LeadDateReceived_private;
		
		



		[Column("LeadEmail")]
		public string LeadEmail 
		{ 
			get { return LeadEmail_private; }
			set { SetProperty(LeadEmail_private, value, (val) => { LeadEmail_private = val; }, LeadEmail_PropertyName); }
		}
		public static string LeadEmail_PropertyName = "LeadEmail";
		private string LeadEmail_private;
		
		



		[Column("LeadFax")]
		public string LeadFax 
		{ 
			get { return LeadFax_private; }
			set { SetProperty(LeadFax_private, value, (val) => { LeadFax_private = val; }, LeadFax_PropertyName); }
		}
		public static string LeadFax_PropertyName = "LeadFax";
		private string LeadFax_private;
		
		



		[Column("LeadMobile")]
		public string LeadMobile 
		{ 
			get { return LeadMobile_private; }
			set { SetProperty(LeadMobile_private, value, (val) => { LeadMobile_private = val; }, LeadMobile_PropertyName); }
		}
		public static string LeadMobile_PropertyName = "LeadMobile";
		private string LeadMobile_private;
		
		



		[Column("LeadName")]
		public string LeadName 
		{ 
			get { return LeadName_private; }
			set { SetProperty(LeadName_private, value, (val) => { LeadName_private = val; }, LeadName_PropertyName); }
		}
		public static string LeadName_PropertyName = "LeadName";
		private string LeadName_private;
		
		



		[Column("LeadNumber")]
		public string LeadNumber 
		{ 
			get { return LeadNumber_private; }
			set { SetProperty(LeadNumber_private, value, (val) => { LeadNumber_private = val; }, LeadNumber_PropertyName); }
		}
		public static string LeadNumber_PropertyName = "LeadNumber";
		private string LeadNumber_private;
		
		



		[Column("LeadPhone")]
		public string LeadPhone 
		{ 
			get { return LeadPhone_private; }
			set { SetProperty(LeadPhone_private, value, (val) => { LeadPhone_private = val; }, LeadPhone_PropertyName); }
		}
		public static string LeadPhone_PropertyName = "LeadPhone";
		private string LeadPhone_private;
		
		



		[Column("LeadPostalCode")]
		public string LeadPostalCode 
		{ 
			get { return LeadPostalCode_private; }
			set { SetProperty(LeadPostalCode_private, value, (val) => { LeadPostalCode_private = val; }, LeadPostalCode_PropertyName); }
		}
		public static string LeadPostalCode_PropertyName = "LeadPostalCode";
		private string LeadPostalCode_private;
		
		



		[Column("LeadSource")]
		public string LeadSource 
		{ 
			get { return LeadSource_private; }
			set { SetProperty(LeadSource_private, value, (val) => { LeadSource_private = val; }, LeadSource_PropertyName); }
		}
		public static string LeadSource_PropertyName = "LeadSource";
		private string LeadSource_private;
		
		



		[Column("LeadStateProvince")]
		public string LeadStateProvince 
		{ 
			get { return LeadStateProvince_private; }
			set { SetProperty(LeadStateProvince_private, value, (val) => { LeadStateProvince_private = val; }, LeadStateProvince_PropertyName); }
		}
		public static string LeadStateProvince_PropertyName = "LeadStateProvince";
		private string LeadStateProvince_private;
		
		



		[Column("LeadStatusCode")]
		public string LeadStatusCode 
		{ 
			get { return LeadStatusCode_private; }
			set { SetProperty(LeadStatusCode_private, value, (val) => { LeadStatusCode_private = val; }, LeadStatusCode_PropertyName); }
		}
		public static string LeadStatusCode_PropertyName = "LeadStatusCode";
		private string LeadStatusCode_private;
		
		



		[Column("LeadWebsite")]
		public string LeadWebsite 
		{ 
			get { return LeadWebsite_private; }
			set { SetProperty(LeadWebsite_private, value, (val) => { LeadWebsite_private = val; }, LeadWebsite_PropertyName); }
		}
		public static string LeadWebsite_PropertyName = "LeadWebsite";
		private string LeadWebsite_private;
		
		



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

		



		[Column("OriginatingUser")]
		public string OriginatingUser 
		{ 
			get { return OriginatingUser_private; }
			set { SetProperty(OriginatingUser_private, value, (val) => { OriginatingUser_private = val; }, OriginatingUser_PropertyName); }
		}
		public static string OriginatingUser_PropertyName = "OriginatingUser";
		private string OriginatingUser_private;
		
		



		[Column("OriginatingUserId")]
		public Nullable<int> OriginatingUserId 
		{ 
			get { return OriginatingUserId_private; }
			set { SetProperty(OriginatingUserId_private, value, (val) => { OriginatingUserId_private = val; }, OriginatingUserId_PropertyName); }
		}
		public static string OriginatingUserId_PropertyName = "OriginatingUserId";
		private Nullable<int> OriginatingUserId_private;
		
		



		[Column("Origins")]
		public string Origins 
		{ 
			get { return Origins_private; }
			set { SetProperty(Origins_private, value, (val) => { Origins_private = val; }, Origins_PropertyName); }
		}
		public static string Origins_PropertyName = "Origins";
		private string Origins_private;
		
		



		[Column("OriginSystem")]
		public string OriginSystem 
		{ 
			get { return OriginSystem_private; }
			set { SetProperty(OriginSystem_private, value, (val) => { OriginSystem_private = val; }, OriginSystem_PropertyName); }
		}
		public static string OriginSystem_PropertyName = "OriginSystem";
		private string OriginSystem_private;
		
		



		[Column("OtherAddress")]
		public string OtherAddress 
		{ 
			get { return OtherAddress_private; }
			set { SetProperty(OtherAddress_private, value, (val) => { OtherAddress_private = val; }, OtherAddress_PropertyName); }
		}
		public static string OtherAddress_PropertyName = "OtherAddress";
		private string OtherAddress_private;
		
		



		[Column("OtherCity")]
		public string OtherCity 
		{ 
			get { return OtherCity_private; }
			set { SetProperty(OtherCity_private, value, (val) => { OtherCity_private = val; }, OtherCity_PropertyName); }
		}
		public static string OtherCity_PropertyName = "OtherCity";
		private string OtherCity_private;
		
		



		[Column("OtherCompany")]
		public string OtherCompany 
		{ 
			get { return OtherCompany_private; }
			set { SetProperty(OtherCompany_private, value, (val) => { OtherCompany_private = val; }, OtherCompany_PropertyName); }
		}
		public static string OtherCompany_PropertyName = "OtherCompany";
		private string OtherCompany_private;
		
		



		[Column("OtherContact")]
		public string OtherContact 
		{ 
			get { return OtherContact_private; }
			set { SetProperty(OtherContact_private, value, (val) => { OtherContact_private = val; }, OtherContact_PropertyName); }
		}
		public static string OtherContact_PropertyName = "OtherContact";
		private string OtherContact_private;
		
		



		[Column("OtherContactSalutation")]
		public string OtherContactSalutation 
		{ 
			get { return OtherContactSalutation_private; }
			set { SetProperty(OtherContactSalutation_private, value, (val) => { OtherContactSalutation_private = val; }, OtherContactSalutation_PropertyName); }
		}
		public static string OtherContactSalutation_PropertyName = "OtherContactSalutation";
		private string OtherContactSalutation_private;
		
		



		[Column("OtherContactTitle")]
		public string OtherContactTitle 
		{ 
			get { return OtherContactTitle_private; }
			set { SetProperty(OtherContactTitle_private, value, (val) => { OtherContactTitle_private = val; }, OtherContactTitle_PropertyName); }
		}
		public static string OtherContactTitle_PropertyName = "OtherContactTitle";
		private string OtherContactTitle_private;
		
		



		[Column("OtherCountryCode")]
		public string OtherCountryCode 
		{ 
			get { return OtherCountryCode_private; }
			set { SetProperty(OtherCountryCode_private, value, (val) => { OtherCountryCode_private = val; }, OtherCountryCode_PropertyName); }
		}
		public static string OtherCountryCode_PropertyName = "OtherCountryCode";
		private string OtherCountryCode_private;
		
		



		[Column("OtherCountryName")]
		public string OtherCountryName 
		{ 
			get { return OtherCountryName_private; }
			set { SetProperty(OtherCountryName_private, value, (val) => { OtherCountryName_private = val; }, OtherCountryName_PropertyName); }
		}
		public static string OtherCountryName_PropertyName = "OtherCountryName";
		private string OtherCountryName_private;
		
		



		[Column("OtherEmail")]
		public string OtherEmail 
		{ 
			get { return OtherEmail_private; }
			set { SetProperty(OtherEmail_private, value, (val) => { OtherEmail_private = val; }, OtherEmail_PropertyName); }
		}
		public static string OtherEmail_PropertyName = "OtherEmail";
		private string OtherEmail_private;
		
		



		[Column("OtherFax")]
		public string OtherFax 
		{ 
			get { return OtherFax_private; }
			set { SetProperty(OtherFax_private, value, (val) => { OtherFax_private = val; }, OtherFax_PropertyName); }
		}
		public static string OtherFax_PropertyName = "OtherFax";
		private string OtherFax_private;
		
		



		[Column("OtherMobile")]
		public string OtherMobile 
		{ 
			get { return OtherMobile_private; }
			set { SetProperty(OtherMobile_private, value, (val) => { OtherMobile_private = val; }, OtherMobile_PropertyName); }
		}
		public static string OtherMobile_PropertyName = "OtherMobile";
		private string OtherMobile_private;
		
		



		[Column("OtherPhone")]
		public string OtherPhone 
		{ 
			get { return OtherPhone_private; }
			set { SetProperty(OtherPhone_private, value, (val) => { OtherPhone_private = val; }, OtherPhone_PropertyName); }
		}
		public static string OtherPhone_PropertyName = "OtherPhone";
		private string OtherPhone_private;
		
		



		[Column("OtherPostalCode")]
		public string OtherPostalCode 
		{ 
			get { return OtherPostalCode_private; }
			set { SetProperty(OtherPostalCode_private, value, (val) => { OtherPostalCode_private = val; }, OtherPostalCode_PropertyName); }
		}
		public static string OtherPostalCode_PropertyName = "OtherPostalCode";
		private string OtherPostalCode_private;
		
		



		[Column("OtherStateProvince")]
		public string OtherStateProvince 
		{ 
			get { return OtherStateProvince_private; }
			set { SetProperty(OtherStateProvince_private, value, (val) => { OtherStateProvince_private = val; }, OtherStateProvince_PropertyName); }
		}
		public static string OtherStateProvince_PropertyName = "OtherStateProvince";
		private string OtherStateProvince_private;
		
		



		[Column("OtherWebsite")]
		public string OtherWebsite 
		{ 
			get { return OtherWebsite_private; }
			set { SetProperty(OtherWebsite_private, value, (val) => { OtherWebsite_private = val; }, OtherWebsite_PropertyName); }
		}
		public static string OtherWebsite_PropertyName = "OtherWebsite";
		private string OtherWebsite_private;
		
		



		[Column("PrimaryContactId")]
		public Nullable<int> PrimaryContactId 
		{ 
			get { return PrimaryContactId_private; }
			set { SetProperty(PrimaryContactId_private, value, (val) => { PrimaryContactId_private = val; }, PrimaryContactId_PropertyName); }
		}
		public static string PrimaryContactId_PropertyName = "PrimaryContactId";
		private Nullable<int> PrimaryContactId_private;
		
		



		[Column("ReasonLost")]
		public string ReasonLost 
		{ 
			get { return ReasonLost_private; }
			set { SetProperty(ReasonLost_private, value, (val) => { ReasonLost_private = val; }, ReasonLost_PropertyName); }
		}
		public static string ReasonLost_PropertyName = "ReasonLost";
		private string ReasonLost_private;
		
		



		[Column("ReferralDate")]

		// The actual column definition, as seen in SQLite
		public string ReferralDate_raw { get; set; }

		public static string ReferralDate_PropertyName = "ReferralDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ReferralDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ReferralDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ReferralDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ReferralDate_raw, ReferralDate_ConvertToString(value), (val) => { ReferralDate_raw = val; }, ReferralDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ReferralDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("ReferralDueDate")]

		// The actual column definition, as seen in SQLite
		public string ReferralDueDate_raw { get; set; }

		public static string ReferralDueDate_PropertyName = "ReferralDueDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ReferralDueDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ReferralDueDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ReferralDueDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ReferralDueDate_raw, ReferralDueDate_ConvertToString(value), (val) => { ReferralDueDate_raw = val; }, ReferralDueDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ReferralDueDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("ReferralResponseDate")]

		// The actual column definition, as seen in SQLite
		public string ReferralResponseDate_raw { get; set; }

		public static string ReferralResponseDate_PropertyName = "ReferralResponseDate";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> ReferralResponseDate { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return ReferralResponseDate_raw != null ? (Nullable<DateTime>)DateTime.Parse(ReferralResponseDate_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(ReferralResponseDate_raw, ReferralResponseDate_ConvertToString(value), (val) => { ReferralResponseDate_raw = val; }, ReferralResponseDate_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string ReferralResponseDate_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("ReferralType")]
		public string ReferralType 
		{ 
			get { return ReferralType_private; }
			set { SetProperty(ReferralType_private, value, (val) => { ReferralType_private = val; }, ReferralType_PropertyName); }
		}
		public static string ReferralType_PropertyName = "ReferralType";
		private string ReferralType_private;
		
		



		[Column("ReferredBySalesRepCode")]
		public string ReferredBySalesRepCode 
		{ 
			get { return ReferredBySalesRepCode_private; }
			set { SetProperty(ReferredBySalesRepCode_private, value, (val) => { ReferredBySalesRepCode_private = val; }, ReferredBySalesRepCode_PropertyName); }
		}
		public static string ReferredBySalesRepCode_PropertyName = "ReferredBySalesRepCode";
		private string ReferredBySalesRepCode_private;
		
		



		[Column("ReferredByStationCode")]
		public string ReferredByStationCode 
		{ 
			get { return ReferredByStationCode_private; }
			set { SetProperty(ReferredByStationCode_private, value, (val) => { ReferredByStationCode_private = val; }, ReferredByStationCode_PropertyName); }
		}
		public static string ReferredByStationCode_PropertyName = "ReferredByStationCode";
		private string ReferredByStationCode_private;
		
		



		[Column("ReferredByStationId")]
		public Nullable<int> ReferredByStationId 
		{ 
			get { return ReferredByStationId_private; }
			set { SetProperty(ReferredByStationId_private, value, (val) => { ReferredByStationId_private = val; }, ReferredByStationId_PropertyName); }
		}
		public static string ReferredByStationId_PropertyName = "ReferredByStationId";
		private Nullable<int> ReferredByStationId_private;
		
		



		[Column("ReferredByStationName")]
		public string ReferredByStationName 
		{ 
			get { return ReferredByStationName_private; }
			set { SetProperty(ReferredByStationName_private, value, (val) => { ReferredByStationName_private = val; }, ReferredByStationName_PropertyName); }
		}
		public static string ReferredByStationName_PropertyName = "ReferredByStationName";
		private string ReferredByStationName_private;
		
		



		[Column("ReferredByUserId")]
		public Nullable<int> ReferredByUserId 
		{ 
			get { return ReferredByUserId_private; }
			set { SetProperty(ReferredByUserId_private, value, (val) => { ReferredByUserId_private = val; }, ReferredByUserId_PropertyName); }
		}
		public static string ReferredByUserId_PropertyName = "ReferredByUserId";
		private Nullable<int> ReferredByUserId_private;
		
		



		[Column("ReferredByUserName")]
		public string ReferredByUserName 
		{ 
			get { return ReferredByUserName_private; }
			set { SetProperty(ReferredByUserName_private, value, (val) => { ReferredByUserName_private = val; }, ReferredByUserName_PropertyName); }
		}
		public static string ReferredByUserName_PropertyName = "ReferredByUserName";
		private string ReferredByUserName_private;
		
		



		[Column("ReferredToEmail")]
		public string ReferredToEmail 
		{ 
			get { return ReferredToEmail_private; }
			set { SetProperty(ReferredToEmail_private, value, (val) => { ReferredToEmail_private = val; }, ReferredToEmail_PropertyName); }
		}
		public static string ReferredToEmail_PropertyName = "ReferredToEmail";
		private string ReferredToEmail_private;
		
		



		[Column("ReferredToSalesRepCode")]
		public string ReferredToSalesRepCode 
		{ 
			get { return ReferredToSalesRepCode_private; }
			set { SetProperty(ReferredToSalesRepCode_private, value, (val) => { ReferredToSalesRepCode_private = val; }, ReferredToSalesRepCode_PropertyName); }
		}
		public static string ReferredToSalesRepCode_PropertyName = "ReferredToSalesRepCode";
		private string ReferredToSalesRepCode_private;
		
		



		[Column("ReferredToStationCode")]
		public string ReferredToStationCode 
		{ 
			get { return ReferredToStationCode_private; }
			set { SetProperty(ReferredToStationCode_private, value, (val) => { ReferredToStationCode_private = val; }, ReferredToStationCode_PropertyName); }
		}
		public static string ReferredToStationCode_PropertyName = "ReferredToStationCode";
		private string ReferredToStationCode_private;
		
		



		[Column("ReferredToStationId")]
		public Nullable<int> ReferredToStationId 
		{ 
			get { return ReferredToStationId_private; }
			set { SetProperty(ReferredToStationId_private, value, (val) => { ReferredToStationId_private = val; }, ReferredToStationId_PropertyName); }
		}
		public static string ReferredToStationId_PropertyName = "ReferredToStationId";
		private Nullable<int> ReferredToStationId_private;
		
		



		[Column("ReferredToStationName")]
		public string ReferredToStationName 
		{ 
			get { return ReferredToStationName_private; }
			set { SetProperty(ReferredToStationName_private, value, (val) => { ReferredToStationName_private = val; }, ReferredToStationName_PropertyName); }
		}
		public static string ReferredToStationName_PropertyName = "ReferredToStationName";
		private string ReferredToStationName_private;
		
		



		[Column("ReferredToUserId")]
		public Nullable<int> ReferredToUserId 
		{ 
			get { return ReferredToUserId_private; }
			set { SetProperty(ReferredToUserId_private, value, (val) => { ReferredToUserId_private = val; }, ReferredToUserId_PropertyName); }
		}
		public static string ReferredToUserId_PropertyName = "ReferredToUserId";
		private Nullable<int> ReferredToUserId_private;
		
		



		[Column("ReferredToUserName")]
		public string ReferredToUserName 
		{ 
			get { return ReferredToUserName_private; }
			set { SetProperty(ReferredToUserName_private, value, (val) => { ReferredToUserName_private = val; }, ReferredToUserName_PropertyName); }
		}
		public static string ReferredToUserName_PropertyName = "ReferredToUserName";
		private string ReferredToUserName_private;
		
		



		[Column("SalesGroup")]
		public string SalesGroup 
		{ 
			get { return SalesGroup_private; }
			set { SetProperty(SalesGroup_private, value, (val) => { SalesGroup_private = val; }, SalesGroup_PropertyName); }
		}
		public static string SalesGroup_PropertyName = "SalesGroup";
		private string SalesGroup_private;
		
		



		[Column("ShipperAddress")]
		public string ShipperAddress 
		{ 
			get { return ShipperAddress_private; }
			set { SetProperty(ShipperAddress_private, value, (val) => { ShipperAddress_private = val; }, ShipperAddress_PropertyName); }
		}
		public static string ShipperAddress_PropertyName = "ShipperAddress";
		private string ShipperAddress_private;
		
		



		[Column("ShipperCity")]
		public string ShipperCity 
		{ 
			get { return ShipperCity_private; }
			set { SetProperty(ShipperCity_private, value, (val) => { ShipperCity_private = val; }, ShipperCity_PropertyName); }
		}
		public static string ShipperCity_PropertyName = "ShipperCity";
		private string ShipperCity_private;
		
		



		[Column("ShipperCompany")]
		public string ShipperCompany 
		{ 
			get { return ShipperCompany_private; }
			set { SetProperty(ShipperCompany_private, value, (val) => { ShipperCompany_private = val; }, ShipperCompany_PropertyName); }
		}
		public static string ShipperCompany_PropertyName = "ShipperCompany";
		private string ShipperCompany_private;
		
		



		[Column("ShipperContact")]
		public string ShipperContact 
		{ 
			get { return ShipperContact_private; }
			set { SetProperty(ShipperContact_private, value, (val) => { ShipperContact_private = val; }, ShipperContact_PropertyName); }
		}
		public static string ShipperContact_PropertyName = "ShipperContact";
		private string ShipperContact_private;
		
		



		[Column("ShipperContactSalutation")]
		public string ShipperContactSalutation 
		{ 
			get { return ShipperContactSalutation_private; }
			set { SetProperty(ShipperContactSalutation_private, value, (val) => { ShipperContactSalutation_private = val; }, ShipperContactSalutation_PropertyName); }
		}
		public static string ShipperContactSalutation_PropertyName = "ShipperContactSalutation";
		private string ShipperContactSalutation_private;
		
		



		[Column("ShipperContactTitle")]
		public string ShipperContactTitle 
		{ 
			get { return ShipperContactTitle_private; }
			set { SetProperty(ShipperContactTitle_private, value, (val) => { ShipperContactTitle_private = val; }, ShipperContactTitle_PropertyName); }
		}
		public static string ShipperContactTitle_PropertyName = "ShipperContactTitle";
		private string ShipperContactTitle_private;
		
		



		[Column("ShipperCountryCode")]
		public string ShipperCountryCode 
		{ 
			get { return ShipperCountryCode_private; }
			set { SetProperty(ShipperCountryCode_private, value, (val) => { ShipperCountryCode_private = val; }, ShipperCountryCode_PropertyName); }
		}
		public static string ShipperCountryCode_PropertyName = "ShipperCountryCode";
		private string ShipperCountryCode_private;
		
		



		[Column("ShipperCountryName")]
		public string ShipperCountryName 
		{ 
			get { return ShipperCountryName_private; }
			set { SetProperty(ShipperCountryName_private, value, (val) => { ShipperCountryName_private = val; }, ShipperCountryName_PropertyName); }
		}
		public static string ShipperCountryName_PropertyName = "ShipperCountryName";
		private string ShipperCountryName_private;
		
		



		[Column("ShipperEmail")]
		public string ShipperEmail 
		{ 
			get { return ShipperEmail_private; }
			set { SetProperty(ShipperEmail_private, value, (val) => { ShipperEmail_private = val; }, ShipperEmail_PropertyName); }
		}
		public static string ShipperEmail_PropertyName = "ShipperEmail";
		private string ShipperEmail_private;
		
		



		[Column("ShipperFax")]
		public string ShipperFax 
		{ 
			get { return ShipperFax_private; }
			set { SetProperty(ShipperFax_private, value, (val) => { ShipperFax_private = val; }, ShipperFax_PropertyName); }
		}
		public static string ShipperFax_PropertyName = "ShipperFax";
		private string ShipperFax_private;
		
		



		[Column("ShipperMobile")]
		public string ShipperMobile 
		{ 
			get { return ShipperMobile_private; }
			set { SetProperty(ShipperMobile_private, value, (val) => { ShipperMobile_private = val; }, ShipperMobile_PropertyName); }
		}
		public static string ShipperMobile_PropertyName = "ShipperMobile";
		private string ShipperMobile_private;
		
		



		[Column("ShipperPhone")]
		public string ShipperPhone 
		{ 
			get { return ShipperPhone_private; }
			set { SetProperty(ShipperPhone_private, value, (val) => { ShipperPhone_private = val; }, ShipperPhone_PropertyName); }
		}
		public static string ShipperPhone_PropertyName = "ShipperPhone";
		private string ShipperPhone_private;
		
		



		[Column("ShipperPostalCode")]
		public string ShipperPostalCode 
		{ 
			get { return ShipperPostalCode_private; }
			set { SetProperty(ShipperPostalCode_private, value, (val) => { ShipperPostalCode_private = val; }, ShipperPostalCode_PropertyName); }
		}
		public static string ShipperPostalCode_PropertyName = "ShipperPostalCode";
		private string ShipperPostalCode_private;
		
		



		[Column("ShipperStateProvince")]
		public string ShipperStateProvince 
		{ 
			get { return ShipperStateProvince_private; }
			set { SetProperty(ShipperStateProvince_private, value, (val) => { ShipperStateProvince_private = val; }, ShipperStateProvince_PropertyName); }
		}
		public static string ShipperStateProvince_PropertyName = "ShipperStateProvince";
		private string ShipperStateProvince_private;
		
		



		[Column("ShipperWebsite")]
		public string ShipperWebsite 
		{ 
			get { return ShipperWebsite_private; }
			set { SetProperty(ShipperWebsite_private, value, (val) => { ShipperWebsite_private = val; }, ShipperWebsite_PropertyName); }
		}
		public static string ShipperWebsite_PropertyName = "ShipperWebsite";
		private string ShipperWebsite_private;
		
		



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
		
		



		[Column("ConsigneeCountry")]
		public string ConsigneeCountry 
		{ 
			get { return ConsigneeCountry_private; }
			set { SetProperty(ConsigneeCountry_private, value, (val) => { ConsigneeCountry_private = val; }, ConsigneeCountry_PropertyName); }
		}
		public static string ConsigneeCountry_PropertyName = "ConsigneeCountry";
		private string ConsigneeCountry_private;
		
		



		[Column("LeadCountry")]
		public string LeadCountry 
		{ 
			get { return LeadCountry_private; }
			set { SetProperty(LeadCountry_private, value, (val) => { LeadCountry_private = val; }, LeadCountry_PropertyName); }
		}
		public static string LeadCountry_PropertyName = "LeadCountry";
		private string LeadCountry_private;
		
		



		[Column("LeadSalutation")]
		public string LeadSalutation 
		{ 
			get { return LeadSalutation_private; }
			set { SetProperty(LeadSalutation_private, value, (val) => { LeadSalutation_private = val; }, LeadSalutation_PropertyName); }
		}
		public static string LeadSalutation_PropertyName = "LeadSalutation";
		private string LeadSalutation_private;
		
		



		[Column("LeadState")]
		public string LeadState 
		{ 
			get { return LeadState_private; }
			set { SetProperty(LeadState_private, value, (val) => { LeadState_private = val; }, LeadState_PropertyName); }
		}
		public static string LeadState_PropertyName = "LeadState";
		private string LeadState_private;
		
		



		[Column("LeadZipCode")]
		public string LeadZipCode 
		{ 
			get { return LeadZipCode_private; }
			set { SetProperty(LeadZipCode_private, value, (val) => { LeadZipCode_private = val; }, LeadZipCode_PropertyName); }
		}
		public static string LeadZipCode_PropertyName = "LeadZipCode";
		private string LeadZipCode_private;
		
		



		[Column("OtherCountry")]
		public string OtherCountry 
		{ 
			get { return OtherCountry_private; }
			set { SetProperty(OtherCountry_private, value, (val) => { OtherCountry_private = val; }, OtherCountry_PropertyName); }
		}
		public static string OtherCountry_PropertyName = "OtherCountry";
		private string OtherCountry_private;
		
		



		[Column("ShipperCountry")]
		public string ShipperCountry 
		{ 
			get { return ShipperCountry_private; }
			set { SetProperty(ShipperCountry_private, value, (val) => { ShipperCountry_private = val; }, ShipperCountry_PropertyName); }
		}
		public static string ShipperCountry_PropertyName = "ShipperCountry";
		private string ShipperCountry_private;
		
		



		[Column("Title")]
		public string Title 
		{ 
			get { return Title_private; }
			set { SetProperty(Title_private, value, (val) => { Title_private = val; }, Title_PropertyName); }
		}
		public static string Title_PropertyName = "Title";
		private string Title_private;
		
		


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

			if (AnnualShipments != null)
			{
				sb.Append(AnnualShipments.ToString());
			}
			sb.Append("|");

			if (AnnualVolumes != null)
			{
				sb.Append(AnnualVolumes.ToString());
			}
			sb.Append("|");

			if (AssignedDate != null)
			{
				sb.Append(AssignedDate_ConvertToString(AssignedDate));
			}
			sb.Append("|");

			if (AssignedSalesRepCode != null)
			{
				sb.Append(AssignedSalesRepCode.ToString());
			}
			sb.Append("|");

			if (CampaignName != null)
			{
				sb.Append(CampaignName.ToString());
			}
			sb.Append("|");

			if (Comments != null)
			{
				sb.Append(Comments.ToString());
			}
			sb.Append("|");

			if (Commodities != null)
			{
				sb.Append(Commodities.ToString());
			}
			sb.Append("|");

			if (Competitors != null)
			{
				sb.Append(Competitors.ToString());
			}
			sb.Append("|");

			if (ConsigneeAddress != null)
			{
				sb.Append(ConsigneeAddress.ToString());
			}
			sb.Append("|");

			if (ConsigneeCity != null)
			{
				sb.Append(ConsigneeCity.ToString());
			}
			sb.Append("|");

			if (ConsigneeCompany != null)
			{
				sb.Append(ConsigneeCompany.ToString());
			}
			sb.Append("|");

			if (ConsigneeContact != null)
			{
				sb.Append(ConsigneeContact.ToString());
			}
			sb.Append("|");

			if (ConsigneeContactSalutation != null)
			{
				sb.Append(ConsigneeContactSalutation.ToString());
			}
			sb.Append("|");

			if (ConsigneeContactTitle != null)
			{
				sb.Append(ConsigneeContactTitle.ToString());
			}
			sb.Append("|");

			if (ConsigneeCountryCode != null)
			{
				sb.Append(ConsigneeCountryCode.ToString());
			}
			sb.Append("|");

			if (ConsigneeCountryName != null)
			{
				sb.Append(ConsigneeCountryName.ToString());
			}
			sb.Append("|");

			if (ConsigneeEmail != null)
			{
				sb.Append(ConsigneeEmail.ToString());
			}
			sb.Append("|");

			if (ConsigneeFax != null)
			{
				sb.Append(ConsigneeFax.ToString());
			}
			sb.Append("|");

			if (ConsigneeMobile != null)
			{
				sb.Append(ConsigneeMobile.ToString());
			}
			sb.Append("|");

			if (ConsigneePhone != null)
			{
				sb.Append(ConsigneePhone.ToString());
			}
			sb.Append("|");

			if (ConsigneePostalCode != null)
			{
				sb.Append(ConsigneePostalCode.ToString());
			}
			sb.Append("|");

			if (ConsigneeStateProvince != null)
			{
				sb.Append(ConsigneeStateProvince.ToString());
			}
			sb.Append("|");

			if (ConsigneeWebsite != null)
			{
				sb.Append(ConsigneeWebsite.ToString());
			}
			sb.Append("|");

			if (ConvertedDate != null)
			{
				sb.Append(ConvertedDate_ConvertToString(ConvertedDate));
			}
			sb.Append("|");

			if (ConvertedById.HasValue)
			{
				sb.Append(ConvertedById.ToString());
			}
			sb.Append("|");

			if (ConvertedByName != null)
			{
				sb.Append(ConvertedByName.ToString());
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

			if (DateLost != null)
			{
				sb.Append(DateLost_ConvertToString(DateLost));
			}
			sb.Append("|");

			sb.Append(Deleted.ToString());

			sb.Append("|");

			if (DeletedById.HasValue)
			{
				sb.Append(DeletedById.ToString());
			}
			sb.Append("|");

			if (Destinations != null)
			{
				sb.Append(Destinations.ToString());
			}
			sb.Append("|");

			if (Direction != null)
			{
				sb.Append(Direction.ToString());
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

			if (FreightServices != null)
			{
				sb.Append(FreightServices.ToString());
			}
			sb.Append("|");

			if (Incoterms != null)
			{
				sb.Append(Incoterms.ToString());
			}
			sb.Append("|");

			if (IndustrySector != null)
			{
				sb.Append(IndustrySector.ToString());
			}
			sb.Append("|");

			sb.Append(InterOffice.ToString());

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

			if (LeadAddress != null)
			{
				sb.Append(LeadAddress.ToString());
			}
			sb.Append("|");

			if (LeadCity != null)
			{
				sb.Append(LeadCity.ToString());
			}
			sb.Append("|");

			if (LeadContact != null)
			{
				sb.Append(LeadContact.ToString());
			}
			sb.Append("|");

			if (LeadContactSalutation != null)
			{
				sb.Append(LeadContactSalutation.ToString());
			}
			sb.Append("|");

			if (LeadContactTitle != null)
			{
				sb.Append(LeadContactTitle.ToString());
			}
			sb.Append("|");

			if (LeadCountryCode != null)
			{
				sb.Append(LeadCountryCode.ToString());
			}
			sb.Append("|");

			if (LeadCountryName != null)
			{
				sb.Append(LeadCountryName.ToString());
			}
			sb.Append("|");

			if (LeadDateReceived != null)
			{
				sb.Append(LeadDateReceived.ToString());
			}
			sb.Append("|");

			if (LeadEmail != null)
			{
				sb.Append(LeadEmail.ToString());
			}
			sb.Append("|");

			if (LeadFax != null)
			{
				sb.Append(LeadFax.ToString());
			}
			sb.Append("|");

			if (LeadMobile != null)
			{
				sb.Append(LeadMobile.ToString());
			}
			sb.Append("|");

			if (LeadName != null)
			{
				sb.Append(LeadName.ToString());
			}
			sb.Append("|");

			if (LeadNumber != null)
			{
				sb.Append(LeadNumber.ToString());
			}
			sb.Append("|");

			if (LeadPhone != null)
			{
				sb.Append(LeadPhone.ToString());
			}
			sb.Append("|");

			if (LeadPostalCode != null)
			{
				sb.Append(LeadPostalCode.ToString());
			}
			sb.Append("|");

			if (LeadSource != null)
			{
				sb.Append(LeadSource.ToString());
			}
			sb.Append("|");

			if (LeadStateProvince != null)
			{
				sb.Append(LeadStateProvince.ToString());
			}
			sb.Append("|");

			if (LeadStatusCode != null)
			{
				sb.Append(LeadStatusCode.ToString());
			}
			sb.Append("|");

			if (LeadWebsite != null)
			{
				sb.Append(LeadWebsite.ToString());
			}
			sb.Append("|");

			if (NextActivityDate != null)
			{
				sb.Append(NextActivityDate_ConvertToString(NextActivityDate));
			}
			sb.Append("|");

			if (OriginatingUser != null)
			{
				sb.Append(OriginatingUser.ToString());
			}
			sb.Append("|");

			if (OriginatingUserId.HasValue)
			{
				sb.Append(OriginatingUserId.ToString());
			}
			sb.Append("|");

			if (Origins != null)
			{
				sb.Append(Origins.ToString());
			}
			sb.Append("|");

			if (OriginSystem != null)
			{
				sb.Append(OriginSystem.ToString());
			}
			sb.Append("|");

			if (OtherAddress != null)
			{
				sb.Append(OtherAddress.ToString());
			}
			sb.Append("|");

			if (OtherCity != null)
			{
				sb.Append(OtherCity.ToString());
			}
			sb.Append("|");

			if (OtherCompany != null)
			{
				sb.Append(OtherCompany.ToString());
			}
			sb.Append("|");

			if (OtherContact != null)
			{
				sb.Append(OtherContact.ToString());
			}
			sb.Append("|");

			if (OtherContactSalutation != null)
			{
				sb.Append(OtherContactSalutation.ToString());
			}
			sb.Append("|");

			if (OtherContactTitle != null)
			{
				sb.Append(OtherContactTitle.ToString());
			}
			sb.Append("|");

			if (OtherCountryCode != null)
			{
				sb.Append(OtherCountryCode.ToString());
			}
			sb.Append("|");

			if (OtherCountryName != null)
			{
				sb.Append(OtherCountryName.ToString());
			}
			sb.Append("|");

			if (OtherEmail != null)
			{
				sb.Append(OtherEmail.ToString());
			}
			sb.Append("|");

			if (OtherFax != null)
			{
				sb.Append(OtherFax.ToString());
			}
			sb.Append("|");

			if (OtherMobile != null)
			{
				sb.Append(OtherMobile.ToString());
			}
			sb.Append("|");

			if (OtherPhone != null)
			{
				sb.Append(OtherPhone.ToString());
			}
			sb.Append("|");

			if (OtherPostalCode != null)
			{
				sb.Append(OtherPostalCode.ToString());
			}
			sb.Append("|");

			if (OtherStateProvince != null)
			{
				sb.Append(OtherStateProvince.ToString());
			}
			sb.Append("|");

			if (OtherWebsite != null)
			{
				sb.Append(OtherWebsite.ToString());
			}
			sb.Append("|");

			if (PrimaryContactId.HasValue)
			{
				sb.Append(PrimaryContactId.ToString());
			}
			sb.Append("|");

			if (ReasonLost != null)
			{
				sb.Append(ReasonLost.ToString());
			}
			sb.Append("|");

			if (ReferralDate != null)
			{
				sb.Append(ReferralDate_ConvertToString(ReferralDate));
			}
			sb.Append("|");

			if (ReferralDueDate != null)
			{
				sb.Append(ReferralDueDate_ConvertToString(ReferralDueDate));
			}
			sb.Append("|");

			if (ReferralResponseDate != null)
			{
				sb.Append(ReferralResponseDate_ConvertToString(ReferralResponseDate));
			}
			sb.Append("|");

			if (ReferralType != null)
			{
				sb.Append(ReferralType.ToString());
			}
			sb.Append("|");

			if (ReferredBySalesRepCode != null)
			{
				sb.Append(ReferredBySalesRepCode.ToString());
			}
			sb.Append("|");

			if (ReferredByStationCode != null)
			{
				sb.Append(ReferredByStationCode.ToString());
			}
			sb.Append("|");

			if (ReferredByStationId.HasValue)
			{
				sb.Append(ReferredByStationId.ToString());
			}
			sb.Append("|");

			if (ReferredByStationName != null)
			{
				sb.Append(ReferredByStationName.ToString());
			}
			sb.Append("|");

			if (ReferredByUserId.HasValue)
			{
				sb.Append(ReferredByUserId.ToString());
			}
			sb.Append("|");

			if (ReferredByUserName != null)
			{
				sb.Append(ReferredByUserName.ToString());
			}
			sb.Append("|");

			if (ReferredToEmail != null)
			{
				sb.Append(ReferredToEmail.ToString());
			}
			sb.Append("|");

			if (ReferredToSalesRepCode != null)
			{
				sb.Append(ReferredToSalesRepCode.ToString());
			}
			sb.Append("|");

			if (ReferredToStationCode != null)
			{
				sb.Append(ReferredToStationCode.ToString());
			}
			sb.Append("|");

			if (ReferredToStationId.HasValue)
			{
				sb.Append(ReferredToStationId.ToString());
			}
			sb.Append("|");

			if (ReferredToStationName != null)
			{
				sb.Append(ReferredToStationName.ToString());
			}
			sb.Append("|");

			if (ReferredToUserId.HasValue)
			{
				sb.Append(ReferredToUserId.ToString());
			}
			sb.Append("|");

			if (ReferredToUserName != null)
			{
				sb.Append(ReferredToUserName.ToString());
			}
			sb.Append("|");

			if (SalesGroup != null)
			{
				sb.Append(SalesGroup.ToString());
			}
			sb.Append("|");

			if (ShipperAddress != null)
			{
				sb.Append(ShipperAddress.ToString());
			}
			sb.Append("|");

			if (ShipperCity != null)
			{
				sb.Append(ShipperCity.ToString());
			}
			sb.Append("|");

			if (ShipperCompany != null)
			{
				sb.Append(ShipperCompany.ToString());
			}
			sb.Append("|");

			if (ShipperContact != null)
			{
				sb.Append(ShipperContact.ToString());
			}
			sb.Append("|");

			if (ShipperContactSalutation != null)
			{
				sb.Append(ShipperContactSalutation.ToString());
			}
			sb.Append("|");

			if (ShipperContactTitle != null)
			{
				sb.Append(ShipperContactTitle.ToString());
			}
			sb.Append("|");

			if (ShipperCountryCode != null)
			{
				sb.Append(ShipperCountryCode.ToString());
			}
			sb.Append("|");

			if (ShipperCountryName != null)
			{
				sb.Append(ShipperCountryName.ToString());
			}
			sb.Append("|");

			if (ShipperEmail != null)
			{
				sb.Append(ShipperEmail.ToString());
			}
			sb.Append("|");

			if (ShipperFax != null)
			{
				sb.Append(ShipperFax.ToString());
			}
			sb.Append("|");

			if (ShipperMobile != null)
			{
				sb.Append(ShipperMobile.ToString());
			}
			sb.Append("|");

			if (ShipperPhone != null)
			{
				sb.Append(ShipperPhone.ToString());
			}
			sb.Append("|");

			if (ShipperPostalCode != null)
			{
				sb.Append(ShipperPostalCode.ToString());
			}
			sb.Append("|");

			if (ShipperStateProvince != null)
			{
				sb.Append(ShipperStateProvince.ToString());
			}
			sb.Append("|");

			if (ShipperWebsite != null)
			{
				sb.Append(ShipperWebsite.ToString());
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

			if (ConsigneeCountry != null)
			{
				sb.Append(ConsigneeCountry.ToString());
			}
			sb.Append("|");

			if (LeadCountry != null)
			{
				sb.Append(LeadCountry.ToString());
			}
			sb.Append("|");

			if (LeadSalutation != null)
			{
				sb.Append(LeadSalutation.ToString());
			}
			sb.Append("|");

			if (LeadState != null)
			{
				sb.Append(LeadState.ToString());
			}
			sb.Append("|");

			if (LeadZipCode != null)
			{
				sb.Append(LeadZipCode.ToString());
			}
			sb.Append("|");

			if (OtherCountry != null)
			{
				sb.Append(OtherCountry.ToString());
			}
			sb.Append("|");

			if (ShipperCountry != null)
			{
				sb.Append(ShipperCountry.ToString());
			}
			sb.Append("|");

			if (Title != null)
			{
				sb.Append(Title.ToString());
			}
			sb.Append("|");

			return sb.ToString();
		}
	}
}