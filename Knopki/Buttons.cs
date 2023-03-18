using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knopki
{
    public abstract class Button
    {
        public abstract void Draw();
    }

    // Клас кнопки звичайного типу
    public class NormalButton : Button
    {
        public override void Draw()
        {
            Console.WriteLine("Normal Button");
        }
    }

    // Клас кнопки RadioButton
    public class RadioButton : Button
    {
        public override void Draw()
        {
            MessageBox.Show("Radio Button");
        }
    }

    // Клас кнопки CheckButton
    public class CheckButton : Button
    {
        public override void Draw()
        {
            MessageBox.Show("Check Button");
        }
    }

    // Абстрактний клас фабрики кнопок
    public abstract class ButtonFactory
    {
        public abstract Button CreateButton();
    }

    // Фабрика для створення звичайної кнопки
    public class NormalButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new NormalButton();
        }
    }

    // Фабрика для створення RadioButton
    public class RadioButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new RadioButton();
        }
    }

    // Фабрика для створення CheckButton
    public class CheckButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new CheckButton();
        }
    }
}

   
