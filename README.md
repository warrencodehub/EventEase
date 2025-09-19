# EventEase

EventEase is a modern event management web application built with Blazor WebAssembly. The application provides an intuitive interface for managing events, registrations, and attendance tracking.

## Features

1. **Event Card Component**
   - Display event details with two-way data binding
   - Visual representation of event information
   - Quick access to registration

2. **Routing Functionality**
   - Seamless navigation between different pages
   - Event details view
   - Registration page

3. **Registration Form**
   - Input validation for user data
   - Form field error messages
   - Terms and conditions acceptance

4. **State Management**
   - User session tracking
   - Registration status persistence
   - Event attendance management

5. **Attendance Tracker**
   - Real-time attendance monitoring
   - Visual progress bar
   - Capacity status indicators

## Getting Started

1. Clone the repository:
   ```
   git clone https://github.com/warrencodehub/EventEase.git
   ```

2. Navigate to the project directory:
   ```
   cd EventEase
   ```

3. Restore dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## Project Structure

- `Components/` - Reusable Blazor components
  - `EventCard.razor` - Event display component
  - `AttendanceTracker.razor` - Attendance tracking component

- `Models/` - Data models
  - `Event.cs` - Event data structure
  - `RegistrationModel.cs` - Registration form model

- `Pages/` - Application pages
  - `Index.razor` - Events listing
  - `EventDetails.razor` - Event details view
  - `Registration.razor` - Registration form

- `Services/` - Business logic and state management
  - `StateContainer.cs` - Application state management

## Development Process with GitHub Copilot

GitHub Copilot was instrumental in developing this project:

1. **Component Generation**
   - Copilot helped generate the foundational Event Card component with proper two-way data binding
   - Suggested appropriate component structure and properties

2. **Routing Implementation**
   - Assisted in setting up navigation parameters and routing logic
   - Provided guidance on best practices for Blazor routing

3. **Form Validation**
   - Generated data annotations for input validation
   - Implemented client-side validation logic
   - Suggested error handling patterns

4. **State Management**
   - Helped create a robust state management solution
   - Implemented session tracking and data persistence
   - Suggested patterns for component communication

5. **Performance Optimization**
   - Provided input validation optimizations
   - Suggested efficient state update patterns
   - Helped implement proper component lifecycle methods

## Contributing

If you'd like to contribute to the project, please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License - see the LICENSE file for details.