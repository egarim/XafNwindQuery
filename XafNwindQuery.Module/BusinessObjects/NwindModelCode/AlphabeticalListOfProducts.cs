﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafNwindQuery.Module.BusinessObjects.Northwind
{

    public partial class AlphabeticalListOfProducts
    {
        public AlphabeticalListOfProducts(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
