using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace GotoGrocery

{
    public partial class DatabaseConnection
    {
        MySqlConnection Connect;
        public DatabaseConnection() //Connects to the local database
        {
            string _server = "localhost";
            string _database = "grotogodb";
            string _username = "root";
            string _password = "student85";

            string _connectionString = "SERVER=" + _server + ";" + "DATABASE=" + _database + ";" +
                "UID=" + _username + ";" + "PASSWORD=" + _password + ";";

            Connect = new MySqlConnection(_connectionString);
            Connect.Open();
        }


        //MEMBER TABLE METHODS

        public DataTable GetMembersList()
        {
            DataTable dtMembers = new DataTable();
            string query = "SELECT * FROM members";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            dtMembers.Load(rdr);
            return dtMembers;
        }

        public void MembersCollection() //Does a full search of the Members Table
        {
            string query = "SELECT * FROM members";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["Member_Id"]);
                Console.WriteLine(rdr["Member_FirstName"]);
                Console.WriteLine(rdr["Member_LastName"]);
                Console.WriteLine(rdr["Member_DOB"]);
                Console.WriteLine(rdr["Member_phoneNumber"]);
                Console.WriteLine(rdr["Member_Email"]);
                Console.WriteLine(rdr["Member_Status"]);
                Console.WriteLine(rdr["Member_StartDate"]);
            }
            rdr.Close();
        }

        public int NumberOfMembers() //Returns the Numbers in the members table
        {
            int i = 0;
            string query = "SELECT * FROM members";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                i++;
            }
            rdr.Close();
            return i;
        }

        public int HighestMemberID()
        {
            string query = "SELECT * FROM members ORDER BY Member_Id DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int id = Int32.Parse(rdr["Member_Id"].ToString()); //Converts the given Value to string then to Int
            rdr.Close();
            return id;
        }


        public bool AddMember(string _firstname, string _lastname, string _dob, string _phone, string email, string start) //Used to add a new Member to the table
        {
            if (CheckMemberExists(email))
            {
                Console.WriteLine("Customer with that email already exists");
                return false;
            }
            else
            {
                int _id;
                _id = HighestMemberID() + 1;
                string query = "INSERT INTO members (Member_Id, Member_FirstName, Member_LastName, Member_DOB, Member_phoneNumber, Member_Email, Member_Status, Member_StartDate) " +
                    "Values(" + _id.ToString() + ", '" + _firstname + "', '" + _lastname + "', '" + _dob + "', '" + _phone + "', '" + email + "', True, '" + start + "')";
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                return true;
            }
        }


        public void RemoveMemberById(int _id) //Removes a member from there Member ID
        {
            string query = "DELETE FROM members WHERE Member_Id=" + _id.ToString();
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }


        public int GetMemberId(string email) //Returns the ID of a member based on their Email
        {
            string query = "select * from members Where Member_Email='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int id = Int32.Parse(rdr["Member_Id"].ToString()); //Converts the given Value to string then to Int
            rdr.Close();
            return id;
        }

        public bool CheckMemberExists(string email)
        {
            string query = "SELECT * FROM members";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<string> _row = new List<string>();

            while (rdr.Read())
            {
                _row.Add(rdr["Member_Email"].ToString());
            }
            rdr.Close();


            if (_row.Contains(email)) return true;
            return false;

        }

        public List<string> MembertoString(int id)
        {
            string query = "SELECT * FROM members WHERE Member_Id='" + id.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            List<string> _row = new List<string>();
            _row.Add(rdr["Member_Id"].ToString());
            _row.Add(rdr["Member_FirstName"].ToString());
            _row.Add(rdr["Member_LastName"].ToString());
            _row.Add(rdr["Member_DOB"].ToString());
            _row.Add(rdr["Member_phoneNumber"].ToString());
            _row.Add(rdr["Member_Email"].ToString());
            _row.Add(rdr["Member_Status"].ToString());
            _row.Add(rdr["Member_StartDate"].ToString());

            rdr.Close();
            return _row;
        }

        public void UpdateMember(string email, string update, string value) //Update the Member Based on their email,
        { //Update is = Member_FirstName, Member_LastName, Member_LastName, Member_DOB, Member_phoneNumber, Member_Email, Member_Status
            string query = "UPDATE members"
                + " SET " + update + " = '" + value + "'" 
                + " WHERE Member_Email = " + "'" + email + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }



        //Inventory Methods

        public void InventoryCollection() //Does a full search of the Inventory Table
        {
            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["product_id"]);
                Console.WriteLine(rdr["product_name"]);
                Console.WriteLine(rdr["inventory_level"]);
                Console.WriteLine(rdr["product_size"]);
                Console.WriteLine(rdr["shelf_quantity"]);
                Console.WriteLine(rdr["order_amount"]);
            }
            rdr.Close();
        }

        public int HighestProductID()
        {
            string query = "SELECT * FROM inventory ORDER BY product_id DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int id = Int32.Parse(rdr["product_id"].ToString()); //Converts the given Value to string then to Int
            rdr.Close();
            return id;
        }
        public int NumberOfProducts() //Returns the Numbers in the products table
        {
            int i = 0;
            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                i++;
            }
            rdr.Close();
            return i;
        }

        public void AddProduct(string _productname, int _inventorylevel, string _productsize, int _shelfquantity, int _orderamount) //Used to add a new products to the table
        {
            int _id;
            _id = HighestProductID() + 1;
            string query = "INSERT INTO inventory (product_id, product_name, inventory_level, product_size, shelf_quantity, order_amount) " +
                "Values(" + _id.ToString() + ", '" + _productname + "', " + _inventorylevel.ToString() + ", '" + _productsize + "', " + _shelfquantity.ToString() + ", " + _orderamount.ToString() + ")";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }

        public List<string> SearchInventoryById(int _id)
        {
            string query = "SELECT * FROM inventory WHERE product_id=" + _id.ToString();
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            List<string> _row = new List<string>();
            _row.Add(rdr["product_id"].ToString());
            _row.Add(rdr["product_name"].ToString());
            _row.Add(rdr["inventory_level"].ToString());
            _row.Add(rdr["product_size"].ToString());
            _row.Add(rdr["shelf_quantity"].ToString());
            _row.Add(rdr["order_amount"].ToString());

            rdr.Close();
            return _row;
        }

        public List<string> ProductRowToString(string name)
        {
            string query = "SELECT * FROM inventory WHERE product_name='" + name + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            List<string> _row = new List<string>();
            _row.Add(rdr["product_id"].ToString());
            _row.Add(rdr["product_name"].ToString());
            _row.Add(rdr["inventory_level"].ToString());
            _row.Add(rdr["product_size"].ToString());
            _row.Add(rdr["shelf_quantity"].ToString());
            _row.Add(rdr["order_amount"].ToString());

            rdr.Close();
            return _row;
        }

        public bool CheckIfProductExists(string name)
        {
            string query = "SELECT * FROM inventory WHERE product_name ='" + name + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                rdr.Close();
                return true;
            }
            rdr.Close();
            return false;
        }

        public void UpdateProduct(string productname, string update, string value)
        {
            string query = "UPDATE inventory"
                + " SET " + update + " = '" + value + "'"
                + " WHERE product_name = " + "'" + productname + "'";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }


        //set up the csv
        StringBuilder csv = new StringBuilder();

        public void ExportInventoryReport()
        {
            string _filePath = @"c:\CSV\data.csv";

            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            string firstline = string.Format("{0},{1},{2},{3},{4},{5}", "Product ID", "Product Name", "Inventory Level",
                "Product Size", "Shelf Quantity", "Order Amount");
            csv.AppendLine(firstline);

            while (rdr.Read())
            {
                //loops for each row
                string id = rdr["product_id"].ToString();
                string name = rdr["product_name"].ToString();
                string level = rdr["inventory_level"].ToString();
                string size = rdr["product_size"].ToString();
                string shelf = rdr["shelf_quantity"].ToString();
                string amount = rdr["order_amount"].ToString();

                string newLine = string.Format("{0},{1},{2},{3},{4},{5}", id, name, level, size, shelf, amount);
                //add new line to the csv
                csv.AppendLine(newLine);
            }
            rdr.Close();
            //export the csv, change the filepath to something useful
            File.WriteAllText(_filePath, csv.ToString());

        }

    }
}
