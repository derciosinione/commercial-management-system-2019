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
    public class bllVendas
    {
        public int Id { get; set; }
        public int Id_produto { get; set; }
        public int Id_funcionario { get; set; }
        public string Estado { get; set; }
        public string Tipo_pagamento { get; set; }
        public string Cliente { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal Total { get; set; }
        public decimal Valor_pago { get; set; }
        public string result { get; set; }
        public bool vf = false;
        public bool vf_pagamento = false;
        public string Comando;
        public DataTable tabelaS;


        public bool inserirPagamento()
        {
            try
            {
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("sp_pagamento", cnx.Conect);
                cnx.Cmd.CommandType = CommandType.StoredProcedure;
                cnx.Cmd.Parameters.AddWithValue("@cliente1", Cliente);
                cnx.Cmd.Parameters.AddWithValue("@total1", Total);
                cnx.Cmd.Parameters.AddWithValue("@valorpago1", Valor_pago);
                cnx.Cmd.Parameters.AddWithValue("@tipo_pagamento1", Tipo_pagamento);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                vf_pagamento = true;
                return true;
                
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao efectuar pagamento \n" + ms.Message;
                vf_pagamento = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool inserirVenda()
        {
            try
            {
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("sp_venda", cnx.Conect);
                cnx.Cmd.CommandType = CommandType.StoredProcedure;
                cnx.Cmd.Parameters.AddWithValue("@id_produto1", Id_produto);
                cnx.Cmd.Parameters.AddWithValue("@quantidade1", Quantidade);
                cnx.Cmd.Parameters.AddWithValue("@preco1", Preco);
                cnx.Cmd.Parameters.AddWithValue("@id_funcionario1", Id_funcionario);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                result = "Venda feita com sucesso";
                vf = true;
                return true;
                
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                result = "BLL Erro ao efectuar venda \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool deleteVenda()
        {
            try
            {
                Comando = "exec sp_delete_vendas '" + this.Id + "'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
               
                    result = "Venda eliminada com sucesso";
                    vf = true;
                    return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao eliminar a venda "+ this.Id+" " + ms.Message;
                vf = false;
                return false;
            }
            finally {
                cnx.dbOnn(false);
            }
        }

        public string lastId()
        {
            try
            {
                tabelaS = new DataTable();
                cnx.dbOnn(true);
                Comando = "select MAX(id) from venda_pagamento";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
                return tabelaS.Rows[0][0].ToString();

            }
            catch (Exception ms)
            {
                MessageBox.Show("Erro ao pegar o id do pagamento"+ms.Message);
                vf = false;
                return "0";
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public bool cancelarVenda(int likeBoll,int id_pagamento)
        {
            try
            {
                Comando = "exec sp_cancelar_venda '"+likeBoll+"','"+id_pagamento+"'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = (likeBoll == 1) ? "Venda cancelada com sucesso" : "Venda registada com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao cancelar" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public DataTable AllVendas(string Campo, string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (Campo == "top")
                {

                    Comando = "select " + Campo + " " + Buscar + " * from vw_vendas where(MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE())) order by id desc";
                }
                else
                {
                    Comando = "exec select_Allvendas '" + Campo + "','" + Buscar + "'";
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
        public DataTable AllVendas_today(string id_funcionario, string Campo, string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                    if (Campo == "top")
                    {

                        //Comando = "select " + Campo + " " + Buscar + " * from vw_vendas where(id_funcionario='" + id_funcionario + "' and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by id desc";

                        Comando = "select * from vw_vendas where(id_funcionario='" + id_funcionario + "' and (DAY(data)=DAY(GETDATE()) and MONTH(data)=MONTH(GETDATE()) and YEAR(data)=YEAR(GETDATE()))) order by id desc";
                    }
                    else 
                    {
                        Comando = "exec select_vendas_today '"+id_funcionario+"','"+Campo+"','"+Buscar+"'";
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
