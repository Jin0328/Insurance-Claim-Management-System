using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public class RoundPanel : Panel
    {
        // 모서리의 둥글기 정도
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 둥근 사각형을 그립니다.
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = CornerRadius * 2;
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}

