using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AppInternacao.Extend
{
    public class PictureBoxExt: PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(graphics);
            base.OnPaint(pe);
        }
    }
}
