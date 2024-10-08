using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
// using static System.Net.WebRequestMethods;
using Azure.Storage.Blobs.Specialized;
using Azure;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel;
using Microsoft.IdentityModel.Tokens;

namespace Login
{

    public class Blob
    {
        private readonly string storageAccount_ = "databasefiles24";
        private readonly string accessKey_ = "";
        private readonly BlobServiceClient blobServiceClient_;
        // var blobUri_;
        BlobContainerClient containerClient_;

        string blobStorageConnectionString_ = "DefaultEndpointsProtocol=https;AccountName=databasefiles24;AccountKey=4KjdhtcBFLFwt/ubWnCxNA1B3inqavdzjL/kPwy1F3TqU8k56FAiZEk5SOEzAQU8NbxFTALGvwC6+AStz0go4w==;EndpointSuffix=core.windows.net";

        public Blob()
        {
            var crendential = new StorageSharedKeyCredential(storageAccount_, accessKey_);
            var blobUri_ = $"https://{storageAccount_}.blob.core.windows.net";
            blobServiceClient_ = new BlobServiceClient(new Uri(blobUri_), crendential);
            containerClient_ = new BlobContainerClient(blobStorageConnectionString_, "admin");

        }
        public async Task ListBlobContainersAsync(ListView list)
        {
            var containers = blobServiceClient_.GetBlobContainersAsync();

            await foreach (var container in containers)
            {
                list.Items.Add(container.Name);
            }
        }

        // Used insights from here https://www.youtube.com/watch?v=2yIbmVd7jxQ
        public async Task UploadFromFileAsync(string localFilePath, string blobStorageContainerName)
        {
            var blobStorageConnectionString = blobStorageConnectionString_;
            var container = new BlobContainerClient(blobStorageConnectionString, blobStorageContainerName);

            var stream = File.OpenRead(localFilePath);

            string fileName = Path.GetFileName(localFilePath);

            BlobClient blobClient = container.GetBlobClient(fileName);

            await blobClient.UploadAsync(stream, true);

            stream.Close();
        }
        // https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blobs-list
        public async Task GetFiles(string containerName,ListView list)
        {
            containerClient_ = new BlobContainerClient(blobStorageConnectionString_, containerName);
            var containerFiles = containerClient_.GetBlobsAsync().AsPages(default, 100);
            await foreach (Page<BlobItem> blobPage in containerFiles)
            {
                foreach (BlobItem blobItem in blobPage.Values)
                {
                    list.Items.Add(blobItem.Name);
                }

            }
        }
    }


    public class enteringPerson()
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public int Account_type { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime dateofBirth { get; set; }
        public string email {get; set;}


    }

    public class enteringClaim()
    {
        //public int claimNumber { get; set; }
        public string claimStatus { get; set; }
        public string claimFiler { get; set; }
        public string claimDate { get; set; }
        public string claimLocation { get; set; }
        public string claimDescription { get; set; }
    }

    public class enteringMessage()
    {
        //public int messageNumber { get; set; }
        public string messageRecipient { get; set; }
        public string messageSender { get; set; }
        public string messageBody { get; set; }
        public DateTime messageTime { get; set; }
    }

    public class userInfo()
    {
        
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        //public string state { get; set; }
        public string zipCode { get; set; }

    }

    public class Database
    {
        private string connectionString_;
        private string tableName_;
        private SqlConnection connection_;

        public Database()
        {
            connectionString_ = @"Data Source=SE361.database.windows.net;Initial Catalog=se361;User ID=;Password=;
            tableName_ = "UserAccount";
            connection_ = new SqlConnection(connectionString_);
            connection_.Open();
        }

      


        public bool QueryLogin(string tableName, ref enteringPerson jimmy)
        {
            tableName_ = tableName;
            string queryString = "SELECT * FROM " + tableName_ + " WHERE username = \'" + jimmy.Username + "\' AND password = \'" + jimmy.Password + "\'";
            SqlCommand command = new SqlCommand(queryString, connection_);

            SqlDataReader result = command.ExecuteReader();



            if (result.HasRows)
            {
                result.Read();
                {
                    jimmy.Username = result.GetString(0);
                    jimmy.Password = result.GetString(1);
                    jimmy.Account_type = result.GetInt32(2);
                }
                result.Close();
                return true;
            }
            else
            {
                result.Close();
                return false;
            }
        }
        public int GetUserAccountTypeForClaim(string claimFiler)
        {
            int accountType = 0;

            try
            {
                string query = "SELECT Account_type FROM UserAccount WHERE Username = @ClaimFiler";

                using (SqlCommand command = new SqlCommand(query, connection_))
                {
                    command.Parameters.AddWithValue("@ClaimFiler", claimFiler);


                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        accountType = Convert.ToInt32(result);
                    }
                    else
                    {

                        //MessageBox.Show("No data");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user account type: " + ex.Message);
            }
            
                    connection_.Close();
               

            return accountType;
        }

        public void InsertUserInfo(string tableName, userInfo details)
        {
            tableName_ = tableName;
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                string query = "INSERT INTO " + tableName_ + " (streetAddress, City, Country, zipCode) VALUES (@streetAddress, @City, @Country, @zipCode);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@streetAddress", details.streetAddress);
                    command.Parameters.AddWithValue("@City", details.city);
                    command.Parameters.AddWithValue("@Country", details.country);
                    //command.Parameters.AddWithValue("@State", details.state);
                    command.Parameters.AddWithValue("@zipCode", details.zipCode);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Inserted!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting into database: " + ex.Message);
                    }
                    
                        connection_.Close();
                    
                }
            }
        }

        public void GetLogs(ListView list)
        {
            tableName_ = "UserAccountLog";

            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                string query = "SELECT * FROM " + tableName_;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string line = "Username: "+ reader.GetString(0) + " Operation: " + reader.GetString(3) + " At " + reader.GetValue(4).ToString() + " by " +reader.GetString(5);
                            list.Items.Add(line);
                        }

                        reader.Close();
                    }
                    catch(Exception ex)
                    {
                     MessageBox.Show("Error inserting into database: " + ex.Message);
                    }
                    
                        connection.Close();
                    
                }
            }
        }

        public void GetStatus(string username,ListView list)
        {
            tableName_ = "Claim";

            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                string query = "SELECT Claim_Filer, Claim_Number, Claim_Status, Incident_Date, Incident_Discription FROM " + tableName_+" WHERE Claim_Filer=\'"+ username+"\';";
                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string item = reader.GetValue(0).ToString() + " " +reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString() + " " + reader.GetValue(4).ToString();
                            list.Items.Add(item);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                        connection.Close();
                    
                }
            }
        }
        public void InsertPersonToLogin(string tableName, enteringPerson jimmy)
        {
            tableName_ = tableName;
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                string query = "INSERT INTO " + tableName_ + " (Username, Password, Account_type, lastName, firstName, dateOfBirth, email) VALUES (@Username, @Password, @AccountType, @lastName, @firstName, @dateOfBirth, @email);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", jimmy.Username);
                    command.Parameters.AddWithValue("@Password", jimmy.Password);
                    command.Parameters.AddWithValue("@AccountType", jimmy.Account_type);
                    command.Parameters.AddWithValue("@lastName", jimmy.lastName);
                    command.Parameters.AddWithValue("@firstName", jimmy.firstName);
                    command.Parameters.AddWithValue("@dateOfBirth", jimmy.dateofBirth);
                    command.Parameters.AddWithValue("@email", jimmy.email);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting into database: " + ex.Message);
                    }
                    
                        connection_.Close();
                    
                }
            }
        }


        public void InsertClaimToTable(string tableName, enteringClaim sketch)
        {

            tableName_ = tableName;
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                
                string query = "INSERT INTO " + tableName_ + " (Claim_Status, Claim_Filer,Incident_Date,Incident_Location,Incident_Discription) VALUES (@Claim_Status, @Claim_Filer, @Incident_Date,@Incident_Location,@Incident_Discription);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@Claim_Number", sketch.claimNumber);
                    command.Parameters.AddWithValue("@Claim_Status", sketch.claimStatus);
                    command.Parameters.AddWithValue("@Claim_Filer", sketch.claimFiler);
                    command.Parameters.AddWithValue("@Incident_Date", sketch.claimDate);
                    command.Parameters.AddWithValue("@Incident_Location", sketch.claimLocation);
                    command.Parameters.AddWithValue("@Incident_Discription", sketch.claimDescription);
                    //command.Parameters.AddWithValue("@Username", username); 


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Claim filed!");
                    }
                    catch (Exception ex)
                    {

                    }
                   
                        connection_.Close();
                    
                }
            }

        }


        public void InsertMessageToTable(string tableName, enteringMessage message)
        {
            tableName_ = tableName;
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                //string query = "INSERT INTO " + tableName_ + " (IMID,Recipient,Sender,MBody,Time_Stamp) VALUES (@IMID, @Recipient, @Sender, @MBody,@Time_Stamp);";
                string query = "INSERT INTO " + tableName_ + " (Recipient,Sender,MBody,Time_Stamp) VALUES (@Recipient, @Sender, @MBody,@Time_Stamp);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@IMID", message.messageNumber);
                    command.Parameters.AddWithValue("@Recipient", message.messageRecipient);
                    command.Parameters.AddWithValue("@Sender", message.messageSender);
                    command.Parameters.AddWithValue("@MBody", message.messageBody);
                    command.Parameters.AddWithValue("@Time_Stamp", message.messageTime);



                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Message Sent!");
                        
                    }
                    catch (Exception ex)
                    {

                    }
                    
                        connection.Close();
                    
                }
            }
        }

        public string GetMessageDetails(string tableName, string recipient, string sender)
        {
            string messageText = "";

            try
            {
                string query = "SELECT MBody FROM " + tableName + " WHERE Recipient = @Recipient AND Sender = @Sender";

                using (SqlCommand command = new SqlCommand(query, connection_))
                {
                    command.Parameters.AddWithValue("@Recipient", recipient);
                    command.Parameters.AddWithValue("@Sender", sender);

                    connection_.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        messageText = reader.GetString(0);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from the database: " + ex.Message);
            }
           
                    connection_.Close();
                
            

            return messageText;
        }

        public string GetClaimDetails(string tableName, string filer_)
        {
            string claimDetails = "";

            try
            {
                string query = "SELECT Incident_Discription FROM " + tableName + " WHERE Claim_Filer = @Filer";

                using (SqlCommand command = new SqlCommand(query, connection_))
                {
                    command.Parameters.AddWithValue("@Filer", filer_);
                    

                    connection_.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        claimDetails = reader.GetString(0);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from the database: " + ex.Message);
            }
            finally
            {
                
                    connection_.Close();
                
            }

            return claimDetails;
        }



        public List<string> GetAllUsernames()
        {
            List<string> usernames = new List<string>();
            using(SqlConnection connection = new SqlConnection(connectionString_))
            {
                try
                {
                    string query = "SELECT Username FROM UserAccount";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string username = reader.GetString(0);
                            usernames.Add(username);
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {

                    connection.Close();
                }
            }
            



            return usernames;



        }

        

        public List<string> GetAllDates()
        {
            List<string> dates = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {

                try
                {
                    string query = "SELECT Incident_Date FROM Claim";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            if(reader.GetString(0).IsNullOrEmpty()==false)
                            {
                                string date = reader.GetString(0);
                                dates.Add(date);
                            }
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    
                }

                connection.Close();


            }

            return dates;



        }

        public List<string> GetAllUsersForClaim()
        {
            List<string> users = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                try
                {
                    string query = "SELECT Claim_Filer FROM Claim";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string user = reader.GetString(0);
                            users.Add(user);
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
            



            return users;



        }


        public List<string> GetAllUsernameOfType(int accountNumber)
        {
            List<string> usernames = new List<string>();

            try
            {
                string query = "SELECT Username FROM UserAccount WHERE Account_type = " + accountNumber;

                using (SqlCommand command = new SqlCommand(query, connection_))
                {
                    connection_.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        usernames.Add(username);
                    }

                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                
                    connection_.Close();
                
            }



            return usernames;


            
        }

        public List<string> GetAllClaims()
        {
            List<string> claims = new List<string>();

            try
            {
                string query = "SELECT Incident_Discription FROM Claim";

                using (SqlConnection connection = new SqlConnection(connectionString_))
                {

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            if (reader.GetString(0).IsNullOrEmpty()==false)
                            {
                                string claim = reader.GetString(0);
                                claims.Add(claim);
                            }
                            
                        }

                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                
            }

                return claims;


            
        }
        public List<string> GetAllUsernameOfTypes(int accountNumber1, int accountNumber2, int accountNumber3)
        {
            List<string> usernames = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString_))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Username FROM UserAccount WHERE Account_type = @accountNumber1 OR Account_type = @accountNumber2 OR Account_type = @accountNumber3";

                    using (SqlCommand command = new SqlCommand(query, connection_))
                    {

                        command.Parameters.AddWithValue("@accountNumber1", accountNumber1);
                        command.Parameters.AddWithValue("@accountNumber2", accountNumber2);
                        command.Parameters.AddWithValue("@accountNumber3", accountNumber3);


                        SqlDataReader reader = command.ExecuteReader();


                        while (reader.Read())
                        {
                            string username = reader.GetString(0);
                            usernames.Add(username);
                        }


                        reader.Close();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {

                }


            }

            return usernames;



        }

        public void UpdateUserDetails(enteringPerson person)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString_))
                {
                    connection.Open();
                    string query = "UPDATE UserAccount SET Password = @Password, LastName = @LastName, FirstName = @FirstName, DateOfBirth = @DateOfBirth, Email = @Email WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection_);
                    command.Parameters.AddWithValue("@Username", person.Username);
                    command.Parameters.AddWithValue("@Password", person.Password);
                    command.Parameters.AddWithValue("@LastName", person.lastName);
                    command.Parameters.AddWithValue("@FirstName", person.firstName);
                    command.Parameters.AddWithValue("@DateOfBirth", person.dateofBirth);
                    command.Parameters.AddWithValue("@Email", person.email);

                    int rowsAffected = command.ExecuteNonQuery();

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user details: " + ex.Message);

            }

            
        }

        public List<string> GetMessages(string recipientUsername)
        {
            List<string> senderUsernames = new List<string>();

            try
            {
                
                string query = "SELECT DISTINCT Sender FROM Message WHERE Recipient = @recipientUsername";

             
                using (SqlCommand command = new SqlCommand(query, connection_))
                {
                    
                    command.Parameters.AddWithValue("@recipientUsername", recipientUsername);

                    
                    connection_.Open();

                   
                    SqlDataReader reader = command.ExecuteReader();

                  
                    while (reader.Read())
                    {
                        string senderUsername = reader.GetString(0);
                        senderUsernames.Add(senderUsername);
                    }

                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sender usernames from the database: " + ex.Message);
            }
            finally
            {
                
                    connection_.Close();
               
            }

           
            return senderUsernames;
        }

    }
}


