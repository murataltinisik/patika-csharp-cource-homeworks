# Pratik - Patika Kütüphane

This repository provides a simple example of object-oriented programming (OOP) in C#. The program defines a `Book` class with several properties and methods to manage and display book details.

## Class Structure

### `Book` Class

- **Properties**:
  - `int PageSize`: The number of pages in the book.
  - `string BookName`: The name of the book.
  - `string Publisher`: The publisher of the book.
  - `string AuthorName`: The first name of the book's author.
  - `string AuthorSurname`: The last name of the book's author.
  - `DateTime CreatedAt`: The date when the book was created (defaults to the current date).

- **Constructors**:
  - `Book()`: An empty constructor, allows creating a book object without initializing the properties.
  - `Book(int pageSize, string bookName, string publisher, string authorName, string authorSurname)`: Initializes a new `Book` object with the provided parameters, and automatically sets the `CreatedAt` property to the current date.

- **Methods**:
  - `void GetBookDetail(Book book)`: Displays the details of the provided `Book` object in the following format:
    ```
    [AuthorName] [AuthorSurname] adlı yazarın, [PageSize] sayfalık kitabı. [Publisher] yayınevinden çıkan, [BookName] adlı kitabı [CreatedAt] tarihinde oluşturuldu.
    ```

## Usage

### Code Example

The following example demonstrates how to create multiple book objects and display their details:

```csharp
using OOP;

// Create Book 1
Book book1 = new Book(320, "Bir Kitap", "Alfa Yayınları", "Ahmet", "Yılmaz");
book1.GetBookDetail(book1);

// Create Book 2
Book book2 = new Book(215, "Başka Bir Kitap", "Beta Yayınları", "Ayşe", "Karan");
book2.GetBookDetail(book2);

// Create Book 3
Book book3 = new Book(450, "Daha Başka Kitap", "Gamma Yayınları", "Mehmet", "Demir");
book3.GetBookDetail(book3);

// Create Book 4
Book book4 = new Book(275, "Son Kitap", "Delta Yayınları", "Elif", "Şahin");
book4.GetBookDetail(book4);

// Create Book 5
Book book5 = new Book(198, "Örnek Kitap", "Epsilon Yayınları", "Selin", "Yurt");
book5.GetBookDetail(book5);
