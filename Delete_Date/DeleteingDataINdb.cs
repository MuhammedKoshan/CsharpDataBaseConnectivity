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



    }

    public static void Main()
    {


        DeleteContact(10);




        Console.ReadKey();
    }

}
