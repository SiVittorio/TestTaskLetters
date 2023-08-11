using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLetters.Models
{
    /// <summary>
    /// Класс информации о выбранном фильтре
    /// </summary>
    public class FilterInfo
    {
        public FilterInfo(string filterName = "", SqlDateTime? beginDate = null, SqlDateTime? endDate = null, int? deliveryMethodId = null, int? organizationId = null)
        {
            FilterName = filterName;
            BeginDate = beginDate;
            EndDate = endDate;
            DeliveryMethodId = deliveryMethodId;
            OrganizationId = organizationId;
        }

        public string FilterName { get; set; }
        public SqlDateTime? BeginDate { get; set; }
        public SqlDateTime? EndDate { get; set;}
        public int? DeliveryMethodId { get; set; }
        public int? OrganizationId { get; set; }
    }
}
