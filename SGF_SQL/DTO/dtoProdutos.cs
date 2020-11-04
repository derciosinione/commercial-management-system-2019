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
    public class dtoProdutos
    {
        bllProdutos p = new bllProdutos();
        bllCategorias c = new bllCategorias();
        public bool vf = false;
        public string result;

        public DataTable tbProdutos(bool x,string Campo, string Buscar)
        {
            return p.AllProdutos(x,Campo, Buscar);
        }

        public DataTable tbEntradas(int Id, string Campo, string Buscar)
        {
            return p.AllProdutos_entrada(Id,Campo, Buscar);
        }

        public ComboBox categorias(ComboBox cbxCategoria)
        {
            c.FullCombol(cbxCategoria);
            return cbxCategoria;
        }

        public int pegarIdCategoria(int valor)
        {
            return c.retornarId(valor);
        }
        
        public bool inserirproduto(string codigo, int idcategoria, string nome, byte[] imagem, decimal preco)
        {
            try
            {
                if (nome == string.Empty)
                {
                    result = "Digite o nome do produto";
                    vf = false;
                    return false;
                }
                if (idcategoria <= 0)
                {
                    result = "Escolhe a categoria do produto";
                    vf = false;
                    return false;
                }
                if (preco <= 0)
                {
                    result = "Digite o preço do produto a ser cadastrado";
                    vf = false;
                    return false;
                }

                // Adicionar valores 
                p.Codigo = codigo;
                p.Idcategoria = idcategoria;
                p.Nome = nome;
                p.Imagem = imagem;
                p.Preco = preco;

                // Iniciar cadastro
                p.inserirproduto();
                vf = p.vf;
                result = p.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                return false;
            }
        }

        public bool editarproduto(string codigo, int idproduto, int idcategoria, string nome,byte[] imagem, decimal preco)
        {
            try
            {

                if (nome == string.Empty)
                {
                    result = "Digite o nome do produto";
                    vf = false;
                    return false;
                }
                if (idcategoria <= 0)
                {
                    result = "Escolhe a categoria do produto";
                    vf = false;
                    return false;
                }
                if (preco <= 0)
                {
                    result = "Digite o preço do produto a ser cadastrado";
                    vf = false;
                    return false;
                }

                // Adicionar valores 
                p.Id = idproduto;
                p.Codigo = codigo;
                p.Idcategoria = idcategoria;
                p.Nome = nome;
                p.Imagem = imagem;
                p.Preco = preco;


                // editar cadastro
                p.editarproduto();
                vf = p.vf;
                result = p.result;

                return true;
            }
            catch (Exception ms)
            {
                MessageBox  .Show(ms.Message);
                return false;
            }
        }

        public bool deleteProduto(int Id, bool x)
        {
            try
            {

                if (MessageBox.Show("Deseja eliminar o produto com Id " + Id + "?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Id <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    }

                    p.Id = Id;
                    x = (x) ? p.deleteProdutos(x) : p.deleteProdutos(x);

                    result = p.result;
                    vf = p.vf;
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

        public bool desativarProduto(int Id, int x)
        {
                    if (Id <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    }

                    p.Id_produto = Id;
                    p.desactivarProduto(x);
                    result = p.result;
                    vf = p.vf;
                    return vf;
        }

        public bool inserirproduto_entrada(int id_produto, int volume, string data_fabricacao, string data_validade, decimal custus)
        {
            try
            {
                if (volume <= 0)
                {
                    result= "O volume não pode menor que 1";
                    vf = false;
                    return false;
                }
                else if (custus < 0)
                {
                    result = "O preço não pode ser negativo";
                    vf = false;
                    return false;
                }
                else if (data_validade == DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    result="Data de validade do produto inválida";
                    return false;
                }

                // Iniciar cadastro
                p.Id_produto = id_produto;
                p.Volume = volume;
                p.dataFabricacao = data_fabricacao;
                p.dataValidade = data_validade;
                p.Custus = custus;
                p.inserirproduto_entrada();
                vf = p.vf;
                result = p.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("dto\n" + ms.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool editarproduto_entrada(int id, int id_produto, int volume, string data_fabricacao, string data_validade, decimal custus)
        {
            try
            {
                if (volume <= 0)
                {
                    result = "O volume não pode ser negativo";
                    vf = false;
                    return false;
                }
                else if (custus < 0)
                {
                    result = "O preço não pode ser negativo";
                    vf = false;
                    return false;
                }
                else if (data_validade == DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    result = "Data de validade do produto inválida";
                    vf = false;
                    return false;
                }

                p.Id = id;
                p.Id_produto = id_produto;
                p.Volume = volume;
                p.dataFabricacao = data_fabricacao;
                p.dataValidade = data_validade;
                p.Custus = custus;
                p.editarproduto_entrada();
                vf = p.vf;
                result = p.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("dto\n" + ms.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
