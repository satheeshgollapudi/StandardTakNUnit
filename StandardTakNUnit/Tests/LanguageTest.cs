using NUnit.Framework;
using System.Threading;
using test.Steps;
using test.Steps.Pages.components;
using test.Utils;

namespace test
{
    public class LanguageTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        LanguageSteps languageSteps;

        public LanguageTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            languageSteps = new LanguageSteps();

        }



        [Test]
        public void givenLoggedInAndAddingNewLanguage_whenAddLanguage_thenLanguageIsAdded()
        {
            //loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            Thread.Sleep(2000);
            homePageSteps.clickOnLangaugesTab();

            languageSteps.addLanguage();
        }


    }

}

