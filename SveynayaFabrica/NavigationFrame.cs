using System.Windows.Controls;

namespace SveynayaFabrica
{
    static class NavigationFrame
    {
        private static Frame _frame;
        public static void SetFrame(Frame frame)
        {
            _frame = frame;
        }

        public static void NavigateTo(Page page)
        {
            _frame.Navigate(page);
        }
    }
}
