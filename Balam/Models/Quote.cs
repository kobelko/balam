using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Balam.Models
{
    public class Quote
    {
        [Display(Name ="Id")]
        public int Id { get; set; }

        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Client")]
        public string Client { get; set; }

        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Days")]
        [Range(0, 15)]
        public int Days { get; set; }

        [Display(Name = "Distance")]
        [Range(0, 3000)]
        public double Distance { get; set; }

        [Display(Name = "Toll")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Toll { get; set; }

        [Display(Name = "Gasoline")]
        public bool GasolineIncluded { get; set; }

        [Display(Name = "Driver")]
        public bool DriverIncluded { get; set; }

        [Display(Name = "Provisioning Days")]
        [Range(0, 15)]
        public int ProvisioningDays { get; set; }

        [Display(Name = "Apportion Days")]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ApportionDays { get; set; }

        [Display(Name = "Calculated Cost")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CalculatedCost { get; set; }

        [Display(Name = "Calculated Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CalculatedPrice { get; set; }

        [Display(Name = "Final Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal FinalPrice { get; set; }

        [Display(Name = "Profit")]
        [Column(TypeName = "decimal(6,3)")]
        [DisplayFormat(DataFormatString = "{0:P1}")]
        public decimal Profit { get; set; }

        [Display(Name = "Competition Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CompetitionPrice { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Driver Wage")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DriverWage { get; set; }

        [Display(Name = "Driver Travel Expenses")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DriverTravelExpenses { get; set; }

        [Display(Name = "Passengers")]
        [Range(1,15)]
        public int Passengers { get; set; }

        [Display(Name = "Target Profit")]
        [Column(TypeName = "decimal(6,3)")]
        [DisplayFormat(DataFormatString = "{0:P1}")]
        public decimal TargetProfit { get; set; }

        [Display(Name = "Provisioning")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Provisioning { get; set; }

        [Display(Name = "Days Per Month")]
        public float DaysPerMonth { get; set; }

        [Display(Name = "Cleaning")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Cleaning { get; set; }

        [Display(Name = "Maintenance")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Maintenance { get; set; }

        [Display(Name = "Taxes")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Taxes { get; set; }

        [Display(Name = "Parking")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Parking { get; set; }

        [Display(Name = "Fund")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Fund { get; set; }

        [Display(Name = "Instalment")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Instalment { get; set; }

        [Display(Name = "Phone Line")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PhoneLine { get; set; }

        [Display(Name = "Gas Price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal GasPrice { get; set; }

        [Display(Name = "Other Costs")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal OtherCosts { get; set; }

        [Display(Name = "Gas Mileage")]
        [Range(0, 40)]
        public float GasMileage { get; set; }
    }
}
