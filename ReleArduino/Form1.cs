using System.IO.Ports;
namespace ReleArduino
{
    public partial class Form1 : Form
    {
        bool bandera = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRelevador_Click(object sender, EventArgs e)
        {
            SerialPort puerto = new SerialPort();
            puerto.PortName = "COM3";
            puerto.BaudRate = 9600;
            try {
                puerto.Open();
                if (bandera == false)
                {
                    puerto.WriteLine("e");
                    btnRelevador.BackColor = Color.Lime;
                    bandera= true;
                }
                else
                {
                    puerto.WriteLine("a");
                    btnRelevador.BackColor = Color.IndianRed;
                    bandera= false;
                }
                puerto.Close();                
            }
            catch (Exception ex) {
                MessageBox.Show("Error" + ex.ToString()); }

            
        }
    }
}
