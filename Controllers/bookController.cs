using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly DbContext _context;

    public BooksController(DbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllBooks()
    {
    // Retrieve all books from the database
        try{
        var books = _context.Books.ToList();
        return Ok(books); 
        }catch (Exception ex)
        {
            // log the exception or handle it as needed
            return StatusCode(500, "An error occurred while retrieving books. ");
        
        }  
    } 

    }

    [HttpGet("{id}")]
    public IActionResult GetBook(int id){
        // Retrieve the book with the given id from the database
        // Return the book as a response
        try{
            var book = _context.Books.FirstOrDefault(book => book.Id == id);

            if(book == null){
                return NotFound();
            }
            return Ok(book);
         }catch (Exception ex){
            // log the exception or handle it as needed
            return StatusCode(500, "An error occurred while retrieving books. ");
        
        }  
    }

    [HttpPost]
    public IActionResult CreateBook(BookDTO bookDto){
        // Validate the bookDto object and perform input validation
        // Map the bookDto to a Book entity
        // Add the book entity to the database
        // Return the created book as a response
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, BookDTO bookDto){
        // Validate the bookDto object and perform input validation
        // Retrieve the book with the given id from the database
        // Update the book entity with the new data from the bookDto
        // Save the changes to the database
        // Return the updated book as a response
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id){
        // Retrieve the book with the given id from the database
        // Remove the book entity from the database
        // Return a success response
    }

