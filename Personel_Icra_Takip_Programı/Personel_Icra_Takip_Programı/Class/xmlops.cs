using Devart.Data.PostgreSql;
using Npgsql;
using Personel_Icra_Takip_Programı.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Personel_Icra_Takip_Programı.Classlar
{
    class xmlops
    {
        private String filePath;
        private String fileName;
        //password = mkAk3FHkst  --------------------DO NOT DELETE ------------------------

        public String FILEPATH
        {
            get
            {
                return this.filePath;
            }

            set
            {
                if (value != String.Empty && value != "") { 
                    this.filePath = value;
                }
            }
        }

        public string FILENAME
        {
            get
            {
                return this.fileName;
            }
            set
            {
                if(value != String.Empty && value != "")
                {
                    this.fileName = value;
                }
            }
        }

        private string encryptText(string input)
        {
            string result;

            result = Cipher.Encrypt(input, "mkAk3FHkst");

            return result;
        }

        private string decryptText(string input)
        {
            string result;

            result = Cipher.Decrypt(input, "mkAk3FHkst");

            return result;
        }

        public void writeDBInfo(NpgsqlConnection conn)
        {
            try
            {
                this.FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami");
                
                Directory.CreateDirectory(this.FILEPATH);
                this.FILENAME = "ConnectionInfo.xml";
                String conString = conn.ConnectionString;
                String[] connElements = conString.Split(';');
              

                XmlTextWriter textWriter = new XmlTextWriter(this.FILEPATH + "\\" + this.FILENAME, null);
               

                XmlDocument data = new XmlDocument();

                XmlElement LoginInfo = data.CreateElement("LoginInfo");

                XmlElement Server = data.CreateElement("Server");
                Server.InnerText = this.encryptText(connElements[0].Split('=')[1]);
                LoginInfo.AppendChild(Server);

                XmlElement port = data.CreateElement("Port");
                port.InnerText = this.encryptText(connElements[1].Split('=')[1]);
                LoginInfo.AppendChild(port);

                XmlElement userName = data.CreateElement("Username");
                userName.InnerText = this.encryptText(connElements[2].Split('=')[1]);
                LoginInfo.AppendChild(userName);

                XmlElement password = data.CreateElement("Password");
                password.InnerText = this.encryptText(connElements[3].Split('=')[1]);
                LoginInfo.AppendChild(password);

                XmlElement database = data.CreateElement("Database");
                database.InnerText = this.encryptText(connElements[4].Split('=')[1]);
                LoginInfo.AppendChild(database);

                data.AppendChild(LoginInfo);
                
                textWriter.Formatting = Formatting.Indented;
                data.WriteContentTo(textWriter);
                textWriter.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public PgSqlConnection getPgSqlDBInfo()
        {
            PgSqlConnection result = new PgSqlConnection();
            try
            {
                this.FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami");
                this.FILENAME = "ConnectionInfo.xml";
                Directory.CreateDirectory(this.FILEPATH);
                String server = "", port = "", username = "", password = "", database = "";
                if (!File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                {
                    CreateConnection form = new CreateConnection();
                    form.ShowDialog();
                    if (!File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                    {
                        Application.Exit();
                    }
                }
                if (File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                {
                    XmlTextReader reader = new XmlTextReader(this.FILEPATH + "\\" + this.FILENAME);
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "Server":
                                    {
                                        reader.Read();
                                        server = reader.Value;
                                        break;
                                    }
                                case "Port":
                                    {
                                        reader.Read();
                                        port = reader.Value;
                                        break;
                                    }
                                case "Username":
                                    {
                                        reader.Read();
                                        username = reader.Value;
                                        break;
                                    }
                                case "Password":
                                    {
                                        reader.Read();
                                        password = reader.Value;
                                        break;
                                    }
                                case "Database":
                                    {
                                        reader.Read();
                                        database = reader.Value;
                                        break;
                                    }
                            }
                        }

                    }

                    reader.Close();

                    result.ConnectionString = "Host=" + this.decryptText(server) + ";" +
                                               "Port=" + this.decryptText(port) + ";" +
                                               "User Id=" + this.decryptText(username) + ";" +
                                               "Password=" + this.decryptText(password) + ";" +
                                               "Database=" + this.decryptText(database) + ";" +
                                               "Character Set=utf8;" +
                                               "Initial Schema=public;";

                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
        public NpgsqlConnection getDBInfo()
        {

            NpgsqlConnection result = new NpgsqlConnection();
            try
            {
                this.FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami");
                this.FILENAME = "ConnectionInfo.xml";
                Directory.CreateDirectory(this.FILEPATH);
                String server = "", port = "", username = "", password = "", database = "";
                if (!File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                {
                    CreateConnection form = new CreateConnection();
                    form.ShowDialog();
                    if (!File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                    {
                        Application.Exit();
                    }
                }
                if (File.Exists(this.FILEPATH + "\\" + this.FILENAME))
                {
                    XmlTextReader reader = new XmlTextReader(this.FILEPATH + "\\" + this.FILENAME);
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "Server":
                                    {
                                        reader.Read();
                                        server = reader.Value;
                                        break;
                                    }
                                case "Port":
                                    {
                                        reader.Read();
                                        port = reader.Value;
                                        break;
                                    }
                                case "Username":
                                    {
                                        reader.Read();
                                        username = reader.Value;
                                        break;
                                    }
                                case "Password":
                                    {
                                        reader.Read();
                                        password = reader.Value;
                                        break;
                                    }
                                case "Database":
                                    {
                                        reader.Read();
                                        database = reader.Value;
                                        break;
                                    }
                            }
                        }

                    }

                    reader.Close();

                    result.ConnectionString = "Server=" + this.decryptText(server) + ";" +
                                               "Port=" + this.decryptText(port) + ";" +
                                               "User Id=" + this.decryptText(username) + ";" +
                                               "Password=" + this.decryptText(password) + ";" +
                                               "Database=" + this.decryptText(database) + ";";

                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

    }
}
