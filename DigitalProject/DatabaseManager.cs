using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace DigitalProject
{
    class DatabaseManager
    {
        public static QueryFactory QueryFactory
        {
            get
            {
                var connection = new MySqlConnection($"Server=34.76.219.140; database=test; UID=root; password=ada123");
                var compiler = new MySqlCompiler();

                var queryFactory = new QueryFactory(connection, compiler);

                //queryFactory.Logger = result => { MessageBox.Show(result.ToString()); };

                return queryFactory;
            }
        }
    }
}
