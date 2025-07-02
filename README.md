# InteractiveGraphicalApp

**InteractiveGraphicalApp** is a desktop application built with C# and Windows Forms. It was designed to interactively visualize graphical algorithms such as rasterization, filling, clipping, and curve generation. The project follows a modular and layered architecture to promote clarity, scalability, and maintainability.

## Main Features

* Step-by-step visualization of core computer graphics algorithms (e.g., Bezier curves, Sutherland-Hodgman clipping, rasterization).
* Layered architecture:

  * `Core`: Contains the main logic and graphical algorithms.
  * `Infraestructure`: Support classes for rendering and utility functions.
  * `Presentation`: UI forms and user interaction logic.
  * `Resources`: Icons, images, and graphical assets.
  * `guidance`: Visual or textual guides embedded in the app.
* Configuration via `App.config`.
* Integration with external libraries like FontAwesome and Tulpep Notifications.

## Requirements

* Visual Studio 2022 or higher
* .NET Framework
* NuGet packages defined in `packages.config`

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/your-user/InteractiveGraphicalApp.git
   ```

2. Open the solution file `InteractiveGraphicalApp.sln` in Visual Studio.

3. Restore NuGet packages.

4. Build the solution (`Ctrl+Shift+B`).

## Usage

* When launched, a splash screen is displayed, followed by the main interactive form.
* Use the interface to create points, draw shapes, or apply algorithms like Sutherland–Hodgman clipping.
* You can save canvas results as PNG, JPG, or BMP.

## Contributing

Feel free to contribute! You can fork the repository and submit a pull request, or open an issue with suggestions or bug reports.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more information.

---

Developed as part of a computer graphics interactive tool using C#. Its layered and modular design encourages object-oriented best practices.
