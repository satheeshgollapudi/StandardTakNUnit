using NUnit.Framework;
using test.Steps;
using test.Utils;

namespace test
{
    public class EducationTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        EducationSteps educationSteps;

        public EducationTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            educationSteps = new EducationSteps();

        }



        [Test]
        public void givenLoggedInAndAddingNewEductaion_whenAddEducation_thenEducationIsAdded()
        {
            //loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();

            educationSteps.addEducation();
        }



        [Test]
        public void givenLoggedInAndUpdateEductaion_thenEducationIsUpdated()
        {
            //loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();

            educationSteps.updateEducation();
        }

        [Test]
        public void givenLoggedInAndDeleteEductaion_thenEducationIsDeleted()
        {
            //loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();

            educationSteps.deleteEducation();
        }


    }

}

