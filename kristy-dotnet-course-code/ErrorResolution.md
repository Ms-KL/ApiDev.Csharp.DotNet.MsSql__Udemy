# Error Resolution

**Unable to load the service index for source**<br>
**Response status code does not indicate success: 401 (Unauthorized)**

* **Trigger:**
    * `dotnet new console -n HelloWorld`
    * `dotnet run`
* **Resolution:**
    * deselect the FintechAdapters Package in Nuget Package Manager
* **Udemy Nuget Troubleshooting**
    * See: https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/39280658#overview

---

**"A network-related or instance-specific error occurred..."**<br>

* **Trigger:**
    * something has happened during installation of SQL server that is stopping it from being accessible.
* **Resolution:**
    * see [Windows Connection Troubleshooting](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/38144014#announcements)




