﻿using static System.Net.Mime.MediaTypeNames;
using System;
 

namespace LuvFinder_ViewModels
{
    public class UserProfileQuestion
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int QuestionID { get; set; }
        public int AnswerID { get; set; }
        public string AnswerText { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool Selected { get; set; }

    }
}
