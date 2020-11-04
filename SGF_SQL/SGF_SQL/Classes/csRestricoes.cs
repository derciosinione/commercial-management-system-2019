using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_SQL
{
    public static class csRestricoes
    {
        //Eventos
        public static void txt_nome_conf(object sender, KeyPressEventArgs e)
            {
            TextBox txt = (TextBox)sender;
            string num = "áàâãéèêíìîóòôõúùûqwertyuiopasdfghjklçzxcvbnm´´`~^ ";
            num += num.ToUpper();

            if (!num.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (txt.TextLength == 0)
            {
                if (e.KeyChar == ' ') e.Handled = true;
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                return;
            }

            try
            {
                if (e.KeyChar.ToString() == " " && txt.Text.Substring(txt.TextLength - 1) == " ")
                {
                    e.Handled = true;
                    return;
                }
            }
            catch { }


            if (txt.Text.Substring(txt.TextLength - 1, 1) == " ")
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
            }
            else
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToLower());
            }

        }
        public static void txt_txtUpper_conf(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());            
        }
        public static void txt_number_conf(object sender, KeyPressEventArgs e)
        {
            string valor = "0123456789.,";

            if (!valor.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
        public static void txt_email_conf(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string num = "qwertyuioplkjhgfdsazxcvbnm1234567890@.";
            num += num.ToUpper();

            if (txt.TextLength > 0)
                if (txt.Text.Substring(txt.TextLength - 1) == "." && e.KeyChar == '.')
                {
                    e.Handled = true;
                }

            if (txt.Text.Contains(e.KeyChar) && e.KeyChar == '@')
            {
                e.Handled = true;
            }

            if (!num.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public static void bloquear_tudo(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //Metodos

        //configurar text
        public static void add_Nome(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(txt_nome_conf);
        }
        public static void add_txtUpper(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(txt_txtUpper_conf);
        }
        public static void add_Number(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(txt_number_conf);
        }
        public static void add_Email(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(txt_email_conf);
        }
        public static void add_Cmb_HANDELDE(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(bloquear_tudo);
        }
        public static void add_Cmb_HANDELDE(ComboBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(bloquear_tudo);
        }
    }
}
