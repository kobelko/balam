using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Balam.Models
{
    public class Settings
    {
        public int Id { get; set; }

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
