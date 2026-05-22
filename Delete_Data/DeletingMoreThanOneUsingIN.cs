    static void DeleteContacts(string ContactIDs)
    {


        SqlConnection connection = new SqlConnection(connectionString);

        string query = @"Delete Contacts 

                            where ContactID in (" + ContactIDs + " ) ";
        SqlCommand command = new SqlCommand(query, connection);

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




        }catch(Exception ex)
        {
            Console.WriteLine("Error " + ex.Message);

        }
        connection.Close();



    }
    public static void Main()
    {


        DeleteContacts("10,9,8");




        Console.ReadKey();
    }

}
