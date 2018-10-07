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
    class InvalidEmailIdTest : Init
    {

        //Invalid Email Id Test 
        [Test, Order(1)]
        [TestCase("Arpana", "Bhardwaj", "arpana91@gmail", "arpana91@gmail", "TestAutomate@1", "TestAutomate@1")]
        public void InvalidEmailTest(String FirstName, String LastName, String Email, String ConfirmEmail, String Passwd, String ConfirmPasswd)
        {

            String ErrorString = "The Email address field is not a valid e-mail address.";
           String  ConfirmErrorString = "The Confirm email address field is not a valid e-mail address.";
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


                //Verify invalid email id error
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".email span")));
                String InvalidEmailError = driver.FindElement(By.CssSelector(".email span")).Text;
                Assert.That(InvalidEmailError, Is.EqualTo(ErrorString));

                //Verify invalid confirm email id error
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".confirm-email span")));
                String InvalidConfirmEmailError = driver.FindElement(By.CssSelector(".confirm-email span")).Text;
                Assert.That(InvalidConfirmEmailError, Is.EqualTo(ConfirmErrorString));


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


        //Email and confirm Email not matched test
        [Test, Order(2)]
        [TestCase("Arpana", "Bhardwaj", "arpana91@gmail.com", "arpana90@gmail.com", "TestAutomate@1", "TestAutomate@1")]
        public void EmailConfirmEmailNtMtchTest(String FirstName, String LastName, String Email, String ConfirmEmail, String Passwd, String ConfirmPasswd)
        {

            String ErrorString = "Email confirmation must match email";
            
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


                //Verify  email match with confirm email error
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".confirm-email span")));
                String InvalidEmailError = driver.FindElement(By.CssSelector(".confirm-email span")).Text;
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
