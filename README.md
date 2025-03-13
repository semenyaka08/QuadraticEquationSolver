# Quadratic Equation Solver

This project is a basic solver for quadratic equations of the form ax^2 + bx + c = 0. The program takes three coefficients — a, b, and c — and calculates the roots. It supports two modes of operation:

1. **Interactive Mode**: The user inputs the coefficients directly through the console.
2. **File Mode**: The user specifies a file path containing the coefficients.

## Installation

Make sure you have [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.

1. Clone the repository:
    ```bash
    https://github.com/semenyaka08/quadratic-equation-solver.git
    ```

2. Navigate to the directory where the .csproj file is located::
    ```bash
    cd QuadraticEquationSolver
    ```

3. Build the project:
    ```bash
    dotnet build
    ```

## How to Use

Before running the program, ensure you are in the project directory.

<span id="interactive-mode"></span>
### Interactive Mode

If no command-line arguments are specified, the program will launch in interactive mode. You will be prompted to enter the coefficient values one by one through the console.

To start the program in interactive mode, execute:

```bash
dotnet run
```

### File Mode

To use the coefficients stored in a specific file, you need to pass the file path as the first command-line argument when running the program via the console.

To run the program in file mode, use the following command:

```bash
dotnet run <file-path>
```

## File Format

The file should have the coefficients in the following format:

| Example            | Format              |
|--------------------|---------------------|
| `3 -7.2 8.1`      | `3\s-7.2\s8.1\n`     |
| `-5 12.6 0`       | `-5\s12.6\s0\r\n`    |

## Revert Commit

1. **Revert "Create README.md"**

Revert commit has the hash `b127bea`, and it can be found at the following [link](https://github.com/semenyaka08/quadratic-equation-solver/commit/b127bea11622cb339e182fe029dce664e35abc6a).
