using AngularTechnicalTrainingApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Dto
{
    public class AssetDTO
    {
        public int TagID { get; set; }
        public int AssetTypeID { get; set; }
        public AssetType AssetType { get; set; }

        public string Description { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public DateTime DateAdded { get; set; }

        public bool Retired { get; set; }

        public DateTime? DateRetired { get; set; }
    }
}
