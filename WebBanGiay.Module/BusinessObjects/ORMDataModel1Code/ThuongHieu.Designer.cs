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

    public partial class ThuongHieu : XPObject
    {
        int fIDThuongHieu;
        public int IDThuongHieu
        {
            get { return fIDThuongHieu; }
            set { SetPropertyValue<int>(nameof(IDThuongHieu), ref fIDThuongHieu, value); }
        }
        string fTenThuongHieu;
        public string TenThuongHieu
        {
            get { return fTenThuongHieu; }
            set { SetPropertyValue<string>(nameof(TenThuongHieu), ref fTenThuongHieu, value); }
        }
        [Association(@"SanPhamReferencesThuongHieu")]
        public XPCollection<SanPham> SanPhams { get { return GetCollection<SanPham>(nameof(SanPhams)); } }
    }

}
