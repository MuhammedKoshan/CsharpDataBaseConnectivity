using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {

        public static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=NewPassword123;";



        static int GetFirstName(string FirstName)
        {

            int ContactID = 0;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Select * From Contacts Where FirstName = @FirstName";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {


                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {

                    ContactID = Convert.ToInt32(result);


                }
                else
                {
                    ContactID = 0;
                }

            }
            catch(Exception EX)
            {

                Console.WriteLine(EX.Message);
            }
            connection.Close();


            return ContactID;
        }

       
        static bool FindContactByID(int ContactID, ref stContact ContactInfo)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

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
                Console.WriteLine("Error" + ex.Message);
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
        
        static void AddNewContact(stContact newContact)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Contacts (FirstName, LastName,Email,Phone,Address,CountryID)
                             VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

            SqlCommand command = new SqlCommand(query, connection);



            command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
            command.Parameters.AddWithValue("@LastName", newContact.LastName);
            command.Parameters.AddWithValue("@Email", newContact.Email);
            command.Parameters.AddWithValue("@Phone", newContact.Phone);
            command.Parameters.AddWithValue("@Address", newContact.Address);
            command.Parameters.AddWithValue("@CountryID ", newContact.CountryID);

            try
            {

                connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record inserted successfully.");
                    

                }
                else
                {
                    Console.WriteLine("Record Insertaion Faild");
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            connection.Close();
            

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

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
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
        static void UpdateContact(int ContactID, stContact ContactInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            string query = @"Update Contacts set FirstName=@FirstName ,
                    LastName=@LastName,     Email=@Email,
            Phone=@Phone,

Address=@Address,
CountryID=@CountryID
where ContactID= @ContactID";


            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {
                connection.Open();


                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    Console.WriteLine("Update Done SuccessFully.");

                }
                else
                {

                    Console.WriteLine("Update Failed.");


                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);


            }
            connection.Close();




        }


        static void DeleteContact(int ContactID)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"dELETE coNTACTS where ContactID=@ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record Deleted successfully.");


                }
                else
                {
                    Console.WriteLine("Record Deletion Faild");
                }


            }
            catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex.Message);

            }


            connection.Close();


        }





        static void DeleteContacts(string ContactIDs)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            string query = @"Delete Contacts where ContactID in (" + ContactIDs + ")";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();




                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record Deleted successfully.");


                }
                else
                {
                    Console.WriteLine("Record Deletion Faild");
                }


            






        } catch (Exception ex)

            {
                Console.WriteLine("Error: " + ex.Message);

            }

            connection.Close();


}
        static void Main(string[] args)
        {

            DeleteContacts("6");


        }
    }
}
