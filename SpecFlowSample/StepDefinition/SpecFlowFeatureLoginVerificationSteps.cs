using System;
using TechTalk.SpecFlow;

namespace SpecFlowSample.StepDefinition
{
    [Binding]
    public class SpecFlowFeatureLoginVerificationSteps
    {
        [Given(@"I have the correct username unni and password unni(.*)")]
        public void GivenIHaveTheCorrectUsernameUnniAndPasswordUnni(int p0)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"Iclick the submit button")]
        public void WhenIclickTheSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be taken to Home page")]
        public void ThenIWillBeTakenToHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
