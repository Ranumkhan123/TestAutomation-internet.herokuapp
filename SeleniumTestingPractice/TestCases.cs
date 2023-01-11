using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestingPractice.Pages;
using System;

namespace SeleniumTestingPractice
{
    [TestClass]
    public class TestCases
    {
        AandBTesting abtest = new AandBTesting();
        AddandRemoveElement adddandremoveelement = new AddandRemoveElement();   
        BasicAuth BasicAuth = new BasicAuth();
        CheckBoxes checkbox = new CheckBoxes();
        DisappearingElements elements = new DisappearingElements();
        DynamicControls dynamicontrols = new DynamicControls();
        DynamicLoading dynamicloading = new DynamicLoading();
        EntryAd entryad = new EntryAd();
        FormAuthentication formauthentication = new FormAuthentication();
        HorizontalSlider horizontalslider = new HorizontalSlider();
        Hovers hovers = new Hovers();
        JavaScriptAlerts alerts = new JavaScriptAlerts();
        MultipleWindows multiplewindows = new MultipleWindows();


        [TestMethod]
        public void ABTesting()
        {

            CorePage.SeleniumInit();
            abtest.ABtest("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void AddAndRemoveElements()
        {

            CorePage.SeleniumInit();
            adddandremoveelement.AddandRemove("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }


        [TestMethod]
        public void BasicAuthTestCase()
        {

            CorePage.SeleniumInit();
            BasicAuth.BasicAuthPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void CheckBoxTestCases()
        {

            CorePage.SeleniumInit();
            checkbox.CheckboxesPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void DisappearingElementsTestCases()
        {

            CorePage.SeleniumInit();
            elements.DisappearingElementsPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void DynamicControlsTestCase()
        {

            CorePage.SeleniumInit();
            dynamicontrols.DynamicControlsPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void DynamicLoadingTestCase()
        {

            CorePage.SeleniumInit();
            dynamicloading.DynamicLoadingPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void EntryAdTestCase()
        {

            CorePage.SeleniumInit();
            entryad.EntryAdPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }


        [TestMethod]
        public void FormAuthenticationTestCase()
        {

            CorePage.SeleniumInit();
            formauthentication.FormAuthenticationPage("https://the-internet.herokuapp.com/", "tomsmith", "SuperSecretPassword!");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void HorizontalSliderTestCase()
        {

            CorePage.SeleniumInit();
            horizontalslider.HorizontalSliderPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }


        [TestMethod]
        public void HoversTestCase()
        {

            CorePage.SeleniumInit();
            hovers.HoversPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void AlertsTestCase()
        {

            CorePage.SeleniumInit();
            alerts.JavaScriptAlertsPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }

        [TestMethod]
        public void MultipleWindowsTestCase()
        {

            CorePage.SeleniumInit();
            multiplewindows.MultipleWindowsPage("https://the-internet.herokuapp.com/");

            CorePage.driver.Close();
        }
    }

}
