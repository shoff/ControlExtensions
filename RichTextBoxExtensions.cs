namespace FeePay.Integrations.Domain.Extensions
{
    using System.Drawing;
    using System.Windows.Forms;

    public static class RichTextBoxExtensions
    {
        /// <summary>
        /// Sets the allow drop.
        /// </summary>
        /// <param name="richTextBox">The control.</param>
        /// <param name="value">if set to <c>true</c> [allow].</param>
        public static void SetAllowDrop(this RichTextBox richTextBox, bool value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetAllowDrop(value)));
            }
            else
            {
                richTextBox.AllowDrop = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the automatic word selection.
        /// </summary>
        /// <param name="richTextBox">The control.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public static void SetAutoWordSelection(this RichTextBox richTextBox, bool value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetAutoWordSelection(value)));
            }
            else
            {
                richTextBox.AutoWordSelection = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the bullet indent.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">The value.</param>
        public static void SetBulletIndent(this RichTextBox richTextBox, int value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetBulletIndent(value)));
            }
            else
            {
                richTextBox.BulletIndent = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the detect urls.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public static void SetDetectUrls(this RichTextBox richTextBox, bool value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetDetectUrls(value)));
            }
            else
            {
                richTextBox.DetectUrls = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the enable automatic drag drop.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public static void SetEnableAutoDragDrop(this RichTextBox richTextBox, bool value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetEnableAutoDragDrop(value)));
            }
            else
            {
                richTextBox.EnableAutoDragDrop = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">The value.</param>
        public static void SetFont(this RichTextBox richTextBox, Font value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetFont(value)));
            }
            else
            {
                richTextBox.Font = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">The value.</param>
        public static void SetForeColor(this RichTextBox richTextBox, Color value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetForeColor(value)));
            }
            else
            {
                richTextBox.ForeColor = value;
                richTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sets the language option.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">The value.</param>
        public static void SetLanguageOption(this RichTextBox richTextBox, RichTextBoxLanguageOptions value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetLanguageOption(value)));
            }
            else
            {
                richTextBox.LanguageOption = value;
                richTextBox.Refresh();
            }
        }
        
        /// <summary>
        /// Sets the maximum length.
        /// </summary>
        /// <param name="richTextBox">The rich text box.</param>
        /// <param name="value">The value.</param>
        public static void SetMaxLength(this RichTextBox richTextBox, int value)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new MethodInvoker(() => richTextBox.SetMaxLength(value)));
            }
            else
            {
                richTextBox.MaxLength = value;
                richTextBox.Refresh();
            }
        }




    }
}