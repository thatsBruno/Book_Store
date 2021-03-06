﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create new instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test the values
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.ActiveAcc = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerPwd = "eRRor!2";
            TestCustomer.FirstName = "Bruno";
            TestCustomer.LastName = "Ribeiro";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ActiveAcc = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerPwd = "eRRor!2";
            TestItem.FirstName = "Bruno";
            TestItem.LastName = "Ribeiro";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

     
    }
}