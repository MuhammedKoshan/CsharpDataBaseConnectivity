using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;"; // Replace with your actual connection string

    static void PrintAllContacts()
    {
            
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts";

            SqlCommand command = new SqlCommand(query, connection);
            
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int contactID = (int)reader["ContactID"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string email = (string)reader["Email"];
                        string phone = (string)reader["Phone"];
                        string address = (string)reader["Address"];
                        int countryID = (int)reader["CountryID"];

                        Console.WriteLine($"Contact ID: {contactID}");
                        Console.WriteLine($"Name: {firstName} {lastName}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Phone: {phone}");
                        Console.WriteLine($"Address: {address}");
                        Console.WriteLine($"Country ID: {countryID}");
                        Console.WriteLine();
                    }

                    reader.Close();
                    connection.Close();

                }


                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            
    }


    static void PrintAllContactsWithFirstName(string FirstName) {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts WHERE FirstName=@FirstName";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", FirstName);

        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int contactID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }



    static void PrintAllContactsWithFirstNameAndCountryId(string FirstName,int CountryID)
    {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts WHERE FirstName=@FirstName and CountryID=@CountryID";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", FirstName);
        command.Parameters.AddWithValue("@CountryID", CountryID);


        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int contactID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }




    static void SearchContactsStartsWith(string StartWith)
    {


        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts WHERE FirstName LIKE '' + @StartWith+ '%'";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@StartWith", StartWith);

        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int contactID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }





    static void SearchContactsEndsWith(string EndsWith)
    {


        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @EndsWith+ ''";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@EndsWith", EndsWith);

        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int contactID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }




    static void SearchContactsContains(string Contains)
    {


        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @Contains+ '%'";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Contains", Contains);

        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int contactID = (int)reader["ContactID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string email = (string)reader["Email"];
                string phone = (string)reader["Phone"];
                string address = (string)reader["Address"];
                int countryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID: {contactID}");
                Console.WriteLine($"Name: {firstName} {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

 // GET SINGLE VALUE
    static String GetFirstName(int ContactID)
    {
        string FirstName = "";

        SqlConnection connection = new SqlConnection(connectionString);
        string query = "SELECT *  From Contacts WHERE ContactID=@ContactID";


        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {

            connection.Open();
            object result = command.ExecuteScalar();

            if (result != null)
            {

                FirstName = result.ToString();



            }
            else
            {
                FirstName = "";
            }
            connection.Close();


        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return FirstName;


    }



    static bool FindContactByID(int ContactID, ref stContact ContactInfo)
    {
        bool isFound = false;

        SqlConnection connection = new SqlConnection(connectionString);

        string query = "SELECT * FROM Contacts where ContactID=@ContactID";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@ContactID", ContactID);


        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                isFound = true;
                ContactInfo.ID = (int)reader["ContactID"];
                ContactInfo.FirstName = (string)reader["FirstName"];
                ContactInfo.LastName = (string)reader["LastName"];
                ContactInfo.Email = (string)reader["Email"];
                ContactInfo.Phone = (string)reader["Phone"];
                ContactInfo.Address = (string)reader["Address"];
                ContactInfo.CountryID = (int)reader["CountryID"];
                



            }
            else
            {

                isFound = false;
            }
            reader.Close();
            connection.Close();





        }
        catch(Exception ex)
        {

            Console.WriteLine("Error: " + ex.Message);
        }


        return isFound;

    }
    public struct stContact
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }


   static void PrintOneRecord(int ContactID)
    {
        stContact ContactInfo = new stContact();

        if (FindContactByID(ContactID, ref ContactInfo))
        {

            Console.WriteLine($"\nContact ID: {ContactInfo.ID}");
            Console.WriteLine($"Name: {ContactInfo.FirstName} {ContactInfo.LastName}");
            Console.WriteLine($"Email: {ContactInfo.Email}");
            Console.WriteLine($"Phone: {ContactInfo.Phone}");
            Console.WriteLine($"Address: {ContactInfo.Address}");
            Console.WriteLine($"Country ID: {ContactInfo.CountryID}");


        }
        else
        {
            Console.WriteLine("Contact is not Found");
        }


    }




    public static void Main()
    {


        PrintOneRecord(4);
            ;
        Console.ReadKey();
    }

}
