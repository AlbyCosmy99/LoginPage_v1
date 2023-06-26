﻿using loginPage_v1.Models;
using System;

namespace loginPage_v1.Dto.UsersBookDto
{
    public class FullUsersBookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } = null;
        public string BookLanguage { get; set; } = null;
        public int? PublicationYear { get; set; } = null;
        public int? Pages { get; set; } = null;
        public string Genre { get; set; } = null;
        public DateTime? FinishingDate { get; set; } = null;
        public string Price { get; set; } = null;
        public string PersonalRating { get; set; } = null;
        public string Notes { get; set; } = null;
    }
}