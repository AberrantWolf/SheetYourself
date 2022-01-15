using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace SheetYourself
{
    internal class LogEntry : ViewModelBase
    {
        public DateTime Date { get => Properties.Get(DateTime.Today); set => Properties.Set(value); }
        public TimeSpan Duration { get => Properties.Get(TimeSpan.Zero); set => Properties.Set(value); }
        public Skill? Skill { get => Properties.Get(null as Skill); set => Properties.Set(value); }
    }

    internal class PlayerPerson : ViewModelBase
    {
        public string PlayerName
        {
            get => Properties.Get("New Player");
            set => Properties.Set(value);
        }

        public DateTime BirthDate
        {
            get => Properties.Get(DateTime.Today);
            set => Properties.Set(value);
        }

        public int Age =>
            Properties.Calculated(() =>
            {
                var today = DateTime.Today;
                var years = today.Year - BirthDate.Year;
                if (today.Month < BirthDate.Month || (today.Month == BirthDate.Month && today.Day < BirthDate.Day))
                {
                    --years;
                }

                return years;
            });

        public ObservableCollection<Skill> Skills { get; set; } = new ObservableCollection<Skill> { };

        public ObservableCollection<LogEntry> LogEntries { get; set; } = new ObservableCollection<LogEntry> { };

        public PlayerPerson()
        {
            Skills.CollectionChanged += OnSkillsChanged;
        }

        private void OnSkillsChanged(object? sender, NotifyCollectionChangedEventArgs args)
        {

        }
    }
}
