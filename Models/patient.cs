//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinic_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class patient
    {

        [Display(Name = "Id")]
        public int patient_id { get; set; }
        [Display(Name = "Name")] 
        public string patient_name { get; set; }
        [Display(Name = "Age")]
        public Nullable<int> patient_age { get; set; }
        [Display(Name = "Appointment Date")]
       
        public System.DateTime patient_visit_date { get; set; }
        [Display(Name = "Symptons")] 
        public string patient_symptoms { get; set; }
        [Display(Name = "Medicines")] 
        public string patient_medicine { get; set; }
    }
}
