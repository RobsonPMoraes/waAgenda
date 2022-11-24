using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogar_Click(object sender, EventArgs e)
        {
            String email = txbEmail.Text;
            String senha = txbSenha.Text;

            // Capturar a string de conexão

            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];

            // Criar um objeto de conexão

            SqlConnection con = new SqlConnection(); // cria um objeto  de conexão chamado con
            con.ConnectionString = connString.ToString(); // definido o tipo de string que ele vai utilizar

            SqlCommand cmd = new SqlCommand(); // cria um objeto de comando chamado cmd que vai executar os comandos no banco
            cmd.Connection = con; // mostramos qual a conexão será feita
            cmd.CommandText = "SELECT * FROM Usuarios WHERE email = @email AND senha = @senha"; // definindo os comandos insert into na tabela contato com os values declarados
            cmd.Parameters.AddWithValue("email", txbEmail.Text); // comando para copiar os parâmetros dos textbox
            cmd.Parameters.AddWithValue("senha", txbSenha.Text);
            con.Open(); // abertura da conexão

            SqlDataReader registro = cmd.ExecuteReader(); // ao chamar o comando ExecuteReader(); ele trará de retorno nada ou vários valores, que será armazendo na variável registro
            if (registro.HasRows) // Se pelo menos teve retorno de ao menos um registro
            {
                // Criando cookie de validação
                HttpCookie login = new HttpCookie("login", txbEmail.Text);
                Response.Cookies.Add(login);
                //Response.Cookies.Add(new HttpCookie("senha", txbSenha.Text));
                // direcionar para a página principal
                Response.Redirect("~/index.aspx");
            }
            else
            {
                // devemos alertar o usuário de possível erro.
                // em JS
                Response.Write("<script> alert('E - mail ou Senha incorretos!');</script>");
                //lMsg.Text = "E-mail ou senha incorreto!";
            }



          
        }
    }
}