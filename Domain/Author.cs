﻿using Art_exhibition.Repository;
namespace Art_exhibition.Domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}