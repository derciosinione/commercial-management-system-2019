using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class bllProdutos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Id_produto { get; set; }
        public string Nome { get; set; }
        public int Idcategoria { get; set; }
        public int Volume { get; set; }
        public string dataValidade { get; set; }
        public string dataFabricacao { get; set; }
        public decimal Custus { get; set; }
        public byte[] Imagem { get; set; }
        public decimal Preco { get; set; }
        public string result { get; set; }
        public bool vf = false;
        public string Comando;
        public DataTable tabelaS;

        public bool inserirproduto()
        {
            try
            {

                cnx.dbOnn(true);
                if (Imagem==null)
                {
                    #region (Cadastrar sem Imagem)
                    Comando = "exec sp_produtos 0,'" + Codigo + "','" + Idcategoria + "','" + Nome + "','" + Imagem + "','" + Preco + "'";
                    cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                    #endregion
                }
                else
                {
                    #region (Cadastrar com Imagem)
                    cnx.Cmd = new SqlCommand("sp_produtos", cnx.Conect);
                    cnx.Cmd.CommandType = CommandType.StoredProcedure;
                    cnx.Cmd.Parameters.AddWithValue("@id1", 0);
                    cnx.Cmd.Parameters.AddWithValue("@codigo1", Codigo);
                    cnx.Cmd.Parameters.AddWithValue("@id_categoria1", Idcategoria);
                    cnx.Cmd.Parameters.AddWithValue("@nome1", Nome);
                    cnx.Cmd.Parameters.AddWithValue("@imagem1", Imagem);
                    cnx.Cmd.Parameters.AddWithValue("@preco1", Preco);
                    #endregion
                }
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                result = "Produto cadastrado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao cadastrar o produto \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public bool inserirproduto_entrada()
        {
            try
            {
                cnx.dbOnn(true);
                Comando = "exec sp_produtos_entrada 0,'"+Id_produto+"','"+Volume+"','"+dataFabricacao+"','"+dataValidade+"','"+Custus+"'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                result = "Registo efectuado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao efectuar efectuar entrada \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public bool editarproduto()
        {
            try
            {

                cnx.dbOnn(true);

                if (Imagem==null)
                {
                    #region (Editar Com Imagem)
                    Comando = "exec sp_produtos '" + Id + "','" + Codigo + "','" + Idcategoria + "','" + Nome + "','" + Imagem + "','" + Preco + "'";
                    cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                    #endregion
                }
                else
                {
                    #region (Editar Com Imagem)
                    cnx.Cmd = new SqlCommand("sp_produtos", cnx.Conect);
                    cnx.Cmd.CommandType = CommandType.StoredProcedure;
                    cnx.Cmd.Parameters.AddWithValue("@id1", Id);
                    cnx.Cmd.Parameters.AddWithValue("@codigo1", Codigo);
                    cnx.Cmd.Parameters.AddWithValue("@id_categoria1", Idcategoria);
                    cnx.Cmd.Parameters.AddWithValue("@nome1", Nome);
                    cnx.Cmd.Parameters.AddWithValue("@imagem1", Imagem);
                    cnx.Cmd.Parameters.AddWithValue("@preco1", Preco);
                    #endregion
                }
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                result = "Produto editado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao editar o produto \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool editarproduto_entrada()
        {
            try
            {
                cnx.dbOnn(true);
                Comando = "exec sp_produtos_entrada '"+Id+"','" + Id_produto + "','" + Volume + "','" + dataFabricacao + "','" + dataValidade + "','" + Custus + "'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                result = "Edição concluida";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao editar\n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool deleteProdutos(bool x)
        {
            try
            {
                Comando = (x) ? "exec sp_delete '" + this.Id + "','produtos'" : "exec sp_delete_entrada '" + this.Id + "'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
               
                    result = "Registo Eliminado com sucesso";
                    vf = true;
                    return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao eliminar registo " + ms.Message;
                vf = false;
                return false;
            }
            finally {
                cnx.dbOnn(false);
            }
        }
        public bool desactivarProduto(int likeBoll)
        {
            try
            {
                Comando = "exec sp_desativar_produto '" + likeBoll + "','" + Id_produto + "'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = (likeBoll == 1) ? "Produto desactivado com sucesso" : "Produto activado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao completar ação" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public DataTable AllProdutos(bool x,string Campo, string Buscar)
        {
            // x=true indica que é para mostrar todos produtos, x=false indica que é para mostrar os produtos a venda

            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (x)
                {
                    if (Campo == "top")
                    {
                        Comando = "select " + Campo + " " + Buscar + " * from vw_produtos order by id desc";
                    }
                    else if (Campo == "tot")
                    {
                        Comando = "select count(*) from vw_produtos";
                    }
                    else if (Campo == "id" || Campo == "volume" || Campo == "codigo")
                    {
                        Comando = "select * from vw_produtos where " + Campo + " like ('" + Buscar + "%')";
                    }
                    else
                    {
                        Comando = "select * from vw_produtos where " + Campo + " like ('" + Buscar + "%') or " + Campo + " like ('%" + Buscar + "') or " + Campo + " like ('%" + Buscar + "%')";
                    }
                }
                else
                {
                    if (Campo == "top")
                    {
                        Comando = "select top 1 percent * from vw_produtos where estado='activado'";
                    }
                    else
                    {
                    Comando = "select top 9 * from vw_produtos where estado='activado' and " + Campo + " like ('" + Buscar + "%') or " + Campo + " like ('%" + Buscar + "') or " + Campo + " like ('%" + Buscar + "%')";
                    }
                }

                #endregion

                
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);

            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message);
            }
            return tabelaS;
        }
        public DataTable AllProdutos_entrada(int newId, string Campo, string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (Campo == "top")
                {
                    Comando = "select " + Campo + " " + Buscar + " * from vw_produtos_entrada where id_produto=" + newId;
                }
                else if (Campo == "tot")
                {
                    Comando = "select count(*) from vw_produtos_entrada where id_produto=" + newId;
                }
                else if (Campo == "id" || Campo == "volume" || Campo == "custus")
                {
                    Comando = "select * from vw_produtos_entrada where " + Campo + " like concat('" + Buscar + "','%') and id_produto=" + newId;
                }
                else if (Campo == "data de fabricação" || Campo == "data de validade" || Campo == "data de entrada")
                {
                    if (Campo == "data de fabricação")
                    {
                        Campo = "data_fabricacao";
                    }
                    else if (Campo == "data de validade")
                    {
                        Campo = "data_validade";
                    }
                    else
                    {
                        Campo = "data_entrada";
                    }

                    Comando = "select * from vw_produtos_entrada where " + Campo + " like concat('%','" + Buscar + "','%') or " + Campo + " like concat('" + Buscar + "','%') or " + Campo + " like concat('%','" + Buscar + "') and id_produto=" + newId;
                }
                else
                {
                    Comando = "select * from vw_produtos_entrada where " + Campo + " like ('" + Buscar + "%') or " + Campo + " like ('%" + Buscar + "') or " + Campo + " like ('%" + Buscar + "%') and id_produto=" + newId;
                }

                #endregion

                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);

            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message);
            }
            return tabelaS;
        }
    }
}
