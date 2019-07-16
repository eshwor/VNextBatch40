using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIOS.DataAccess
{
    public class DataAccess
    {
        public void AddNewUser(UserLogin userLogin)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=192.168.0.53;Initial Catalog=VIOSDB;User ID=sa;password=innovative");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into UserLogin values('"+ userLogin.UserName+"','"+userLogin.UserPassword+"')", sqlConnection);
            cmd.ExecuteNonQuery();
        }

        public List<UserLogin> GetAllUser()
        {
            List<UserLogin> userLogins = new List<UserLogin>();
            SqlConnection sqlConnection = new SqlConnection("Data Source=192.168.0.53;Initial Catalog=VIOSDB;User ID=sa;password=innovative");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from UserLogin", sqlConnection);
            SqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                userLogins.Add(new UserLogin()
                {
                    UserName = rd.GetString(0),
                    UserPassword = rd.GetString(1)


                }

                    );

            }
            return userLogins;
        }
    }
}
