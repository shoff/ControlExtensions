namespace FeePay.Integrations.Domain.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Library.Extensions;

    public static class ListBoxExtensions
    {
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
    }
}