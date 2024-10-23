﻿using DESAISIV_Task_Omar_Almahammed.DTOs;
using DESAISIV_Task_Omar_Almahammed.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DESAISIV_Task_Omar_Almahammed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class libraryController : ControllerBase
    {

        private readonly MyDbContext _db;

        public libraryController(MyDbContext db)
        {
            _db = db;
        }


        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            try
            {
                var allBooks = _db.Books.ToList();

                if (allBooks == null)
                {
                    return NotFound("No books available.");
                }

                return Ok(allBooks);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the books.");
            }
        }



        [HttpGet("GetBookDetails/{id}")]
        public IActionResult GetBookDetails(int id)
        {
            try
            {
                var bookDetails = _db.Books.Find(id);

                if (bookDetails == null)
                {

                    return NotFound("This book not exist!");
                }

                return Ok(bookDetails);
            }
            catch (Exception ex) {

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the books.");
            }
        }



        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] BookRequestDTO book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Book newBook = new Book()
                {
                    Title = book.Title,
                    Author = book.Author,
                    PublicationYear = book.PublicationYear,
                };

                _db.Books.Add(newBook);
                _db.SaveChanges();

                return CreatedAtAction(nameof(GetBookDetails), new { id = newBook.BookId }, newBook);
                }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the book.");
            }
        }


        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook([FromBody] BookRequestDTO book, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkBook = _db.Books.Find(id);

            if (checkBook == null)
            {
                return NotFound("This book not exist!");
            }

            checkBook.Title = book.Title;
            checkBook.Author = book.Author;
            checkBook.PublicationYear = book.PublicationYear;

            _db.Books.Update(checkBook);
            _db.SaveChanges();

            return Ok(checkBook);
        }


        [HttpDelete("DeleteBook/{id}")]

        public IActionResult DeleteBook(int id)
        {
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return NotFound("This book not exist!");
            }
            
            _db.Books.Remove(book);
            _db.SaveChanges();

            return Ok();
        }

    }
}