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
    public partial class CurrentProductList : XPLiteObject
    {
        int fProductid;
        [Persistent(@"ProductID")]
        public int Productid
        {
            get { return fProductid; }
            set { SetPropertyValue<int>(nameof(Productid), ref fProductid, value); }
        }
        string fProductname;
        [Size(40)]
        [Persistent(@"ProductName")]
        public string Productname
        {
            get { return fProductname; }
            set { SetPropertyValue<string>(nameof(Productname), ref fProductname, value); }
        }
    }

}