﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafNwindQuery.Module.BusinessObjects.Northwind
{

    [NonPersistent]
    public partial class EmployeeSalesbyCountryResult
    {
        public string Country { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal SaleAmount { get; set; }
    }

}
