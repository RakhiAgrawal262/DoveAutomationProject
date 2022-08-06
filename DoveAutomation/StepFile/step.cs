using System;
using TechTalk.SpecFlow;
using DoveAutomation.CommonObjectMethod;
namespace DoveAutomation.FeatureFile
{

    [Binding]
    public class DoveSteps
    {
        CommonMethod obj = new CommonMethod();

        [Given(@"I have navigate to Dove website")]
        public void GivenIHaveNavigateToDoveWebsite()
        {
            obj.OpenDoveURL();
        }
        
        [Given(@"I have entered Shampoo as search keyword")]
        public void GivenIHaveEnteredShampooAsSearchKeyword()
        {
            obj.EnteredShampoo();
        }
        
        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            obj.PressSearch();
        }
        
        [Then(@"Verify the text ""(.*)""")]
        public void ThenVerifyTheText(string p0)
        {
            obj.VerifyShampoo();
        }


        [Given(@"Navigate WebSite URL")]
        public void GivenNavigateWebSiteURL()
        {
            obj.OpenDoveURL1();
        }

        [When(@"Click on Discover more")]
        public void WhenClickOnDiscoverMore()
        {
            obj.ClickOnDiscoverMore();
        }

        [Then(@"Verify the text The Real Women behind \#StopTheBeautyTest")]
        public void ThenVerifyTheTextTheRealWomenBehindStopTheBeautyTest()
        {
            obj.VerifyTheRealWomen();
        }



        [Given(@"Dove website URL")]
        public void GivenDoveWebsiteURL()
        {
            obj.OpenDoveURL2();
        }

        [When(@"Click on Terms of use")]
        public void WhenClickOnTermsOfUse()
        {
            obj.ClickonTermsofuse();
        }

        [Then(@"Verify Prohibited Uses")]
        public void ThenVerifyProhibitedUses()
        {
            obj.VerifyProhibitedUses();
        }

    }
}
