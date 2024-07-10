﻿namespace DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString(string DatabaseName = "master")
        {
            return $"Data Source=.;Initial Catalog={DatabaseName};Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
