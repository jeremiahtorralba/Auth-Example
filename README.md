# Auth-Example ### [Register](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#register-using-email)| [Password Validation](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#register-password-validation)| [Landing page](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#registerlogin-landing-page)
| [Account](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#account-management)| [Change password](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#changing-account-password)| [Password change confirmed](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#account-password-changed)| [Web.config](https://github.com/jeremiahtorralba/Auth-Example/blob/main/README.md#webconfig-lines-11-13-connectionstring---add-mdf-and-initial-catalog-names)
ASP.NET Account registration - Email

### Register using Email
![register](https://user-images.githubusercontent.com/28037427/218297920-61968cc3-741b-4fa7-86f7-85c2c8440e50.jpg)

### Register password validation
![register password error handling](https://user-images.githubusercontent.com/28037427/218297925-1a81e607-fa6f-4f3e-a39e-a83987b19051.jpg)

### Register/Login landing page
![account landing page](https://user-images.githubusercontent.com/28037427/218297934-372c2136-bf3d-4c3a-872e-127b62940e43.jpg)

### Account management
![manage account](https://user-images.githubusercontent.com/28037427/218297942-81559d48-5fa4-420a-858b-1738fc173a9a.jpg)

### Changing account password
![manage account - change password](https://user-images.githubusercontent.com/28037427/218297949-eb410752-4543-4a59-a7e0-7f7baed0c2b2.jpg)

### Account password changed
![manage account - changed password](https://user-images.githubusercontent.com/28037427/218297953-8c5df877-1541-4a19-8647-f599e850674b.jpg)

### Web.config, lines 11-13, connectionString - add .mdf and Initial Catalog names.
```
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\.MDF FILE NAME HERE .mdf;Initial Catalog=INITIAL CATALOG HERE;Integrated Security=True" providerName="System.Data.SqlClient"/>
</connectionStrings>
```
