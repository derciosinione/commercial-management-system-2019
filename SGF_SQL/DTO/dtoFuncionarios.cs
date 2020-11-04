using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using BLL;

namespace DTO
{
    public class dtoFuncionarios
    {
        bllFuncionarios f = new bllFuncionarios();
        public bool vf = false;
        public string result;

        public DataTable tbFuncionarios(string Campo, string Buscar)
        {
            return f.AllFuncionarios(Campo, Buscar);
        }
        public DataTable tbEscala(string Campo, string Buscar)
        {
            return f.AllEscalas(Campo, Buscar);
        }
        public DataTable tbContacto(int id_funcionario)
        {
            return f.AllContacto(id_funcionario);
        }

        #region (Cargos)
        public DataTable tbCargos(string Campo, string Buscar)
        {
            return f.AllCargos(Campo, Buscar);
        }

        public bool inserirCargo(string Nome, decimal Salario)
        {
            try
            {
                if (Nome == string.Empty)
                {
                    MessageBox.Show("Digite o nome do cargo", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                f.Nome = Nome;
                f.Salario = Salario;
                f.inserirCargo();
                vf = f.vf;
                result = f.result;
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO " + ms.Message, "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool editarCargo(int Id,string Nome, decimal Salario)
        {
            try
            {
                if (Id==0)
                {
                 MessageBox.Show("Id inválido", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;   
                }
                if (Nome == string.Empty)
                {
                    MessageBox.Show("Digite o nome do cargo", "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                f.id_cargo = Id;
                f.Nome = Nome;
                f.Salario = Salario;
                f.editarCargo();
                vf = f.vf;
                result = f.result;
                return true;

            }
            catch (Exception ms)
            {
                MessageBox.Show("DTO " + ms.Message, "Cargos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public ComboBox Cargos(ComboBox cbxCargos)
        {
            f.FullCombol(cbxCargos);
            return cbxCargos;
        }
        public int pegarIdCargo(int valor)
        {
            return f.retornarId(valor);
        }
   
        public bool deleteCargo(int Id)
        {
            try
            {

                if (MessageBox.Show("Deseja eliminar o cargo com Id " + Id + "?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Id <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    }

                    f.id_cargo = Id;
                    f.deleteCargo();

                    result = f.result;
                    vf = f.vf;
                    return vf;
                }
                else
                {
                    result = "DTO Seleção cancelada";
                    vf = true;
                    return false;
                }
            }
            catch (Exception ms)
            {
                result = "DTO " + ms.Message;
                vf = false;
                return false;
            }
        }
        
        #endregion
        
        public bool inserirFuncionario(string BI, string Nome, string Sexo, string Data, string Residencia, string Formacao,string Email,string Banco,string Num_banco,string IBAN,decimal Aumento,byte[] Imagem,string Acesso,int Id_cargo,string Tel1,string Tel2)
        {
            try
            {
                if (Nome == string.Empty)
                {
                    result = "Digite o nome do funcionário";
                    vf = false;
                    return false;
                }
                if (Id_cargo <= 0)
                {
                    result = "Selecione o cargo do funcionário";
                    vf = false;
                    return false;
                }
                if (BI==string.Empty)
                {
                    result = "Informe o número do Bilhete de identificação";
                    vf = false;
                    return false;
                }
                if (Sexo == string.Empty)
                {
                    result = "Informe o gênero do funcionário";
                    vf = false;
                    return false;
                }
                if (Tel1 == string.Empty)
                {
                    Tel1 = null;
                }
                if (Tel2 == string.Empty)
                {
                    Tel2 = null;
                }
                if (Acesso=="not")
                {
                    Acesso = null;
                }

                // Adicionar valores 
                f.Nome = Nome;
                f.BI = BI;
                f.Sexo = Sexo;
                f.Data = Data;
                f.Residencia = Residencia;
                f.Formacao = Formacao;
                f.Email = Email;
                f.Banco = Banco;
                f.Num_banco = Num_banco;
                f.IBAN = IBAN;
                f.Aumento = Aumento;
                f.Imagem = Imagem;
                f.Acesso = Acesso;
                f.id_cargo = Id_cargo;
                f.Tel1 = Tel1;
                f.Tel2 = Tel2;
                // Iniciar cadastro
                f.inserirFuncionario();
                vf = f.vf;
                result = f.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                return false;
            }
        }

        public bool editarFuncionario(int Id,string BI, string Nome, string Sexo, string Data, string Residencia, string Formacao, string Email, string Banco, string Num_banco, string IBAN, decimal Aumento, byte[] Imagem, string Acesso, int Id_cargo, string Tel1, string Tel2)
        {
            try
            {
                if (Id <= 0)
                {
                    result = "Id do funcionário inválido";
                    vf = false;
                    return false;
                }
                if (Nome == string.Empty)
                {
                    result = "Digite o nome do funcionário";
                    vf = false;
                    return false;
                }
                if (Id_cargo <= 0)
                {
                    result = "Selecione o cargo do funcionário";
                    vf = false;
                    return false;
                }
                if (BI == string.Empty)
                {
                    result = "Informe o número do Bilhete de identificação";
                    vf = false;
                    return false;
                }
                if (Sexo == string.Empty)
                {
                    result = "Informe o gênero do funcionário";
                    vf = false;
                    return false;
                }
                if (Tel1 == string.Empty)
                {
                    Tel1 = null;
                }
                if (Tel2 == string.Empty)
                {
                    Tel2 = null;
                }

                // Adicionar valores 
                f.Id_funcionario = Id;
                f.Nome = Nome;
                f.BI = BI;
                f.Sexo = Sexo;
                f.Data = Data;
                f.Residencia = Residencia;
                f.Formacao = Formacao;
                f.Email = Email;
                f.Banco = Banco;
                f.Num_banco = Num_banco;
                f.IBAN = IBAN;
                f.Aumento = Aumento;
                f.Imagem = Imagem;
                f.Acesso = Acesso;
                f.id_cargo = Id_cargo;
                f.Tel1 = Tel1;
                f.Tel2 = Tel2;

                // Iniciar cadastro
                f.editarFuncionario();
                vf = f.vf;
                result = f.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                return false;
            }
        }

        public bool inserirEscala(int Id, string dia, string turno, string hora_entrada, string hora_saida)
        {
            try
            {
                if (Id <= 0)
                {
                    result = "Id Inválido.";
                    vf = false;
                    return false;
                }
                
                f.Id_funcionario = Id;
                f.inserirEscala(dia,turno,hora_entrada,hora_saida);
                result = f.result;
                vf = f.vf;
                return true;
            }
            catch (Exception ms)
            {
                result = "DTO " + ms.Message;
                vf = false;
                return false;
            }
        }
        public bool deleteEscala(int Id)
        {
              if (Id <= 0)
              {
                  result = "Id Inválido";
                  vf = false;
                  return false;
              }

              f.Id_funcionario = Id;
              f.deleteEscala();
              result = f.result;
              vf = f.vf;
              return vf;
         }
        

 
        //public bool deleteFuncionario(int Id)
        //{
        //    try
        //    {

        //        if (MessageBox.Show("Deseja eliminar o funcionário com Id " + Id + "?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            if (Id <= 0)
        //            {
        //                result = "Id Inválido";
        //                vf = false;
        //                return false;
        //            }

        //            f.Id_funcionario = Id;
        //            f.deleteFuncionario();

        //            result = f.result;
        //            vf = f.vf;
        //            return vf;
        //        }
        //        else
        //        {
        //            result = "DTO Seleção cancelada";
        //            vf = true;
        //            return false;
        //        }
        //    }
        //    catch (Exception ms)
        //    {
        //        result = "DTO " + ms.Message;
        //        vf = false;
        //        return false;
        //    }
        //}

        public bool desablitar_Funcionario(int ops,int Id)
        {
            try
            {
                string msg = (ops == 0) ? "Desejas desablitar o funcionário ?" : "Desejas hablitar o funcionário ?";

                if (MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Id <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    }

                    f.Id_funcionario = Id;
                    f.desablitar(ops);

                    result = f.result;
                    vf = f.vf;
                    return vf;
                }
                else
                {
                    result = "";
                    vf = true;
                    return true;
                }
            }
            catch (Exception ms)
            {
                result = "DTO " + ms.Message;
                vf = false;
                return false;
            }
        }

        public bool trocarSenha(int Id,string Nome_user,string oldKey,string newKey,string confirm)
        {
            try
            {
                    if (Id <= 0)
                    {
                        result = "Id Inválido.";
                        vf = false;
                        return false;
                    }
                    if (tbFuncionarios("id",Id.ToString()).Rows[0]["senha"].ToString()!=oldKey)
                    {
                        result = "A senha antiga errada.";
                        vf = false;
                        return false;   
                    }
                    if (newKey.Length<=3 && oldKey!=string.Empty)
                    {
                        result = "A senha tem de ter no mínimo 4 dígitos.";
                        vf = false;
                        return false;
                    }
                    if (newKey!=confirm)
                    {
                        result = "A senhas incompactíveis.";
                        vf = false;
                        return false;
                    }
                    
                    f.Id_funcionario = Id;
                    f.Nome_User = Nome_user;
                    f.Senha = newKey;
                    f.trocarSenha();

                    result = f.result;
                    vf = f.vf;
                    return true;                
            }
            catch (Exception ms)
            {
                result = "DTO " + ms.Message;
                vf = false;
                return false;
            }
        }

       
    }
}
