using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IButton
    {
        void Render();
    }

    public interface ITextBox
    {
        void Render();
    }
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button.");
        }
    }

    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows textbox.");
        }
    }

    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a MacOS button.");
        }
    }

    public class MacOSTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a MacOS textbox.");
        }
    }
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    public class MacOSUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Chọn factory cụ thể (Windows hoặc MacOS)
            IUIFactory factory = new WindowsUIFactory();

            // Tạo các sản phẩm từ factory đã chọn
            IButton button = factory.CreateButton();
            ITextBox textBox = factory.CreateTextBox();

            // Sử dụng các sản phẩm
            button.Render();
            textBox.Render();
        }
    }
}
