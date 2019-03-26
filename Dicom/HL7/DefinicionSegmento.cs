﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicom.HL7
{
    class DefinicionSegmento
    {
        public static readonly Hashtable MSH = new Hashtable
        {
            { 0, "MSH" },
            { 1, "Field Separator" },
            { 2, "Encoding Characters"},
            { 3, "Sending Application"},
            { 4, "Sending Facility"},
            { 5, "Receiving Application"},
            { 6, "Receiving Facility"},
            { 7, "Date / Time of Message"},
            { 8, "Security"},
            { 9, "Message Type"},
            { 10, "Message Control ID"},
            { 11, "Processing ID"},
            { 12, "Version ID"},
            { 13, "Sequence Number" },
            { 14, "Continuation Pointer"},
            { 15, "Accept Acknowledgement Type"},
            { 16, "Application Acknowledgement Type"},
            { 17, "Country Code"},
            { 18, "Character Set" },
            { 19, "Principal Language of Message" },
            { 20, "Alternate Character Set Handling Scheme" },
            { 21, "Conformance Statement ID" }
        };
        
        public static readonly Hashtable EVN = new Hashtable
        {
            { 0, "EVN" },
            { 1, "Event Type Code" },
            { 2, "Recorded Date/Time" },
            { 3, "Date/Time Planned Event" },
            { 4, "Event Reason Code" },
            { 5, "Operator ID" },
            { 6, "Event Occurred" },
            { 7, "Event Facility" }
        };
        
        public static readonly Hashtable PID = new Hashtable
        {
            { 0, "PID" },
            { 1, "Set ID - PID"},
            { 2, "Patient ID"},
            { 3, "Patient Identifier List"},
            { 4, "Alternate Patient ID - PID"},
            { 5, "Patient Name"},
            { 6, "Mother's Maiden Name"},
            { 7, "Date/Time Of Birth"},
            { 8, "Administrative Sex"},
            { 9, "Patient Alias"},
            { 10, "Race"},
            { 11, "Patient Address"},
            { 12, "County Code"},
            { 13, "Phone Number - Home"},
            { 14, "Phone Number - Business"},
            { 15, "Primary Language"},
            { 16, "Marital Status"},
            { 17, "Religion"},
            { 18, "Patient Account Number"},
            { 19, "SSN Number - Patient"},
            { 20, "Driver's License Number - Patient"},
            { 21, "Mother's Identifier"},
            { 22, "Ethnic Group"},
            { 23, "Birth Place"},
            { 24, "Multiple Birth Indicator"},
            { 25, "Birth Order"},
            { 26, "Citizenship"},
            { 27, "Veterans Military Status"},
            { 28, "Nationality"},
            { 29, "Patient Death Date and Time"},
            { 30, "Patient Death Indicator"},
            { 31, "Identity Unknown Indicator"},
            { 32, "Identity Reliability Code"},
            { 33, "Last Update Date/Time"},
            { 34, "Last Update Facility"},
            { 35, "Species Code"},
            { 36, "Breed Code"},
            { 37, "Strain"},
            { 38, "Production Class Code"},
        };
        
        public static readonly Hashtable PV1 = new Hashtable
        {
            { 0, "PV1" },
            { 1, "SET ID - PV1"},
            { 2, "Patient Class"},
            { 3, "Assigned Patient Location"},
            { 4, "Admission Type"},
            { 5, "Preadmit Number"},
            { 6, "Prior Patient Location"},
            { 7, "Attending Doctor"},
            { 8, "Referring Doctor"},
            { 9, "Consulting Doctor"},
            { 10, "Hospital Service"},
            { 11, "Temporary Location"},
            { 12, "Preadmit Test Indicator"},
            { 13, "Re-admission Indicator"},
            { 14, "Admit Source"},
            { 15, "Ambulatory Status"},
            { 16, "VIP Indicator"},
            { 17, "Admitting Doctor"},
            { 18, "Patient Type"},
            { 19, "Visit Number"},
            { 20, "Financial Class"},
            { 21, "Charge Price Indicator"},
            { 22, "Courtesy Code"},
            { 23, "Credit Rating"},
            { 24, "Contract Code"},
            { 25, "Contract Effective Date"},
            { 26, "Contract Amount"},
            { 27, "Contract Period"},
            { 28, "Interest Code"},
            { 29, "Transfer to Bad Debt Code"},
            { 30, "Transfer to Bad Debt Date"},
            { 31, "Bad Debt Agency Code"},
            { 32, "Bad Debt Transfer Amount"},
            { 33, "Bad Debt Recovery Amount"},
            { 34, "Delete Account Indicator"},
            { 35, "Delete Account Date"},
            { 36, "Discharge Disposition"},
            { 37, "Discharged to Location"},
            { 38, "Diet Type"},
            { 39, "Servicing Facility"},
            { 40, "Bed Status"},
            { 41, "Account Status"},
            { 42, "Pending Location"},
            { 43, "Prior Temporary Location"},
            { 44, "Admit Date/Time"},
            { 45, "Discharge Date/Time"},
            { 46, "Current Patient Balance"},
            { 47, "Total Charges"},
            { 48, "Total Adjustments"},
            { 49, "Total Payments"},
            { 50, "Alternate Visit ID"},
            { 51, "Visit Indicator"},
            { 52, "Other Healthcare Provider"},
        };
        
        public static readonly Hashtable IN1 = new Hashtable
        {
            { 0, "IN1" },
            { 1, "Set ID – Patient ID"},
            { 2, "Insurance Plan ID"},
            { 3, "Insurance Company ID"},
            { 4, "Insurance Company Name"},
            { 5, "Insurance Company Address"},
            { 6, "Insurance Co Contact Person"},
            { 7, "Insurance Co Phone Number"},
            { 8, "Group Number"},
            { 9, "Group Name"},
            { 10, "Insured’s Group Emp ID"},
            { 11, "Insured’s Group Emp Name"},
            { 12, "Plan Effective Date"},
            { 13, "Plan Expiration Date"},
            { 14, "Authorization Information"},
            { 15, "Plan Type"},
            { 16, "Name Of Insured"},
            { 17, "Insured’s Relationship To Patient"},
            { 18, "Insured’s Date Of Birth"},
            { 19, "Insured’s Address"},
            { 20, "Assignment Of Benefits"},
            { 21, "Coordination Of Benefits"},
            { 22, "Coord Of Ben. Priority"},
            { 23, "Notice Of Admission Flag"},
            { 24, "Notice Of Admission Date"},
            { 25, "Report Of Eligibility Flag"},
            { 26, "Report Of Eligibility Date"},
            { 27, "Release Information Code"},
            { 28, "Pre-Admit Cert (PAC)"},
            { 29, "Verification Date/Time"},
            { 30, "Verification By"},
            { 31, "Type Of Agreement Code"},
            { 32, "Billing Status"},
            { 33, "Lifetime Reserve Days"},
            { 34, "Delay Before L.R. Day"},
            { 35, "Company Plan Code"},
            { 36, "Policy Number"},
            { 37, "Policy Deductible"},
            { 38, "Policy Limit &#8211; Amount"},
            { 39, "Policy Limit &#8211; Days"},
            { 40, "Room Rate &#8211; Semi-Private"},
            { 41, "Room Rate &#8211; Private"},
            { 42, "Insured’s Employment Status"},
            { 43, "Insured’s Sex"},
            { 44, "Insured’s Employer’s Address"},
            { 45, "Verification Status"},
            { 46, "Prior Insurance Plan ID"},
            { 47, "Coverage Type"},
            { 48, "Handicap"},
            { 49, "Insured’s ID Number"},
        };
        
        public static readonly Hashtable IN2 = new Hashtable
        {
            { 0, "IN2" },
            { 1, "Insured's Employee Id"},
            { 2, "Insured's Social Security Number"},
            { 3, "Insured's Employer's Name And Id"},
            { 4, "Employer Information Data"},
            { 5, "Mail Claim Party"},
            { 6, "Medicare Health Ins Card Number"},
            { 7, "Medicaid Case Name"},
            { 8, "Medicaid Case Number"},
            { 9, "Military Sponsor Name"},
            { 10, "Military Id Number"},
            { 11, "Dependent Of Military Recipient"},
            { 12, "Military Organization"},
            { 13, "Military Station"},
            { 14, "Military Service"},
            { 15, "Military Rank/Grade"},
            { 16, "Military Status"},
            { 17, "Military Retire Date"},
            { 18, "Military Non-avail Cert On File"},
            { 19, "Baby Coverage"},
            { 20, "Combine Baby Bill"},
            { 21, "Blood Deductible"},
            { 22, "Special Coverage Approval Name"},
            { 23, "Special Coverage Approval Title"},
            { 24, "Non-covered Insurance Code"},
            { 25, "Payor Id"},
            { 26, "Payor Subscriber Id"},
            { 27, "Eligibility Source"},
            { 28, "Room Coverage Type/Amount"},
            { 29, "Policy Type/Amount"},
            { 30, "Daily Deductible"},
            { 31, "Living Dependency"},
            { 32, "Ambulatory Status"},
            { 33, "Citizenship"},
            { 34, "Primary Language"},
            { 35, "Living Arrangement"},
            { 36, "Publicity Code"},
            { 37, "Protection Indicator"},
            { 38, "Student Indicator"},
            { 39, "Religion"},
            { 40, "Mother's Maiden Name"},
            { 41, "Nationality"},
            { 42, "Ethnic Group"},
            { 43, "Marital Status"},
            { 44, "Insured's Employment Start Date"},
            { 45, "Employment Stop Date"},
            { 46, "Job Title"},
            { 47, "Job Code/Class"},
            { 48, "Job Status"},
            { 49, "Employer Contact Person Name"},
            { 50, "Employer Contact Person Phone Number"},
            { 51, "Employer Contact Reason"},
            { 52, "Insured's Contact Person's Name"},
            { 53, "Insured's Contact Person Phone Number"},
            { 54, "Insured's Contact Person Reason"},
            { 55, "Relationship To The Patient Start Date"},
            { 56, "Relationship To The Patient Stop Date"},
            { 57, "Insurance Co Contact Reason"},
            { 58, "Insurance Co Contact Phone Number"},
            { 59, "Policy Scope"},
            { 60, "Policy Source"},
            { 61, "Patient Member Number"},
            { 62, "Guarantor's Relationship To Insured"},
            { 63, "Insured's Phone Number - Home"},
            { 64, "Insured's Employer Phone Number"},
            { 65, "Military Handicapped Program"},
            { 66, "Suspend Flag"},
            { 67, "Copay Limit Flag"},
            { 68, "Stoploss Limit Flag"},
            { 69, "Insured Organization Name And Id"},
            { 70, "Insured Employer Organization Name And Id"},
            { 71, "Race"},
            { 72, "Patient's Relationship To Insured"},
        };
        
        private static readonly Hashtable ORC = new Hashtable
        {
            { 0, "ORC" },
            { 1, "Order Control"},
            { 2, "Placer Order Number"},
            { 3, "Filler Order Number"},
            { 4, "Placer Group Number"},
            { 5, "Order Status"},
            { 6, "Response Flag"},
            { 7, "Quantity/Timing"},
            { 8, "Parent Order"},
            { 9, "Date/Time of Transaction"},
            { 10, "Entered By"},
            { 11, "Verified By"},
            { 12, "Ordering Provider"},
            { 13, "Enterer's Location"},
            { 14, "Call Back Phone Number"},
            { 15, "Order Effective Date/Time"},
            { 16, "Order Control Code Reason"},
            { 17, "Entering Organization"},
            { 18, "Entering Device"},
            { 19, "Action By"},
            { 20, "Advanced Beneficiary Notice Code"},
            { 21, "Ordering Facility Name"},
            { 22, "Ordering Facility Address"},
            { 23, "Ordering Facility Phone Number"},
            { 24, "Ordering Provider Address"},
            { 25, "Order Status Modifier"}
        };
        
        public static readonly Hashtable OBR = new Hashtable
        {
            { 0, "OBR" },
            { 1, "Set ID - OBR"},
            { 2, "Placer Order Number"},
            { 3, "Filler Order Number"},
            { 4, "Universal Service Identifier"},
            { 5, "Priority"},
            { 6, "Requested Date/Time"},
            { 7, "Observation Date/Time"},
            { 8, "Observation End Date/Time"},
            { 9, "Collection Volume *"},
            { 10, "Collector Identifier *"},
            { 11, "Specimen Action Code *"},
            { 12, "Danger Code"},
            { 13, "Relevant Clinical Info."},
            { 14, "Specimen Received Date/Time *"},
            { 15, "Specimen Source"},
            { 16, "Ordering Provider"},
            { 17, "Order Callback Phone Number"},
            { 18, "Placer Field 1"},
            { 19, "Placer Field 2"},
            { 20, "Filler Field 1 +"},
            { 21, "Filler Field 2 +"},
            { 22, "Results Rpt/Status Chng - Date/Time +"},
            { 23, "Charge to Practice +"},
            { 24, "Diagnostic Serv Sect ID"},
            { 25, "Result Status +"},
            { 26, "Parent Result +"},
            { 27, "Quantity/Timing"},
            { 28, "Result Copies To"},
            { 29, "Parent Number"},
            { 30, "Transportation Mode"},
            { 31, "Reason for Study"},
            { 32, "Principal Result Interpreter +"},
            { 33, "Assistant Result Interpreter +"},
            { 34, "Technician +"},
            { 35, "Transcriptionist +"},
            { 36, "Scheduled Date/Time +"},
            { 37, "Number of Sample Containers *"},
            { 38, "Transport Logistics of Collected Sample *"},
            { 39, "Collector's Comment *"},
            { 40, "Transport Arrangement Responsibility"},
            { 41, "Transport Arranged"},
            { 42, "Escort Required"},
            { 43, "Planned Patient Transport Comment"},
            { 44, "Procedure Code"},
            { 45, "Procedure Code Modifier"},
            { 46, "Placer Supplemental Service Information"},
            { 47, "Filler Supplemental Service Information"},
        };
        
        public static readonly Hashtable OBX = new Hashtable
        {
            { 0, "OBX" },
            { 1, "Set ID – Obx"},
            { 2, "Value Type"},
            { 3, "Observation Identifier"},
            { 4, "Observation Sub-Id"},
            { 5, "Observation Value"},
            { 6, "Units"},
            { 7, "Reference Range"},
            { 8, "Abnormal Flags"},
            { 9, "Probability"},
            { 10, "Nature of Abnormal Test"},
            { 11, "Observ Result Status"},
            { 12, "Data Last Obs Normal Values"},
            { 13, "User Defined Access Checks"},
            { 14, "Date/Time of the Observation"},
            { 15, "Producer’s Id"},
            { 16, "Responsible Observer"},
            { 17, "Observation Method"},
            { 18, "Equipment Instance Identifier"},
            { 19, "Date/Time of the Analysis"},
        };
        
        public static readonly Hashtable NTE = new Hashtable
        {
            { 0, "NTE" },
            { 1, "Set ID - NTE"},
            { 2, "Source of Comment"},
            { 3, "Comment"},
            { 4, "Comment Type"},
        };

        public static readonly Hashtable PV2 = new Hashtable
        {
            { 0, "PV2" },
            { 1, "Prior Pending Location"},
            { 2, "Accommodation Code"},
            { 3, "Admit Reason"},
            { 4, "Transfer Reason"},
            { 5, "Patient Valuables"},
            { 6, "Patient Valuables Location"},
            { 7, "Visit User Code"},
            { 8, "Expected Admit Date/Time"},
            { 9, "Expected Discharge Date/Time"},
            { 10, "Estimated Length of Inpatient Stay"},
            { 11, "Actual Length of Inpatient Stay"},
            { 12, "Visit Description"},
            { 13, "Referral Source Code"},
            { 14, "Previous Service Date"},
            { 15, "Employment Illness Related Indicator"},
            { 16, "Purge Status Code"},
            { 17, "Purge Status Date"},
            { 18, "Special Program Code"},
            { 19, "Retention Indicator"},
            { 20, "Expected Number of Insurance Plans"},
            { 21, "Visit Publicity Code"},
            { 22, "Visit Protection Indicator"},
            { 23, "Clinic Organization Name"},
            { 24, "Patient Status Code"},
            { 25, "Visit Priority Code"},
            { 26, "Previous Treatment Date"},
            { 27, "Expected Discharge Disposition"},
            { 28, "Signature on File Date"},
            { 29, "First Similar Illness Date"},
            { 30, "Patient Charge Adjustment Code"},
            { 31, "Recurring Service Code"},
            { 32, "Billing Media Code"},
            { 33, "Expected Surgery Date and Time"},
            { 34, "Military Partnership Code"},
            { 35, "Military Non-Availability Code"},
            { 36, "Newborn Baby Indicator"},
            { 37, "Baby Detained Indicator"},
            { 38, "Mode of Arrival Code"},
            { 39, "Recreational Drug Use Code"},
            { 40, "Admission Level of Care Code"},
            { 41, "Precaution Code"},
            { 42, "Patient Condition Code"},
            { 43, "Living Will Code"},
            { 44, "Organ Donor Code"},
            { 45, "Advance Directive Code"},
            { 46, "Patient Status Effective Date"},
            { 47, "Expected LOA Return Date/Time"}
        };

        public static readonly List<Hashtable> listaSegmentos = new List<Hashtable>
        {
            MSH,
            EVN,
            PID,
            PV1,
            PV2,
            IN1,
            IN2,
            ORC,
            OBR,
            OBX,
            NTE
        };

    }
}
