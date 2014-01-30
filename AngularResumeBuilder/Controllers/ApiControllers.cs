using System.Collections.Generic;
using System.Threading;
using System.Web.Http;
using Backend;

namespace AngularResumeBuilder.Controllers
{
    /// <summary>
    /// For real-world app, we would probably use some kind of IOC. To make this simple, 
    /// we will create ResumeBuilderService in a base class and derive all controllers 
    /// from it.
    /// </summary>
    public class BaseApiController : ApiController
    {
        internal readonly IResumeBuilderService Service = new ResumeBuilderService(new ResumeRepository());
    }

    #region Resume Controller
    public class ResumeController : BaseApiController
    {
        //Get
        [HttpGet]
        public UserResume Get(int id)
        {
            Thread.Sleep(1000);
            return Service.GetUserResume(id);
        }

        //Save new
        [HttpPut]
        public UserResume Put(UserResume resume)
        {
            var newResumeId = Service.SaveResume(resume);
            return Service.GetUserResume(newResumeId);
        }

        //Update existing
        [HttpPost]
        public UserResume Post(UserResume resume)
        {
            var updatedResume = Service.UpdateResume(resume);
            return updatedResume;
        }
    }
    #endregion

    #region LookupControllers

    public class OccupationsController : BaseApiController
    {
        public IEnumerable<Occupation> Get()
        {
            return Service.GetOccupations();
        }
    }

    public class AddressTypesController : BaseApiController
    {
        public IEnumerable<AddressType> Get()
        {
            return Service.GetAddressTypes();
        }
    }

    public class PhoneNumberTypesController : BaseApiController
    {
        public IEnumerable<PhoneNumberType> Get()
        {
            return Service.GetPhoneNumberTypes();
        }
    }

    public class ImHandleTypesController : BaseApiController
    {
        public IEnumerable<ImHandleType> Get()
        {
            return Service.GetImHandleTypes();
        }
    }

    public class StatesController : BaseApiController
    {
        public IEnumerable<State> Get()
        {
            return Service.GetStates();
        }
    }

    public class CountriesController : BaseApiController
    {
        public IEnumerable<Country> Get()
        {
            return Service.GetCountries();
        }
    }

    #endregion
}