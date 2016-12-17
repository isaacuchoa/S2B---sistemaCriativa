using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    #region Construtores
        public Usuario()
	    {
            this.persisted = false;
        }
        public Usuario(int ID)
        {
            this.m_idUsuario =  ID;
            this.persisted = true;
        }
        #endregion

    #region Atributos
        private int m_idUsuario;
        private String m_Login;
        private String m_Senha;
        private String m_Nome;
        private String m_Email;
        private String m_Celular;
        private String m_UltimoAcesso;
        private bool m_Admin;
        private bool persisted;
    #endregion

    #region Propriedades
        public int IdUsuario
        {
            get { return m_idUsuario; }
            set { m_idUsuario = value; }
        }
        public String Login
        {
            get { return m_Login; }
            set { m_Login = value; }
        }
        public String Senha
        {
            get { return m_Senha; }
            set { m_Senha = value; }
        }
        public String Nome
        {
            get { return m_Nome; }
            set { m_Nome = value; }
        }
        public String Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        public String Celular
        {
            get { return m_Celular; }
            set { m_Celular = value; }
        }
        public String UltimoAcesso
        {
            get { return m_UltimoAcesso; }
            set { m_UltimoAcesso = value; }
        }
        public bool Admin
        {
            get { return m_Admin; }
            set { m_Admin = value; }
        }
    #endregion

    #region Variaveis
        private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
    #endregion

    #region Métodos
        public void Save()
        {
            if (persisted)
            {
                this.Update();
            }
            else
            {
                this.Insert();
            }
        }
        private void SetParameters(SqlParameter[] parms)
        {
            /*Esse método atribui os valores dos membros a cada
             parâmetro do SqlCommand.*/
            parms[0].Value = this.m_idUsuario;
            parms[1].Value = this.m_Login;
            parms[2].Value = this.m_Senha;
            parms[3].Value = this.m_Nome;
            parms[4].Value = this.m_Email;
            parms[5].Value = this.m_Celular;
            parms[6].Value = this.m_Admin;
            parms[7].Value = this.m_UltimoAcesso;

        }
        private bool Update()
        {
            //this.LoadObject();
            SqlParameter[] Parametros = GetParameters();
            SqlCommand Comando = new SqlCommand("UpdUsuario", Conn);
            SetParameters(Parametros);

            try
            {
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddRange(Parametros);
                Conn.Open();
                Comando.ExecuteNonQuery();
                return true; //retorna TRUE, se tudo ocorrer nos conformes ^^
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
            finally
            {
                Conn.Close();
            }
            return false;
        }
        private static SqlParameter[] GetParameters()
        {
            /*Esse método cria um array com os parâmetros 
             * correspondentes aos campos da tabela. */
         SqlParameter[] Parametros = new SqlParameter[]{
             new SqlParameter("idUsuario", DbType.Int32),
             new SqlParameter("Login", DbType.String),
             new SqlParameter("Senha",DbType.String),
             new SqlParameter("Nome",DbType.String),
             new SqlParameter("Email",DbType.String),
             new SqlParameter("Celular",DbType.String),
             new SqlParameter("Admin",DbType.String),
             new SqlParameter("Ultimo_Acesso", DbType.String),
                                                       };

            return Parametros;

        }
        public void LoadObject()
        {
            SqlParameter[] Parametros = GetParameters(); //Pega o array de PARAMETROS
            SqlCommand Comando = new SqlCommand("SELECT * FROM Usuarios WHERE (idUsuario = @IDUSUARIO)", Conn);
            SqlDataReader dr;
            Comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
            Comando.Parameters["@IDUSUARIO"].Value = this.m_idUsuario;
            try
            {
                Conn.Open();
                dr = Comando.ExecuteReader();
                dr.Read();
                this.m_Login        = dr["Login"].ToString();
                this.m_Senha        = dr["Senha"].ToString();
                this.m_Nome         = dr["Nome"].ToString();
                this.m_Email        = dr["Email"].ToString();
                this.m_Celular      = dr["Celular"].ToString();
                this.m_Admin        = (bool)dr["Admin"];
                this.m_UltimoAcesso = dr["Ultimo_Acesso"].ToString();
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                Conn.Close();
            }
        }
        private bool Insert()
        {
            SqlParameter[] Parametros = GetParameters(); //Pega o array de PARAMETROS
            SqlCommand Comando = new SqlCommand("InsUsuario", Conn);

            try
            {
                Comando.CommandType = CommandType.StoredProcedure;
                SetParameters(Parametros); //Atribuindo os valores dos atributos da classe a cada parâmetro
                Comando.Parameters.AddRange(Parametros); //Finalmente, adicionando os parâmetros já com seus respectivos valores a Collection de Parâmetros do SqlCommand
                Conn.Open();
                Comando.ExecuteNonQuery();
                return true; //retorna true, se tudo ocorrer nos conformes ^^
            }
            catch (Exception Ex)
            {

            }
            finally
            {

                Conn.Close();
            }
            return false;
        }
        public static bool Delete(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
            SqlCommand Comando = new SqlCommand("DelUsuario", conn);
            Comando.CommandType = CommandType.StoredProcedure;

            try
            {
                Comando.Parameters.Add("@IDUSUARIO", SqlDbType.Int);
                Comando.Parameters["@IDUSUARIO"].Value = id;
                conn.Open();
                Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            { }
            finally
            {
                conn.Close();
            }

            return false;
        }
   #endregion
}
