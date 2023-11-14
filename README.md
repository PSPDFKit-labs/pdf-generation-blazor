## Blazor PDF Generation with PDFsharp

This repository contains a Blazor Server application demonstrating how to generate PDF documents using the [PDFsharp](https://docs.pdfsharp.net/PDFsharp/Overview/About.html) library. It showcases basic PDF creation, including drawing text and graphics, and offers a user interface for downloading the generated PDF.

Check out the accompanying [blog post](https://pspdfkit.com/blog/2023/how-to-generate-a-pdf-in-blazor).

## Features

- Basic PDF generation with PDFsharp.
- Drawing lines, shapes, and text in a PDF.
- Implementing a download function in a Blazor Server application.
- Example of JavaScript interop in Blazor.

## Getting Started

### Prerequisites

- .NET 7.0 SDK or later
- Visual Studio 2022 or a compatible IDE

### Installation

1. Clone the repository:

```bash
git clone https://github.com/PSPDFKit-labs/pdf-generation-blazor.git
```

2. Navigate to the project directory:

```bash
cd pdf-generation-blazor
```

3. [Restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore) the project dependencies:

```bash
dotnet restore
```

4. Run the application:

```bash
dotnet run
```

## Usage

After running the application, navigate to https://localhost:5036 (or the appropriate URL). Click the 'Download PDF' button to generate and download a sample PDF.


## Contributing

Contributions to this project are welcome! Please feel free to fork the repository and submit pull requests.
Please ensure
[you have signed our CLA](https://pspdfkit.com/guides/web/current/miscellaneous/contributing/) so that we can
accept your contributions.
