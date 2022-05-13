using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GotoGrocery;

namespace DatabaseTesting
{

    public class DatabaseTesting
    {
        // Testing Database Object
        DatabaseConnection db;

        //Member1 Information:
        int id;
        string firstname;
        string lastname;
        string dob;
        string phone;
        string email;
        string date;

        string updatemember;
        string newName;

        //Member2 Information
        string email2;


        //Product1 Information
        string product_name;
        int inventory_level;
        string product_size;
        int shelfquantity;
        int orderamount;

        string updateproduct;
        string newProductName;

        //Product 2 Information
        string product_name2;
       


        [SetUp]
        public void SetUp()
        {

            db = new DatabaseConnection();
            //Member1 Setup
            firstname = "Jeff";
            lastname = "Reginald";
            dob = "2000-10-02";
            phone = "0412220991";
            email = "Jef.Reg@gmail.com";
            date = "2022-05-13";

            //Member2 Setup       
            email2 = "Rice@live.com";
            //Member Update
            newName = "Jarrod";
            updatemember = "Member_FirstName";

            //Product1 Information
            product_name = "Smith Chips";
            inventory_level = 32;
            product_size = "300g";
            shelfquantity = 12;
            orderamount = 32;


            //Product2 Information
            product_name2 = "Cheesol";

            //update Product
            updateproduct = "product_name";
            newProductName = "Cheesol";
        }

        [Test]
        public void TestDatabaseConnects()
        {
            Assert.IsNotNull(db); // Ensure object is created and existing
        }

        [Test]
        public void TestGetMemberDataTable()
        {
            Assert.IsNotNull(db.GetMembersList());
        }

        [Test]
        public void TestAddingAndRemovingAMember()
        {
            Assert.IsTrue(db.AddMember(firstname, lastname, dob, phone, email, date));
            id = db.GetMemberId(email);
            db.RemoveMemberById(id);
        }

        [Test]
        public void TestUpdateMember()
        {
            Assert.IsTrue(db.UpdateMember(email2, updatemember, newName));
        }


        //Product Tests

        [Test]
        public void TestSearchInventoryDataTable()
        {
            Assert.IsNotNull(db.GetInventoryList());
        }

        [Test]
        public void TestAddingAndRemovingProducts()
        {
            Assert.IsTrue(db.AddProduct(product_name, inventory_level, product_size, shelfquantity, orderamount));
            db.RemoveProductByname(product_name);
        }

        [Test]
        public void TestUpdateProduct()
        {
            Assert.IsTrue(db.UpdateProduct(product_name2, updateproduct, newProductName));
        }

        [Test]
        public void TestExportCSV()
        {
            db.ExportInventoryReport();
        }

    }
}