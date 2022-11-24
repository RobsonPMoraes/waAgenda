using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class Contatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try // Toda conexão requer que seja inicado com o try/cath para corrigir exceções de erros
            {
                if (txbEmail.Text != "" && txbNome.Text != "" && txbTelefone.Text != "") 
                    // Se as txb conterem qualquer caracter, executará o comando de conexão, desde que não haja erro.
                {
                    // Capturar a string de conexão

                    System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
                    System.Configuration.ConnectionStringSettings connString;
                    connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];

                    // Criar um objeto de conexão

                    SqlConnection con = new SqlConnection(); // cria um objeto  de conexão chamado con
                    con.ConnectionString = connString.ToString(); // definido o tipo de string que ele vai utilizar

                    SqlCommand cmd = new SqlCommand(); // cria um objeto de comando chamado cmd que vai executar os comandos no banco
                    cmd.Connection = con; // mostramos qual a conexão será feita
                    cmd.CommandText = "Insert INTO Contato (nome, email, telefone) values (@nome, @email, @telefone)"; // definindo os comandos insert into na tabela contato com os values declarados
                    cmd.Parameters.AddWithValue("nome", txbNome.Text); // comando para copiar os parâmetros dos textbox
                    cmd.Parameters.AddWithValue("email", txbEmail.Text);
                    cmd.Parameters.AddWithValue("telefone", txbTelefone.Text);
                    con.Open(); // abertura da conexão
                    cmd.ExecuteNonQuery(); // mandamos executar a conexão
                    con.Close(); // mandamos fechar a conexão   
                    GridView1.DataBind(); // atualiza a lista após a inserção dos dados, ou seja, faça a releitura dos dados
                }
                else // do contrário irá executar essa linha de erro em JS de campos em branco
                {
                    throw new Exception("Campos em branco!");
                }
            } catch (Exception erro)
                {
                Response.Write("<script> alert ('" + erro.Message + "'); </script>");
                }
        }
    }
}