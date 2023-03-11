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

    public partial class Orders : XPLiteObject
    {
        int fOrderid;
        [Key(true)]
        [Persistent(@"OrderID")]
        public int Orderid
        {
            get { return fOrderid; }
            set { SetPropertyValue<int>(nameof(Orderid), ref fOrderid, value); }
        }
        Customers fCustomerid;
        [Size(5)]
        [Persistent(@"CustomerID")]
        [Association(@"OrdersReferencesCustomers")]
        public Customers Customerid
        {
            get { return fCustomerid; }
            set { SetPropertyValue<Customers>(nameof(Customerid), ref fCustomerid, value); }
        }
        Employees fEmployeeid;
        [Persistent(@"EmployeeID")]
        [Association(@"OrdersReferencesEmployees")]
        public Employees Employeeid
        {
            get { return fEmployeeid; }
            set { SetPropertyValue<Employees>(nameof(Employeeid), ref fEmployeeid, value); }
        }
        DateTime fOrderdate;
        [Indexed(Name = @"OrderDate")]
        [Persistent(@"OrderDate")]
        public DateTime Orderdate
        {
            get { return fOrderdate; }
            set { SetPropertyValue<DateTime>(nameof(Orderdate), ref fOrderdate, value); }
        }
        DateTime fRequireddate;
        [Persistent(@"RequiredDate")]
        public DateTime Requireddate
        {
            get { return fRequireddate; }
            set { SetPropertyValue<DateTime>(nameof(Requireddate), ref fRequireddate, value); }
        }
        DateTime fShippeddate;
        [Indexed(Name = @"ShippedDate")]
        [Persistent(@"ShippedDate")]
        public DateTime Shippeddate
        {
            get { return fShippeddate; }
            set { SetPropertyValue<DateTime>(nameof(Shippeddate), ref fShippeddate, value); }
        }
        Shippers fShipvia;
        [Persistent(@"ShipVia")]
        [Association(@"OrdersReferencesShippers")]
        public Shippers Shipvia
        {
            get { return fShipvia; }
            set { SetPropertyValue<Shippers>(nameof(Shipvia), ref fShipvia, value); }
        }
        decimal fFreight;
        [ColumnDbDefaultValue("((0))")]
        public decimal Freight
        {
            get { return fFreight; }
            set { SetPropertyValue<decimal>(nameof(Freight), ref fFreight, value); }
        }
        string fShipname;
        [Size(40)]
        [Persistent(@"ShipName")]
        public string Shipname
        {
            get { return fShipname; }
            set { SetPropertyValue<string>(nameof(Shipname), ref fShipname, value); }
        }
        string fShipaddress;
        [Size(60)]
        [Persistent(@"ShipAddress")]
        public string Shipaddress
        {
            get { return fShipaddress; }
            set { SetPropertyValue<string>(nameof(Shipaddress), ref fShipaddress, value); }
        }
        string fShipcity;
        [Size(15)]
        [Persistent(@"ShipCity")]
        public string Shipcity
        {
            get { return fShipcity; }
            set { SetPropertyValue<string>(nameof(Shipcity), ref fShipcity, value); }
        }
        string fShipregion;
        [Size(15)]
        [Persistent(@"ShipRegion")]
        public string Shipregion
        {
            get { return fShipregion; }
            set { SetPropertyValue<string>(nameof(Shipregion), ref fShipregion, value); }
        }
        string fShippostalcode;
        [Indexed(Name = @"ShipPostalCode")]
        [Size(10)]
        [Persistent(@"ShipPostalCode")]
        public string Shippostalcode
        {
            get { return fShippostalcode; }
            set { SetPropertyValue<string>(nameof(Shippostalcode), ref fShippostalcode, value); }
        }
        string fShipcountry;
        [Size(15)]
        [Persistent(@"ShipCountry")]
        public string Shipcountry
        {
            get { return fShipcountry; }
            set { SetPropertyValue<string>(nameof(Shipcountry), ref fShipcountry, value); }
        }
    }

}
