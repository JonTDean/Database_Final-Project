namespace  sqllfs{
    public class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set;}
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? SupportRepId { get; set; }
    }
}


        // public int Id { get; set; }
        // public string Name { get; set; }
        // public int? AlbumId { get; set; }
        // public int MediaTypeId { get; set; } // CANNOT BE NULL
        // public int? GenreId { get; set; }    // CAN BE NULL
        // public string Composer { get; set; }
        // public int Milliseconds { get; set; }
        // public int? Bytes { get; set; }
        // public int UnitPrice { get; set; }

        // public string