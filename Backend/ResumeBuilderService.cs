using System;
using System.Collections.Generic;

namespace Backend
{
    public interface IResumeBuilderService
    {
        List<AddressType> GetAddressTypes();
        List<PhoneNumberType> GetPhoneNumberTypes();
        List<ImHandleType> GetImHandleTypes();
        List<State> GetStates();
        List<Country> GetCountries();
        List<Occupation> GetOccupations();
            
        UserResume GetEmptyUserResume();
        UserResume GetUserResume(int resumeId);
        int SaveResume(UserResume userResume);
        UserResume UpdateResume(UserResume userResume);
    }
    
    public class ResumeBuilderService : IResumeBuilderService
    {
        private readonly IResumeRepository _resumeRepository;

        public ResumeBuilderService(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }
        
        
        public UserResume GetEmptyUserResume()
        {
            return new UserResume();
        }

        public UserResume GetUserResume(int resumeId)
        {
            return _resumeRepository.GetUserResume(resumeId);
        }

        public int SaveResume(UserResume userResume)
        {
            return _resumeRepository.SaveResume(userResume);
        }

        public UserResume UpdateResume(UserResume userResume)
        {
            return _resumeRepository.UpdateResume(userResume);
        }

        #region lookups
        public List<AddressType> GetAddressTypes()
        {
            return LookupData.GetAddressTypes();
        }

        public List<PhoneNumberType> GetPhoneNumberTypes()
        {
            return LookupData.GetPhoneNumberTypes();
        }

        public List<ImHandleType> GetImHandleTypes()
        {
            return LookupData.GetImHandleTypes();
        }

        public List<State> GetStates()
        {
            return LookupData.GetStates();
        }

        public List<Country> GetCountries()
        {
            return LookupData.GetCountries();
        }

        public List<Occupation> GetOccupations()
        {
            return LookupData.GetOccupations();
        }
        #endregion

    }
}
