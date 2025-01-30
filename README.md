# UdemyCarBook

Recently, I developed a multi-layered architecture project using ASP.NET Core 8 following the principles of Onion Architecture. My goal was to build a scalable, maintainable, and cleanly structured application by applying Clean Code, SOLID principles, and modern development techniques.

🎯 Project Architecture
The project is structured into four main layers, ensuring a modular and well-organized system:

🔹 Core Layer: The foundation of the application.
      📌 Domain: Contains all the entity models.
      📌 Application: Includes DTOs, Enums, Features (CQRS), Interfaces, Services, Validators, Tools, and ViewModels.

🔹 Frontends Layer: Responsible for handling the UI and data transfer objects.
      📌 DTO: Stores all Data Transfer Objects (DTOs).
      📌 WebUI: Houses MVC controllers, views, ViewComponents, and HTML/CSS/JavaScript assets.

🔹 Infrastructure Layer: Manages database operations and persistence.
      📌 Persistence: Includes Entity Framework Core, DbContext configuration, Migrations, and Repository Pattern implementation.

🔹 Presentation Layer: Exposes APIs and acts as the entry point of the application.

With this architecture, I aimed to create a loosely coupled and highly scalable application.

![Main Page](https://github.com/user-attachments/assets/21d4c8d9-5b66-4769-9ea5-2f4d20b3de1f)

🔥 Technologies & Design Patterns Used
During the development process, I incorporated various modern technologies and best practices, including:

✅ `ASP.NET Core 8 (MVC & API)`
✅ `Entity Framework Core for database management (Code-First approach)`
✅ `FluentValidation for robust input validation`
✅ `JWT (Json Web Token) for authentication & authorization`
✅ `CQRS and Mediator Pattern for separating query and command operations`
✅ `SignalR for real-time communication`
✅ `Pivot Table implementation for complex data relationships`
✅ `Repository Pattern & Unit of Work for structured data access`
✅ `Extension Methods to enhance code readability and reusability`
✅ `Dependency Injection to maintain a modular architecture`

![Ekran görüntüsü 2025-01-30 090754](https://github.com/user-attachments/assets/64ecef1c-8e56-4882-b826-fd5c3448e056)

🚀 Key Takeaways & Learnings
This project not only helped me reinforce my existing skills but also gave me the opportunity to explore new technologies and architectural patterns:

🔹 Enhanced my expertise in SignalR, making real-time communication more efficient.
🔹 Applied CQRS & Mediator Pattern to improve code maintainability and separation of concerns.
🔹 Experimented with multiple design patterns, enhancing the flexibility and scalability of the application.
🔹 Followed Clean Code & SOLID principles to ensure high code quality and maintainability.
![Ekran görüntüsü 2025-01-30 090808](https://github.com/user-attachments/assets/e975416b-bf81-4578-9b28-4997d6dc0be8)
![Ekran görüntüsü 2025-01-30 090837](https://github.com/user-attachments/assets/db186238-c920-4c74-ad3c-abfbd725d963)
![Ekran görüntüsü 2025-01-30 090925](https://github.com/user-attachments/assets/0903b5b9-2a30-44a7-8a13-e0f412f615e4)
![Ekran görüntüsü 2025-01-30 093144](https://github.com/user-attachments/assets/7e173657-244e-4503-9ac5-bd38326475df)



