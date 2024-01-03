
using OpenQA.Selenium;
using System;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;
using test.Utils;

namespace test.Steps
{
	public class EducationSteps : GobalHelper
    {
        ProfileEducationOverviewComponent ProfileEducationOverviewComponent;
        AddAndUpdateEducationComponent addAndUpdateEducationComponent;

        public EducationSteps() {

            ProfileEducationOverviewComponent =  new ProfileEducationOverviewComponent();
            addAndUpdateEducationComponent = new AddAndUpdateEducationComponent();

        }


		public void addEducation()
		{
            Model.EducationModel education = new Model.EducationModel();

           
            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\Education.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);

            ProfileEducationOverviewComponent.clickAddEducationButton();

            addAndUpdateEducationComponent.addEducation(education);
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage("Education has been added", acutalSuccessMessage);
        }


        public void updateEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\UpdateEducation.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);


            IWebElement updateButton = driver.FindElement(By.XPath("//td[text()='" + education.getTitle() + "']/ancestor::tbody/descendant::i[1]"));

           updateButton.Click();

            addAndUpdateEducationComponent.updateEducation(education);
            ProfileEducationOverviewComponent.clickupdateEducationButton();
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage("Education as been updated", acutalSuccessMessage);
        }

        public void deleteEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\Education.json";


            JsonReader er = JsonReader.read(path);
            education.setTitle(er.title);

            addAndUpdateEducationComponent.deleteEducation(education);

            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage("Education entry successfully removed", acutalSuccessMessage);
        }
    }
}

