namespace FeePay.Integrations.Domain.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Library.Extensions;

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
        /// Loads the list items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TK">The type of the k.</typeparam>
        /// <param name="lb">The lb.</param>
        /// <param name="items">The items.</param>
        /// <param name="func">The function.</param>
        public static void LoadListItems<T, TK>(this ListBox lb, ICollection<T> items, Func<T, TK> func)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke(new MethodInvoker(() => lb.LoadListItems(items, func)));
            }
            else
            {
                lb.Items.Clear();
                var newItems = items.Map(func);

                foreach (var item in newItems)
                {
                    lb.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="text">The text.</param>
        public static void SetText(this Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke(new MethodInvoker(() => label.SetText(text)));
            }
            else
            {
                label.Text = text;
                label.Refresh();
            }
        }
    }
}