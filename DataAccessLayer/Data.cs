using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Entities;

namespace DataAccessLayer
{
    public class Data
    {
        private SqlConnection con = new SqlConnection(@"Server=8d39074f-5e10-44d3-8873-a2d700fd349e.sqlserver.sequelizer.com;Database=db8d39074f5e1044d38873a2d700fd349e;User ID=dmicdnhhfwonwldo;Password=63wShho5KRp8faNbodMSvxyrcQWE3mEwJqxVPbj8qxByprmnnGqYVxnGCfPztQcy;");

        /// <summary>
        /// Create a new account for a new user
        /// </summary>
        /// <param name="user">Info about the new user</param>
        public void Register(User user)
        {
            string Query = @"insert into Member values(@Uname, @Email, @PW, @Fname, @Lname, @Address, @Zip, @City, @Country)";

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Email";
                param.Value = user.Email;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@PW";
                param2.Value = user.Password;
                cmd.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@Fname";
                param3.Value = user.Fname;
                cmd.Parameters.Add(param3);

                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@Lname";
                param4.Value = user.Lname;
                cmd.Parameters.Add(param4);

                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@Address";
                param5.Value = user.Address;
                cmd.Parameters.Add(param5);

                SqlParameter param6 = new SqlParameter();
                param6.ParameterName = "@Zip";
                param6.Value = user.ZipCode;
                cmd.Parameters.Add(param6);

                SqlParameter param7 = new SqlParameter();
                param7.ParameterName = "@City";
                param7.Value = user.City;
                cmd.Parameters.Add(param7);

                SqlParameter param8 = new SqlParameter();
                param8.ParameterName = "@Country";
                param8.Value = user.Country;
                cmd.Parameters.Add(param8);

                SqlParameter param9 = new SqlParameter();
                param9.ParameterName = "@Uname";
                param9.Value = user.Uname;
                cmd.Parameters.Add(param9);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        
        /// <summary>
        /// Authenticates a user 
        /// </summary>
        /// <param name="Email">Email inserted by the user</param>
        /// <param name="Password">Password inserted by the user</param>
        /// <returns>Returns the result</returns>
        public bool authenticateUser(string Username, string Password)
        {
            string Query = @"select count(*) from Member where Username = @Username and Password = @PW";

            bool result = false;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Username";
                param.Value = Username;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@PW";
                param2.Value = Password;
                cmd.Parameters.Add(param2);

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// Authenticates an Admin
        /// </summary>
        /// <param name="Email">Email inserted by the user</param>
        /// <param name="Password">Password inserted by the user</param>
        /// <returns>Returns the result</returns>
        public bool authenticateAdmin(string Username, string Password)
        {
            string Query = @"select count(*) from Admin where Username = @Username and Password = @PW";

            bool result = false;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Username";
                param.Value = Username;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@PW";
                param2.Value = Password;
                cmd.Parameters.Add(param2);

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return result;
        }



        public void addSaga(Saga sagan)
        {
            string Query = @"insert into Saga values(@Namn, @Beskrivning, @Data, @Langd, @Pris, GETDATE(), null, 0)";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Namn";
                param.Value = sagan.Namn;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Beskrivning";
                param2.Value = sagan.Beskrivning;
                cmd.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@Data";
                param3.Value = sagan.Data;
                cmd.Parameters.Add(param3);

                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@Langd";
                param4.Value = sagan.Langd;
                cmd.Parameters.Add(param4);

                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@Pris";
                param5.Value = sagan.Pris;
                cmd.Parameters.Add(param5);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<Saga> getSaga()
        {
            List<Saga> sagor = new List<Saga>();

            SqlDataReader reader = null;

            string Query = @"select * from Saga";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Saga sagan = new Saga();

                    sagan.Namn = (string)reader["Namn"];
                    sagan.Langd = (string)reader["Langd"];
                    sagan.Pris = (int)reader["Pris"];
                    sagan.Beskrivning = (string)reader["Beskrivning"];

                    sagor.Add(sagan);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return sagor;

        }

        /// <summary>
        /// Authenticates an Editor
        /// </summary>
        /// <param name="Email">Email inserted by the user</param>
        /// <param name="Password">Password inserted by the user</param>
        /// <returns>Returns the result</returns>
        public bool authenticateEditor(string Username, string Password)
        {
            string Query = @"select count(*) from Redaktor where Username = @Username and Password = @PW";

            bool result = false;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Username";
                param.Value = Username;
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@PW";
                param2.Value = Password;
                cmd.Parameters.Add(param2);

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return result;
        }

        public void removeSaga(string Namn)
        {
            string Query = @"delete from Saga where Namn = @Namn";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Namn";
                param.Value = Namn;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<Saga> getSagorByUser(string Username)
        {
            List<Saga> sagorna = new List<Saga>();

            SqlDataReader reader = null;

            string Query = @"Select * from Saga join SagorMedlem on SagorMedlem.Member = Member.Username where SagorMedlem.Member = @User";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Query, con);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@User";
                param.Value = Username;
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Saga sagan = new Saga();

                    sagan.Namn = (string)reader["Namn"];
                    sagan.Langd = (string)reader["Langd"];
                    sagan.Beskrivning = (string)reader["Beskrivning"];

                    sagorna.Add(sagan);
                }
            }
            catch(Exception ex)
            {
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
                if(reader != null)
                {
                    reader.Close();
                }
            }
            return sagorna;
        }
    }
}
