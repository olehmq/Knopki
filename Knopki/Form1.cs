using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Knopki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonFactory normalButtonFactory = new NormalButtonFactory();
            ButtonFactory radioButtonFactory = new RadioButtonFactory();
            ButtonFactory checkButtonFactory = new CheckButtonFactory();

            // Створення звичайної кнопки
            Button normalButton = normalButtonFactory.CreateButton();
            normalButton.Draw();

            // Створення RadioButton
            Button radioButton = radioButtonFactory.CreateButton();
            radioButton.Draw();

            // Створення CheckButton
            Button checkButton = checkButtonFactory.CreateButton();
            checkButton.Draw();

          
        }
    }

}
