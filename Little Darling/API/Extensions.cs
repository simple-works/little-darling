using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LittleDarling
{
    public static class Extensions
    {
        public enum State { Normal = 1, Error = 2, Warning = 3 }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public static FontFamily ToFontFamily(this byte[] resource)
        {
            int length = resource.Length;
            IntPtr data = Marshal.AllocCoTaskMem(length);
            Marshal.Copy(resource, 0, data, length);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddMemoryFont(data, length);
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)length, IntPtr.Zero, ref cFonts);
            Marshal.FreeCoTaskMem(data);
            return privateFonts.Families[privateFonts.Families.Length - 1];
        }

        public static void SetState(this ProgressBar progressBar, State state)
        {
            SendMessage(progressBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }

        public static void CenterHorizontally(this Control control)
        {
            if (control.Parent != null)
            {
                control.Location = new Point((int)(0.5 * control.Parent.Width - 0.5 * control.Width), control.Location.Y);
            }
        }

        public static void SetFont(this Control control, FontFamily fontFamily)
        {
            control.Font = new Font(fontFamily, control.Font.Size);
        }

        public static void SetFont(this Control control, Font font)
        {
            control.Font = new Font(font.FontFamily, control.Font.Size);
        }

        public static void EnableButtonsHoverEffects(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    Color foreColor = Color.Empty, backColor = Color.Empty;
                    Timer timer = new Timer();
                    timer.Tick += (s, e) =>
                        {
                            button.BackColor = Color.FromArgb(new Random().Next());
                        };
                    button.MouseEnter += (s, e) =>
                        {
                            timer.Start();
                        };
                    button.MouseLeave += (s, e) =>
                        {
                            timer.Stop();
                            timer.Dispose();
                            button.ForeColor = foreColor;
                            button.BackColor = backColor;
                        };
                }
            }
        }

        public static void SetRandomInterval(this Timer timer, int min = 1000, int max = 60000)
        {
            timer.Interval = (new Random().Next(min, max));
        }
    }
}
