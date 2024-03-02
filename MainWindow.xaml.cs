using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Зад2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {                                             
            private List<Button> buttons;            
            private Random random = new Random();     
            public MainWindow()
            {
                InitializeComponent();  
                buttons = new List<Button> { Первая, Вторая, Третья, Четвертая, Пятая, Шестая, Седьмая, Восьмая, Девятая, Десятая, elf, zwolf, тринадцатая, Четырнадцатая, Пятнадцатая };
                foreach (var щелк in buttons)     //Создала список кнопок, которые будут использоваться как лампочки в гирлянде
                {  
                    щелк.Background = GetRandomColor(); //Вызвала метод GetRandomColor
                }
                CompositionTarget.Rendering += BlinkLights;
            }
            private void BlinkLights(object sender, EventArgs e)
            {  
                foreach (var щелк in buttons)
                {
                    if (random.Next(10) == 2)  //С вероятностью 1/5 меняется цвет на случайный
                    {
                        щелк.Background = GetRandomColor(); // Вызывала метод GetRandomColor
                }
            }
            }
            private SolidColorBrush GetRandomColor()  //Применила  метод GetRandomColor, который генерирует случайный цвет из 256 
        {
                Color тон = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            return new SolidColorBrush(тон);   
            }
        }
    }