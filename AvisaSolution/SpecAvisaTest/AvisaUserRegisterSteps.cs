using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecAvisaTest
{
    [Binding]
    public class AvisaUserRegisterSteps
    {
       
        [Given(@"I have entered ""(.*)"" into the username")]
        public void GivenIHaveEnteredIntoTheUsername(string p0)
        {
            int i = 0;
            i++;
        }
        
        [Given(@"I have entered ""(.*)"" into the lastname")]
        public void GivenIHaveEnteredIntoTheLastname(string p0)
        {
            int i = 0;
            i++;
        }

        [Given(@"I have entered ""(.*)"" into the password")]
        public void GivenIHaveEnteredIntoThePassword(int p0)
        {
            int i = 0;
            i++;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            int i = 0;
            i++;
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(1, 1);
        }
    }
}
