using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using web09052024.App_Code.BLL;

namespace web09052024
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<client> LsClient = new List<client>();// הגדרת רשימה עבור לקוחות
            client Tmp;
            Tmp = new client()
            {
                CusFullName = "shay",
                cusMail = "shayelisha2312@gmail.com",
                cusPassword = "shay1234"
            };
            LsClient.Add(Tmp);
            Tmp = new client()
            {
                CusFullName = "nati",
                cusMail = "nati@gmail.com",
                cusPassword = "nati1234"
            };
            LsClient.Add(Tmp);
            Tmp = new client()
            {
                CusFullName = "vered",
                cusMail = "vered@gmail.com",
                cusPassword = "vered1234"
            };
            LsClient.Add(Tmp);
            Tmp = new client()
            {
                CusFullName = "orel",
                cusMail = "orel@gmail.com",
                cusPassword = "orel1234"
            };
            LsClient.Add(Tmp);
            Tmp = new client()
            {
                CusFullName = "yaron",
                cusMail = "yaron@gmail.com",
                cusPassword = "yaron1234"
            };
            LsClient.Add(Tmp);
            Application["Clients"] = LsClient;

            List<city> Cities = new List<city>();
            city tmp;
            tmp = new city();
            tmp = new city()
            {
                CityId = 1,
                CityName = "Ashkelon",
            };
            Cities.Add(tmp);
            tmp = new city()
            {
                CityId = 2,
                CityName = "hifa",
            };
            Cities.Add(tmp);
            tmp = new city()
            {
                CityId = 3,
                CityName = "Ashdod",
            };
            Cities.Add(tmp);
            tmp = new city()
            {
                CityId = 4,
                CityName = "Tel Aviv",
            };
            Cities.Add(tmp);
            Application["cities"] = Cities;

            List<product> lsProduct = new List<product>();// הגדרת רשימה עבור לקוחות
            product Tmp1;
            Tmp1 = new product()
            {
                pName = "bread",
                PicName = "bread.jpg",
                price = 7
            };
            lsProduct.Add(Tmp1);
            Tmp1 = new product()
            {
                pName = "milk",
                PicName = "milk",
                price = 6
            };
            lsProduct.Add(Tmp1);
            Tmp1 = new product()
            {
                pName = "tv Tushiba",
                PicName = "tv.jpg",
                price = 1200
            };
            lsProduct.Add(Tmp1);
            Tmp1 = new product()
            {
                pName = "table",
                PicName = "table.jpg",
                price = 500
            };
            lsProduct.Add(Tmp1);
            Tmp1 = new product()
            {
                pName = "flowers",
                PicName = "flower.jpg",
                price = 50
            };
            lsProduct.Add(Tmp1);
            Application["Products"] = lsProduct;


            List<category> lsCategory = new List<category>();// הגדרת רשימה עבור לקוחות
            category TmpC;
            TmpC = new category()
            {
                Cid = 1,
                Cname = "breads",
                CPic = "breads.jpg"
            };
            lsCategory.Add(TmpC);
            TmpC = new category()
            {
                Cid = 2,
                Cname = "Electicity",
                CPic = "electric.jpg"
            };
            lsCategory.Add(TmpC);
            TmpC = new category()
            {
                Cid = 3,
                Cname = "home styling",
                CPic = "home.jpg"
            };
            lsCategory.Add(TmpC);
            TmpC = new category()
            {
                Cid = 4,
                Cname = "garden",
                CPic = "garden.jpg"
            };
            lsCategory.Add(TmpC);
            TmpC = new category()
            {
                Cid = 5,
                Cname = "clouthes",
                CPic = "clouthes.jpg"
            };
            lsCategory.Add(TmpC);
            Application["Categories"] = lsCategory;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}