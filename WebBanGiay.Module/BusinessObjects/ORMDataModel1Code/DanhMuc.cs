using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace WebBanGiay.Module.BusinessObjects.ORMDataModel1
{
    [DefaultClassOptions]
    public partial class DanhMuc
    {
        public DanhMuc(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public DanhMuc() { }

    }

}
