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

    [Indices(@"DanhSachSanPham")]
    public partial class GioHang : XPObject
    {
        int fIDGioHang;
        public int IDGioHang
        {
            get { return fIDGioHang; }
            set { SetPropertyValue<int>(nameof(IDGioHang), ref fIDGioHang, value); }
        }
        KhachHang fKhachHang;
        [Association(@"GioHangReferencesKhachHang")]
        public KhachHang KhachHang
        {
            get { return fKhachHang; }
            set { SetPropertyValue<KhachHang>(nameof(KhachHang), ref fKhachHang, value); }
        }
        DateTime fNgayTao;
        public DateTime NgayTao
        {
            get { return fNgayTao; }
            set { SetPropertyValue<DateTime>(nameof(NgayTao), ref fNgayTao, value); }
        }
        int fDanhSachSanPham;
        public int DanhSachSanPham
        {
            get { return fDanhSachSanPham; }
            set { SetPropertyValue<int>(nameof(DanhSachSanPham), ref fDanhSachSanPham, value); }
        }
        decimal fTongTien;
        public decimal TongTien
        {
            get { return fTongTien; }
            set { SetPropertyValue<decimal>(nameof(TongTien), ref fTongTien, value); }
        }
        [Association(@"ChiTietGioHangReferencesGioHang")]
        public XPCollection<ChiTietGioHang> ChiTietGioHangs { get { return GetCollection<ChiTietGioHang>(nameof(ChiTietGioHangs)); } }
    }

}