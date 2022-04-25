using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace details
{
    class taskfri
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-UIIPJ9N; database=project;user id = sa; password=P@ssw0rd");
        public void ProductList()
        {
            string prolist = "Select *from Product_table";
            SqlCommand cmd = new SqlCommand(prolist, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("prodIid : " + dr[0] + " " + "prodname : " + dr[1] + "  " + "price : " + dr[2] + "  " + "dateOfManu : " + dr[3] + "  " + "ExpiryDate : " + dr[4]);
            }
        }
        public void NewCustomer()
        {
            Console.WriteLine("Enter the name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter the Dob:");
            string DOB = Console.ReadLine();
            Console.WriteLine("Enter the ContactNo:");
            string ContactNo = Console.ReadLine();
            Console.WriteLine("Enter the MailID:");
            string EmailID = Console.ReadLine();
            Console.WriteLine("Enter the City(Chennai/Mumbai/pune/hyderabad):");
            string City = Console.ReadLine();
            string CustDetails = "insert Customer_table(Name,Gender,DOB,ContactNo,EmailID,City) values('" + Name + "','" + Gender + "','" + DOB + "','" + ContactNo + "','" + EmailID + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(CustDetails, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Customer Details inserted");
           
            while (true)
            {
                SqlConnection con1 = new SqlConnection("data source = DESKTOP-UIIPJ9N; database = project; user id = sa; password = P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand("select CustID  from Customer_table where Name='" + Name + "'", con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine("Your Customer ID is : " + dr1[0]);
                }
                con1.Close();
                break;
            }
            Console.WriteLine();
            taskfri obj1 = new taskfri();
            obj1.ProductList();
            con.Close();
        }
        public void purchaseList()
        {
            Console.WriteLine("Enter the CustomerID:");
            string cus = Console.ReadLine();
            Console.WriteLine("Enter the ProductID:");
            string pur = Console.ReadLine();
            Console.WriteLine("Enter the Quantity:");
            int unit = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection("data source=DESKTOP-UIIPJ9N; database=project;user id=sa; password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select Price* " + unit + " ,prodid,prodname,price from Product_table where prodid = " + pur + "", con);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                int Total = Convert.ToInt32(dr[0]);
                Console.WriteLine("ProdID : " + dr[1] + " " + "   ProdName : " + dr[2] + "  " + "  Price : " + dr[3] + "  Total Amount :  " + Total);
                string purins = "insert Purchase_table (custid,prodid,quantity,totalamount) values (" + cus + "," + pur + "," + unit + "," + Total + ")";
                SqlConnection con1 = new SqlConnection("data source=DESKTOP-UIIPJ9N; database=project;user id=sa; password=P@ssw0rd");
                SqlCommand cmd1 = new SqlCommand(purins, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                Console.WriteLine("                                   Thank You");
                
                con1.Close();
            }
            con.Close();
            
        }
     
        public void showPurchase()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your cusid To View Your Purchase Information:");
            int cuss = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection("data source=DESKTOP-UIIPJ9N; database=project;user id=sa; password=P@ssw0rd");
            string purch = "select  custid,ptt.prodid,prodname,price,quantity,totalamount from Product_table pt join Purchase_table ptt on pt.prodid = ptt.prodid where custid=" + cuss + "";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("                                        PURCHASE INFORMATION ");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public void showPurchaseByDate()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Date:");
            var Date = Convert.ToString(Console.ReadLine());
            SqlConnection con = new SqlConnection("data source=DESKTOP-UIIPJ9N; database=project;user id=sa; password=P@ssw0rd");
            string purch = "select  custid,ptt.prodid,prodname,price,quantity,totalamount,purchasedate from Product_table pt join Purchase_table ptt on pt.prodid = ptt.prodid where purchasedate='" + Date + "'";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("                                  PURCHASE INFORMATION By Using Date");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public static void Main()
        {
            Console.WriteLine("  WELLCOME  ");
            taskfri obj = new taskfri();
            Console.WriteLine("Are you Existing Costomer (yes/no)");
            string cho = Console.ReadLine();
            switch (cho)
            {
               
                case "yes":
                    obj.ProductList();
                    break;
                case "no":
                    obj.NewCustomer();
                    break;
            }

            obj.purchaseList();
            obj.showPurchase();
            obj.showPurchaseByDate();
           

        }
    }
}

