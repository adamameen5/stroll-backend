# Stroll Technical Assessment - Backend

This repository contains the backend API for the Stroll Technical Assessment, developed by Adam Ameen. The backend is written in C#.

## Please make sure you have already cloned the stroll-ui project and completed step 3 before doing any of the below. Link to stroll-ui project : [Stroll UI Repository](https://github.com/adamameen5/stroll-ui)

## Setup and Running the Backend API

Follow these steps to set up and run the backend API:

1. **Download and Extract**  
   - Download the zip file of this repository.  
   - Extract the downloaded file to your desired location.

2. **Open the Project**  
   - Open the `.sln` file in Visual Studio.  
   - This will load the entire backend codebase written in C#.

3. **Run the Application**  
   - Run the application in Visual Studio without making any code changes.  
   - This will launch a Swagger page in your browser.

4. **Obtain the API URL**  
   - Copy the URL of the Swagger page, which will look something like:  
     ```
     https://localhost:44322/swagger/index.html
     ```
   - The base API URL will be the root of this URL, for example:  
     ```
     https://localhost:44322
     ```

5. **Configure the Frontend**  
   - Keep the backend API project running.  
   - Navigate to the frontend project and update the `API_BASE_URL` in the `api.js` file with the API URL obtained from the Swagger page.  
   - Set the `API_BASE_URL` as follows:  
     ```javascript
     export const API_BASE_URL = "https://localhost:44322/api";
     ```

## Notes
- Ensure the backend API is running before starting the frontend application.  
- The Swagger page provides documentation for the API endpoints, which can be used for testing and integration with the frontend.  
- If you encounter issues, verify that the API URL is correct and the backend server is running.

For any questions or issues, feel free to contact Adam Ameen.

## ⌚ What could have been done with a bit more time 

Right now, the API is simple — just three controllers and some mocked data. If I had a few more hours, I would make it a little more structured and easier to manage, like this:

1. Split the code into layers, like:
   - Have controllers to handle API request
   - Have a business layer to handle extra logic like validation and stuff
   - Database layer - for storing and retrieving data
   This keeps the code tidy and follows best practices.

2. Create a class library for Models. I will move the data models like Prescription, SessionResult and Patient into a seperate class library. This will help these models to be used across different services.

3. Add support for pagination for data like session results and prescriptions.

4. Even though it's mocked data now, I will structure the code in a way it's easy to incorporate a real database later like SQL Server using SQL Dapper.

So with a few more hours, I will just focus on organizing the code better which follows a clean architecture which will allow me to extend the features and also maintain the code easily.
