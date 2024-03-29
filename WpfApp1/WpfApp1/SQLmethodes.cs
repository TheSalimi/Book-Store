﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    abstract class SQLmethodes
    {
        public static SqlConnection SQLconnectionToBooksTable() { return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\ApProject\Book-Store-\WpfApp1\Books.mdf;Integrated Security=True;Connect Timeout=30"); }
        public static SqlConnection SQLconnectionToUsersTable() { return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\ApProject\Book-Store-\WpfApp1\Users.mdf;Integrated Security=True;Connect Timeout=30"); }

        public static void ReturnUserStats(string EmailOfUser, out string email, out string name, out string family, out string password, out string shoppinglist, out string buyedlist, out string bookmarked, out float wallet, out string VIPTime, out bool exist)
        {
            email = ""; name = ""; family = ""; password = ""; shoppinglist = ""; buyedlist = ""; bookmarked = ""; wallet = 0; VIPTime = "";
            exist = false;
            string command;
            SqlConnection connection = SQLconnectionToUsersTable();
            connection.Open();
            command = "select * from UserTable";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            int row = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString().ToLower() == EmailOfUser)
                {
                    exist = true;
                    row = i;
                }
            }

            if (!exist)
            {
                connection.Close();
                MessageBoxResult messageBox = MessageBox.Show("There is no user with this email!");
                return;
            }

            connection.Close();

            email = data.Rows[row][0].ToString();
            name = data.Rows[row][1].ToString();
            family = data.Rows[row][2].ToString();
            password = data.Rows[row][3].ToString();
            shoppinglist = data.Rows[row][4].ToString();
            buyedlist = data.Rows[row][5].ToString();
            bookmarked = data.Rows[row][6].ToString();
            wallet = float.Parse(data.Rows[row][7].ToString());
            VIPTime = data.Rows[row][8].ToString();
        }
        public static void UpdateUserTable(string EmailOfUser, string email, string name, string family, string password, string shoppinglist, string buyedlist, string bookmarked, float wallet, string VIPTime, out bool exist)
        {
            SqlConnection connection = SQLconnectionToUsersTable();
            string command;
            try
            {
                exist = true;
                connection.Open();
                string DeleteCommand;
                DeleteCommand = "delete from UserTable where Email = '" + EmailOfUser + "'";
                SqlCommand DeleteRow = new SqlCommand(DeleteCommand, connection);
                DeleteRow.ExecuteNonQuery();

                command = "insert into UserTable values" +
                        "('" + EmailOfUser.Trim() + "','" + name.Trim() + "' , '" + family.Trim() + "','" + password.Trim() + "','" + shoppinglist.Trim() + "','" + buyedlist + "','" + bookmarked + "','" + wallet + "','" + VIPTime + "')";

                SqlCommand Command = new SqlCommand(command, connection);
                Command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBoxResult message = MessageBox.Show(error.Message);
                connection.Close();
                exist = false;
            }
        }
        public static void ReturnBookStats(int CulomnIndex, string searchingfor, out string name, out string authorname, out string year, out string price, out string bookdescription, out string authorprofile, out bool isvip,
            out int salenumber, out int point, out string bookimagepath, out float vipfee, out string timefordiscount, out float discount, out int numberofponits, out string pdfpath, out bool exist)
        {
            //Column Index = ایندکس ستون اون چیزی که دنبالش میگردیم
            //searchingfor = اسم چیزی که دنبالش میگردیم

            exist = true; name = ""; authorname = ""; year = ""; price = ""; bookdescription = ""; authorprofile = ""; pdfpath = ""; numberofponits = 0;
            isvip = false; salenumber = 0; point = 0; bookimagepath = ""; vipfee = 0; timefordiscount = ""; discount = 0; exist = false;
            string command;
            SqlConnection connection = SQLconnectionToBooksTable();

            connection.Open();

            command = "select * from BookTable";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            int row = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][CulomnIndex].ToString().ToLower() == searchingfor.ToLower())
                {
                    exist = true;
                    row = i;
                    break;
                }
            }

            if (!exist)
            {
                connection.Close();
                MessageBoxResult messageBox = MessageBox.Show("There is no book with this name!");
                return;
            }

            connection.Close();

            name = data.Rows[row][0].ToString();
            authorname = data.Rows[row][1].ToString();
            year = data.Rows[row][2].ToString();
            price = data.Rows[row][3].ToString();
            bookdescription = data.Rows[row][4].ToString();
            authorprofile = data.Rows[row][5].ToString();
            isvip = Convert.ToBoolean(data.Rows[row][6]);
            salenumber = int.Parse(data.Rows[row][7].ToString());
            point = int.Parse(data.Rows[row][8].ToString());
            bookimagepath = data.Rows[row][9].ToString();
            vipfee = float.Parse(data.Rows[row][10].ToString());
            timefordiscount = data.Rows[row][11].ToString().ToString();
            discount = float.Parse(data.Rows[row][12].ToString());
            numberofponits = int.Parse(data.Rows[row][13].ToString());
            pdfpath = data.Rows[row][14].ToString();
        }


        public static void AddToUserTable(string Email, string Name, string Family, string Password, string ShoppingList, string BuyedList, string BookMarked, float wallet, string VIPTime, out bool ok)
        {
            ok = true;
            SqlConnection connection = SQLconnectionToUsersTable();

            try
            {
                connection.Open();

                string command = "insert into UserTable values" +
                        "('" + Email.Trim() + "','" + Name.Trim() + "' , '" + Family.Trim() + "','" + Password.Trim() + "','" + ShoppingList.Trim() + "','" + BuyedList + "','" + BookMarked + "','" + wallet + "','" + VIPTime + "')";

                SqlCommand Command = new SqlCommand(command, connection);
                Command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception Er)
            {
                ok = false;
                connection.Close();
                MessageBoxResult message = MessageBox.Show(Er.Message);
                return;
            }
        }

        public static void DeleteBookFromBookTable(string bookname, out bool ok)
        {
            ok = true;
            SqlConnection connection = SQLconnectionToBooksTable();
            try
            {
                connection.Open();
                string DeleteCommand;
                DeleteCommand = "delete from BookTable where BookName = '" + bookname + "'";
                SqlCommand DeleteRow = new SqlCommand(DeleteCommand, connection);
                DeleteRow.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                ok = false;
                connection.Close();
                MessageBoxResult message = MessageBox.Show("Book was not deleted \n" + error.Message);
            }
        }
        public static void AddBookToBookTable(string name, string authorname, string year, string price, string bookdescription, string authorprofile, bool isvip, int salenumber, int point, string bookimagepath, float vipfee, string timefordiscount, float discount, int numberofponits, string pdfpath, out bool isok)
        {
            isok = true;
            SqlConnection connection = SQLconnectionToBooksTable();
            try
            {
                connection.Open();
                string AddCommand = "insert into BookTable values" +
                        "('" + name + "','" + authorname.Trim() + "' , '" + year.Trim() + "','" + price.Trim() + "','" + bookdescription.Trim() + "','" + authorprofile.Trim() + "','"
                        + isvip + "','" + salenumber + "','" + point + "' , '" + bookimagepath + "','" + vipfee +
                        "','" + timefordiscount + "','" + discount + "' , '" + numberofponits + "','" + pdfpath + "')";
                SqlCommand AddRow = new SqlCommand(AddCommand, connection);
                AddRow.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                isok = false;
                connection.Close();
                MessageBoxResult message = MessageBox.Show("inserting book was unsuccessful");
            }
        }
        public static void ReturnVIPfee(out bool exist , out float fee)
        {
            fee = 0;
            exist = true;
            string command;
            SqlConnection connection = SQLconnectionToBooksTable();

            connection.Open();

            command = "select * from VIPfeee";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            try
            {
                fee = float.Parse(data.Rows[0][0].ToString());
            }
            catch (Exception error)
            {
                connection.Close();
                exist = false;
                return;
            }
            connection.Close();
        }
        public static void DeleteVIPfee(out bool ok)
        {
            bool exist;
            float fee;

            ReturnVIPfee(out exist, out fee);
            if (!exist) { ok = false; return; }

            ok = true;
            SqlConnection connection = SQLconnectionToBooksTable();
            try
            {
                connection.Open();
                string DeleteCommand;
                DeleteCommand = "delete from VIPfeee where VIPfeee = '" + fee + "'";
                SqlCommand DeleteRow = new SqlCommand(DeleteCommand, connection);
                DeleteRow.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                ok = false;
                connection.Close();
                MessageBoxResult message = MessageBox.Show("Book was not deleted \n" + error.Message);
            }
        }
        public static void EditVIPfee(float NewVIPfee , out bool isok)
        {
            isok = true;
            bool ok;
            DeleteVIPfee(out ok);

            if(!ok)
            {
                MessageBoxResult message = MessageBox.Show("The last VIP fee isn\'t deleted");
            }

            bool done;
            AddToVIPfee(NewVIPfee, out done);
            if (!done)
            {
                MessageBoxResult messageBox = MessageBox.Show("New fee isn\'t added");
                isok = false;
            }
        }
        public static void AddToVIPfee(float fee , out bool done)
        {
            done = true;

            SqlConnection connection = SQLconnectionToBooksTable();
            try
            {
                connection.Open();
                string AddCommand = "insert into VIPfeee values" +
                        "('" + fee + "')";
                SqlCommand AddRow = new SqlCommand(AddCommand, connection);
                AddRow.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                done = false;
                connection.Close();
                MessageBoxResult message = MessageBox.Show("VIP add editing was unsuccessful");
            }
        }
    }
}
