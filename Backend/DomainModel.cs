using System;
using System.Collections.Generic;

namespace Backend
{
    public class UserResume
    {
        public int UserResumeId { get; set; }
        public BasicUserInfo BasicUserInfo { get; set; }
        public Summary Summary { get; set; }
        public Experience Experience { get; set; }
        public UserSkills Skills { get; set; }
    }

    #region UserInfo
    public class BasicUserInfo
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<UserAddresses> Addresses { get; set; }
        public List<ImHandle> ImHandles { get; set; }
        public List<string> WebsiteList { get; set; }
    }

    #region PhoneNumbes
    public class PhoneNumberType
    {
        public int PhoneNumberTypeId { get; set; }
        public string PhoneNumberTypeName { get; set; }
    }
    
    public class PhoneNumber
    {
        public int PhoneNumberTypeId { get; set; }
        public string Number { get; set; }
    }
    #endregion

    #region IM Handles
    public class ImHandleType
    {
        public int ImHandleTypeId { get; set; }
        public string ImHandleName { get; set; }
    }

    public class ImHandle
    {
        public ImHandleType ImHandleType { get; set; }
        public string HandleIdentifier { get; set; }
    }
    #endregion

    #region Address
    public class AddressType
    {
        public int AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
    }

    public class UserAddresses
    {
        public AddressType Type { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public string ZipCode { get; set; }
    }

    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string StateAbbrev { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
    #endregion

    #endregion

    #region Summary
    public class Summary
    {
        public string SummaryText { get; set; }
        public List<Occupation> Occupations { get; set; }
    }

    public class Occupation
    {
        public string OccupationId { get; set; }
        public string OccupationGroupName { get; set; }
        public string OccupationName { get; set; }
    }
    #endregion

    #region Experience

    public class UserExperience
    {
        public List<Experience> Experiences { get; set; }
    }

    public class Experience
    {
        public string Employer { get; set; }
        public string JobTitle { get; set; }
        public Country Country { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public List<UserSkills> Skills { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateFinished { get; set; }
        public bool WorkingHere { get; set; }
    }
    #endregion

    #region Skills

    public class UserSkills
    {
        public Skill Skill { get; set; }
        public int YearsOfExperience { get; set; }
    }

    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
    }
    
    #endregion

}
