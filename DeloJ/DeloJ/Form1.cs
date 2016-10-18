using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeloJ
{
    public partial class Form1 : Form
    {

        Cannon cannon;
        Castle target;
        ArrayList shots;


        public Form1()
        {
            InitializeComponent();

            cannon = new Cannon() { left = 25, top = 400};
            target = new Castle() { left = 700, top = 400 };
            shots = new ArrayList();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Console.WriteLine("Key 'a' was pressed.");
            }

            if (e.KeyCode == Keys.D)
            {
                Console.WriteLine("Key 'd' was pressed.");
            }

            if (e.KeyCode == Keys.W)
            {
                Console.WriteLine("Key 'w' was pressed.");
            }

            if (e.KeyCode == Keys.S)
            {
                Console.WriteLine("Key 's' was pressed.");
            }

            if (e.KeyCode == Keys.Space)
            {
                Console.WriteLine("Key 'space' was pressed.");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            cannon.DrawImage(g);
            target.DrawImage(g);

            base.OnPaint(e);
        }

    }
}
