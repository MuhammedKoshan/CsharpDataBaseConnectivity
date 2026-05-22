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





    static void AddNewContact(stContact newContact)
    {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID)
                      VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
        command.Parameters.AddWithValue("@LastName", newContact.LastName);
        command.Parameters.AddWithValue("@Email", newContact.Email);
        command.Parameters.AddWithValue("@Phone", newContact.Phone);
        command.Parameters.AddWithValue("@Address", newContact.Address);
        command.Parameters.AddWithValue("@CountryID", newContact.CountryID);



        try
        {
            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record inserted Successfully");
            }
            else
            {
                Console.WriteLine("Record Insertion Faild");


            }



        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        connection.Close();
        
    }

    static void setTheValuesToAddINdb()
    {

        stContact Contact = new stContact 
        { 
        FirstName ="Mohammed",
        LastName="Abu_Hadhoud",
        Email="m@example.com",
        Phone="123456789",
        Address = "123 Main Street",
        CountryID=1
        
        
        };



        AddNewContact(Contact);


    }


    static void AddNewContactAndGetID(stContact newContact)
    {

        SqlConnection connection = new SqlConnection(connectionString);


        string query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID)
                      VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);
               SELECT SCOPE_IDENTITY();";


        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
        command.Parameters.AddWithValue("@LastName", newContact.LastName);
        command.Parameters.AddWithValue("@Email", newContact.Email);
        command.Parameters.AddWithValue("@Phone", newContact.Phone);
        command.Parameters.AddWithValue("@Address", newContact.Address);
        command.Parameters.AddWithValue("@CountryID", newContact.CountryID);



        try
        {
            connection.Open();


            object result = command.ExecuteScalar();

            if(result !=null && int.TryParse(result.ToString (), out int insertedID))
            {
                Console.WriteLine($"Newly inserted ID: {insertedID}");
                
            }
            else
            {
                Console.WriteLine("Failed to retrieve the inserted ID.");


            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        connection.Close();



    }

 
    static void UpdateContact(int ContactID, stContact newContact)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        string query = @"Update Contacts 
                         set FirstName=@FirstName,
                             LastName=@LastName,
                             Email=@Email,
                             Phone=@Phone,
                             Address= @Address,
                             CountryID=@CountryID
                              where ContactID= @ContactID";
                             

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@ContactID", ContactID);

        command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
        command.Parameters.AddWithValue("@LastName", newContact.LastName);
        command.Parameters.AddWithValue("@Email", newContact.Email);
        command.Parameters.AddWithValue("@Phone", newContact.Phone);
        command.Parameters.AddWithValue("@Address", newContact.Address);
        command.Parameters.AddWithValue("@CountryID", newContact.CountryID);
try
        {

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record Updated Successfully");


            }
            else
            {
                Console.WriteLine("Record Update Failed.");
            }

            connection.Close();


            

        }catch(Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }

    }

    static void DeleteContact(int ContactID)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        string query = @"DELETE Contacts    WHERE ContactID=@ContactID";

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ContactID", ContactID);
        try
        {
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();



            if (rowsAffected > 0)
            {
                Console.WriteLine("Record Deleted Successfully");


            }
            else
            {
                Console.WriteLine("Record Delete Failed.");
            }

            connection.Close();


        }catch(Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }


        connection.Close();
    }

    public static void Main()
    {


        DeleteContact(10);




        Console.ReadKey();
    }

}
