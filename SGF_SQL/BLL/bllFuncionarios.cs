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
    public class bllFuncionarios
    {

        public int Id_funcionario { get; set; }
        public int Id_contacto { get; set; }
        public int id_cargo { get; set; }        
        public string Nome { get; set; }
        public string BI { get; set; }
        public string Sexo { get; set; }
        public string Data { get; set; }
        public string Residencia { get; set; }
        public string Formacao { get; set; }
        public string Email { get; set; }
        public string Banco { get; set; }
        public string Num_banco { get; set; }
        public string IBAN { get; set; }
        public decimal Aumento { get; set; }
        public byte[] Imagem { get; set; }
        public string Nome_User { get; set; }
        public string Senha { get; set; }
        public string Acesso { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public decimal Salario { get; set; }
        public string result { get; set; }
        public bool vf = false;
        public string Comando;
        public DataTable tabelaS;

        public bool inserirFuncionario()
        {
            try
            {
                cnx.dbOnn(true);
                if (Imagem==null)
                {
                    #region (Cadastrar sem Imagem)

                    Comando = "exec sp_funcionarios '" + 0 + "','" + BI + "','" + Nome + "','" + Sexo + "','" + Data + "','" + Residencia + "','" + Formacao + "','" + Email + "','" + Banco + "','" + Num_banco + "','" + IBAN + "','" + Aumento + "','" + Imagem + "','" + Acesso + "','" + id_cargo + "'";

                    
                    cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                    #endregion
                }
                else
                {
                    #region (Cadastrar com Imagem)
                    cnx.Cmd = new SqlCommand("sp_funcionarios", cnx.Conect);
                    cnx.Cmd.CommandType = CommandType.StoredProcedure;
                    cnx.Cmd.Parameters.AddWithValue("@id1", 0);
                    cnx.Cmd.Parameters.AddWithValue("@bi1", BI);
                    cnx.Cmd.Parameters.AddWithValue("@nome1", Nome);
                    cnx.Cmd.Parameters.AddWithValue("@sexo1", Sexo);
                    cnx.Cmd.Parameters.AddWithValue("@data1", Data);
                    cnx.Cmd.Parameters.AddWithValue("@residencia1", Residencia);
                    cnx.Cmd.Parameters.AddWithValue("@formacao1", Formacao);
                    cnx.Cmd.Parameters.AddWithValue("@email1", Email);
                    cnx.Cmd.Parameters.AddWithValue("@banco1", Banco);
                    cnx.Cmd.Parameters.AddWithValue("@num_banco1", Num_banco);
                    cnx.Cmd.Parameters.AddWithValue("@iban1", IBAN);
                    cnx.Cmd.Parameters.AddWithValue("@aumento1", Aumento);
                    cnx.Cmd.Parameters.AddWithValue("@imagem1", Imagem);
                    cnx.Cmd.Parameters.AddWithValue("@acesso1", Acesso); ;
                    cnx.Cmd.Parameters.AddWithValue("@id_cargo1", id_cargo);

                    #endregion
                }
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Funcionário cadastrado com sucesso";
                vf = true;
                inserirContacto();
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao cadastrar o funcionário \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool editarFuncionario()
        {
            try
            {
                
                cnx.dbOnn(true);
                if (Imagem == null)
                {
                    #region (Cadastrar sem Imagem)
                    Comando = "exec sp_funcionarios '"+Id_funcionario+"','" + BI + "','" + Nome + "','" + Sexo + "','" + Data + "','" + Residencia + "','" + Formacao + "','" + Email + "','" + Banco + "','" + Num_banco + "','" + IBAN + "','" + Aumento + "','" + Imagem + "','" + Acesso + "','" + id_cargo + "'";
                    cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                    #endregion
                }
                else
                {
                    #region (Cadastrar com Imagem)
                    cnx.Cmd = new SqlCommand("sp_funcionarios", cnx.Conect);
                    cnx.Cmd.CommandType = CommandType.StoredProcedure;
                    cnx.Cmd.Parameters.AddWithValue("@id1", Id_funcionario);
                    cnx.Cmd.Parameters.AddWithValue("@bi1", BI);
                    cnx.Cmd.Parameters.AddWithValue("@nome1", Nome);
                    cnx.Cmd.Parameters.AddWithValue("@sexo1", Sexo);
                    cnx.Cmd.Parameters.AddWithValue("@data1", Data);
                    cnx.Cmd.Parameters.AddWithValue("@residencia1", Residencia);
                    cnx.Cmd.Parameters.AddWithValue("@formacao1", Formacao);
                    cnx.Cmd.Parameters.AddWithValue("@email1", Email);
                    cnx.Cmd.Parameters.AddWithValue("@banco1", Banco);
                    cnx.Cmd.Parameters.AddWithValue("@num_banco1", Num_banco);
                    cnx.Cmd.Parameters.AddWithValue("@iban1", IBAN);
                    cnx.Cmd.Parameters.AddWithValue("@aumento1", Aumento);
                    cnx.Cmd.Parameters.AddWithValue("@imagem1", Imagem);
                    cnx.Cmd.Parameters.AddWithValue("@acesso1", Acesso); ;
                    cnx.Cmd.Parameters.AddWithValue("@id_cargo1", id_cargo);

                    #endregion
                }
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Funcionário editado com sucesso";
                vf = true;
                EditarContacto();
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao editar funcionário \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        private void inserirContacto()
        {
            try
            {
                cnx.dbOnn(true);
                Comando = "exec sp_contacto 0,'" + Tel1 + "','" + Tel2 + "'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                vf = true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao inserir o contacto do funcionário\n" + ms.Message;
                vf = false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        private void EditarContacto()
        {
            try
            {
                cnx.dbOnn(true);
                Comando = "exec sp_contacto '"+Id_funcionario + "','" + Tel1 + "','" + Tel2 + "'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
                vf = true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao Editar contacto do funcionário\n" + ms.Message;
                vf = false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool inserirCargo()
        {
            try
            {

                cnx.dbOnn(true);
                Comando = "exec sp_cargos 0,'" + Nome + "','" + Salario + "'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Cargo cadastrado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao cadastrar o Cargo.\n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool editarCargo()
        {
            try
            {

                cnx.dbOnn(true);
                Comando = "exec sp_cargos '"+id_cargo+"','"+Nome+"','"+Salario+"'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Cargo editado com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao editar o Cargo.\n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }

        public bool inserirEscala(string dia,string turno,string hora_entrada,string hora_saida)
        {
            try
            {

                cnx.dbOnn(true);
                Comando = "exec sp_escalas '" + Id_funcionario + "','"+dia+"','"+turno+"','"+hora_entrada+"','"+hora_saida+"'";
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Escala salva com sucesso";
                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao salvar escala do funcionário \n" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
       
        
        public bool trocarSenha()
        {
            try
            {
                Comando = "exec sp_User '" + Id_funcionario + "','" + Nome_User + "','"+Senha+"'";

                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = "Dados alterados com com sucesso";

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


        //public bool deleteFuncionario()
        //{
        //    try
        //    {
        //        Comando = "exec sp_delete '" + Id_funcionario + "','funcionarios'";
        //        cnx.dbOnn(true);
        //        cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
        //        cnx.Conect.Open();
        //        cnx.Cmd.ExecuteNonQuery();

        //        result = "Funcionário Eliminado com sucesso";
        //        vf = true;
        //        return true;
        //    }
        //    catch (Exception ms)
        //    {
        //        result = "BLL Erro ao eliminar registo" + ms.Message;
        //        vf = false;
        //        return false;
        //    }
        //    finally
        //    {
        //        cnx.dbOnn(false);
        //    }
        //}
        public bool deleteEscala()
        {
            try
            {
                Comando = "exec sp_delete_escala '" + Id_funcionario + "'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                vf = true;
                return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao eliminar a escala do funcionário" + ms.Message;
                vf = false;
                return false;
            }
            finally
            {
                cnx.dbOnn(false);
            }
        }
        public bool deleteCargo()
        {
            try
            {
                Comando = "exec sp_delete '" + id_cargo + "','cargos'";
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();
               
                    result = "Cargo Eliminado com sucesso";
                    vf = true;
                    return true;
            }
            catch (Exception ms)
            {
                result = "BLL Erro ao eliminar Cargo" + ms.Message;
                vf = false;
                return false;
            }
            finally {
                cnx.dbOnn(false);
            }
        }
        public bool desablitar(int ops)
        {
            try
            {
                Comando="exec sp_desablitar_funcionario '" + ops + "','"+Id_funcionario+"'";
                
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand(Comando, cnx.Conect);
                cnx.Conect.Open();
                cnx.Cmd.ExecuteNonQuery();

                result = (ops == 0) ? "Funcionário desablitado com sucesso" : "Funcionário hablitado com sucesso";

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
        public DataTable AllFuncionarios(string Campo, string Buscar)
        {   
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (Campo == "top")
                {

                    Comando = "select top "+Buscar+" f.*, c.nome 'cargo', c.salario from funcionarios f left join cargos c on c.id=f.id_cargo order by f.nome";
                }
                else
                {
                    Comando = "exec select_funcionarios '" + Campo + "','" + Buscar + "'";
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
        public DataTable AllEscalas(string Campo, string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (Campo == "top")
                {

                    Comando = "select top " + Buscar + " e.dia,e.turno,e.hora_entrada,e.hora_saida,f.nome from escala e inner join funcionarios f on f.id=e.id_funcionario order by e.dia,e.turno";
                }
                else
                {
                    Comando = "exec select_escalas '" + Campo + "','" + Buscar + "'";
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
        
        public DataTable AllContacto(int id_funcionario)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                Comando = "exec select_contacto '" + id_funcionario + "'";
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
        public DataTable AllCargos(string Campo, string Buscar)
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);

                #region (verificar campos)
                if (Campo == "top")
                {

                    Comando = "select " + Campo + " " + Buscar + " * from cargos";
                }
                else
                {
                    Comando = "exec select_cargos '" + Campo + "','" + Buscar + "'";
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
        public DataTable TocombolCargos()
        {
            tabelaS = new DataTable();
            try
            {
                tabelaS.Clear();
                cnx.dbOnn(true);
                cnx.Cmd = new SqlCommand("select * from cargos order by nome", cnx.Conect);
                cnx.Adp = new SqlDataAdapter(cnx.Cmd);
                cnx.Adp.Fill(tabelaS);
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cnx.dbOnn(false); }
            return tabelaS;
        }
        public ComboBox FullCombol(ComboBox cbx)
        {
            try
            {
                TocombolCargos();
                cbx.Items.Clear();

                for (int i = 0; i < TocombolCargos().Rows.Count; i++)
                {
                    cbx.Items.Add(TocombolCargos().Rows[i][1]);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show("Bll " + ms.Message, "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cbx;
        }
        public int retornarId(int linha)
        {
            return (int)TocombolCargos().Rows[linha][0];
        }
    }
}
