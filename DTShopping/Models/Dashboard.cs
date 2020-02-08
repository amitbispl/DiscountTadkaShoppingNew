﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTShopping.Models
{
    public class Dashboard
    {
        public List<PointsLedger> ledgerList { get; set; }
        public List<Category> MenuItems { get; set; }
        public List<Banners> Banners { get; set; }
        public List<R_StateMaster> States { get; set; }
        public List<R_CityMaster> Cities { get; set; }
        public List<Product> Products { get; set; }
        public UserDetails User { get; set; }
        public decimal NetPayment { get; set; }
        public double UsersPoints { get; set; }
        public double TotalProductPoints { get; set; }
        public Product ProductDetail { get; set; }
        public order OrderDetail { get; set; }
        public company CompanyDetail { get; set; }
        public OrderDetailContainer orderDetailContainer { get; set; }
        public List<order_products> OrderProducts { get; set; }
        public List<Containers> PaymentModeList { get; set; }
        public List<Containers> WalletPaymentModeList { get; set; }
        public List<KeyValue> deliveryTypeList { get; set; }
        public ShoppingPortalFrontPageProdList FontpageSections{get;set;}
        public double Amount { get; set; }
        public Filters FilterDetail { get; set; }
        public CompanyProfile CompanyProfileDetail { get; set; }

        public void AssignPaymentModes()
        {
            this.PaymentModeList = new List<Containers>();
            this.PaymentModeList.Add(new Containers { value = "Cash Deposit"});
            this.PaymentModeList.Add(new Containers { value = "Demand Draft" });
            this.PaymentModeList.Add(new Containers { value = "Cheque" });
            this.PaymentModeList.Add(new Containers { value = "NEFT" });
            this.PaymentModeList.Add(new Containers { value = "RTGS" });
            this.PaymentModeList.Add(new Containers { value = "IMPS" });
            this.PaymentModeList.Add(new Containers { value = "Paytm" });
            this.PaymentModeList.Add(new Containers { value = "PhonePe" });            
            
        }
    }

    public partial class brand
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
        public byte status { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime modified { get; set; }
    }
}