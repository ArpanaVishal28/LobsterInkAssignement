# LobsterInk.WebAppTest
Assumptions:

To test the  Signup and FormValidations, First Name , Last Name  Email id and password needs to be provided.
1>InvalidEmailIdTest.cs --> Incorrect Email ID and other valid details provided. to test invalid emailid  with error  "The Email address field is not a valid e-mail address." 
and "The Confirm email address field is not a valid e-mail address." .

2>InvalidPasswordTest.cs -->Invalid password with min and max length & not matching with confirm password and other valid details provided. to test invalid password
with valid errors ("Password must be 8 to 20 characters long","Password verification must match password").


3>SignUpTest.cs --> Valid details provided to test Signup and verify registration.


4>EmailAlreadyUsedTest.cs --> valid details provided with already registered Email Id, verify error "The email address is already in use.".

To execute this test cases , Nunit-console is required.
nunit-console LobsterIncSolution.dll command needs to be executed.
