using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test1()
            {
              
               
                //SignIn data = new SignIn();
                //data.LoginSteps();

                //SignUp data1 = new SignUp();
                //data1.register();
            
                ShareSkill data2 = new ShareSkill();
                data2.EnterShareSkill();

               


            }
            [Test]
            public void Test2()
            {
                ManageListings data3 = new ManageListings();
                data3.Listings();

                data3.EditShareSkill();
                data3.DeleteShareskill();
            }


        }
    }
}