// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ffmobile.xaml {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class tblLeadsDetailPage : ContentPage {
        
        private Entry ID_column;
        
        private Entry SubscriberId_column;
        
        private Entry AnnualShipments_column;
        
        private Entry AnnualVolumes_column;
        
        private Entry AssignedDate_column;
        
        private Entry AssignedSalesRepCode_column;
        
        private Entry CampaignName_column;
        
        private Entry Comments_column;
        
        private Entry Commodities_column;
        
        private Entry Competitors_column;
        
        private Entry ConsigneeAddress_column;
        
        private Entry ConsigneeCity_column;
        
        private Entry ConsigneeCompany_column;
        
        private Entry ConsigneeContact_column;
        
        private Entry ConsigneeContactSalutation_column;
        
        private Entry ConsigneeContactTitle_column;
        
        private Entry ConsigneeCountryCode_column;
        
        private Entry ConsigneeCountryName_column;
        
        private Entry ConsigneeEmail_column;
        
        private Entry ConsigneeFax_column;
        
        private Entry ConsigneeMobile_column;
        
        private Entry ConsigneePhone_column;
        
        private Entry ConsigneePostalCode_column;
        
        private Entry ConsigneeStateProvince_column;
        
        private Entry ConsigneeWebsite_column;
        
        private Entry ConvertedDate_column;
        
        private Entry ConvertedById_column;
        
        private Entry ConvertedByName_column;
        
        private Entry CreatedById_column;
        
        private Entry CreatedDate_column;
        
        private Entry CreatedUserName_column;
        
        private Entry CustomerType_column;
        
        private Entry DateDeleted_column;
        
        private Entry DateLost_column;
        
        private Switch Deleted_column;
        
        private Entry DeletedById_column;
        
        private Entry Destinations_column;
        
        private Entry Direction_column;
        
        private Entry FileUploadId_column;
        
        private Entry FileUploadDate_column;
        
        private Entry FreightServices_column;
        
        private Entry Incoterms_column;
        
        private Entry IndustrySector_column;
        
        private Switch InterOffice_column;
        
        private Entry LastActivityDate_column;
        
        private Entry LastUpdate_column;
        
        private Entry LeadAddress_column;
        
        private Entry LeadCity_column;
        
        private Entry LeadContact_column;
        
        private Entry LeadContactSalutation_column;
        
        private Entry LeadContactTitle_column;
        
        private Entry LeadCountryCode_column;
        
        private Entry LeadCountryName_column;
        
        private Entry LeadDateReceived_column;
        
        private Entry LeadEmail_column;
        
        private Entry LeadFax_column;
        
        private Entry LeadMobile_column;
        
        private Entry LeadName_column;
        
        private Entry LeadNumber_column;
        
        private Entry LeadPhone_column;
        
        private Entry LeadPostalCode_column;
        
        private Entry LeadSource_column;
        
        private Entry LeadStateProvince_column;
        
        private Entry LeadStatusCode_column;
        
        private Entry LeadWebsite_column;
        
        private Entry NextActivityDate_column;
        
        private Entry OriginatingUser_column;
        
        private Entry OriginatingUserId_column;
        
        private Entry Origins_column;
        
        private Entry OriginSystem_column;
        
        private Entry OtherAddress_column;
        
        private Entry OtherCity_column;
        
        private Entry OtherCompany_column;
        
        private Entry OtherContact_column;
        
        private Entry OtherContactSalutation_column;
        
        private Entry OtherContactTitle_column;
        
        private Entry OtherCountryCode_column;
        
        private Entry OtherCountryName_column;
        
        private Entry OtherEmail_column;
        
        private Entry OtherFax_column;
        
        private Entry OtherMobile_column;
        
        private Entry OtherPhone_column;
        
        private Entry OtherPostalCode_column;
        
        private Entry OtherStateProvince_column;
        
        private Entry OtherWebsite_column;
        
        private Entry PrimaryContactId_column;
        
        private Entry ReasonLost_column;
        
        private Entry ReferralDate_column;
        
        private Entry ReferralDueDate_column;
        
        private Entry ReferralResponseDate_column;
        
        private Entry ReferralType_column;
        
        private Entry ReferredBySalesRepCode_column;
        
        private Entry ReferredByStationCode_column;
        
        private Entry ReferredByStationId_column;
        
        private Entry ReferredByStationName_column;
        
        private Entry ReferredByUserId_column;
        
        private Entry ReferredByUserName_column;
        
        private Entry ReferredToEmail_column;
        
        private Entry ReferredToSalesRepCode_column;
        
        private Entry ReferredToStationCode_column;
        
        private Entry ReferredToStationId_column;
        
        private Entry ReferredToStationName_column;
        
        private Entry ReferredToUserId_column;
        
        private Entry ReferredToUserName_column;
        
        private Entry SalesGroup_column;
        
        private Entry ShipperAddress_column;
        
        private Entry ShipperCity_column;
        
        private Entry ShipperCompany_column;
        
        private Entry ShipperContact_column;
        
        private Entry ShipperContactSalutation_column;
        
        private Entry ShipperContactTitle_column;
        
        private Entry ShipperCountryCode_column;
        
        private Entry ShipperCountryName_column;
        
        private Entry ShipperEmail_column;
        
        private Entry ShipperFax_column;
        
        private Entry ShipperMobile_column;
        
        private Entry ShipperPhone_column;
        
        private Entry ShipperPostalCode_column;
        
        private Entry ShipperStateProvince_column;
        
        private Entry ShipperWebsite_column;
        
        private Entry StationCode_column;
        
        private Entry StationName_column;
        
        private Entry UpdateUserId_column;
        
        private Entry UpdateUserName_column;
        
        private Entry ConsigneeCountry_column;
        
        private Entry LeadCountry_column;
        
        private Entry LeadSalutation_column;
        
        private Entry LeadState_column;
        
        private Entry LeadZipCode_column;
        
        private Entry OtherCountry_column;
        
        private Entry ShipperCountry_column;
        
        private Entry Title_column;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(tblLeadsDetailPage));
            ID_column = this.FindByName <Entry>("ID_column");
            SubscriberId_column = this.FindByName <Entry>("SubscriberId_column");
            AnnualShipments_column = this.FindByName <Entry>("AnnualShipments_column");
            AnnualVolumes_column = this.FindByName <Entry>("AnnualVolumes_column");
            AssignedDate_column = this.FindByName <Entry>("AssignedDate_column");
            AssignedSalesRepCode_column = this.FindByName <Entry>("AssignedSalesRepCode_column");
            CampaignName_column = this.FindByName <Entry>("CampaignName_column");
            Comments_column = this.FindByName <Entry>("Comments_column");
            Commodities_column = this.FindByName <Entry>("Commodities_column");
            Competitors_column = this.FindByName <Entry>("Competitors_column");
            ConsigneeAddress_column = this.FindByName <Entry>("ConsigneeAddress_column");
            ConsigneeCity_column = this.FindByName <Entry>("ConsigneeCity_column");
            ConsigneeCompany_column = this.FindByName <Entry>("ConsigneeCompany_column");
            ConsigneeContact_column = this.FindByName <Entry>("ConsigneeContact_column");
            ConsigneeContactSalutation_column = this.FindByName <Entry>("ConsigneeContactSalutation_column");
            ConsigneeContactTitle_column = this.FindByName <Entry>("ConsigneeContactTitle_column");
            ConsigneeCountryCode_column = this.FindByName <Entry>("ConsigneeCountryCode_column");
            ConsigneeCountryName_column = this.FindByName <Entry>("ConsigneeCountryName_column");
            ConsigneeEmail_column = this.FindByName <Entry>("ConsigneeEmail_column");
            ConsigneeFax_column = this.FindByName <Entry>("ConsigneeFax_column");
            ConsigneeMobile_column = this.FindByName <Entry>("ConsigneeMobile_column");
            ConsigneePhone_column = this.FindByName <Entry>("ConsigneePhone_column");
            ConsigneePostalCode_column = this.FindByName <Entry>("ConsigneePostalCode_column");
            ConsigneeStateProvince_column = this.FindByName <Entry>("ConsigneeStateProvince_column");
            ConsigneeWebsite_column = this.FindByName <Entry>("ConsigneeWebsite_column");
            ConvertedDate_column = this.FindByName <Entry>("ConvertedDate_column");
            ConvertedById_column = this.FindByName <Entry>("ConvertedById_column");
            ConvertedByName_column = this.FindByName <Entry>("ConvertedByName_column");
            CreatedById_column = this.FindByName <Entry>("CreatedById_column");
            CreatedDate_column = this.FindByName <Entry>("CreatedDate_column");
            CreatedUserName_column = this.FindByName <Entry>("CreatedUserName_column");
            CustomerType_column = this.FindByName <Entry>("CustomerType_column");
            DateDeleted_column = this.FindByName <Entry>("DateDeleted_column");
            DateLost_column = this.FindByName <Entry>("DateLost_column");
            Deleted_column = this.FindByName <Switch>("Deleted_column");
            DeletedById_column = this.FindByName <Entry>("DeletedById_column");
            Destinations_column = this.FindByName <Entry>("Destinations_column");
            Direction_column = this.FindByName <Entry>("Direction_column");
            FileUploadId_column = this.FindByName <Entry>("FileUploadId_column");
            FileUploadDate_column = this.FindByName <Entry>("FileUploadDate_column");
            FreightServices_column = this.FindByName <Entry>("FreightServices_column");
            Incoterms_column = this.FindByName <Entry>("Incoterms_column");
            IndustrySector_column = this.FindByName <Entry>("IndustrySector_column");
            InterOffice_column = this.FindByName <Switch>("InterOffice_column");
            LastActivityDate_column = this.FindByName <Entry>("LastActivityDate_column");
            LastUpdate_column = this.FindByName <Entry>("LastUpdate_column");
            LeadAddress_column = this.FindByName <Entry>("LeadAddress_column");
            LeadCity_column = this.FindByName <Entry>("LeadCity_column");
            LeadContact_column = this.FindByName <Entry>("LeadContact_column");
            LeadContactSalutation_column = this.FindByName <Entry>("LeadContactSalutation_column");
            LeadContactTitle_column = this.FindByName <Entry>("LeadContactTitle_column");
            LeadCountryCode_column = this.FindByName <Entry>("LeadCountryCode_column");
            LeadCountryName_column = this.FindByName <Entry>("LeadCountryName_column");
            LeadDateReceived_column = this.FindByName <Entry>("LeadDateReceived_column");
            LeadEmail_column = this.FindByName <Entry>("LeadEmail_column");
            LeadFax_column = this.FindByName <Entry>("LeadFax_column");
            LeadMobile_column = this.FindByName <Entry>("LeadMobile_column");
            LeadName_column = this.FindByName <Entry>("LeadName_column");
            LeadNumber_column = this.FindByName <Entry>("LeadNumber_column");
            LeadPhone_column = this.FindByName <Entry>("LeadPhone_column");
            LeadPostalCode_column = this.FindByName <Entry>("LeadPostalCode_column");
            LeadSource_column = this.FindByName <Entry>("LeadSource_column");
            LeadStateProvince_column = this.FindByName <Entry>("LeadStateProvince_column");
            LeadStatusCode_column = this.FindByName <Entry>("LeadStatusCode_column");
            LeadWebsite_column = this.FindByName <Entry>("LeadWebsite_column");
            NextActivityDate_column = this.FindByName <Entry>("NextActivityDate_column");
            OriginatingUser_column = this.FindByName <Entry>("OriginatingUser_column");
            OriginatingUserId_column = this.FindByName <Entry>("OriginatingUserId_column");
            Origins_column = this.FindByName <Entry>("Origins_column");
            OriginSystem_column = this.FindByName <Entry>("OriginSystem_column");
            OtherAddress_column = this.FindByName <Entry>("OtherAddress_column");
            OtherCity_column = this.FindByName <Entry>("OtherCity_column");
            OtherCompany_column = this.FindByName <Entry>("OtherCompany_column");
            OtherContact_column = this.FindByName <Entry>("OtherContact_column");
            OtherContactSalutation_column = this.FindByName <Entry>("OtherContactSalutation_column");
            OtherContactTitle_column = this.FindByName <Entry>("OtherContactTitle_column");
            OtherCountryCode_column = this.FindByName <Entry>("OtherCountryCode_column");
            OtherCountryName_column = this.FindByName <Entry>("OtherCountryName_column");
            OtherEmail_column = this.FindByName <Entry>("OtherEmail_column");
            OtherFax_column = this.FindByName <Entry>("OtherFax_column");
            OtherMobile_column = this.FindByName <Entry>("OtherMobile_column");
            OtherPhone_column = this.FindByName <Entry>("OtherPhone_column");
            OtherPostalCode_column = this.FindByName <Entry>("OtherPostalCode_column");
            OtherStateProvince_column = this.FindByName <Entry>("OtherStateProvince_column");
            OtherWebsite_column = this.FindByName <Entry>("OtherWebsite_column");
            PrimaryContactId_column = this.FindByName <Entry>("PrimaryContactId_column");
            ReasonLost_column = this.FindByName <Entry>("ReasonLost_column");
            ReferralDate_column = this.FindByName <Entry>("ReferralDate_column");
            ReferralDueDate_column = this.FindByName <Entry>("ReferralDueDate_column");
            ReferralResponseDate_column = this.FindByName <Entry>("ReferralResponseDate_column");
            ReferralType_column = this.FindByName <Entry>("ReferralType_column");
            ReferredBySalesRepCode_column = this.FindByName <Entry>("ReferredBySalesRepCode_column");
            ReferredByStationCode_column = this.FindByName <Entry>("ReferredByStationCode_column");
            ReferredByStationId_column = this.FindByName <Entry>("ReferredByStationId_column");
            ReferredByStationName_column = this.FindByName <Entry>("ReferredByStationName_column");
            ReferredByUserId_column = this.FindByName <Entry>("ReferredByUserId_column");
            ReferredByUserName_column = this.FindByName <Entry>("ReferredByUserName_column");
            ReferredToEmail_column = this.FindByName <Entry>("ReferredToEmail_column");
            ReferredToSalesRepCode_column = this.FindByName <Entry>("ReferredToSalesRepCode_column");
            ReferredToStationCode_column = this.FindByName <Entry>("ReferredToStationCode_column");
            ReferredToStationId_column = this.FindByName <Entry>("ReferredToStationId_column");
            ReferredToStationName_column = this.FindByName <Entry>("ReferredToStationName_column");
            ReferredToUserId_column = this.FindByName <Entry>("ReferredToUserId_column");
            ReferredToUserName_column = this.FindByName <Entry>("ReferredToUserName_column");
            SalesGroup_column = this.FindByName <Entry>("SalesGroup_column");
            ShipperAddress_column = this.FindByName <Entry>("ShipperAddress_column");
            ShipperCity_column = this.FindByName <Entry>("ShipperCity_column");
            ShipperCompany_column = this.FindByName <Entry>("ShipperCompany_column");
            ShipperContact_column = this.FindByName <Entry>("ShipperContact_column");
            ShipperContactSalutation_column = this.FindByName <Entry>("ShipperContactSalutation_column");
            ShipperContactTitle_column = this.FindByName <Entry>("ShipperContactTitle_column");
            ShipperCountryCode_column = this.FindByName <Entry>("ShipperCountryCode_column");
            ShipperCountryName_column = this.FindByName <Entry>("ShipperCountryName_column");
            ShipperEmail_column = this.FindByName <Entry>("ShipperEmail_column");
            ShipperFax_column = this.FindByName <Entry>("ShipperFax_column");
            ShipperMobile_column = this.FindByName <Entry>("ShipperMobile_column");
            ShipperPhone_column = this.FindByName <Entry>("ShipperPhone_column");
            ShipperPostalCode_column = this.FindByName <Entry>("ShipperPostalCode_column");
            ShipperStateProvince_column = this.FindByName <Entry>("ShipperStateProvince_column");
            ShipperWebsite_column = this.FindByName <Entry>("ShipperWebsite_column");
            StationCode_column = this.FindByName <Entry>("StationCode_column");
            StationName_column = this.FindByName <Entry>("StationName_column");
            UpdateUserId_column = this.FindByName <Entry>("UpdateUserId_column");
            UpdateUserName_column = this.FindByName <Entry>("UpdateUserName_column");
            ConsigneeCountry_column = this.FindByName <Entry>("ConsigneeCountry_column");
            LeadCountry_column = this.FindByName <Entry>("LeadCountry_column");
            LeadSalutation_column = this.FindByName <Entry>("LeadSalutation_column");
            LeadState_column = this.FindByName <Entry>("LeadState_column");
            LeadZipCode_column = this.FindByName <Entry>("LeadZipCode_column");
            OtherCountry_column = this.FindByName <Entry>("OtherCountry_column");
            ShipperCountry_column = this.FindByName <Entry>("ShipperCountry_column");
            Title_column = this.FindByName <Entry>("Title_column");
        }
    }
}
