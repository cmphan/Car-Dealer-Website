using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Dealer_Website.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature 
    {
        public int VehicleId {get ;set;}
        public int FeatureId {get;set;}
        public Vehicle Vehicle {get;set;}
        public Feature Feature {get; set;}
    }
}