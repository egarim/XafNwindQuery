﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace XafNwindQuery.Module.BusinessObjects.Northwind
{

    [DefaultClassOptions()]
    public partial class Categories
    {
        public Categories(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
