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
    public class dtoVendas
    {
        bllVendas v =new bllVendas();
        public bool vf = false;
        public bool vf_pagamento = false;
        public string result;

        
        public DataTable tbVendas_today(string id_funcionario,string Campo, string Buscar)
        {
            return v.AllVendas_today(id_funcionario, Campo, Buscar);
        }


        public DataTable tbVendas(string Campo, string Buscar)
        {
            return v.AllVendas(Campo, Buscar);
        }

        public string lastId()
        {
            return v.lastId();
        }
        public bool inserirPagamento(string cliente,decimal total,decimal valor_pago,string tipo_pagamento)
        {
            try
            {
                if (valor_pago<=0)
                {
                    result = "Efectue o pagamento";
                    vf = false;
                    return false;
                }
                if (tipo_pagamento == string.Empty)
                {
                    result = "Informe o tipo do pagamento";
                    vf = false;
                    return false;
                }


                // Adicionar valores 
                v.Cliente = cliente;
                v.Total = total;
                v.Valor_pago = valor_pago; 
                v.Tipo_pagamento = tipo_pagamento;
                // Iniciar cadastro
                v.inserirPagamento();
                vf_pagamento=v.vf_pagamento;
                result = v.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                return false;
            }
        }

        public bool inserirVenda(int id_produto,int quantidade,decimal preco,int id_funcionario)
        {
            try
            {
                if (!vf_pagamento)
                {
                    result = "Erro ao efectuar o pagamento";
                    vf = false;
                    return false;
                }
                if (id_produto <= 0)
                {
                    result = "Id do produto inválido";
                    vf = false;
                    return false;
                }
                if (quantidade <= 0)
                {
                    result = "a quantidade do produto a venda tem de ser superior a 0";
                    vf = false;
                    return false;
                }
                if (preco <= 0)
                {
                    result = "não é possível vender um produto com preço inferior ou a igual a 0";
                    vf = false;
                    return false;
                }
                if (id_funcionario <= 0)
                {
                    result = "Id do funcionário inválido";
                    vf = false;
                    return false;
                }
                
                // Adicionar valores 
                v.Id_produto = id_produto;
                v.Quantidade = quantidade;
                v.Preco = preco;
                v.Id_funcionario = id_funcionario;
                // Iniciar cadastro
                v.inserirVenda();
                vf = v.vf;
                result = v.result;
                return true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                return false;
            }
        }

        public bool deleteVenda(int Id)
        {
            try
            {

                if (MessageBox.Show("Deseja eliminar a venda com Id " + Id + "?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Id <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    }

                    v.Id = Id;
                    v.deleteVenda();

                    result = v.result;
                    vf = v.vf;
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

        public bool cancelarVenda(int likeBoll, int id_pagamento)
        {
            try{
                    if (id_pagamento <= 0)
                    {
                        result = "Id Inválido";
                        vf = false;
                        return false;
                    } 
                
                   v.cancelarVenda(likeBoll, id_pagamento); 
                   result = v.result;
                    vf = v.vf;
                    return vf;
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
