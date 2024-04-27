using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
    using System;
    using System.Collections.ObjectModel;
    using System.Windows;

    namespace AgendaApp
    {
        public class MainWindowViewModel : ViewModelBase
        {
            private ObservableCollection<Task> tasks;
            public ObservableCollection<Task> Tasks
            {
                get { return tasks; }
                set { SetProperty(ref tasks, value); }
            }

            public MainWindowViewModel()
            {
                Tasks = new ObservableCollection<Task>();
            }

            private void AddTask(string name, string description, DateTime dueDate)
            {
                Tasks.Add(new Task(name, description, dueDate));
            }

            private void AddTask_Click(object sender, RoutedEventArgs e)
            {
                string name = txtName.Text;
                string description = txtDescription.Text;
                DateTime dueDate = datePicker.SelectedDate.Value;

                if (!string.IsNullOrEmpty(name) && !