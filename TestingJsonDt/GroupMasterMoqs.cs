using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingJsonDt
{
    public class GroupMasterMoqs
    {
        public IEnumerable<GroupMaster> GetAll()
        {
            yield return new GroupMaster
            {
                Id = 1,
                Name = "Voltage and Temperature",
                JsonDtAsString = "[{\"Environemt\":\"Nominal\", \"Voltage\":3.5, \"Temperature\":25}," +
                                  "{\"Environemt\":\"Extreme\", \"Voltage\":4.2, \"Temperature\":80}]"
            };
        }
    }
}
