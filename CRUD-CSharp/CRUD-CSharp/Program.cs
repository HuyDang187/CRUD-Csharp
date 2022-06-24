using System;

namespace CRUD_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerConnection connecsql = new SqlServerConnection();
            connecsql.GetData();
            if (connecsql.GetData() != null)
            {
                Console.WriteLine("Ket noi thanh cong");
            }



        }
    }
}
