//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumeAPI_SUN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SignUpTB
    {
        public int id { get; set; }
        [Required(ErrorMessage ="UserName is Required")]
        [Display(Name ="Enter UserName")]
        public string username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [Display(Name ="Enter Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}