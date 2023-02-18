﻿using Microsoft.EntityFrameworkCore;
using ModelValidasyonu.DbOperations;
using ModelValidasyonu.Models;
using ModelValidasyonu.ViewModels.BookViewModels;

namespace ModelValidasyonu.BookOperations.UpdateBook.UpdateBookWithPatch
{
    public class UpdateBookWithPatchCommand
    {
        public UpdateBookWithPatchViewModel Model { get; set; }
        public int BookId { get; set; }

        private readonly BookStoreDbContext _dbContext;

        public UpdateBookWithPatchCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            Book? book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);

            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı");

            if (Model.Title != default)
                book.Title = Model.Title;
            if (Model.GenreId != default)
                book.GenreId = Model.GenreId;
            if (Model.PageCount != default)
                book.PageCount = Model.PageCount;
            if (Model.PublishDate != default)
                book.PublishDate = Model.PublishDate;

            _dbContext.SaveChanges();
        }
    }
}
