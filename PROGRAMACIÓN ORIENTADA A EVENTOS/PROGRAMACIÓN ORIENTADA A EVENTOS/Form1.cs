using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACIÓN_ORIENTADA_A_EVENTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarEjercicio1();
            ConfigurarEjercicio2y3();
            ConfigurarEjercicio4();
            ConfigurarEjercicio5();
        }
        public event Action AlRealizarVenta;

        private void ConfigurarEjercicio1()
        {
          
            AlRealizarVenta += ProcesarFactura;
            AlRealizarVenta += ReducirInventario;
        }

        // Suscriptor A 
        private void ProcesarFactura()
        {
            lstLogFacturacion.Items.Add($"{DateTime.Now:HH:mm:ss} - [FACTURA]: Generando comprobante fiscal...");
        }

       // Suscriptor B 
        private void ReducirInventario()
        {
            lstLogFacturacion.Items.Add($"{DateTime.Now:HH:mm:ss} - [INVENTARIO]: Descontando artículos del stock...");
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            lstLogFacturacion.Items.Add("Iniciando Proceso de Venta");

            // Invocamos el evento (esto ejecuta todos los métodos suscritos)
            AlRealizarVenta?.Invoke();

            lstLogFacturacion.Items.Add("Proceso Finalizado");
        }

        //PROGRAMA 2 Y 3

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Definimos el evento que acepta un parámetro (double)
        public event Action<double> AlCambiarTemperatura;

        private void ConfigurarEjercicio2y3()
        {
            // Suscribimos varios sistemas (Ejercicio 2: Múltiples suscriptores)
            AlCambiarTemperatura += ActualizarInterfaz;
            AlCambiarTemperatura += LogDeSeguridad;

            // Ejercicio 3: Suscriptor que solo actúa en condición crítica
            AlCambiarTemperatura += (temp) => {
                if (temp > 35)
                {
                    lstLogSensor.Items.Add($"!!! ALERTA CRÍTICA: {temp}°C detectados !!!");
                    lblValorTemp.ForeColor = Color.Red;
                }
                else
                {
                    lblValorTemp.ForeColor = Color.Black;
                }
            };
        }

        // Suscriptor 1: Actualiza la etiqueta visual
        private void ActualizarInterfaz(double t)
        {
            lblValorTemp.Text = $"Temperatura: {t}°C";
        }

        // Suscriptor 2: Simula un sistema de guardado de datos
        private void LogDeSeguridad(double t)
        {
            // Esto se ejecuta siempre que el sensor cambie (Ejercicio 2)
            Console.WriteLine($"Dato enviado al servidor: {t}");
        }

        // Disparador: Evento del TrackBar al mover la barra
       

        private void tkbTemperatura_Scroll(object sender, EventArgs e)
        {
            double tempSimulada = tkbTemperatura.Value;
            // Notificamos a todos los suscriptores
            AlCambiarTemperatura?.Invoke(tempSimulada);
        }

        //PROGRAMA NUMERO 4
      
        public event Action<double> OnPagoRealizado;

        private void ConfigurarEjercicio4()
        {
         
            OnPagoRealizado += AumentarSaldoBancario;
            OnPagoRealizado += EnviarNotificacion;
        }

     
        private void AumentarSaldoBancario(double monto)
        {
            lstLogEmpresarial.Items.Add($"[BANCO]: Transacción procesada. Saldo +{monto}");
        }

        // Suscriptor 2: Notificar el pago
        private void EnviarNotificacion(double monto)
        {
            lstLogEmpresarial.Items.Add($"[NOTIFICAR]: ¡Pago de {monto} recibido con éxito!"); 
        }
        

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            double montoAPagar = 250.75; 

            lstLogEmpresarial.Items.Add(">>> Registrando nuevo pago...");
            OnPagoRealizado?.Invoke(montoAPagar);
            lstLogEmpresarial.Items.Add(">>> Registro completado.");
        }
        // progama numero 5
    
        public event Action<string> OnOrdenCreada;

        private void ConfigurarEjercicio5()
        {
            OnOrdenCreada += ReservarStock;
            OnOrdenCreada += ProcesarVentaFinal;
        }

        // Suscriptor: Almacén
        private void ReservarStock(string idOrden)
        {
            lstLogEmpresarial_1.Items.Add($"[ALMACÉN]: Reservando productos para {idOrden}...");
        }

        // Suscriptor: Ventas
        private void ProcesarVentaFinal(string idOrden)
        {
            lstLogEmpresarial_1.Items.Add($"[VENTAS]: Orden {idOrden} marcada como 'En Proceso'.");
        }
        
        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            string nuevaOrden = "ORD-" + new Random().Next(1000, 9999);

            lstLogEmpresarial_1.Items.Add($"--- Iniciando Flujo de Orden {nuevaOrden} ---");

            OnOrdenCreada?.Invoke(nuevaOrden);
        }
    }
}
