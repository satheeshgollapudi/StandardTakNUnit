using System;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;
using test.Utils;

namespace test.Steps.Pages.components
{
	public class LanguageSteps
    {
        ProfileLanguageOverviewComponent ProfileLanguageOverviewComponent;
        AddAndUpdateLanguageComponent addAndUpdateLanguageComponent;

        public LanguageSteps() {

            ProfileLanguageOverviewComponent =  new ProfileLanguageOverviewComponent();
            addAndUpdateLanguageComponent = new AddAndUpdateLanguageComponent();

        }


		public void addLanguage()
		{
            Model.LanguageModel language = new Model.LanguageModel();

            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\Language.json";


            JsonReader jr = JsonReader.read(path);

            language.setLanguage(jr.Language);
            language.setLevel(jr.Level);


           ProfileLanguageOverviewComponent.clickAddLanguageButton();

            addAndUpdateLanguageComponent.addLanguage(language);
           
            String acutalSuccessMessage = addAndUpdateLanguageComponent.getSuccessMessage();

            AssertHelper.assertAddLanguageSuccessMessage(language.getLanguage()+ " has been added to your languages", acutalSuccessMessage);
        }
	}
}

