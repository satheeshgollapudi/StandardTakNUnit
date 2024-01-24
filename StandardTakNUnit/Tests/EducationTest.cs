using NUnit.Framework;
using System.Threading;
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
           

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();
            educationSteps.addEducation();
            Thread.Sleep(3000);
            educationSteps.deleteEducation();
        }

        [Test]
        public void givenLoggedInAndAddingNewEductaion_whenAddEducation_thenExistingEducationIsAdded()
        {


            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();
            educationSteps.addEducation();
            Thread.Sleep(3000);
            educationSteps.deleteEducation();
        }



        [Test]
        public void givenLoggedInAndUpdateEductaion_thenEducationIsUpdated()
        {
           

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnEducationTab();
            educationSteps.addEducation();
            Thread.Sleep(3000);
            educationSteps.updateEducation();
            Thread.Sleep(3000);
            educationSteps.deleteEducation();
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

