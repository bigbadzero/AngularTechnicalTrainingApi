using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTrainingApi.Dto
{
    public class AssetDialogOptionsDTO
    {
        public IList<AssetTypeDTO> AssetTypes { get; set; }
        public IList<EmployeeDTO> Employees { get; set; }
    }
}
