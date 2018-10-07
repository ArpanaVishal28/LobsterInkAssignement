using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobsterIncSolution
{

    [TestFixture]
    class EmailAlreadyUsedTest : Init
    {

        [Test, Order(1)]
        [TestCase("Arpana", "Bhardwaj", "arpana91@gmail.com", "arpana91@gmail.com", "TestAutomate@1", "TestAutomate@1")]
        public void EmailAlready_UsedTest(String FirstName, String LastName, String Email, String ConfirmEmail, String Passwd, String ConfirmPasswd)

        {

                String ErrorString = "The email address is already in use.";
           
            try
            {
                //Wait until element Signup is clickable
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body > app > div > learn > div > marketplace > desktop-page-header > header > div > div > login > div > a.end-margin-1.signup-link.mat-button.mat-accent.ghost-button > span")));

                var ClickSignUp = driver.FindElement(By.CssSelector("body > app > div > learn > div > marketplace > desktop-page-header > header > div > div > login > div > a.end-margin-1.signup-link.mat-button.mat-accent.ghost-button > span"));

                //Click on SignUp Button
                ClickSignUp.Click();


                //Wait until element Signupwithemail is clickable
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("sign-up-with-email")));

                var ClickSignUpWithEmail = driver.FindElement(By.Id("sign-up-with-email"));

                //Click on SignUpwithEmail Button
                ClickSignUpWithEmail.Click();

                //Wait until page loads with text "Sign up With Email"
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".z-index-1 div .bottom-margin-2.color-blacks-54")));


                /***  form fill and registeration start**/

                //Assert that page has Text Sign up with email
                String Text = driver.FindElement(By.CssSelector(".z-index-1 div .bottom-margin-2.color-blacks-54")).Text;
                Assert.That(Text, Is.EqualTo("Sign up with email"));

                //Enter First Name
                driver.FindElement(By.Id("FirstName")).SendKeys(FirstName);

                //Enter Last Name
                driver.FindElement(By.Id("LastName")).SendKeys(LastName);

                //Enter Email ID
                driver.FindElement(By.Id("Email")).SendKeys(Email);

                //Enter Confirm Email ID
                driver.FindElement(By.Id("ConfirmEmail")).SendKeys(ConfirmEmail);

                //Enter Password
                driver.FindElement(By.Id("Password")).SendKeys(Passwd);
                //Enter confirm Password
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys(ConfirmPasswd);


                //Scroll to sign up button
                IWebElement Element = driver.FindElement(By.Id("sign-up-button"));

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", Element);

                //Click on sign up button to register

                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("sign-up-button")));
                Element.Click();


                //Verify Email id already used error
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div > div > div.alert-wrapper > div > div > div.left-spacing-1 > header")));
                String InvalidEmailError = driver.FindElement(By.CssSelector("body > div > div > div.alert-wrapper > div > div > div.left-spacing-1 > header")).Text;
                Assert.That(InvalidEmailError, Is.EqualTo(ErrorString));

               


            }


            catch (AssertionException e)
            {
                Console.WriteLine("Sign up with email test failed" + e);

            }

            catch (ElementClickInterceptedException e)
            {

                Console.WriteLine("Clicking on element fail" + e);
            }

            catch (ElementNotVisibleException e)
            {

                Console.WriteLine("Element not visible" + e);
            }

            catch (Exception e)
            {

                Console.WriteLine("Exception occured in Sign up with Email Test" + e);
            }

        }


    



    }
}
