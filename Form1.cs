using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Editor
{
    public partial class MainForm : Form
    {
        CStorage storage;
        public MainForm()
        {
            InitializeComponent();
            storage = new CStorage();          
        }

        public interface IHandler
        {
            void handleFigure(CFigure f);
            void handleGroup(CGroup g);
        }

        public class CMover : IHandler
        {
            private int dX = 5, dY = 5;
            private bool isPositive = true; 
            private CGroup group;

            public CMover(bool isPositive)
            {
                this.isPositive = isPositive;
                if(this.isPositive == false)
                {
                    dX = -dX;
                    dY = -dY;
                }

            }
            public void handleFigure(CFigure f)
            {
                f.X += dX;
                f.Y += dY; 
            }
            public void handleGroup(CGroup g)
            {
                for(var i = g.first(); i != null; i = g.next(i))
                {
                    i.X += dX;
                    i.Y += dY;
                }             
            }
        }
        public interface Command
        {
            void action(CFigure f);
            void unaction();
            Command clone();
        }

        public class MoveCommand : Command
        {
            //private CMover mover;
            private int X, Y;
            private CFigure figure;

            public MoveCommand(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }

            public void action(CFigure f)
            {
                figure = f;
                if(figure != null)
                {
                    figure.Apply(new CMover(true));
                }
            }
            public void unaction()
            {
                if (figure != null)
                {
                    figure.Apply(new CMover(false));
                }
            }
            public Command clone()
            {
                return new MoveCommand(X, Y);
            }
        }

        public class CStorage 
        {        
            private LinkedList<CFigure> list = new LinkedList<CFigure>();
             
            public CFigure first()
            {
                return list.First();
            }

            public CFigure next(CFigure figure)
            {
                bool check = false;
                foreach (CFigure fig in list)
                {
                    if (check == true)
                        return fig;
                    if (figure == fig)
                        check = true;
                }
                return null;
            }
            public int getCount()
            {
                return list.Count;
            }

            public void add(CFigure f)
            {
                list.AddLast(f);
            }
            //public bool isEOL()
            //{
            //    return current_index == getCount();
            //}
          
          
        }

        public abstract class CFigure
        {
            public int X, Y;
            public Color Color = Color.OrangeRed;
            public Color Border;

            public CFigure(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }

            public abstract void Apply(IHandler handler);
            public abstract void Draw(Panel Canvas);
        }

        public class CEllipse : CFigure
        {
            private int Rad = 15;

            public CEllipse(int X, int Y) : base(X, Y) { }

            public override void Apply(IHandler handler)
            {
                handler.handleFigure(this);
            }
            public override void Draw(Panel Canvas)
            {
                Canvas.CreateGraphics().FillEllipse(new SolidBrush(Color), X - Rad, Y - Rad,
                    2 * Rad, 2 * Rad);
            }
        }

      

        public class CRectangle : CFigure
        {
            private int Diag = 15;
            public CRectangle(int X, int Y) : base(X, Y) { }

            public override void Apply(IHandler handler)
            {
                handler.handleFigure(this);
            }
            public override void Draw(Panel Canvas)
            {
                Canvas.CreateGraphics().FillRectangle(new SolidBrush(Color), X - Diag, Y - Diag,
                    2 * Diag, 2 * Diag);
            }

        }

        public class CTriangle : CFigure
        {
            private int CircumRad = 15;
            private int Ugol;
            public CTriangle(int X, int Y) : base(X, Y) { }
            public override void Apply(IHandler handler)
            {
                handler.handleFigure(this);
            }
            public override void Draw(Panel Canvas)
            {
                //List<Point> line1 = new List<Point>();
                //List<Point> line2 = new List<Point>();
                //List<Point> line3 = new List<Point>();
                //line1.Add(new Point(X, Y - CircumRad - it.BorderSize));
                //line1.Add(new Point(X + CircumRad + it.BorderSize, Y + CircumRad / 2 + it.BorderSize / 2));
                //line2.Add(new Point(it.X, it.Y - it.Radius - it.BorderSize));
                //line2.Add(new Point(it.X - it.Radius - it.BorderSize, it.Y + it.Radius / 2 + it.BorderSize / 2));
                //line3.Add(new Point(it.X - it.Radius - it.BorderSize, it.Y + it.Radius / 2 + it.BorderSize / 2));
                //line3.Add(new Point(it.X + it.Radius + it.BorderSize, it.Y + it.Radius / 2 + it.BorderSize / 2));

                //GraphicsPath myPath = new GraphicsPath();
                //myPath.StartFigure();
                //myPath.AddLines(line1.ToArray());
                //myPath.AddLines(line2.ToArray());
                //myPath.AddLines(line3.ToArray());
                //myPath.CloseFigure();

                //form.CreateGraphics().FillPath(cr, myPath);
                //form.CreateGraphics().DrawPath(br, myPath);
            }

        }

        public class CGroup : CFigure
        {
            private LinkedList<CFigure> list = null;

            public CGroup(int X, int Y) : base(X, Y) { }

            public CFigure first()
            {
                return list.First();
            }

            public CFigure next(CFigure figure)
            {
                bool check = false;
                foreach (CFigure fig in list)
                {
                    if (check == true)
                        return fig;
                    if (figure == fig)
                        check = true;
                }
                return null;
            }
            public int getCount()
            {
                return list.Count;
            }

            public void AddShape(CFigure f)
            {
                list.AddLast(f);
            }

            public override void Apply(IHandler handler)
            {
                handler.handleGroup(this);
            }
            public override void Draw(Panel Canvas)
            {
                //foreach(CFigure f in CGroup)
                //{

                //}         
            }

            

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            CFigure f = null;
            if (cmbxShape.SelectedItem == cmbxShape.Items[0]) f = new CEllipse(e.X, e.Y);
            if (cmbxShape.SelectedItem == cmbxShape.Items[1]) f = new CRectangle(e.X, e.Y);
            if (cmbxShape.SelectedItem == cmbxShape.Items[2]) f = new CTriangle(e.X, e.Y);
            //Instruments.Focus();
            storage.add(f);
            f.Draw(Canvas);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Instruments.BackColor = Color.Red;

        }
    }
}
