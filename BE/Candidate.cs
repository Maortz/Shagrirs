//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public Candidate()
        {
            this.Shagrirs = new HashSet<Shagrir>();
            this.Sharings = new HashSet<Sharing>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public string Ethnical { get; set; }
        public string Address { get; set; }
        public string HighSchool { get; set; }
        public string Service { get; set; }
        public string Employment { get; set; }
        public string Phone { get; set; }
        public string Info { get; set; }
        public string ThirdParty { get; set; }
        public string Sector { get; set; }
        public string Hobbies { get; set; }
        public string LookingNature { get; set; }
        public string LookingAppearance { get; set; }
        public string AgeRange { get; set; }
        public string More { get; set; }
        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public bool IsDating { get; set; }
    
        public virtual ICollection<Shagrir> Shagrirs { get; set; }
        public virtual ICollection<Sharing> Sharings { get; set; }
    }
}
