using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSourceUsuarios_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {
            
        }

        protected void SqlDataSourceUsuarios_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null) //Se exception for diferente de nulo apresentará mensagem do erro gerado. Só será diferente de nulo se apresentar algum erro
            {
                Response.Write("<script> alert ('O dado que você registrou já existe. Por favor insira um dado diferente. Todos os campos têm que estar preenchidos!'); </script>");

                // lMsg.Text = "O dado que você registrou já existe. Por favor insira um dado diferente.\nTodos os campos têm que estar preenchidos!";
               
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSourceUsuarios_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null) //Se exception for diferente de nulo apresentará mensagem do erro gerado. Só será diferente de nulo se apresentar algum erro
            {
                Response.Write("<script> alert ('Alterando o registro sem informar todos os campos!'); </script>");

                // lMsg.Text = e.Exception.Message;
                e.ExceptionHandled = true;
            }
        }
    }
}