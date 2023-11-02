using NUnit.Framework;
using test.Steps;
using test.Utils;

namespace test
{
    public class CertificationTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        CertificationSteps certificationSteps;

        public CertificationTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            certificationSteps = new CertificationSteps();

        }



        [Test]
        public void givenLoggedInAndAddingNewCertificate_whenAddCertificate_thenCertificateIsAdded()
        {
            //loginSteps.doLogin();

            homePageSteps.validateIsLoggedIn();
            System.Threading.Thread.Sleep(2000);
            homePageSteps.clickOnCertificationTab();

            certificationSteps.addCertification();
        }


    }

}

