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
namespace WebBanGiay.Module.BusinessObjects.ORMDataModel1
{

    public partial class DanhMuc : DevExpress.Persistent.BaseImpl.BaseObject
    {
        int fIDDanhMuc;
        public int IDDanhMuc
        {
            get { return fIDDanhMuc; }
            set { SetPropertyValue<int>(nameof(IDDanhMuc), ref fIDDanhMuc, value); }
        }
        string fTenDanhMuc;
        public string TenDanhMuc
        {
            get { return fTenDanhMuc; }
            set { SetPropertyValue<string>(nameof(TenDanhMuc), ref fTenDanhMuc, value); }
        }
        [Association(@"SanPhamReferencesDanhMuc")]
        public XPCollection<SanPham> SanPhams { get { return GetCollection<SanPham>(nameof(SanPhams)); } }
    }

}