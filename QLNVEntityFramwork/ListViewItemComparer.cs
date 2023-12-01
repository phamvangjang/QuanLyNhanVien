using System;
using System.Collections;
using System.Windows.Forms;

namespace QLNVEntityFramwork
{
    internal class ListViewItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            // So sánh theo thâm niên giảm dần
            int result = DateTime.Compare(DateTime.Parse(itemY.SubItems[4].Text), DateTime.Parse(itemX.SubItems[4].Text));

            // Nếu thâm niên bằng nhau, so sánh theo họ tên tăng dần
            if (result == 0)
            {
                result = string.Compare(itemX.SubItems[1].Text, itemY.SubItems[1].Text);
            }

            return result;
        }
    }
}
