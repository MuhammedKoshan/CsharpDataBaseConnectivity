

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


    public static void Main()
    {

        stContact ContactInfo = new stContact
        {
            FirstName = "Mohammed",
            LastName = "Abu-Hadhoud",
            Email = "m@example.com",
            Phone = "123456789",
            Address = "123 Main Street",
            CountryID = 1

        };

        UpdateContact(2, ContactInfo);




        Console.ReadKey();
    }

}
