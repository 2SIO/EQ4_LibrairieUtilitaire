using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ4_LibrairieUtilitaire
{
    public class Class1
    {
        string message = " ";
        #region ouverture de connexion
        public static String OpenConnexion(String SonLogin,String SonMdp,String SonServeur,String SaBD, out Boolean verif, out String )
        {
            String Message = " ";

            SqlConnection gObjetConnection = new SqlConnection();

            gObjetConnection.ConnectionString = "User ID =" + SonLogin + ";PWD= " + SonMdp + "; Server= " + SonServeur + "; Database=" + SaBD+ ";";

            try
            {
                
                gObjetConnection.Open();
                Message = "Connexion Reussie";
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                
               Message = "Connexion échoué"+probleme;
            }
            return Message;
        }
        #endregion
    }
}
