using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Mileage { get; set; }
        public string VinNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeID { get; set; }
        public Branch Branch { get; set; }
        public int BranchID { get; set; }
        public Status Status { get; set; }
        public int StatusID { get; set; }

    }

  
}
