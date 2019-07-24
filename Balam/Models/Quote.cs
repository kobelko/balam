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
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Client { get; set; }

        public string Destination { get; set; }

        public string State { get; set; }

        [Range(0, 15)]
        public int Days { get; set; }

        [Range(0, 3000)]
        public double Distance { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Toll { get; set; }

        public bool GasolineIncluded { get; set; }

        public bool DriverIncluded { get; set; }

        [Range(0, 15)]
        public int ProvisioningDays { get; set; }

        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ApportionDays { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CalculatedCost { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CalculatedPrice { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal FinalPrice { get; set; }

        [Column(TypeName = "decimal(6,3)")]
        [DisplayFormat(DataFormatString = "{0:P1}")]
        public decimal Profit { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal CompetitionPrice { get; set; }

        public string Description { get; set; }



        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DriverWage { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DriverTravelExpenses { get; set; }

        public int Passengers { get; set; }

        [Column(TypeName = "decimal(6,3)")]
        [DisplayFormat(DataFormatString = "{0:P1}")]
        public decimal TargetProfit { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Provisioning { get; set; }

        public float DaysPerMonth { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Cleaning { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Maintenance { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Taxes { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Parking { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Fund { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Instalment { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PhoneLine { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal GasPrice { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,6)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal OtherCosts { get; set; }

        [Range(0, 40)]
        public float GasMileage { get; set; }
    }
}
