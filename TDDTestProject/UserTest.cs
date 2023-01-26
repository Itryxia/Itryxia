
using Itryxia.Core;
using Itryxia.Core.Models.UserAgg;
using System.Xml.Linq;
using TDDTestProject.Helper;
using Xunit;

namespace TDDTestProject
{
    public class UserTest
    {
        [Fact]
        public void Test1()
        {
            
            //Arange
            UserCreateRequest request = new UserCreateRequest() 
            {
                Age = TestFaker.Age(),
                Name = TestFaker.Name(),
                Family = TestFaker.Family(),
                Mobile = TestFaker.Mobile(),
                Email = TestFaker.Email(),
            };
            
            //Act
            UserRegisterHandler handler= new UserRegisterHandler();
            var response = handler.Craete(request);

            //Assert
            Assert.NotNull(request.Email);
            Assert.NotEmpty(request.Email);
            Assert.NotNull(response);

            //Assert.NotEqual(request.Id, 0);
            Assert.Equal(request.Age, response.Age);
            Assert.Equal(request.Name, response.Name);
            Assert.Equal(request.Family, response.Family);
            Assert.Equal(request.Email, response.Email);
            Assert.Equal(request.Mobile, response.Mobile);
        }
    }
}
