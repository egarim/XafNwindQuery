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
    public partial class CustomerAndSuppliersByCity : XPLiteObject
    {
        string fCity;
        [Size(15)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        string fCompanyname;
        [Size(40)]
        [Persistent(@"CompanyName")]
        public string Companyname
        {
            get { return fCompanyname; }
            set { SetPropertyValue<string>(nameof(Companyname), ref fCompanyname, value); }
        }
        string fContactname;
        [Size(30)]
        [Persistent(@"ContactName")]
        public string Contactname
        {
            get { return fContactname; }
            set { SetPropertyValue<string>(nameof(Contactname), ref fContactname, value); }
        }
        string fRelationship;
        [Size(9)]
        public string Relationship
        {
            get { return fRelationship; }
            set { SetPropertyValue<string>(nameof(Relationship), ref fRelationship, value); }
        }
    }

}
