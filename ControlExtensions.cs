namespace FeePay.Integrations.Domain.Extensions
{
    using System.Windows.Forms;
    using System.Drawing;

    public static class ControlExtensions
    {
        /// <summary>
        /// Sets the visibility.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="visible">if set to <c>true</c> [visible].</param>
        public static void SetVisibility(this Control control, bool visible)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => control.SetVisibility(visible)));
            }
            else
            {
                control.Visible = visible;
                control.Refresh();
            }
        }

        /// <summary>
        /// Sets the allow drop.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="allow">if set to <c>true</c> [allow].</param>
        public static void SetAllowDrop(this Control control, bool allow)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => control.SetAllowDrop(allow)));
            }
            else
            {
                control.AllowDrop = allow;
                control.Refresh();
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void SetBackColor(this Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => control.SetBackColor(color)));
            }
            else
            {
                control.BackColor = color;
                control.Refresh();
            }
        }

        /// <summary>
        /// Sets the background image.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="image">The image.</param>
        public static void SetBackgroundImage(this Control control, Image image)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => control.SetBackgroundImage(image)));
            }
            else
            {
                control.BackgroundImage = image;
                control.Refresh();
            }
        }

        /// <summary>
        /// Sets the background image layout.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="imageLayout">The image layout.</param>
        public static void SetBackgroundImageLayout(this Control control, ImageLayout imageLayout)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => control.SetBackgroundImageLayout(imageLayout)));
            }
            else
            {
                control.BackgroundImageLayout = imageLayout;
                control.Refresh();
            }
        }        

    }

}