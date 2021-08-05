using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
//using AutoItX3Lib;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[@class='tooltip-target ui grid']/div[@class='twelve wide column']/div[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement Tags { get; set; }

        //Enter New Tag name in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement NewTags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//div[3]//div[1]//div[1]//input[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        //[FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
       // private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter New Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]")]
        private IWebElement NewSkill { get; set; }

        //Upload work sample
       // [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        //private IWebElement worksample { get; set; }

        //Enter the amount for Credit
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        // private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void EnterShareSkill()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(2000);
            //Click on ShareSkii button
            ShareSkillButton.Click();
            
            //Enter the Title 
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            
            //Enter the Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            
            //Click on Category
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            CategoryDropDown.Click();
            
            //Click on SubCategory
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            SubCategoryDropDown.Click();
            
            //Enter Tag names
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
           NewTags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "New Tags"));

            //Select the Service type
            ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType"));

            //Select the Location type
            LocationTypeOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LocationType"));

            //Click on Start Date
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            StartDateDropDown.Click();

            //Click on End Date
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            EndDateDropDown.Click();

            //Storing the table of available days
            Days.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Selectday"));
            Days.Click();

            //Click on start time
            StartTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            StartTimeDropDown.Click();

            //Click on End Time
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));
            EndTimeDropDown.Click();

            //Click on Skill Trade
            SkillTradeOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade"));
            SkillTradeOption.Click();

            //Enter Skill-Exchange
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);
            NewSkill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "New Skill"));

            //Upload work sample file
            //worksample.Click();
            //Thread.Sleep(2000);
           //AutoItX3 autoIt = new AutoItX3();
           // autoIt.WinActivate("Open");
            //autoIt.Send(@"C:\Users\vanda\OneDrive\Desktop\Test\sample.txt");
           // Thread.Sleep(2000);
            //autoIt.Send("{Enter}");
            
            //Enter the Creditamount
            //CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            //Click on Active/Hidden
            ActiveOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Active"));
            ActiveOption.Click();

            //Click on Save
            Save.Click();


        }

        internal void EditShareSkill()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");

            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

        }
    }
}
