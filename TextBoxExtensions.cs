namespace FeePay.Integrations.Domain.Extensions
{
    using System.Windows.Forms;

    public static class TextBoxExtensions
    {
        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <param name="text">The text.</param>
        /// <example>
        /// <code> this.textBox.SetText("Hello Async World");</code>
        /// </example>
        public static void SetText(this TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new MethodInvoker(() => textBox.SetText(text)));
            }
            else
            {
                textBox.Text = text;
                textBox.Refresh();
            }
        }
    }
}