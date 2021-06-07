using NUnit.Framework;

namespace APITestApp
{
    public class WhenTheSinglePostcodeServiceIsCalledWithAValidPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetup]
        public void OneTimeSetup()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
        }
        //The response code will not always be returned in the response body
        [Test]
        public void Statustest200()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"], Is.EqualTo(200));
        }
        [Test]
        public void StatusIs200_alt()
        {
            Assert.That(_singlePostcodeService.ResponseContent["status"], Is.EqualTo("OK"));
        }
        [Test]
        public void StatusIs200_alt2()
        {
            Assert.That(_singlePostcodeService.ResponseObject.Status, Is.EqualTo("OK"));
        }
        [Test]
        public void AdminDistrict_IsCityOfLondon()
        {
            Assert.That(_singlePostcodeService.ResponseObject.result.admin_district, Is.EqualTo("City of London"));
        }
    }
}