using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Web;
using TrashCollectorRemade.Models;

namespace TrashCollectorRemade
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string SpecialOneTimePickUp { get; set; }
        public string PickupDay { get; set; }
        public bool PickUpStatus { get; set; }
        public double Balance { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
       

    }
}
 //{
        //    get { return SpecialOneTimePickUp; }
        //    set
        //    {
             
        //        if (SpecialOneTimePickUp == null)
        //        {
        //            SpecialOneTimePickUp = value;
        //            Balance += 30;
        //        }
        //        else if (SpecialOneTimePickUp != null)
        //        {
        //            SpecialOneTimePickUp = SpecialOneTimePickUp;
        //        }
                
        //    }
        //}