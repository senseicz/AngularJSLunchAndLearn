using System.Collections.Generic;

namespace Backend
{
    public class LookupData
    {
        public static List<AddressType> GetAddressTypes()
        {
            return new List<AddressType>
            {
                new AddressType {AddressTypeId = 1, AddressTypeName = "Home"},
                new AddressType {AddressTypeId = 2, AddressTypeName = "Temporary"}

            };
        }

        public static List<PhoneNumberType> GetPhoneNumberTypes()
        {
            return new List<PhoneNumberType>
            {
                new PhoneNumberType {PhoneNumberTypeId = 1, PhoneNumberTypeName = "Mobile"},
                new PhoneNumberType {PhoneNumberTypeId = 2, PhoneNumberTypeName = "Home"},
                new PhoneNumberType {PhoneNumberTypeId = 3, PhoneNumberTypeName = "Work"},
                new PhoneNumberType {PhoneNumberTypeId = 4, PhoneNumberTypeName = "Voip"},
            };
        }

        public static List<ImHandleType> GetImHandleTypes()
        {
            return new List<ImHandleType>
            {
                new ImHandleType {ImHandleTypeId = 1, ImHandleName = "Twitter"},
                new ImHandleType {ImHandleTypeId = 2, ImHandleName = "Yahoo"},
                new ImHandleType {ImHandleTypeId = 3, ImHandleName = "Skype"},
                new ImHandleType {ImHandleTypeId = 4, ImHandleName = "MSN"},
            };
        }

        public static List<State> GetStates()
        {
            return new List<State>
            {
                new State {StateId = 1, StateAbbrev = "MA", StateName = "Massetchusets"},
                new State {StateId = 2, StateAbbrev = "NY", StateName = "New York"},
                new State {StateId = 3, StateAbbrev = "CA", StateName = "California"},
            };
        }

        public static List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country {CountryId = 1, CountryName = "Afghanistan"},
                new Country {CountryId = 2, CountryName = "Albania"},
                new Country {CountryId = 3, CountryName = "Algeria"},
                new Country {CountryId = 243, CountryName = "American Samoa"},
                new Country {CountryId = 4, CountryName = "Andorra"},
                new Country {CountryId = 5, CountryName = "Angola"},
                new Country {CountryId = 176, CountryName = "Anguilla"},
                new Country {CountryId = 177, CountryName = "Antarctica"},
                new Country {CountryId = 175, CountryName = "Antigua and Barbuda"},
                new Country {CountryId = 6, CountryName = "Argentina"},
                new Country {CountryId = 7, CountryName = "Armenia"},
                new Country {CountryId = 179, CountryName = "Aruba"},
                new Country {CountryId = 8, CountryName = "Australia"},
                new Country {CountryId = 9, CountryName = "Austria"},
                new Country {CountryId = 10, CountryName = "Azerbaidjan"},
                new Country {CountryId = 11, CountryName = "Bahamas"},
                new Country {CountryId = 12, CountryName = "Bahrain"},
                new Country {CountryId = 13, CountryName = "Bangladesh"},
                new Country {CountryId = 14, CountryName = "Barbados"},
                new Country {CountryId = 15, CountryName = "Belarus"},
                new Country {CountryId = 16, CountryName = "Belgium"},
                new Country {CountryId = 17, CountryName = "Belize"},
                new Country {CountryId = 18, CountryName = "Benin"},
                new Country {CountryId = 19, CountryName = "Bermuda"},
                new Country {CountryId = 20, CountryName = "Bhutan"},
                new Country {CountryId = 21, CountryName = "Bolivia"},
                new Country {CountryId = 22, CountryName = "Bosnia-Herzegovina"},
                new Country {CountryId = 23, CountryName = "Botswana"},
                new Country {CountryId = 181, CountryName = "Bouvet Island"},
                new Country {CountryId = 24, CountryName = "Brazil"},
                new Country {CountryId = 201, CountryName = "British Indian Ocean Territory"},
                new Country {CountryId = 180, CountryName = "Brunei Darussalam"},
                new Country {CountryId = 25, CountryName = "Bulgaria"},
                new Country {CountryId = 26, CountryName = "Burkina Faso"},
                new Country {CountryId = 27, CountryName = "Burundi"},
                new Country {CountryId = 28, CountryName = "Cambodia"},
                new Country {CountryId = 29, CountryName = "Cameroon"},
                new Country {CountryId = 30, CountryName = "Canada"},
                new Country {CountryId = 31, CountryName = "Cape Verde"},
                new Country {CountryId = 32, CountryName = "Cayman Islands"},
                new Country {CountryId = 33, CountryName = "Central African Republic"},
                new Country {CountryId = 34, CountryName = "Chad"},
                new Country {CountryId = 35, CountryName = "Chile"},
                new Country {CountryId = 36, CountryName = "China"},
                new Country {CountryId = 185, CountryName = "Christmas Island"},
                new Country {CountryId = 182, CountryName = "Cocos {Keeling} Islands"},
                new Country {CountryId = 37, CountryName = "Colombia"},
                new Country {CountryId = 204, CountryName = "Comoros"},
                new Country {CountryId = 38, CountryName = "Congo"},
                new Country {CountryId = 183, CountryName = "Cook Islands"},
                new Country {CountryId = 39, CountryName = "Costa Rica"},
                new Country {CountryId = 40, CountryName = "Croatia"},
                new Country {CountryId = 184, CountryName = "Cuba"},
                new Country {CountryId = 41, CountryName = "Cyprus"},
                new Country {CountryId = 42, CountryName = "Czech Republic"},
                new Country {CountryId = 172, CountryName = "Democratic Republic of Congo"},
                new Country {CountryId = 43, CountryName = "Denmark"},
                new Country {CountryId = 44, CountryName = "Djibouti"},
                new Country {CountryId = 186, CountryName = "Dominica"},
                new Country {CountryId = 187, CountryName = "Dominican Republic"},
                new Country {CountryId = 233, CountryName = "East Timor"},
                new Country {CountryId = 251, CountryName = "East Timor"},
                new Country {CountryId = 45, CountryName = "Ecuador"},
                new Country {CountryId = 46, CountryName = "Egypt"},
                new Country {CountryId = 47, CountryName = "El Salvador"},
                new Country {CountryId = 48, CountryName = "Equatorial Guinea"},
                new Country {CountryId = 49, CountryName = "Eritrea"},
                new Country {CountryId = 50, CountryName = "Estonia"},
                new Country {CountryId = 51, CountryName = "Ethiopia"},
                new Country {CountryId = 189, CountryName = "Falkland Islands"},
                new Country {CountryId = 191, CountryName = "Faroe Islands"},
                new Country {CountryId = 52, CountryName = "Fiji"},
                new Country {CountryId = 53, CountryName = "Finland"},
                new Country {CountryId = 228, CountryName = "Former USSR"},
                new Country {CountryId = 54, CountryName = "France"},
                new Country {CountryId = 55, CountryName = "France {European Territory}"},
                new Country {CountryId = 193, CountryName = "French Guyana"},
                new Country {CountryId = 230, CountryName = "French Southern Territories"},
                new Country {CountryId = 56, CountryName = "Gabon"},
                new Country {CountryId = 57, CountryName = "Gambia"},
                new Country {CountryId = 58, CountryName = "Georgia"},
                new Country {CountryId = 59, CountryName = "Germany"},
                new Country {CountryId = 60, CountryName = "Ghana"},
                new Country {CountryId = 194, CountryName = "Gibraltar"},
                new Country {CountryId = 61, CountryName = "Greece"},
                new Country {CountryId = 195, CountryName = "Greenland"},
                new Country {CountryId = 192, CountryName = "Grenada"},
                new Country {CountryId = 196, CountryName = "Guadeloupe {French}"},
                new Country {CountryId = 245, CountryName = "Guam"},
                new Country {CountryId = 198, CountryName = "Guatemala"},
                new Country {CountryId = 63, CountryName = "Guinea"},
                new Country {CountryId = 64, CountryName = "Guinea Bissau"},
                new Country {CountryId = 65, CountryName = "Guyana"},
                new Country {CountryId = 200, CountryName = "Haiti"},
                new Country {CountryId = 199, CountryName = "Heard and McDonald Islands"},
                new Country {CountryId = 66, CountryName = "Honduras"},
                new Country {CountryId = 67, CountryName = "Hong Kong"},
                new Country {CountryId = 68, CountryName = "Hungary"},
                new Country {CountryId = 69, CountryName = "Iceland"},
                new Country {CountryId = 70, CountryName = "India"},
                new Country {CountryId = 71, CountryName = "Indonesia"},
                new Country {CountryId = 72, CountryName = "Iran"},
                new Country {CountryId = 73, CountryName = "Iraq"},
                new Country {CountryId = 74, CountryName = "Ireland"},
                new Country {CountryId = 75, CountryName = "Israel"},
                new Country {CountryId = 76, CountryName = "Italy"},
                new Country {CountryId = 77, CountryName = "Ivory Coast"},
                new Country {CountryId = 202, CountryName = "Jamaica"},
                new Country {CountryId = 78, CountryName = "Japan"},
                new Country {CountryId = 79, CountryName = "Jordan"},
                new Country {CountryId = 80, CountryName = "Kazakhstan"},
                new Country {CountryId = 81, CountryName = "Kenya"},
                new Country {CountryId = 203, CountryName = "Kiribati"},
                new Country {CountryId = 82, CountryName = "Kuwait"},
                new Country {CountryId = 83, CountryName = "Kyrgyzstan"},
                new Country {CountryId = 84, CountryName = "Laos"},
                new Country {CountryId = 85, CountryName = "Latvia"},
                new Country {CountryId = 86, CountryName = "Lebanon"},
                new Country {CountryId = 87, CountryName = "Lesotho"},
                new Country {CountryId = 88, CountryName = "Liberia"},
                new Country {CountryId = 89, CountryName = "Libya"},
                new Country {CountryId = 90, CountryName = "Liechtenstein"},
                new Country {CountryId = 91, CountryName = "Lithuania"},
                new Country {CountryId = 92, CountryName = "Luxembourg"},
                new Country {CountryId = 208, CountryName = "Macau"},
                new Country {CountryId = 93, CountryName = "Macedonia"},
                new Country {CountryId = 94, CountryName = "Madagascar"},
                new Country {CountryId = 95, CountryName = "Malawi"},
                new Country {CountryId = 96, CountryName = "Malaysia"},
                new Country {CountryId = 97, CountryName = "Maldives"},
                new Country {CountryId = 98, CountryName = "Mali"},
                new Country {CountryId = 99, CountryName = "Malta"},
                new Country {CountryId = 207, CountryName = "Marshall Islands"},
                new Country {CountryId = 210, CountryName = "Martinique {French}"},
                new Country {CountryId = 100, CountryName = "Mauritania"},
                new Country {CountryId = 212, CountryName = "Mauritius"},
                new Country {CountryId = 241, CountryName = "Mayotte"},
                new Country {CountryId = 101, CountryName = "Mexico"},
                new Country {CountryId = 190, CountryName = "Micronesia"},
                new Country {CountryId = 102, CountryName = "Moldavia"},
                new Country {CountryId = 103, CountryName = "Monaco"},
                new Country {CountryId = 104, CountryName = "Mongolia"},
                new Country {CountryId = 246, CountryName = "Montenegro"},
                new Country {CountryId = 211, CountryName = "Montserrat"},
                new Country {CountryId = 105, CountryName = "Morocco"},
                new Country {CountryId = 106, CountryName = "Mozambique"},
                new Country {CountryId = 242, CountryName = "Myanmar, Union of {Burma}"},
                new Country {CountryId = 107, CountryName = "Namibia"},
                new Country {CountryId = 215, CountryName = "Nauru"},
                new Country {CountryId = 108, CountryName = "Nepal"},
                new Country {CountryId = 109, CountryName = "Netherlands"},
                new Country {CountryId = 110, CountryName = "Netherlands Antilles"},
                new Country {CountryId = 216, CountryName = "Neutral Zone"},
                new Country {CountryId = 213, CountryName = "New Caledonia {French}"},
                new Country {CountryId = 111, CountryName = "New Zealand"},
                new Country {CountryId = 112, CountryName = "Nicaragua"},
                new Country {CountryId = 113, CountryName = "Niger"},
                new Country {CountryId = 114, CountryName = "Nigeria"},
                new Country {CountryId = 217, CountryName = "Niue"},
                new Country {CountryId = 214, CountryName = "Norfolk Island"},
                new Country {CountryId = 115, CountryName = "North Korea"},
                new Country {CountryId = 209, CountryName = "Northern Mariana Islands"},
                new Country {CountryId = 116, CountryName = "Norway"},
                new Country {CountryId = 117, CountryName = "Oman"},
                new Country {CountryId = 118, CountryName = "Pakistan"},
                new Country {CountryId = 222, CountryName = "Palau"},
                new Country {CountryId = 249, CountryName = "Palestinian Territory, Occupied"},
                new Country {CountryId = 119, CountryName = "Panama"},
                new Country {CountryId = 219, CountryName = "Papua New Guinea"},
                new Country {CountryId = 120, CountryName = "Paraguay"},
                new Country {CountryId = 121, CountryName = "Peru"},
                new Country {CountryId = 122, CountryName = "Philippines"},
                new Country {CountryId = 221, CountryName = "Pitcairn Island"},
                new Country {CountryId = 123, CountryName = "Poland"},
                new Country {CountryId = 218, CountryName = "Polynesia {French}"},
                new Country {CountryId = 124, CountryName = "Portugal"},
                new Country {CountryId = 248, CountryName = "Puerto Rico"},
                new Country {CountryId = 126, CountryName = "Qatar"},
                new Country {CountryId = 127, CountryName = "Reunion {French}"},
                new Country {CountryId = 128, CountryName = "Romania"},
                new Country {CountryId = 129, CountryName = "Russian Federation"},
                new Country {CountryId = 130, CountryName = "Rwanda"},
                new Country {CountryId = 197, CountryName = "S. Georgia & S. Sandwich Islands"},
                new Country {CountryId = 244, CountryName = "Saint Barthelemy"},
                new Country {CountryId = 224, CountryName = "Saint Helena"},
                new Country {CountryId = 205, CountryName = "Saint Kitts & Nevis Anguilla"},
                new Country {CountryId = 206, CountryName = "Saint Lucia"},
                new Country {CountryId = 247, CountryName = "Saint Martin"},
                new Country {CountryId = 220, CountryName = "Saint Pierre and Miquelon"},
                new Country {CountryId = 131, CountryName = "Saint Tome and Principe"},
                new Country {CountryId = 237, CountryName = "Saint Vincent & Grenadines"},
                new Country {CountryId = 132, CountryName = "Samoa"},
                new Country {CountryId = 227, CountryName = "San Marino"},
                new Country {CountryId = 133, CountryName = "Saudi Arabia"},
                new Country {CountryId = 134, CountryName = "Senegal"},
                new Country {CountryId = 250, CountryName = "Serbia"},
                new Country {CountryId = 135, CountryName = "Seychelles"},
                new Country {CountryId = 136, CountryName = "Sierra Leone"},
                new Country {CountryId = 137, CountryName = "Singapore"},
                new Country {CountryId = 138, CountryName = "Slovakia"},
                new Country {CountryId = 139, CountryName = "Slovenia"},
                new Country {CountryId = 223, CountryName = "Solomon Islands"},
                new Country {CountryId = 140, CountryName = "Somalia"},
                new Country {CountryId = 141, CountryName = "South Africa"},
                new Country {CountryId = 142, CountryName = "South Korea"},
                new Country {CountryId = 143, CountryName = "Spain"},
                new Country {CountryId = 144, CountryName = "Sri Lanka"},
                new Country {CountryId = 145, CountryName = "Sudan"},
                new Country {CountryId = 146, CountryName = "Suriname"},
                new Country {CountryId = 225, CountryName = "Svalbard and Jan Mayen Islands"},
                new Country {CountryId = 147, CountryName = "Swaziland"},
                new Country {CountryId = 148, CountryName = "Sweden"},
                new Country {CountryId = 149, CountryName = "Switzerland"},
                new Country {CountryId = 150, CountryName = "Syria"},
                new Country {CountryId = 151, CountryName = "Tadjikistan"},
                new Country {CountryId = 152, CountryName = "Taiwan"},
                new Country {CountryId = 153, CountryName = "Tanzania"},
                new Country {CountryId = 154, CountryName = "Thailand"},
                new Country {CountryId = 155, CountryName = "Togo"},
                new Country {CountryId = 231, CountryName = "Tokelau"},
                new Country {CountryId = 232, CountryName = "Tonga"},
                new Country {CountryId = 234, CountryName = "Trinidad and Tobago"},
                new Country {CountryId = 156, CountryName = "Tunisia"},
                new Country {CountryId = 157, CountryName = "Turkey"},
                new Country {CountryId = 158, CountryName = "Turkmenistan"},
                new Country {CountryId = 229, CountryName = "Turks and Caicos Islands"},
                new Country {CountryId = 235, CountryName = "Tuvalu"},
                new Country {CountryId = 159, CountryName = "Uganda"},
                new Country {CountryId = 160, CountryName = "UK"},
                new Country {CountryId = 161, CountryName = "Ukraine"},
                new Country {CountryId = 162, CountryName = "United Arab Emirates"},
                new Country {CountryId = 163, CountryName = "Uruguay"},
                new Country {CountryId = 164, CountryName = "US"},
                new Country {CountryId = 236, CountryName = "USA Minor Outlying Islands"},
                new Country {CountryId = 165, CountryName = "Uzbekistan"},
                new Country {CountryId = 239, CountryName = "Vanuatu"},
                new Country {CountryId = 166, CountryName = "Vatican City"},
                new Country {CountryId = 167, CountryName = "Venezuela"},
                new Country {CountryId = 168, CountryName = "Vietnam"},
                new Country {CountryId = 169, CountryName = "Virgin Islands {British}"},
                new Country {CountryId = 238, CountryName = "Virgin Islands {USA}"},
                new Country {CountryId = 240, CountryName = "Wallis and Futuna Islands"},
                new Country {CountryId = 188, CountryName = "Western Sahara"},
                new Country {CountryId = 170, CountryName = "Yemen"},
                new Country {CountryId = 171, CountryName = "Yugoslavia"},
                new Country {CountryId = 173, CountryName = "Zambia"},
                new Country {CountryId = 174, CountryName = "Zimbabwe"},
            };
        }

        public static List<Occupation> GetOccupations()
        {
            return new List<Occupation>
            {
                new Occupation
                {
                    OccupationId = "1.11711",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Accounts Payable/Receivable"
                },
                new Occupation
                {
                    OccupationId = "1.11712",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Actuarial Analysis"
                },
                new Occupation
                {
                    OccupationId = "1.11724",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Audit"
                },
                new Occupation
                {
                    OccupationId = "1.11730",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Bookkeeping"
                },
                new Occupation
                {
                    OccupationId = "1.14866",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Claims Review and Adjusting"
                },
                new Occupation
                {
                    OccupationId = "1.11750",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Collections"
                },
                new Occupation
                {
                    OccupationId = "1.14867",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Corporate Accounting"
                },
                new Occupation
                {
                    OccupationId = "1.11760",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Corporate Finance"
                },
                new Occupation
                {
                    OccupationId = "1.11766",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Credit Review/Analysis"
                },
                new Occupation
                {
                    OccupationId = "1.11803",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Financial Analysis/Research/Reporting"
                },
                new Occupation
                {
                    OccupationId = "1.14868",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Financial Control"
                },
                new Occupation
                {
                    OccupationId = "1.11804",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Financial Planning/Advising"
                },
                new Occupation
                {
                    OccupationId = "1.11960",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Financial Products Sales/Brokerage"
                },
                new Occupation
                {
                    OccupationId = "1.11817",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Fund Accounting"
                },
                new Occupation
                {
                    OccupationId = "1.11893",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "General/Other: Accounting/Finance"
                },
                new Occupation
                {
                    OccupationId = "1.11843",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Investment Management"
                },
                new Occupation
                {
                    OccupationId = "1.11927",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Policy Underwriting"
                },
                new Occupation
                {
                    OccupationId = "1.11940",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Real Estate Appraisal"
                },
                new Occupation
                {
                    OccupationId = "1.14875",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Real Estate Leasing/Acquisition"
                },
                new Occupation
                {
                    OccupationId = "1.11952",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Risk Management/Compliance"
                },
                new Occupation
                {
                    OccupationId = "1.11959",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Securities Analysis/Research"
                },
                new Occupation
                {
                    OccupationId = "1.11981",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Tax Accounting"
                },
                new Occupation
                {
                    OccupationId = "1.11982",
                    OccupationGroupName = "Accounting/Finance/Insurance",
                    OccupationName = "Tax Assessment and Collections"
                },
                new Occupation
                {
                    OccupationId = "2.11713",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Administrative Support"
                },
                new Occupation
                {
                    OccupationId = "2.14865",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Claims Processing"
                },
                new Occupation
                {
                    OccupationId = "2.11770",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Data Entry/Order Processing"
                },
                new Occupation
                {
                    OccupationId = "2.11797",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Executive Support"
                },
                new Occupation
                {
                    OccupationId = "2.11802",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Filing/Records Management"
                },
                new Occupation
                {
                    OccupationId = "2.11894",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "General/Other: Administrative/Clerical"
                },
                new Occupation
                {
                    OccupationId = "2.11888",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Office Management"
                },
                new Occupation
                {
                    OccupationId = "2.14874",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Property Management"
                },
                new Occupation
                {
                    OccupationId = "2.11942",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Reception/Switchboard"
                },
                new Occupation
                {
                    OccupationId = "2.11958",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Secretary/Executive Assistant"
                },
                new Occupation
                {
                    OccupationId = "2.14880",
                    OccupationGroupName = "Administrative/Clerical",
                    OccupationName = "Transcription"
                },
                new Occupation
                {
                    OccupationId = "558.11726",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Bank Teller"
                },
                new Occupation
                {
                    OccupationId = "558.15226",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Credit Manager"
                },
                new Occupation
                {
                    OccupationId = "558.15232",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Escrow Officer/Manager"
                },
                new Occupation
                {
                    OccupationId = "558.15228",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Loan Officer/Originator"
                },
                new Occupation
                {
                    OccupationId = "558.15229",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Mortgage Broker"
                },
                new Occupation
                {
                    OccupationId = "558.11939",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Real Estate Agent/Broker"
                },
                new Occupation
                {
                    OccupationId = "558.11940",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Real Estate Appraisal"
                },
                new Occupation
                {
                    OccupationId = "558.11941",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Real Estate Law"
                },
                new Occupation
                {
                    OccupationId = "558.11975",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Store/Branch Management"
                },
                new Occupation
                {
                    OccupationId = "558.15230",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Title Officer/Closer"
                },
                new Occupation
                {
                    OccupationId = "558.15231",
                    OccupationGroupName = "Banking/Real Estate/Mortgage Professionals",
                    OccupationName = "Underwriter"
                },
                new Occupation
                {
                    OccupationId = "559.11729",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Biological/Chemical Research"
                },
                new Occupation
                {
                    OccupationId = "559.11749",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Clinical Research"
                },
                new Occupation
                {
                    OccupationId = "559.11790",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Environmental/Geological Testing & Analysis"
                },
                new Occupation
                {
                    OccupationId = "559.11912",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "General/Other: R&D/Science"
                },
                new Occupation
                {
                    OccupationId = "559.11865",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Materials/Physical Research "
                },
                new Occupation
                {
                    OccupationId = "559.11866",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Mathematical/Statistical Research"
                },
                new Occupation
                {
                    OccupationId = "559.11883",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "New Product R&D"
                },
                new Occupation
                {
                    OccupationId = "559.11921",
                    OccupationGroupName = "Biotech/R&D/Science",
                    OccupationName = "Pharmaceutical Research"
                },
                new Occupation
                {
                    OccupationId = "544.11737",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "CAD/Drafting"
                },
                new Occupation
                {
                    OccupationId = "544.11743",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Carpentry/Framing"
                },
                new Occupation
                {
                    OccupationId = "544.11755",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Concrete and Masonry"
                },
                new Occupation
                {
                    OccupationId = "544.11783",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Electrician"
                },
                new Occupation
                {
                    OccupationId = "544.11809",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Flooring/Tiling/Painting/Wallpapering"
                },
                new Occupation
                {
                    OccupationId = "544.11896",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "General/Other: Construction/Skilled Trades"
                },
                new Occupation
                {
                    OccupationId = "544.11829",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Heavy Equipment Operation"
                },
                new Occupation
                {
                    OccupationId = "544.11835",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "HVAC"
                },
                new Occupation
                {
                    OccupationId = "544.11845",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Ironwork/Metal Fabrication"
                },
                new Occupation
                {
                    OccupationId = "544.11925",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Plumbing/Pipefitting"
                },
                new Occupation
                {
                    OccupationId = "544.11953",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Roofing"
                },
                new Occupation
                {
                    OccupationId = "544.11963",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Sheetrock/Plastering"
                },
                new Occupation
                {
                    OccupationId = "544.11965",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Site Superintendent"
                },
                new Occupation
                {
                    OccupationId = "544.11978",
                    OccupationGroupName = "Building Construction/Skilled Trades",
                    OccupationName = "Surveying"
                },
                new Occupation
                {
                    OccupationId = "3561.11734",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Business Analysis/Research"
                },
                new Occupation
                {
                    OccupationId = "3561.11736",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Business Unit Management"
                },
                new Occupation
                {
                    OccupationId = "3561.11814",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Franchise-Business Ownership"
                },
                new Occupation
                {
                    OccupationId = "3561.11895",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "General/Other: Business/Strategic Management"
                },
                new Occupation
                {
                    OccupationId = "3561.11830",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Hospital/Clinic Administration"
                },
                new Occupation
                {
                    OccupationId = "3561.14869",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Hotel/Lodging Management"
                },
                new Occupation
                {
                    OccupationId = "3561.11860",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Managerial Consulting"
                },
                new Occupation
                {
                    OccupationId = "3561.11875",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Mergers and Acquisitions"
                },
                new Occupation
                {
                    OccupationId = "3561.11929",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "President/Top Executive"
                },
                new Occupation
                {
                    OccupationId = "3561.11936",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Public Health Administration"
                },
                new Occupation
                {
                    OccupationId = "3561.11947",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Restaurant Management"
                },
                new Occupation
                {
                    OccupationId = "3561.11955",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "School/College Administration"
                },
                new Occupation
                {
                    OccupationId = "3561.11975",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Store/Branch Management"
                },
                new Occupation
                {
                    OccupationId = "3561.11976",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Strategic Planning/Intelligence"
                },
                new Occupation
                {
                    OccupationId = "3561.11990",
                    OccupationGroupName = "Business/Strategic Management",
                    OccupationName = "Town/City Planning"
                },
                new Occupation
                {
                    OccupationId = "11454.11714",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Advertising Writing {Creative}"
                },
                new Occupation
                {
                    OccupationId = "11454.11719",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Architecture/Interior Design"
                },
                new Occupation
                {
                    OccupationId = "11454.11752",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Computer Animation & Multimedia"
                },
                new Occupation
                {
                    OccupationId = "11454.11765",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Creative Direction/Lead"
                },
                new Occupation
                {
                    OccupationId = "11454.11800",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Fashion & Accessories Design"
                },
                new Occupation
                {
                    OccupationId = "11454.11897",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "General/Other: Creative/Design"
                },
                new Occupation
                {
                    OccupationId = "11454.11821",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Graphic Arts/Illustration"
                },
                new Occupation
                {
                    OccupationId = "11454.11837",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Industrial Design"
                },
                new Occupation
                {
                    OccupationId = "11454.11923",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Photography and Videography"
                },
                new Occupation
                {
                    OccupationId = "11454.12005",
                    OccupationGroupName = "Creative/Design",
                    OccupationName = "Web/UI/UX Design"
                },
                new Occupation
                {
                    OccupationId = "545.11710",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Account Management {Non-Commissioned}"
                },
                new Occupation
                {
                    OccupationId = "545.11726",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Bank Teller"
                },
                new Occupation
                {
                    OccupationId = "545.11738",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Call Center"
                },
                new Occupation
                {
                    OccupationId = "545.11768",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Customer Training"
                },
                new Occupation
                {
                    OccupationId = "545.11808",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Flight Attendant"
                },
                new Occupation
                {
                    OccupationId = "545.11898",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "General/Other: Customer Support/Client Care"
                },
                new Occupation
                {
                    OccupationId = "545.11824",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Hair Cutting/Styling"
                },
                new Occupation
                {
                    OccupationId = "545.11945",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Reservations/Ticketing"
                },
                new Occupation
                {
                    OccupationId = "545.11948",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Retail Customer Service"
                },
                new Occupation
                {
                    OccupationId = "545.11985",
                    OccupationGroupName = "Customer Support/Client Care",
                    OccupationName = "Technical Customer Service"
                },
                new Occupation
                {
                    OccupationId = "5623.11775",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "Digital Content Development"
                },
                new Occupation
                {
                    OccupationId = "5623.11778",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "Documentation/Technical Writing"
                },
                new Occupation
                {
                    OccupationId = "5623.11781",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "Editing & Proofreading"
                },
                new Occupation
                {
                    OccupationId = "5623.11899",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "General/Other: Editorial/Writing"
                },
                new Occupation
                {
                    OccupationId = "5623.11850",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "Journalism"
                },
                new Occupation
                {
                    OccupationId = "5623.11992",
                    OccupationGroupName = "Editorial/Writing",
                    OccupationName = "Translation/Interpretation"
                },
                new Occupation
                {
                    OccupationId = "3.11748",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Classroom Teaching"
                },
                new Occupation
                {
                    OccupationId = "3.11756",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Continuing/Adult "
                },
                new Occupation
                {
                    OccupationId = "3.11759",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Corporate Development and Training"
                },
                new Occupation
                {
                    OccupationId = "3.11768",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Customer Training"
                },
                new Occupation
                {
                    OccupationId = "3.11779",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Early Childhood Care & Development"
                },
                new Occupation
                {
                    OccupationId = "3.11784",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Elementary School"
                },
                new Occupation
                {
                    OccupationId = "3.11807",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Fitness & Sports Training/Instruction"
                },
                new Occupation
                {
                    OccupationId = "3.11915",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "General/Other: Training/Instruction"
                },
                new Occupation
                {
                    OccupationId = "3.11851",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Junior/High School"
                },
                new Occupation
                {
                    OccupationId = "3.11955",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "School/College Administration"
                },
                new Occupation
                {
                    OccupationId = "3.11971",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Software/Web Training"
                },
                new Occupation
                {
                    OccupationId = "3.11972",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "Special Education"
                },
                new Occupation
                {
                    OccupationId = "3.11995",
                    OccupationGroupName = "Education/Training",
                    OccupationName = "University "
                },
                new Occupation
                {
                    OccupationId = "4.11715",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Aeronautic/Avionic Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11728",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Bio-Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11737",
                    OccupationGroupName = "Engineering",
                    OccupationName = "CAD/Drafting"
                },
                new Occupation
                {
                    OccupationId = "4.11746",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Chemical Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11747",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Civil & Structural Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11782",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Electrical/Electronics Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11786",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Energy/Nuclear Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11788",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Environmental and Geological Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11900",
                    OccupationGroupName = "Engineering",
                    OccupationName = "General/Other: Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11838",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Industrial/Manufacturing Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11867",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Mechanical Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11881",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Naval Architecture/Marine Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11951",
                    OccupationGroupName = "Engineering",
                    OccupationName = "RF/Wireless Engineering"
                },
                new Occupation
                {
                    OccupationId = "4.11980",
                    OccupationGroupName = "Engineering",
                    OccupationName = "Systems/Process Engineering"
                },
                new Occupation
                {
                    OccupationId = "13.11810",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Food & Beverage Serving"
                },
                new Occupation
                {
                    OccupationId = "13.11811",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Food Preparation/Cooking"
                },
                new Occupation
                {
                    OccupationId = "13.11816",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Front Desk/Reception"
                },
                new Occupation
                {
                    OccupationId = "13.11901",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "General/Other: Food Services"
                },
                new Occupation
                {
                    OccupationId = "13.11822",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Guest Services/Concierge"
                },
                new Occupation
                {
                    OccupationId = "13.11823",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Guide {Tour} "
                },
                new Occupation
                {
                    OccupationId = "13.11831",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Host/Hostess"
                },
                new Occupation
                {
                    OccupationId = "13.11947",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Restaurant Management"
                },
                new Occupation
                {
                    OccupationId = "13.12007",
                    OccupationGroupName = "Food Services/Hospitality",
                    OccupationName = "Wine Steward {Sommelier}"
                },
                new Occupation
                {
                    OccupationId = "5.14864",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Academic Admissions and Advising"
                },
                new Occupation
                {
                    OccupationId = "5.11751",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Compensation/Benefits Policy"
                },
                new Occupation
                {
                    OccupationId = "5.11759",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Corporate Development and Training"
                },
                new Occupation
                {
                    OccupationId = "5.11777",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Diversity Management/EEO/Compliance"
                },
                new Occupation
                {
                    OccupationId = "5.11902",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "General/Other: Human Resources"
                },
                new Occupation
                {
                    OccupationId = "5.11834",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "HR Systems Administration"
                },
                new Occupation
                {
                    OccupationId = "5.11918",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Payroll and Benefits Administration"
                },
                new Occupation
                {
                    OccupationId = "5.11943",
                    OccupationGroupName = "Human Resources",
                    OccupationName = "Recruiting/Sourcing "
                },
                new Occupation
                {
                    OccupationId = "553.11753",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Computer/Electronics/Telecomm Install/Maintain/Repair"
                },
                new Occupation
                {
                    OccupationId = "553.11783",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Electrician"
                },
                new Occupation
                {
                    OccupationId = "553.11791",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Equipment Install/Maintain/Repair"
                },
                new Occupation
                {
                    OccupationId = "553.11798",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Facilities Management/Maintenance"
                },
                new Occupation
                {
                    OccupationId = "553.11903",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "General/Other: Installation/Maintenance/Repair"
                },
                new Occupation
                {
                    OccupationId = "553.11835",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "HVAC"
                },
                new Occupation
                {
                    OccupationId = "553.11849",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Janitorial & Cleaning "
                },
                new Occupation
                {
                    OccupationId = "553.11854",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Landscaping"
                },
                new Occupation
                {
                    OccupationId = "553.11858",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Locksmith"
                },
                new Occupation
                {
                    OccupationId = "553.11889",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Oil Rig & Pipeline Install/Maintain/Repair"
                },
                new Occupation
                {
                    OccupationId = "553.11925",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Plumbing/Pipefitting"
                },
                new Occupation
                {
                    OccupationId = "553.12000",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Vehicle Repair and Maintenance"
                },
                new Occupation
                {
                    OccupationId = "553.14881",
                    OccupationGroupName = "Installation/Maintenance/Repair",
                    OccupationName = "Wire and Cable Install/Maintain/Repair"
                },
                new Occupation
                {
                    OccupationId = "660.11754",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Computer/Network Security"
                },
                new Occupation
                {
                    OccupationId = "660.11772",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Database Development/Administration"
                },
                new Occupation
                {
                    OccupationId = "660.11774",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Desktop Service and Support"
                },
                new Occupation
                {
                    OccupationId = "660.11787",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Enterprise Software Implementation & Consulting"
                },
                new Occupation
                {
                    OccupationId = "660.11904",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "General/Other: IT/Software Development"
                },
                new Occupation
                {
                    OccupationId = "660.11848",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "IT Project Management"
                },
                new Occupation
                {
                    OccupationId = "660.11882",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Network and Server Administration"
                },
                new Occupation
                {
                    OccupationId = "660.11969",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Software/System Architecture"
                },
                new Occupation
                {
                    OccupationId = "660.11970",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Software/Web Development"
                },
                new Occupation
                {
                    OccupationId = "660.11979",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Systems Analysis - IT"
                },
                new Occupation
                {
                    OccupationId = "660.11987",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Telecommunications Administration/Management"
                },
                new Occupation
                {
                    OccupationId = "660.11996",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Usability/Information Architecture"
                },
                new Occupation
                {
                    OccupationId = "660.12005",
                    OccupationGroupName = "IT/Software Development",
                    OccupationName = "Web/UI/UX Design"
                },
                new Occupation {OccupationId = "7.11722", OccupationGroupName = "Legal", OccupationName = "Attorney"},
                new Occupation
                {
                    OccupationId = "7.11757",
                    OccupationGroupName = "Legal",
                    OccupationName = "Contracts Administration"
                },
                new Occupation
                {
                    OccupationId = "7.11905",
                    OccupationGroupName = "Legal",
                    OccupationName = "General/Other: Legal"
                },
                new Occupation
                {
                    OccupationId = "7.11852",
                    OccupationGroupName = "Legal",
                    OccupationName = "Labor & Employment Law"
                },
                new Occupation
                {
                    OccupationId = "7.11916",
                    OccupationGroupName = "Legal",
                    OccupationName = "Paralegal & Legal Secretary"
                },
                new Occupation
                {
                    OccupationId = "7.11917",
                    OccupationGroupName = "Legal",
                    OccupationName = "Patent/IP Law"
                },
                new Occupation
                {
                    OccupationId = "7.11941",
                    OccupationGroupName = "Legal",
                    OccupationName = "Real Estate Law"
                },
                new Occupation
                {
                    OccupationId = "7.11944",
                    OccupationGroupName = "Legal",
                    OccupationName = "Regulatory/Compliance Law"
                },
                new Occupation {OccupationId = "7.11983", OccupationGroupName = "Legal", OccupationName = "Tax Law"},
                new Occupation
                {
                    OccupationId = "5625.11739",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Car, Van and Bus Driving"
                },
                new Occupation
                {
                    OccupationId = "5625.11742",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Cargo and Baggage Handling"
                },
                new Occupation
                {
                    OccupationId = "5625.11763",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Cost Estimating"
                },
                new Occupation
                {
                    OccupationId = "5625.11793",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Equipment/Forklift/Crane Operation"
                },
                new Occupation
                {
                    OccupationId = "5625.11906",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "General/Other: Logistics/Transportation"
                },
                new Occupation
                {
                    OccupationId = "5625.11827",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Hazardous Materials Handling"
                },
                new Occupation
                {
                    OccupationId = "5625.11836",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Import/Export Administration"
                },
                new Occupation
                {
                    OccupationId = "5625.11842",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Inventory Planning and Management"
                },
                new Occupation
                {
                    OccupationId = "5625.11874",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Merchandise Planning and Buying"
                },
                new Occupation
                {
                    OccupationId = "5625.11876",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Messenger/Courier"
                },
                new Occupation
                {
                    OccupationId = "5625.11924",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Piloting: Air and Marine"
                },
                new Occupation
                {
                    OccupationId = "5625.11937",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Purchasing"
                },
                new Occupation
                {
                    OccupationId = "5625.11964",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Shipping and Receiving/Warehousing"
                },
                new Occupation
                {
                    OccupationId = "5625.11977",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Supplier Management/Vendor Management"
                },
                new Occupation
                {
                    OccupationId = "5625.11991",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Train or Rail Operator"
                },
                new Occupation
                {
                    OccupationId = "5625.11994",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Truck Driving"
                },
                new Occupation
                {
                    OccupationId = "5625.11998",
                    OccupationGroupName = "Logistics/Transportation",
                    OccupationName = "Vehicle Dispatch, Routing and Scheduling"
                },
                new Occupation
                {
                    OccupationId = "47.11721",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Assembly/Assembly Line"
                },
                new Occupation
                {
                    OccupationId = "47.11723",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Audio/Video Broadcast & Postproduction"
                },
                new Occupation
                {
                    OccupationId = "47.11792",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Equipment Operations"
                },
                new Occupation
                {
                    OccupationId = "47.11909",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "General/Other: Production/Operations"
                },
                new Occupation
                {
                    OccupationId = "47.11827",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Hazardous Materials Handling"
                },
                new Occupation
                {
                    OccupationId = "47.14871",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Laundry and Dry-Cleaning Operations"
                },
                new Occupation
                {
                    OccupationId = "47.11855",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Layout, Prepress, Printing, & Binding Operations"
                },
                new Occupation
                {
                    OccupationId = "47.11859",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Machining/CNC"
                },
                new Occupation
                {
                    OccupationId = "47.11877",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Metal Fabrication and Welding "
                },
                new Occupation
                {
                    OccupationId = "47.11880",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Moldmaking/Casting"
                },
                new Occupation
                {
                    OccupationId = "47.11890",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Operations/Plant Management"
                },
                new Occupation
                {
                    OccupationId = "47.11933",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Production/Operations Planning"
                },
                new Occupation
                {
                    OccupationId = "47.14878",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Scientific/Technical Production"
                },
                new Occupation
                {
                    OccupationId = "47.11962",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Sewing and Tailoring"
                },
                new Occupation
                {
                    OccupationId = "47.11987",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Telecommunications Administration/Management"
                },
                new Occupation
                {
                    OccupationId = "47.12003",
                    OccupationGroupName = "Manufacturing/Production/Operations",
                    OccupationName = "Waste Pick-up and Removal"
                },
                new Occupation
                {
                    OccupationId = "9007.11732",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Brand/Product Marketing"
                },
                new Occupation
                {
                    OccupationId = "9007.11758",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Copy Writing/Editing"
                },
                new Occupation
                {
                    OccupationId = "9007.11776",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Direct Marketing {CRM}"
                },
                new Occupation
                {
                    OccupationId = "9007.11795",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Events/Promotional Marketing"
                },
                new Occupation
                {
                    OccupationId = "9007.11907",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "General/Other: Marketing/Product"
                },
                new Occupation
                {
                    OccupationId = "9007.11844",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Investor and Public/Media Relations"
                },
                new Occupation
                {
                    OccupationId = "9007.11862",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Market Research"
                },
                new Occupation
                {
                    OccupationId = "9007.11863",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Marketing Communications"
                },
                new Occupation
                {
                    OccupationId = "9007.11864",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Marketing Production/Traffic"
                },
                new Occupation
                {
                    OccupationId = "9007.11869",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Media Planning and Buying"
                },
                new Occupation
                {
                    OccupationId = "9007.11931",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Product Management"
                },
                new Occupation
                {
                    OccupationId = "9007.11988",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Telemarketing"
                },
                new Occupation
                {
                    OccupationId = "9007.12002",
                    OccupationGroupName = "Marketing/Product",
                    OccupationName = "Visual/Display Merchandising"
                },
                new Occupation
                {
                    OccupationId = "3975.11872",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Dental Assistant/Hygienist"
                },
                new Occupation
                {
                    OccupationId = "3975.11773",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Dental Practitioner"
                },
                new Occupation
                {
                    OccupationId = "3975.11785",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "EMT/Paramedic"
                },
                new Occupation
                {
                    OccupationId = "3975.11908",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "General/Other: Medical/Health"
                },
                new Occupation
                {
                    OccupationId = "3975.11820",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Healthcare Aid"
                },
                new Occupation
                {
                    OccupationId = "3975.11853",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Laboratory/Pathology"
                },
                new Occupation
                {
                    OccupationId = "3975.11938",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Medical Imaging"
                },
                new Occupation
                {
                    OccupationId = "3975.11870",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Medical Practitioner"
                },
                new Occupation
                {
                    OccupationId = "3975.11871",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Medical Therapy/Rehab Services"
                },
                new Occupation
                {
                    OccupationId = "3975.11873",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Mental Health"
                },
                new Occupation
                {
                    OccupationId = "3975.11885",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Nursing"
                },
                new Occupation
                {
                    OccupationId = "3975.11886",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Nutrition and Diet"
                },
                new Occupation
                {
                    OccupationId = "3975.11891",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Optical"
                },
                new Occupation
                {
                    OccupationId = "3975.11922",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Pharmacy "
                },
                new Occupation
                {
                    OccupationId = "3975.14873",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Physician Assistant/Nurse Practitioner"
                },
                new Occupation
                {
                    OccupationId = "3975.11936",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Public Health Administration"
                },
                new Occupation
                {
                    OccupationId = "3975.11967",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Social Service"
                },
                new Occupation
                {
                    OccupationId = "3975.11973",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Sports Medicine"
                },
                new Occupation
                {
                    OccupationId = "3975.12001",
                    OccupationGroupName = "Medical/Health",
                    OccupationName = "Veterinary/Animal Care "
                },
                new Occupation
                {
                    OccupationId = "11.11741",
                    OccupationGroupName = "Other",
                    OccupationName = "Career Fair"
                },
                new Occupation {OccupationId = "11.11892", OccupationGroupName = "Other", OccupationName = "Other"},
                new Occupation
                {
                    OccupationId = "11.12008",
                    OccupationGroupName = "Other",
                    OccupationName = "Work at Home"
                },
                new Occupation
                {
                    OccupationId = "9008.11794",
                    OccupationGroupName = "Project/Program Management",
                    OccupationName = "Event Planning/Coordination"
                },
                new Occupation
                {
                    OccupationId = "9008.11910",
                    OccupationGroupName = "Project/Program Management",
                    OccupationName = "General/Other: Project/Program Management"
                },
                new Occupation
                {
                    OccupationId = "9008.11848",
                    OccupationGroupName = "Project/Program Management",
                    OccupationName = "IT Project Management"
                },
                new Occupation
                {
                    OccupationId = "9008.11934",
                    OccupationGroupName = "Project/Program Management",
                    OccupationName = "Program Management"
                },
                new Occupation
                {
                    OccupationId = "9008.11935",
                    OccupationGroupName = "Project/Program Management",
                    OccupationName = "Project Management"
                },
                new Occupation
                {
                    OccupationId = "11455.11733",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Building/Construction Inspection"
                },
                new Occupation
                {
                    OccupationId = "11455.11789",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Environmental Protection/Conservation"
                },
                new Occupation
                {
                    OccupationId = "11455.11813",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Food Safety and Inspection"
                },
                new Occupation
                {
                    OccupationId = "11455.11815",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Fraud Investigation"
                },
                new Occupation
                {
                    OccupationId = "11455.11911",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "General/Other: Quality Assurance/Safety"
                },
                new Occupation
                {
                    OccupationId = "11455.11846",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "ISO Certification"
                },
                new Occupation
                {
                    OccupationId = "11455.11887",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Occupational Health and Safety"
                },
                new Occupation
                {
                    OccupationId = "11455.11932",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Production Quality Assurance"
                },
                new Occupation
                {
                    OccupationId = "11455.11966",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Six Sigma/Black Belt/TQM"
                },
                new Occupation
                {
                    OccupationId = "11455.11968",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Software Quality Assurance"
                },
                new Occupation
                {
                    OccupationId = "11455.11999",
                    OccupationGroupName = "Quality Assurance/Safety",
                    OccupationName = "Vehicle Inspection"
                },
                new Occupation
                {
                    OccupationId = "10.11709",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Account Management {Commissioned}"
                },
                new Occupation
                {
                    OccupationId = "10.11735",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Business Development/New Accounts"
                },
                new Occupation
                {
                    OccupationId = "10.11801",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Field Sales"
                },
                new Occupation
                {
                    OccupationId = "10.11960",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Financial Products Sales/Brokerage"
                },
                new Occupation
                {
                    OccupationId = "10.11818",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Fundraising"
                },
                new Occupation
                {
                    OccupationId = "10.11913",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "General/Other: Sales/Business Development"
                },
                new Occupation
                {
                    OccupationId = "10.11839",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Insurance Agent/Broker"
                },
                new Occupation
                {
                    OccupationId = "10.11840",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "International Sales"
                },
                new Occupation
                {
                    OccupationId = "10.11868",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Media and Advertising Sales"
                },
                new Occupation
                {
                    OccupationId = "10.11874",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Merchandise Planning and Buying"
                },
                new Occupation
                {
                    OccupationId = "10.11939",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Real Estate Agent/Broker"
                },
                new Occupation
                {
                    OccupationId = "10.11950",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Retail/Counter Sales and Cashier"
                },
                new Occupation
                {
                    OccupationId = "10.11954",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Sales Support/Assistance"
                },
                new Occupation
                {
                    OccupationId = "10.11975",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Store/Branch Management"
                },
                new Occupation
                {
                    OccupationId = "10.11986",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Technical Presales Support & Technical Sales"
                },
                new Occupation
                {
                    OccupationId = "10.11989",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Telesales"
                },
                new Occupation
                {
                    OccupationId = "10.11993",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Travel Agent/Ticket Sales"
                },
                new Occupation
                {
                    OccupationId = "10.12002",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Visual/Display Merchandising"
                },
                new Occupation
                {
                    OccupationId = "10.12006",
                    OccupationGroupName = "Sales/Retail/Business Development",
                    OccupationName = "Wholesale/Reselling Sales"
                },
                new Occupation
                {
                    OccupationId = "555.11718",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Airport Security and Screening"
                },
                new Occupation
                {
                    OccupationId = "555.11762",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Correctional Officer"
                },
                new Occupation
                {
                    OccupationId = "555.11769",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Customs/Immigration"
                },
                new Occupation
                {
                    OccupationId = "555.11805",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Firefighting and Rescue"
                },
                new Occupation
                {
                    OccupationId = "555.11914",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "General/Other: Security/Protective Services"
                },
                new Occupation
                {
                    OccupationId = "555.11879",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Military Combat"
                },
                new Occupation
                {
                    OccupationId = "555.11926",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Police-Law Enforcement"
                },
                new Occupation
                {
                    OccupationId = "555.11961",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Security Guard"
                },
                new Occupation
                {
                    OccupationId = "555.14879",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Security Intelligence & Analysis"
                },
                new Occupation
                {
                    OccupationId = "555.11974",
                    OccupationGroupName = "Security/Protective Services",
                    OccupationName = "Store Security/Loss Prevention"
                },

            };
        }
    }
}
