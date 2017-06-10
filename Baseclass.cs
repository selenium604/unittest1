using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Configuration;
using System.Linq;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;


namespace UnitTestingProject1
{


    public class Baseclass
    {
        appcommomn ap = new appcommomn();
  
        
        [SetUp]
        public void Setup()
        {
            ap.webdriverlogin();
           
            System.Threading.Thread.Sleep(5000);
        }
 //       [Test]
 //       public void registration()
 //       {
 //           ap.backhomepage();
 //           ap.linktext(ConfigurationManager.AppSettings["signin"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["signup"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.webelementndata(ConfigurationManager.AppSettings["FirstNameelement"].ToString(), ConfigurationManager.AppSettings["FirstName"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["lastNameelement"].ToString(), ConfigurationManager.AppSettings["lastName"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["emailaddresselement"].ToString(), ConfigurationManager.AppSettings["emailaddress"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["Residenceelement"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["seelement"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["usernameelement"].ToString(), ConfigurationManager.AppSettings["username"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["passelement"].ToString(), ConfigurationManager.AppSettings["pass"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["UserIDelement"].ToString(), ConfigurationManager.AppSettings["UserID"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["Technologyinterselement"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["Tselement"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["Tselement"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["signinelement"].ToString());

 //       }
 //       [Test]
 //       public void login()
 //       {
 //           ap.linktext(ConfigurationManager.AppSettings["signin"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["login"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.webelementndata(ConfigurationManager.AppSettings["usernameelement"].ToString(), ConfigurationManager.AppSettings["username"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["passelement"].ToString(), ConfigurationManager.AppSettings["pass"].ToString());
           
 //           ap.click(ConfigurationManager.AppSettings["signinelement"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["profileelement"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["dashboardelement"].ToString());
            
 //           ap.webelementndata(ConfigurationManager.AppSettings["displayeelemnt"].ToString(), ConfigurationManager.AppSettings["displayname"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["firstdashelement"].ToString(), ConfigurationManager.AppSettings["firstname"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["lastdashelement"].ToString(), ConfigurationManager.AppSettings["lastname"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["submitelement"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["userdispaly"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["anotherdash"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.checkpoint(ConfigurationManager.AppSettings["firstdashelement"].ToString(), ConfigurationManager.AppSettings["firstname"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["userdispaly"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["logout"].ToString());

 //           Console.WriteLine("the last is completed");
           
 //       }
 //       [Test]
 //       public void searchengine()
 //       {

 //           ap.linktext(ConfigurationManager.AppSettings["signin"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["login"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.webelementndata(ConfigurationManager.AppSettings["usernameelement"].ToString(), ConfigurationManager.AppSettings["username"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["passelement"].ToString(), ConfigurationManager.AppSettings["pass"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["signinelement"].ToString());
 //           System.Threading.Thread.Sleep(5000);
 //           ap.click(ConfigurationManager.AppSettings["srchbar"].ToString());
 //           ap.webelementndata(ConfigurationManager.AppSettings["looking"].ToString(), ConfigurationManager.AppSettings["lookval"].ToString());
 //           ap.click(ConfigurationManager.AppSettings["enginele"].ToString());
 //           ap.dropdown(ConfigurationManager.AppSettings["multielement"].ToString(), ConfigurationManager.AppSettings["lookval"].ToString());
 //}
        [Test]
        public void upload()
        {
            ap.linktext(ConfigurationManager.AppSettings["signin"].ToString());
            System.Threading.Thread.Sleep(5000);
            ap.click(ConfigurationManager.AppSettings["login"].ToString());
            System.Threading.Thread.Sleep(5000);
            ap.webelementndata(ConfigurationManager.AppSettings["usernameelement"].ToString(), ConfigurationManager.AppSettings["username"].ToString());
            ap.webelementndata(ConfigurationManager.AppSettings["passelement"].ToString(), ConfigurationManager.AppSettings["pass"].ToString());
            ap.click(ConfigurationManager.AppSettings["signinelement"].ToString());
            System.Threading.Thread.Sleep(5000);
            ap.click(ConfigurationManager.AppSettings["profileelement"].ToString());
            System.Threading.Thread.Sleep(5000);
            ap.click(ConfigurationManager.AppSettings["dashboardelement"].ToString());
            System.Threading.Thread.Sleep(5000);
           // ap.click(ConfigurationManager.AppSettings["browseelement"].ToString());
           System.Threading.Thread.Sleep(5000);
          
           ap.webelementndata(ConfigurationManager.AppSettings["browseelement"].ToString(), ConfigurationManager.AppSettings["valueupload"].ToString()); 
            
            ap.click(ConfigurationManager.AppSettings["uploadelement"].ToString());




        }
        [TearDown]
        public void logout()
        {
            Console.WriteLine("the name is verified");
           
            System.Threading.Thread.Sleep(20000);
            appcommomn.driver.Quit();
            Console.Read();

        }
    }
}
