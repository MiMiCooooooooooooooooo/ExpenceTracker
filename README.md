# 💰 ExpenseTracker

## 📖 Description

**ExpenseTracker** is a powerful web application designed to help you effectively track your expenses and income. With features like wallet management, expense categorization, and secure transfers, managing your finances has never been easier! 🌟

## 🌟 Key Features

- **Expense and Income Tracking**: Easily add and view your expenses and income.
- **Wallet Creation**: Create and manage multiple wallets for different purposes.
- **Expense Categorization**: Assign categories to your expenses for better financial insights.
- **Transfers Between Wallets**: Perform seamless transfers between different wallets. 🔄
- **Authentication and Authorization**: Secure your application with robust authentication and authorization mechanisms. 🔐
- **Email Notifications**: Receive notifications via email for important actions and updates. 📧
- **Email Confirmation:** Confirm user email addresses for added security and account verification. 📩
- **File Management:** Upload, store, and manage files related to your transactions and accounts. 📂

## ⚙️ Technologies Used

- **Frontend**: HTML, CSS, JavaScript, Bootstrap, Syncfusion
- **Backend**: ASP.NET Core MVC
- **Database**: Microsoft SQL Server (MS SQL)
- **ORM**: Entity Framework Core

## 🚀 Installation

To set up the project locally, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your_username/ExpenseTracker.git
2. **Navigate to the project folder:**
   ```bash
   cd ExpenseTracker
3. **Install the necessary dependencies:**
   ```bash
   # Run this command inside the project folder:
   dotnet restore
4. **Set up the database:**
   ```bash
   # Replace "YourSecurePassword", "your-email@gmail.com", "your-secure-app-password", and "YourSyncfusionLicenseKeyHere" with the actual values only in your development or production environment.
   {
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*",
     "ConnectionStrings": {
       "ExpenseTrackerDbContextConnection": "Server=localhost; Database=ExpenseTracker; User Id=sa; Password=YourSecurePassword; TrustServerCertificate=True;"
     },
     "MailSettings": {
       "From": "your-email@gmail.com",
       "SmtpServer": "smtp.gmail.com",
       "Port": 465,
       "Username": "your-email@gmail.com",
       "Password": "your-secure-app-password"
     },
     "SyncfusionKey": "YourSyncfusionLicenseKeyHere"
   }

5. **Run the application:**
   ```bash
   dotnet run
## 🛠️ Usage

1. **Register or Log In to start managing your finances.**
2. **Confirm Your Email to secure and verify your account. 📩**
3. **Create Wallets to organize your money for different goals.**
4. **Add Income and Expenses with categories for better insights.**
5. **Transfer Between Wallets for easy, organized finances.**
6. **Receive Email Notifications for important actions and updates! 🎉**

## 🤝 Contributing

Contributions are welcome! If you would like to contribute to this project, please follow these steps:
1. **Fork the repository.**
   ```bash
   git clone https://github.com/your_username/ExpenseTracker.git
2. **Create a new branch for your feature or bug fix:**
   ```bash
   git checkout -b feature/YourFeature
3. **Make your changes and commit them:**
   ```bash
   git commit -m "Add your message here"
4. **Push your changes to your forked repository:**
   ```bash
   git push origin feature/YourFeature
4. **Create a pull request.**

## 📝 License
This project is licensed under the MIT License.
