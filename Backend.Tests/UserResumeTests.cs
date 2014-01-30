using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Backend.Tests
{
    [TestClass]
    public class UserResumeTests
    {
        private const string _resumeStorePath = @"c:\_AngularResumes\Tests\";
        
        
        [TestMethod]
        public void CreateResumeAndSaveIt()
        {
            //Arrange
            var myResume = new UserResume
            {
                BasicUserInfo = new BasicUserInfo
                {
                    FirstName = "Antonin",
                    LastName = "Jelinek",
                    PrimaryEmail = "antonin.jelinek@gmail.com",
                    Title = "Mr.",
                    PhoneNumbers = new List<PhoneNumber>
                    {
                        new PhoneNumber {Number = "123456789", PhoneNumberTypeId = 1 /*mobile*/},
                        new PhoneNumber {Number = "888888888", PhoneNumberTypeId = 2 /*home*/},
                        new PhoneNumber {Number = "666", PhoneNumberTypeId = 3 /*work*/},
                        new PhoneNumber {Number = "987654321", PhoneNumberTypeId = 4 /*voip*/},
                    },
                    WebsiteList = new List<string> {"http://www.bohemians.cz", "http://trener.lidovky.cz"},
                    Addresses = new List<UserAddresses>
                    {
                        new UserAddresses
                        {
                            Address = new Address
                            {   Street = "Vaclavske nam. 11, Praha 1", 
                                ZipCode = "110 00", 
                                Country = new Country
                                {
                                    CountryId = 42
                                }
                            },
                            Type = new AddressType
                            {
                                AddressTypeId = 1
                            }
                        },
                        new UserAddresses
                        {
                            Address = new Address
                            {   Street = "5 Clock Tower Place, MAynard, MA", 
                                ZipCode = "01754", 
                                Country = new Country
                                {
                                    CountryId = 164
                                }
                            },
                            Type = new AddressType
                            {
                                AddressTypeId = 2
                            }
                        },
                    }
                },
                Summary = new Summary
                {
                    SummaryText = "Long time server side developer recently turned by dark forces to discover beauties of client side web development. All you server code are belong to us.",
                    Occupations = new List<Occupation>
                    {
                        new Occupation
                        {
                            OccupationId = "5623.11775"
                        }
                    }
                }
            };

            if (Directory.GetFiles(_resumeStorePath).Length > 0)
            {
                foreach (var filePath in Directory.GetFiles(_resumeStorePath))
                {
                    File.Delete(filePath);
                }
            }

            var service = new ResumeBuilderService(new ResumeRepository(_resumeStorePath));

            //Act
            int newResumeId = service.SaveResume(myResume);

            //Assert
            Assert.IsTrue(newResumeId == 1);
        }

        [TestMethod]
        public void LoadResume()
        {
            //Arrange
            var resumeId = 1;
            var service = new ResumeBuilderService(new ResumeRepository(_resumeStorePath));

            //Act
            var resume = service.GetUserResume(resumeId);

            //Assert
            Assert.IsNotNull(resume);
            Assert.IsTrue(resume.UserResumeId == 1);
            Assert.IsTrue(resume.BasicUserInfo.PhoneNumbers.Count ==4);
        }
    }
}
