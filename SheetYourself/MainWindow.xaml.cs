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

namespace SheetYourself
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PlayerPerson _player = new PlayerPerson();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _player;
        }

        private void AddSkillButton_Click(object sender, RoutedEventArgs e)
        {
            _player.Skills.Add(new Skill());
        }

        private void AddLogEntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (_player.Skills.Count < 1)
            {
                return;
            }

            var entry = new LogEntry();
            entry.Skill = _player.Skills[0];
            _player.LogEntries.Add(entry);
        }

        private void RemoveLogEventButton_Click(object sender, RoutedEventArgs e)
        {
            var boundLog = (LogEntry)((Button)sender).DataContext;
            _player.LogEntries.Remove(boundLog);
        }
    }
}
