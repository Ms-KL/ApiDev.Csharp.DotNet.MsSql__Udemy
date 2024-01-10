# Error Resolution

## **Unable to load the service index for source**<br>
**Response status code does not indicate success: 401 (Unauthorized)**

* **Trigger:**
    * `dotnet new console -n HelloWorld`
    * `dotnet run`
* **Resolution:**
    * deselect the FintechAdapters Package in Nuget Package Manager
        * Visual Studio -> Tools -> Nuget Package Manager -> Package Manager Settings -> Nuget Package Manager -> Package Sources -> `Deselect FintechAdapters`
* **Udemy Nuget Troubleshooting**
    * See: https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/39280658#overview

---

## **Unauthorized {appVeyor Path}**<br>
**error: Failed to fetch results from V2 feed at {AppVeyor Path} <br> with following message : Response status code does not indicate success: 401 (Unauthorized).**
**error:   Response status code does not indicate success: 401 (Unauthorized).**

* **Trigger:**
    * `dotnet add package <nameofpackage>`
* **Resolution:**
    * deselect the AppVeyor Package in Nuget Package Manager
        * Visual Studio -> Tools -> Nuget Package Manager -> Package Manager Settings -> Nuget Package Manager -> Package Sources -> `Deselect AppVeyor`
---

## **"A network-related or instance-specific error occurred..."**<br>

* **Trigger:**
    * something has happened during installation of SQL server that is stopping it from being accessible.
* **Resolution:**
    * see [Windows Connection Troubleshooting](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/38144014#announcements)


---

## **Error converting data type varchar to numeric:**<br>

* **Resolution:**
    * see [Error converting data type varchar to numeric](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/36318546#content)

