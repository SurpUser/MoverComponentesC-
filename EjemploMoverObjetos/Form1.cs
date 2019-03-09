using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMoverObjetos
{
    public partial class Form1 : Form
    {
        int LocationX = 0, LocationY = 0;
        int LocationFormX = 0, LocationFormY = 0;
        int LocationActualX = 0, LocationActualY = 0;
        bool Precionado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocationActualX = button1.Location.X;
            LocationActualY = button1.Location.Y;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            LocationX = e.Location.X;
            LocationY = e.Location.Y;
            Precionado = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Precionado = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            LocationFormX = e.Location.X;
            LocationFormY = e.Location.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            LocationFormX = LocationActualX + e.Location.X;
            LocationFormY= LocationActualY + e.Location.Y;
            if (Precionado)
            {
                MoverBoton();
            }
        } 

        private void MoverBoton()
        {
            button1.Location = new System.Drawing.Point(LocationFormX - LocationX,LocationFormY - LocationY);
            LocationActualX = button1.Location.X;
            LocationActualY = button1.Location.Y;
        }

    }
}
