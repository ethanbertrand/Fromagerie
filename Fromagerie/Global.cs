using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Fromagerie
{
    public static class Global
    {
        // Chaîne de connexion accessible partout
        public static string ConnectionString { get; set; } =
            "Server=172.16.119.25;Database=fromagerie;Uid=mathias;Pwd=mathias;";

        // Exemple : utilisateur connecté
        public static string UtilisateurCourant { get; set; }
    }
    internal class global
    {
    }
}
