using System;
using System.Collections.Generic;
using Edu.Framework.EF;
using Edu.Framework.EF.Base;

namespace Edu.Data.Domain
{
    /// <summary>
    /// [TblEmployee]
    /// </summary>
    [Serializable]
    public partial class TblEmployee: BaseEntity
    {
        /// <summary>
        /// [EmployeeId]
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// [FristName]
        /// </summary>
        public string FristName { get; set; }
        /// <summary>
        /// [LastName]
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// [Salary]
        /// </summary>
        public int Salary { get; set; }
    }
}
