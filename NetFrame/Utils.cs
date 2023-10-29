using NetFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFrame
{
    public static class Utils
    {
        public static string ToStringPoint(Point point)
        {
            return $"{point.X}:{point.Y}";
        }

        public static void ParentFormWorkSetUpdate()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == nameof(Form1))
                {
                    (item as Form1).WorkSetUpdate();
                }
            }
        }
    }
}
