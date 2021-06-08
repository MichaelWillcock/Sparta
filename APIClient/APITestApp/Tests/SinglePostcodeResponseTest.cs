﻿using NUnit.Framework;
using System;

namespace APITestApp
{
    class WhenTheSinglePostcodeServiceIsCalledWithValidPostcode
    {
        SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async System.Threading.Tasks.Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
        }

        //The response code will not always be in the response body.
        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostcodeService.Json_Response["status"].ToString(), Is.EqualTo("200"));
        }
        [Test]
        public void StatusIs200_alt()
        {
            Assert.That(_singlePostcodeService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }
        [Test]
        public void StatusIs200_alt2()
        {
            Assert.That(_singlePostcodeService.SinglePostcodeDTO.Response.Status, Is.EqualTo(200));
        }
        [Test]
        public void AdminDistrict_IsCityOfLondon()
        {
            Assert.That(_singlePostcodeService.SinglePostcodeDTO.Response.result.admin_district, Is.EqualTo("City of London"));
        }
        [Test]
        public void NumberOfCodes_IsCorrect()
        {
            Assert.That(_singlePostcodeService.CodeCount(), Is.EqualTo(12));
        }

    }
}
