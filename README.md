## 🚀 Getting Started with the Backend

Follow the steps below to run the backend and connect it to the frontend:

### 🛠️ Setup Instructions

1. **Download & Extract**
   - Download the ZIP file of this repository.
   - Extract the downloaded file to your computer.

2. **Open in Visual Studio**
   - Open the `.sln` file using **Visual Studio**.
   - This will load the complete backend project written in **C# .NET**.

3. **Run the Application**
   - Run the project **without making any code changes**.
   - After running, it will open the **Swagger UI** in your browser.

4. **Get the API URL**
   - You will see a Swagger page URL like:
     ```
     https://localhost:44322/swagger/index.html
     ```
   - From this, your API base URL will be:
     ```
     https://localhost:44322
     ```

---

## 🔗 Connecting Frontend to Backend

1. Open your **frontend project**.
2. Find the `api.js` file.
3. Update the `API_BASE_URL` with the URL you copied.

```javascript
export const API_BASE_URL = "https://localhost:44322/api";
