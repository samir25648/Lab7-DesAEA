using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class DInvoice
    {
        public static string ConnectionString { get; set; } = "Data Source=SAMIR;Initial Catalog=tarea;User ID=userTecsup;Password=123456";

        public List<Invoice> Get()
        {
            List<Invoice> detalles = new List<Invoice>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "usp_ListarInvoice";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Invoice detalle = new Invoice
                                {
                                    invoice_id = reader.GetInt32(reader.GetOrdinal("invoice_id")),
                                    customer_id = reader.GetInt32(reader.GetOrdinal("customer_id")),
                                    date = reader.GetDateTime(reader.GetOrdinal("date")),
                                    total = reader.GetDecimal(reader.GetOrdinal("total"))
                                };
                                detalles.Add(detalle);
                            }
                        }
                    }
                }
            }

            return detalles;
        }

    }
}
