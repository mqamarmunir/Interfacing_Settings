using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace DataLayer
{
    /// <summary>
    /// Summary description for clsdbhims.
    /// </summary>
    public class clsdbhims : Iinterface, IDisposable
    {
        public clsdbhims()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        # region "Class_Variables"

        private string StrQuery = null;

        # endregion

        #region "Properties"

        public string Query
        {
            get { return StrQuery; }
            set { StrQuery = value; }
        }

        # endregion

        # region "Data_Methods"

        public MySqlCommand Delete()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Insert()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Get_Max()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Update()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }


        public MySqlCommand Get_All()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }

        public MySqlCommand Get_Single()
        {
            MySqlCommand objCommand = new MySqlCommand();

            objCommand.CommandText = this.Query;
            objCommand.CommandType = CommandType.Text;

            return objCommand;
        }
        #endregion

        public void Dispose()
        {
            
        }
    }
}
