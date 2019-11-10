using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pico_Placa
{
    
    public partial class Inicio : Form
    {
        
        public string placa, placa_t, fecha, hora, hora_1, min, dia,mes,año;
        
        //boton busqueda nueva y limpieza variables
        private void BTN_NUEVA_BUSQ_Click(object sender, EventArgs e)
        {
            TB_PLACA.Clear();
            TB_PLACA.Enabled = true;
            LBL_PLACA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            TB_FECHA.Clear();
            LBL_FECHA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            TB_HORA.Clear();
            LBL_HORA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            TB_RESPUESTA.Clear();
            TB_RESPUESTA.Visible = false;
            BTN_NUEVA_BUSQ.Visible = false;
            placa = "";
            placa_t = "";
            fecha = "";
            hora = "";
            hora_1 = "";
            min = "";
            dia = "";
            mes = "";
            año = "";

        }

        public Inicio()
        {
            InitializeComponent();
            TB_PLACA.Focus(); 
            
        }

        //verificacion de datos ingresados de placa.
        private void TB_PLACA_CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int temp = 0;
                placa = TB_PLACA.ToString();
                if (placa.Contains('-'))
                {
                    int posicion = placa.IndexOf("-");
                    placa_t = placa.Substring(posicion + 1);
                    if (int.TryParse(placa_t, out temp) && (placa_t.Length == 4))
                    {
                        TB_PLACA.Enabled = false;
                        TB_FECHA.Enabled = true;
                        TB_FECHA.Focus();
                        
                    }
                    else
                    {
                        Mensaje_error(error_placa);
                        LBL_PLACA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        TB_PLACA.Clear();
                    }
                }
                else
                {
                    Mensaje_error(error_placa);
                    LBL_PLACA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    TB_PLACA.Clear();
                }
            }
        }
        
        //verificacion de datos ingresados de fecha.
        private void TB_FECHA_CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int temp = 0, temp1=0 , temp2=0 , car_b=0;
                fecha = TB_FECHA.Text;
                car_b = fecha.Split('/').Length - 1;

                if ((fecha.Length == 10) && (car_b==2))
                {
                    dia = fecha.Substring(0, 2);
                    mes = fecha.Substring(3, 2);
                    año = fecha.Substring(6, 4);

                    if (int.TryParse(dia, out temp) && int.TryParse(mes, out temp1) && int.TryParse(año, out temp2) && (Convert.ToInt32(año) >= DateTime.Now.Year))
                    {
                        if ((Convert.ToInt32(año) % 4 == 0) && (Convert.ToInt32(año) != 0))
                        {
                            if ((Convert.ToInt32(mes) == 2) && (Convert.ToInt32(dia) < 30))
                            {
                                TB_FECHA.Enabled = false;
                                TB_HORA.Enabled = true;
                                TB_HORA.Clear();
                                TB_HORA.Focus();
                                
                            }
                            else if (Convert.ToInt32(mes) != 2)
                            {
                                TB_FECHA.Enabled = false;
                                TB_HORA.Enabled = true;
                                TB_HORA.Clear();
                                TB_HORA.Focus();
                                
                            }
                            else {
                                Mensaje_error(error_fecha);
                                LBL_FECHA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                                TB_FECHA.Clear();
                                fecha = "";
                            }
                        }
                        else {
                            TB_FECHA.Enabled = false;
                            TB_HORA.Enabled = true;
                            TB_HORA.Clear();
                            TB_HORA.Focus();
                            
                        }

                    }
                    else
                    {
                        Mensaje_error(error_fecha);
                        LBL_FECHA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        TB_FECHA.Clear();
                        fecha = "";
                    }
                                 
                }
                else
                {
                    Mensaje_error(error_fecha);
                    LBL_FECHA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    TB_FECHA.Clear();
                    fecha = "";
                }
            }
                   
        }
       
        //verificacion de datos ingresados de hora.
        private void TB_HORA_CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int temp = 0, temp1 = 0, car_b = 0;
                hora = TB_HORA.Text;
                car_b = hora.Split(':').Length - 1;

                if ((hora.Length == 5) && (car_b == 1))
                {
                    hora_1 = hora.Substring(0, 2);
                    min = hora.Substring(3, 2);
                    
                    if (int.TryParse(hora_1, out temp) && int.TryParse(min, out temp1) && (Convert.ToInt32(hora_1) < 25) && (Convert.ToInt32(min) < 60))
                    {
                        TB_HORA.Enabled = false;
                       // BTN_VERIFICAR.Focus();
                        BTN_VERIFICAR.Enabled = true;
                    }
                    else
                    {
                        Mensaje_error(error_hora);
                        LBL_HORA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                        TB_HORA.Clear();
                        hora = "";
                    }

                }
                else
                {
                    Mensaje_error(error_hora);
                    LBL_HORA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                    TB_HORA.Clear();
                    hora = "";
                }
            }

        }

        /*busqueda de circulacion de acuerdo a las reglas:
          terminacion de placas en:
                1 y 2 lunes 
                3 y 4 martes            restriccion con horarios: 
                5 y 6 miercoles          07:00 hasta 09:30      
                7 y 8 jueves             16:00 hasta 19:30  
                9 y 0 viernes 
         */
        private void BTN_VERIFICAR_Click(object sender, EventArgs e)
        {
            DateTime dia_Semana;
            string dsemana,rhora;
            dia_Semana = Convert.ToDateTime(fecha);
            dsemana = (dia_Semana.ToString("dddd"));
            int horar, digito;
            digito = Convert.ToInt32(placa_t.Substring(3));
            rhora = hora.Replace(":", "");
            horar = Convert.ToInt32(rhora);
            
            if (dsemana == "lunes")
            {
                if (digito == 1 || digito == 2)
                {
                    if ((horar < 0700) || (horar > 0930 && horar < 1600) || (horar > 1930))
                    {
                        Mensaje_circular(puede); 
                    }
                    else
                    {
                        Mensaje_circular(no_puede); 
                    }
                }
                else
                {
                    Mensaje_circular(puede);
                }
            }
            else if (dsemana == "martes")
            {
                if (digito == 3 || digito == 4)
                {

                    if ((horar < 0700) || (horar > 0930 && horar < 1600) || (horar > 1930))
                    {
                        Mensaje_circular(puede); 
                    }
                    else
                    {
                        Mensaje_circular(no_puede);
                    }
                }
                else
                {
                    Mensaje_circular(puede);
                }
            }
            else if (dsemana == "miércoles")
            {
                if (digito == 5 || digito == 6)
                {
                    if ((horar < 0700) || (horar > 0930 && horar < 1600) || (horar > 1930))
                    {
                        Mensaje_circular(puede);
                    }
                    else
                    {
                        Mensaje_circular(no_puede);
                    }
                }
                else
                {
                    Mensaje_circular(puede);
                }
            }
            else if (dsemana == "jueves")
            {
                if (digito == 7 || digito == 8)
                {
                    if ((horar < 0700) || (horar > 0930 && horar < 1600) || (horar > 1930))
                    {
                        Mensaje_circular(puede);
                    }
                    else
                    {
                        Mensaje_circular(no_puede);
                    }
                }
                else
                {
                    Mensaje_circular(puede);
                }
            }
            else if (dsemana == "viernes")
            {
                if (digito == 9 || digito == 0)
                {
                    if ((horar < 0700) || (horar > 0930 && horar < 1600) || (horar > 1930))
                    {
                        Mensaje_circular(puede);
                    }
                    else
                    {
                        Mensaje_circular(no_puede);
                    }
                }
                else
                {
                    Mensaje_circular(puede);
                }
            }
            else
            {
                Mensaje_circular(puede);
            }
            BTN_VERIFICAR.Enabled=false;
            BTN_VERIFICAR.Visible = false;
            BTN_NUEVA_BUSQ.Enabled = true;
            BTN_NUEVA_BUSQ.Visible = true;

        }
        public void Mensaje_error (string error) {
            MessageBox.Show(error);
        }
        public void Mensaje_circular(string mensaje) {
            TB_RESPUESTA.Visible = true;
            TB_RESPUESTA.Enabled = false;
            TB_RESPUESTA.Text = mensaje;
        }

    }
}
