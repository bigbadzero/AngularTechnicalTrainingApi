using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Domain.Models
{
    public class Asset
    {
        [Key]
        public int TagID { get; set; }

        [ForeignKey(nameof(AssetType))]
        public int AssetTypeID { get; set; }
        public AssetType AssetType { get; set; }

        public string Description { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public DateTime DateAdded { get; set; }

        public bool Retired { get; set; }

        public DateTime? DateRetired { get; set; }
    }
}
