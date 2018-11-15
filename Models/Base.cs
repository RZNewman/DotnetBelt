using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ent.Models
{
    public class TimeStampedModel
    {



        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }



    }
        #region Login
    public class User : TimeStampedModel
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Name can only contain Letters")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Name can only contain Letters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[@#\$%\^&\*\-=\+\?!]).*", ErrorMessage = "Password requires a letter, number, and special character")]
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public List<Atendee> Attending{get;set;}
        public List<Event> Hosting{get;set;}
    }
    public class loginObj
    {
        [Required]
        [EmailAddress]
        [MaxLength(120)]
        public string Email { get; set; }
        [Required]
        [MaxLength(45)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    #endregion
    public class Event : TimeStampedModel
    {
        [Key]
        public int EventId{get;set;}
        [Required]
        [MinLength(2)]
        public string Title{get;set;}

        [Required]
        [Future]
        public DateTime Start { get; set; }

        [NotMapped]
        public DateTime End{get{
            DateTime e = Start;
            switch((TimeType)Type){
                case TimeType.Days:  
                    return e.AddDays(Durration);
                case TimeType.Hours:   
                    return  e.AddHours(Durration);
                case TimeType.Minutes:
                    return  e.AddMinutes(Durration);
                default:
                    return e;
            }
            
        }}

        [Required]
        [Range(1,int.MaxValue)]
        public int Durration{get; set;}

        [Required]
        public TimeType Type {get; set;}

        public enum TimeType{
            Days,
            Hours,
            Minutes
        }

        [Required]
        [MinLength(10)]
        public string Description{get;set;}

        public int UserId {get;set;}
        public User Creator{get; set;}

        public List<Atendee> Guests{get;set;}

    }
    public class Atendee{
        [Key]
        public int RSVPId{get;set;}

        public int UserId{get;set;}
        public User User{get; set;}

        public int EventId{get;set;}
        public Event Event{get; set;}
    }
    public class FutureAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime v = (DateTime)value;
            if (v<DateTime.Now)
                return new ValidationResult("Date must be in the future");
            return ValidationResult.Success;
        }
    }
   
}