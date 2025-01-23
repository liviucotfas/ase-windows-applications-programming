using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClockUserControlSample
{
    public partial class ClockCustomControl : Control
    {
        private int _ora;
        private int _min;
        private int _sec;
        public event EventHandler Ring;
        public ClockCustomControl()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        #region Proprietati
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Ora
        {
            get { return _ora; }
            set
            {
                if (value < 0 || value > 24) throw new ArgumentException();
                _ora = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Min
        {
            get { return _min; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentException();
                _min = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Sec
        {
            get { return _sec; }
            set
            {
                if (value < 0 || value > 60) throw new ArgumentException();
                _sec = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int OraAlarm { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MinAlarm { get; set; }

        #endregion

        //se atasaza aceste atribute pentru a seta daca proprietatile pot fi vizibile sau nu in designer
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Never), Category("Custom")]
        private void tmTimp_Tick(object sender, EventArgs e)
        {
            _sec++;
            if (_sec == 60)
            {
                _sec = 0; _min++;
                if (_min == 60)
                {
                    _min = 0; _ora++;
                    if (_ora == 24) _ora = 0;
                }
            }
            /*string timp = DateTime.Now.ToLongTimeString();
            if (timp[1] == ':')
            {
                ora = Convert.ToInt32(timp.Substring(0, 1));
                min = Convert.ToInt32(timp.Substring(2, 2));
                sec = Convert.ToInt32(timp.Substring(5, 2));
            }
            else 
            {
                ora = Convert.ToInt32(timp.Substring(0, 2));
                min = Convert.ToInt32(timp.Substring(3, 2));
                sec = Convert.ToInt32(timp.Substring(6, 2));
            }*/
            Invalidate();
            if (_ora == OraAlarm && Ring != null)
            {
                if (_min == MinAlarm)
                {
                    Ring(this, new EventArgs());
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int i;
            //definim tipul pensulei ca sa reprezentam minutarul, secundarul si orarul
            SolidBrush pnsRosie = new SolidBrush(Color.Red);
            SolidBrush pnsNeagra = new SolidBrush(Color.Black);
            SolidBrush pnsAlbasra = new SolidBrush(Color.Blue);
            //culoarea pensulei si grosimea se trimit ca parametri
            Pen penSec = new Pen(pnsNeagra, 1);
            Pen penMin = new Pen(pnsAlbasra, 2);
            Pen penOra = new Pen(pnsNeagra, 5);
            //pentru conturul ceasului
            Pen pen = new Pen(pnsRosie, 3);
            //extragem dreptunghiul in care sa putem desena(preluand dreptunghiul ferestrei)
            Rectangle r = e.ClipRectangle;
            r.X += 5; r.Y += 5; r.Height -= 10; r.Width -= 10;
            //in cadrul acestui dreptunghi vom desena un cerc
            int raza = r.Height / 2 - 10;

            //preluam contextul grafic
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, r);
            //definim coordonatele de inceput pentru a putea trasa cadranul ceasului
            //definim centrul cercului
            int x0 = r.X += r.Width / 2;
            int y0 = r.Y += r.Height / 2;
            DrawCircle(x0, y0, 5, g);
            //desenam cadranul
            for (i = 0; i < 12; i++)
            {
                int x, y;
                x = x0 + (int)(raza * Math.Cos(i * Math.PI / 6.0));
                y = y0 - (int)(raza * Math.Sin(i * Math.PI / 6.0));
                //functia care deseneaza patratelul pentru fiecare 
                DrawSquare(x, y, 8, g);
            }
            Point centru = new Point(x0, y0);
            //desenam capatul secundarului
            Point secC = new Point(x0 + (int)(raza * Math.Cos(Math.PI / 2 - _sec * Math.PI / 30.0)), y0 - (int)(raza * Math.Sin(Math.PI / 2 - _sec * Math.PI / 30.0)));
            g.DrawLine(penSec, centru, secC);
            Point minC = new Point(x0 + (int)((raza - 15) * Math.Cos(Math.PI / 2 - (_min + _sec / 60.0) * Math.PI / 30.0)), y0 - (int)((raza - 15) * Math.Sin(Math.PI / 2 - (_min + _sec / 60.00) * Math.PI / 30.0)));
            g.DrawLine(penMin, centru, minC);
            Point oraC = new Point(x0 + (int)((raza - 30) * Math.Cos(Math.PI / 2 - (_ora + _min / 60.0) * Math.PI / 6.0)), y0 - (int)((raza - 30) * Math.Sin(Math.PI / 2 - (_ora + _min / 60.00) * Math.PI / 6.0)));
            g.DrawLine(penOra, centru, oraC);
        }

        private void DrawSquare(int x, int y, int raza, Graphics g)
        {
            //se deseneaza un cerc cu centru si raza date
            Rectangle r = new Rectangle(new Point(x - raza, y - raza), new Size(2 * raza, 2 * raza));
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, r);
        }

        private void DrawCircle(int x0, int y0, int latura, Graphics g)
        {
            //se dau centrul si latura patratului
            Rectangle r = new Rectangle(new Point(x0 - latura / 2, y0 - latura / 2), new Size(latura, latura));
            SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 255));
            Pen p = new Pen(b, 2);
            g.DrawRectangle(p, r);
        }
    }
}
