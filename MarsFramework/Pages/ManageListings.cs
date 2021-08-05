using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
        private IWebElement delete { get; set; }
       
        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[2]/i[1]")]
        private IWebElement edit { get; set; }
        //update edit the title
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement UpdateTitle { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Yes']")]
        private IWebElement clickActionsButton { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            Thread.Sleep(5000);
            //Click on Manage Listings
            manageListingsLink.Click();
            Thread.Sleep(5000);
            //View the Listing
            view.Click();
            Thread.Sleep(5000);
            manageListingsLink.Click();
            Thread.Sleep(5000);
            edit.Click();
            Thread.Sleep(2000);
            UpdateTitle.Clear();
            Thread.Sleep(2000);
            UpdateTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));


        }  
            
            internal void EditShareSkill()
            {
                //Populate the Excel Sheet
                //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
              //  Thread.Sleep(2000);
                //manageListingsLink.Click();
                //Thread.Sleep(2000);
                //Edit the Listing
                //edit.Click();
                //UpdateTitle.Clear();

                //UpdateTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
                //Delete the Listing
                //delete.Click();

                //Click on Yes or No
                //clickActionsButton.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Deleteaction"));
                //clickActionsButton.Click();

            }
           internal void DeleteShareskill()
        {
            //Thread.Sleep(5000);
            manageListingsLink.Click();
            Thread.Sleep(5000);
            delete.Click();
            Thread.Sleep(2000);
            clickActionsButton.Click();
        }

        
    }
}
