//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin_Tekbot.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Team"), DisplayName("User Email"), EmailAddress(ErrorMessage = "Invalid Format.")]
        public string mail { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Complete this Field"), DisplayName("User Name"), StringLength(55, ErrorMessage = "The string is too long."), RegularExpression("([A-Za-z])+( [A-Za-z]+)*", ErrorMessage = "Invalid Format.")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Team"), DisplayName("Team")]
        public Nullable<int> TeamId { get; set; }
        [DisplayName("Last Review")]
        public Nullable<System.DateTime> Last_Review { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Status"), DisplayName("Status")]
        public string Users_Status { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Position"), DisplayName("Position")]
        public string Users_positions { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Team"), DisplayName("Vacations")]
        public Nullable<int> Users_vacations { get; set; }
        public int User_Number { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select a Team"), System.ComponentModel.DisplayName("Team")]
        public virtual Team Team { get; set; }
    }
}
