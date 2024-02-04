# Authentication WebPage
This is an authentication project that allows users to enroll and login to the system using their email and password. It is implemented using ASP.NET Core MVC framework and Microsoft SQL Server for data storage.

<img src="" width=100%> 

## Project Files
- `Welcome.cshtml`: Contains the view for the welcome page that is displayed to users after successful login. It shows the enrolled user's information fetched from the database.
- `Index.cshtml`: Contains the view for the login page where users can enter their registered email and password to log in.
- `Index.cshtml`: (in enroll folder) Contains the view for the registration page where users can complete their registration by providing their personal information, including first name, last name, email, password, confirm password, and gender.
- `SQL Script for Database.sql`: Contains the SQL Script for intializing the database.
- `UserEnrollController.cs`: Contains the controller logic for user enrollment. It includes actions for displaying the registration form and processing the form submission by inserting the user details into the database.
- `UserLoginController.cs`: Contains the controller logic for user login. It includes actions for displaying the login form, validating the user credentials against the database, and redirecting to the welcome page upon successful login.

## Features
- User Enrollment: Users can register by providing their personal information such as first name, last name, password, gender, email, and phone number.
- User Login: Registered users can log in using their email and password. If the login is successful, they are redirected to a welcome page.
- Welcome Page: Once logged in, users are greeted with a personalized welcome page that displays their enrollment details fetched from the database.
- Logout: Users can log out of the system, which redirects them back to the login page.

## Prerequisites
- Microsoft SQL Server: Make sure you have SQL Server installed and running.
- .NET Core SDK: Install .NET Core SDK to build and run the project.
- Visual Studio or any other compatible IDE: To edit and run the code.

## Setup

1. Clone the repository
2. Open the project in your preferred IDE.
3. Update the connection string: In the `UserLoginController.cs` and `UserEnrollController.cs` files, update the connection string to match your SQL Server setup. Modify the `Data Source`, `Integrated Security`, and `Initial Catalog` values according to your SQL Server configuration.
4. Run the database scripts: Execute the SQL scripts provided in the project to create the necessary database and tables. You can find the scripts in the `DatabaseScripts` folder.
5. Build and run the project: Use the IDE's build and run functionality or run `dotnet run` command in the project's root directory.

## Usage

1. Open a web browser and navigate to `[http://localhost:5000/](https://localhost:7286/UserEnroll/Index)` to access the login page (`Index.cshtml`).
2. Register a new user: Click on the "Register" link on the login page and provide the required information.
3. Log in: Enter the registered email and password to log in.
4. Welcome page: After successful login, you will be redirected to the welcome page (`Welcome.cshtml`), which displays your enrollment details.
5. Log out: To log out, click on the "LOG ME OUT" button on the welcome page.


## Screenshots of project's run

1- Login Photo: The login photo depicts the login page of the authentication system. It showcases a clean and user-friendly interface with a form where users can enter their credentials to access their accounts. The photo may feature a login form with fields for email and password, along with a login button. The image aims to convey a sense of security, trust, and simplicity, encouraging users to log in and access their personalized dashboard.
<img src="" width=100%> 

2- Register Photo: The register photo showcases the registration page of the authentication system. It highlights the process of creating a new account by capturing the essence of a user-friendly and intuitive registration form. The image may depict fields for personal information such as name, email, password, and additional details like gender and phone number. The register photo aims to inspire users to create an account by highlighting the simplicity and convenience of the registration process.
<img src="" width=100%> 

3- Dashboard Photo: The dashboard photo represents the personalized user dashboard in the authentication system. It portrays an overview of the user's account information, settings, and activities. The photo may display a visually appealing and organized interface, providing a glimpse of various features such as profile details, account settings, access to resources or services, and recent activity or notifications. The dashboard photo aims to convey a sense of control, efficiency, and convenience, illustrating the benefits of using the authentication system.
<img src="" width=100%> 


# Watch the Video



# To contact Developer:
## [LinkedIn](https://www.linkedin.com/in/doaa-sayed-ibrahim-08a77a209) 
